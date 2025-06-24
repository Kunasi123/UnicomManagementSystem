using System;
using System.Windows.Forms;
using Assignment123.data;
using System.Data.SQLite;

namespace Assignment123
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            CreateTable.createdTables();
            // Call the default admin setup here
            //CreateTable.createdTables();
            EnsureDefaultAdminExists();


            Application.Run(new LoginForm());
        }

        // You can define it here if nowhere else
        public static void EnsureDefaultAdminExists()
        {
            using (var conn = Dataconfig.GetConnection())
            {
                string checkQuery = "SELECT COUNT(*) FROM User WHERE Name = 'Suki'";
                using (var cmd = new SQLiteCommand(checkQuery, conn))
                {
                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    if (count == 0)
                    {
                        string insertQuery = @"INSERT INTO User (Name, Password, Role, ReferenceID)
                                               VALUES (@name, @password, @role, @refId)";
                        using (var insertCmd = new SQLiteCommand(insertQuery, conn))
                        {
                            insertCmd.Parameters.AddWithValue("@name", "Suki");
                            insertCmd.Parameters.AddWithValue("@password", "44444");
                            insertCmd.Parameters.AddWithValue("@role", "Admin");
                            insertCmd.Parameters.AddWithValue("@refId", 1); // Or use a valid Admin ID
                            insertCmd.ExecuteNonQuery();
                        }
                    }
                }
            }
        }
    }
}
