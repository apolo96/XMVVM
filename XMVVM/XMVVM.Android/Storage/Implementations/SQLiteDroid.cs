using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using SQLite;
using XMVVM.Storage;
using System.IO;
using Xamarin.Forms;
using XMVVM.Droid.Storage.Implementations;

[assembly:Dependency(typeof(SQLiteDroid))]
namespace XMVVM.Droid.Storage.Implementations
{
    class SQLiteDroid : ISQLite
    {
        public SQLiteConnection GetConnection()
        {
            SQLitePCL.Batteries.Init();
            var sqliteFileName = "students.db3";
            string documentPath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
            var path = Path.Combine(documentPath,sqliteFileName);
            var connection = new SQLite.SQLiteConnection(path);
            return connection;
        }
    }
}