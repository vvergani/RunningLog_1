using RunningLogDbModel.Interfaces;
using System;
using System.IO;
using Xamarin.Forms;

[assembly: Dependency(typeof(ISQLite))]

namespace RunningLog.iOS.Classes
{
    public class SQLite_iOS : ISQLite
    {
        public SQLite_iOS()
        {
        }

        #region ISQLite implementation

        public SQLite.Net.SQLiteConnection GetConnection(string dbName)
        {
            string documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal); // Documents folder
            string libraryPath = Path.Combine(documentsPath, "..", "Library"); // Library folder
            var path = Path.Combine(libraryPath, dbName);
            var platform = new SQLite.Net.Platform.XamarinIOS.SQLitePlatformIOS();

            // Create the connection
            var conn = new SQLite.Net.SQLiteConnection(platform, path, false);

            // Return the database connection
            return conn;
        }

        #endregion
    }
}
