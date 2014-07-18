using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using Crucible.XPO;
using Microsoft.CSharp;
using Roslyn.Compilers;
using Roslyn.Compilers.CSharp;

namespace Crucible
{
    internal sealed class CSharpFilterReview
    {
        private readonly List< MetadataFileReference > assemblyRefes;
        private readonly string codeAround;
        private readonly CompilerParameters compilerParams;
        private readonly CSharpCodeProvider provider;
        private Func< ReviewXPO, bool > filter;

        public CSharpFilterReview()
        {
            provider = new CSharpCodeProvider( new Dictionary< string, string > { { "CompilerVersion", "v4.0" } } );
            compilerParams = new CompilerParameters { GenerateInMemory = true, GenerateExecutable = false };
            var executingAssembly = Assembly.GetExecutingAssembly();
            assemblyRefes = EnumerableEx.Return( executingAssembly ).Union( executingAssembly.GetReferencedAssemblies().Select( Assembly.Load ) ).Select( item => new MetadataFileReference( item.Location ) ).ToList();
            compilerParams.ReferencedAssemblies.AddRange( assemblyRefes.Select( item => item.FullPath ).ToArray() );

            codeAround = @"using System.Linq;
using Crucible.XPO;

namespace Crucible
{{
    public class CompileClass
    {{
        public static bool Filter( ReviewXPO review )
        {{
            return {0};
        }}
    }}
}}";
        }

        public string Filter
        {
            set
            {
                if ( string.IsNullOrEmpty( value ) )
                {
                    filter = null;
                    return;
                }

                var source = string.Format( codeAround, value );

                var results = provider.CompileAssemblyFromSource( compilerParams, source );
                ThrowIfErrors( results );
                filter = review => ( bool ) results.CompiledAssembly.GetType( "Crucible.CompileClass" ).GetMethod( "Filter" ).Invoke( null, new object[] { review } );
            }
        }

        public bool FilterByCode( ReviewXPO review )
        {
            return filter == null || filter( review );
        }

        public IEnumerable< string > GetSymbols( string code )
        {
            var text = string.Format( codeAround, code );
            var posInText = text.IndexOf( code, StringComparison.Ordinal );

            var splitter =
                new[] { '.', ' ', '&', '|', '>', ';', '(', ')' }.Select( item => text.LastIndexOf( item.ToString( CultureInfo.InvariantCulture ), posInText + code.Length - 2, code.Length - 1, StringComparison.Ordinal ) ).Max();
            var postiton = splitter != -1 ? splitter + 1 : posInText;

            var tree = SyntaxTree.ParseText( text, options: ParseOptions.Default.WithKind( SourceCodeKind.Script ) );
            var identifier = ( ExpressionSyntax ) tree.GetRoot().FindToken( postiton ).Parent;

            var compilation = Compilation.CreateSubmission( "Test", new CompilationOptions( OutputKind.DynamicallyLinkedLibrary ), tree );
            compilation = compilation.AddReferences( assemblyRefes );

            var semantic = compilation.GetSemanticModel( tree );
            var symbols = semantic.LookupSymbols( postiton, semantic.GetTypeInfo( identifier ).Type, options: LookupOptions.IncludeExtensionMethods );

            //return symbols.Select( symbol => symbol.DeclaredAccessibility + " " + symbol.Kind + ": " + symbol.ToDisplayString() );
            return symbols.Select( symbol => symbol.Name + ( symbol.Kind == SymbolKind.Method ? "()" : string.Empty ) ).Distinct().OrderBy( item => item );
        }

        private static void ThrowIfErrors( CompilerResults results )
        {
            if ( results.Errors.Count == 0 )
                return;
            var builder = new StringBuilder();
            results.Errors.Cast< CompilerError >().ForEach( item => builder.AppendLine( item.ErrorText ) );
            throw new Exception( builder.ToString() );
        }
    }
}