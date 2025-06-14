using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.Marshalling;
using System.Text;
using System.Threading.Tasks;

namespace Assignment123.data
{
    internal class Dataconfig
    {
        public static SQLiteConnection GetConnection()
        {
            SQLiteConnection conn = new SQLiteConnection("data Source= Unicom.db;version=3;");
            conn.Open();
            return conn;    
        }
    }
}
