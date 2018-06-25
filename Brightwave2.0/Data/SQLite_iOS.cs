using System;
using System.IO;
using System.Runtime.CompilerServices;
using BrightwaveApp.iOS.Data;

//[assembly: Dependency(typeof(SQLite_iOS))]

namespace BrightwaveApp.iOS.Data
{
    public class SQLite_iOS : SQLiteInt
    {
        public SQLite_iOS()
        {
        }

        public SQLite.SQLiteConnection getConnection()
        {
            var filename = "Testdb.db3";
            var documentPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            var libraryPath = Path.Combine(documentPath, "..", "Library");
            var path = Path.Combine(libraryPath, filename);
            var connection = new SQLite.SQLiteConnection(path);
            return connection;

        }
    }
}
