using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Foundation;
using SQLite;
using UIKit;
using XMVVM.Storage;
using System.IO;
using Xamarin.Forms;
using XMVVM.iOS.Storage.Implementations;

[assembly:Dependency(typeof(SQLiteIOS))]
namespace XMVVM.iOS.Storage.Implementations
{
    class SQLiteIOS : ISQLite
    {
        public SQLiteConnection GetConnection()
        {
            var sqliteFilename = "students.db3";
            string documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal); // Documents folder
            string libraryPath = Path.Combine(documentsPath, "..", "Library"); // Library folder
            var path = Path.Combine(libraryPath, sqliteFilename); 
            var connection = new SQLite.SQLiteConnection(path);
            return connection;
        }
    }
}