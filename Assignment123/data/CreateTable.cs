using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment123.data
{
    internal class CreateTable
    {
        public void createtable()
        {
            using (var conn = Dataconfig.GetConnection())
            {
                string query = @"CREATE TABLE IF NOT EXISTS Student(ID INTEGER PRIMARY KEY AUTOINCREMENT,Name TEXT,Address TEXT, Stream TEXT);";

                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                { cmd.ExecuteNonQuery(); }
            }
        }
    }
}
