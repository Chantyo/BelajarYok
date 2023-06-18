using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
namespace BelajarYok
{
    public class Database
    {
        readonly SQLiteAsyncConnection db;
        public Database(string dbPath)
        {
            db = new SQLiteAsyncConnection(dbPath);
            //db.CreateTableAsync<>
        }
    }
}
