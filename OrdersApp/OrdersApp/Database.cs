using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using OrdersApp.Models;
using SQLite;

namespace OrdersApp
{
    public class Database
    {
        readonly SQLiteConnection _database;

        public Database(string dbPath)
        {
            _database = new SQLiteConnection(dbPath);
           // _database.CreateTableAsync<Material>();
        }

        public IEnumerable<Material> GetItems()
        {
            return _database.Table<Material>().ToList();
        }
        public Material GetItem(int code)
        {
            return _database.Get<Material>(code);
        }

    }
}