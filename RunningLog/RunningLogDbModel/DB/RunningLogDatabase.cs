using RunningLogDbModel.Interfaces;
using RunningLogDbModel.Model;
using SQLite.Net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace RunningLogDbModel.DB
{
    public class RunningLogDatabase
    {
        private SQLiteConnection _connection;
        public bool IsOpen = false;

        public RunningLogDatabase(string dbName)
        {
            if (!string.IsNullOrEmpty(dbName))
            {
                _connection = DependencyService.Get<ISQLite>().GetConnection(dbName);

                _connection.CreateTable<Runs>();
                _connection.CreateTable<Shoes>();
               
                IsOpen = true;
            }
        }
    }
}
