using System;
using System.Data.SqlClient;
using System.Reflection;
using System.Windows.Forms;
using DevExpress.LookAndFeel;
using DevExpress.Skins;
using DevExpress.UserSkins;
using DevExpress.Xpo;
using DevExpress.Xpo.DB;
using DevExpress.Xpo.Metadata;

namespace Crucible
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault( false );

            SkinManager.EnableFormSkins();
            BonusSkins.Register();
            UserLookAndFeel.Default.SetSkinStyle( "DevExpress Style" );

            XPDictionary dict = new ReflectionDictionary();
            dict.GetDataStoreSchema( Assembly.GetExecutingAssembly() );
            const string reviewsDatabase = @"data source=;integrated security=true;initial catalog=Reviews;";

            XpoDefault.DataLayer = new ThreadSafeDataLayer( dict, new MSSqlConnectionProvider( new SqlConnection( reviewsDatabase ), AutoCreateOption.DatabaseAndSchema ) );
            XpoDefault.Session = null;
            Application.Run( new MainForm() );
        }

        internal static DateTime ToDT( this string date ) => DateTime.Parse( date );
    }
}