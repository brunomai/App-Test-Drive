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
using AppXamarin.Data;
using SQLite;

namespace AppXamarin.Droid
{
    class SQLite_Android : ISQLite
    {
        public SQLiteConnection GetConnection()
        {
            return new SQLite.SQLiteConnection("Agendamentos.db3");
        }
    }
}