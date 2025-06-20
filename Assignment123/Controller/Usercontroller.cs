using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment123.data;
using Assignment123.Models;

namespace Assignment123.Controller
{
    internal class Usercontroller
    {
        public string AddUser(User user, string username)
        {
            try
            {
                using (var conn = Dataconfig.GetConnection())
                {

                    string query = @"INSERT INTO User(Name, Password, Role, ReferenceID) 
                                     VALUES (@Username, @Password, @Role, @ReferenceId)";

                    using (var cmd = new SQLiteCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Username", username);
                        cmd.Parameters.AddWithValue("@Password", user.Password);
                        cmd.Parameters.AddWithValue("@Role", user.Role);
                        cmd.Parameters.AddWithValue("@ReferenceId", user.ReferenceID);
                        cmd.ExecuteNonQuery();
                    }
                }
                return "User Added successfully";

            }
            catch (Exception ex)
            {
                return $"Error adding user:{ex.Message}";
            }
            
        }
        
    }
}
