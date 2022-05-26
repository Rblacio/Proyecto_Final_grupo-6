using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using SOPORTECNICO.Droid;
using SOPORTECNICO.ViewModel;
using SQLite;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

[assembly: Xamarin.Forms.Dependency(typeof(SqlCliente))]
namespace SOPORTECNICO.Droid
{
    public class SqlCliente : DataBase
    {
        public SQLiteAsyncConnection GetConnection()
        {
            var databasePath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.MyDocuments);
            var path = Path.Combine(databasePath, "soportecnico.db3");
            return new SQLiteAsyncConnection(path);
        }
    }
}