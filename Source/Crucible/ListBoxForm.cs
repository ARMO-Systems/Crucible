using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reactive.Linq;
using System.Threading;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace Crucible
{
    internal sealed partial class ListBoxForm : XtraForm
    {
        private string currentSymbolsString;
        private List< string > items;

        public ListBoxForm()
        {
            InitializeComponent();

            var enterKeys = new[] { Keys.Space, Keys.Return, Keys.Space };
            Func< Keys, bool > isEnterKeys = enterKeys.Contains;
            var keyUpEvent = Observable.FromEventPattern< KeyEventArgs >( listBoxControl1, "KeyUp" ).Select( ev => new Tuple< Keys, Keys >( ev.EventArgs.KeyData, ev.EventArgs.KeyCode ) );
            SelectedItemObservable =
                Observable.FromEventPattern< EventArgs >( listBoxControl1, "DoubleClick" ).
                    Select( ev => listBoxControl1.SelectedItem as string ).
                    Merge( keyUpEvent.Where( ev => isEnterKeys( ev.Item2 ) ).Select( ev => listBoxControl1.SelectedItem as string ) ).
                    ObserveOn( SynchronizationContext.Current );

            BackObservable = keyUpEvent.Where( ev => ev.Item2 == Keys.Back ).Select( item => true ).ObserveOn( SynchronizationContext.Current );
            BackObservable.Subscribe( ev => OnBack() );
            keyUpEvent.Where( ev => ev.Item2 == Keys.Escape ).ObserveOn( SynchronizationContext.Current ).Subscribe( item => Hide() );
            SymbolObservable = Observable.FromEventPattern< KeyPressEventArgs >( listBoxControl1, "KeyPress" ).Select( ev => ev.EventArgs.KeyChar ).Where( char.IsLetter ).ObserveOn( SynchronizationContext.Current );
            SymbolObservable.Subscribe( Filter );
        }

        public IObservable< bool > BackObservable { get; set; }

        public IObservable< char > SymbolObservable { get; private set; }

        public IObservable< string > SelectedItemObservable { get; private set; }

        public List< string > Items
        {
            set
            {
                items = value;
                listBoxControl1.Items.Clear();
                listBoxControl1.Items.AddRange( items.Cast< object >().ToArray() );
                listBoxControl1.SelectedIndex = 0;
                currentSymbolsString = string.Empty;
            }
            get { return items; }
        }

        private void OnBack()
        {
            if ( currentSymbolsString.Length == 0 )
            {
                Hide();
                return;
            }
            currentSymbolsString = currentSymbolsString.Substring( 0, currentSymbolsString.Length - 1 );
            UpdateListBox();
        }

        private void Filter( char key )
        {
            currentSymbolsString += key;
            UpdateListBox();
        }

        private void UpdateListBox()
        {
            listBoxControl1.BeginUpdate();
            listBoxControl1.Items.Clear();
            var possibleSymbols = items.Where( item => item.ToLowerInvariant().Contains( currentSymbolsString.ToLowerInvariant() ) ).ToList();
            listBoxControl1.Items.AddRange( possibleSymbols.Cast< object >().ToArray() );
            Trace.WriteLine( currentSymbolsString );
            listBoxControl1.SelectedIndex = 0;
            listBoxControl1.EndUpdate();
        }
    }
}