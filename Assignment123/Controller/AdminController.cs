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
    internal class AdminController
    {
        public string AddAdmin( Admin admin)
        {
            try
            {
                using (var conn = Dataconfig.GetConnection())
                {
                    string query = @"INSERT INTO Admins (Name, Age, Phoneno)
                                     VALUES (@name, @age, @phone)";
                    using (var cmd = new SQLiteCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@name", admin.Name);
                        cmd.Parameters.AddWithValue("@age", admin.Age);
                        cmd.Parameters.AddWithValue("@phone", admin.Phoneno);

                        cmd.ExecuteNonQuery();
                    }
                }
                return "Admin added successfully.";
            }
            catch (Exception ex)
            {
                return $"Error adding admin: {ex.Message}";
            }
        }

        // Get all Admin
        public List<Admin> GetAllAdmins( ) 
        {
            var AdminList = new List<Admin>();

            try
            {
                using (var conn = Dataconfig.GetConnection())
                {
                    string query = "SELECT * FROM Admins";
                    using (var cmd = new SQLiteCommand(query, conn))
                    {
                        using (var reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                AdminList.Add(new Admin
                                {
                                    Id = reader.GetInt32(reader.GetOrdinal("ID")),
                                    Name = reader.GetString(reader.GetOrdinal("Name")),
                                    Age = reader.GetInt32(reader.GetOrdinal("Age")),
                                    Phoneno = reader.GetString(reader.GetOrdinal("Phoneno"))
                                });
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error retrieving admin: {ex.Message}");
            }

            return AdminList;
        }

        public string UpdateaAdmin(Admin admin)
        {
            try
            {
                using (var conn = Dataconfig.GetConnection())
                {
                    string query = @"UPDATE Admins 
                                     SET Name = @name, Age = @age, Phoneno = @phone 
                                     WHERE id = @id";
                    using (var cmd = new SQLiteCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@name", admin.Name);
                        cmd.Parameters.AddWithValue("@age", admin.Age);
                        cmd.Parameters.AddWithValue("@phone", admin.Phoneno);
                        cmd.Parameters.AddWithValue("@id", admin.Id);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        return rowsAffected > 0 ? "Admins updated successfully." : "No admin was updated.";
                    }
                }
            }
            catch (Exception ex)
            {
                return $"Error updating admin: {ex.Message}";
            }
        }

        public string DeleteAdmin(int id)
        {
            try
            {
                using (var conn = Dataconfig.GetConnection())
                {
                    string query = "DELETE FROM Admins WHERE id = @id";
                    using (var cmd = new SQLiteCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", id);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        return rowsAffected > 0 ? "Admins deleted successfully." : "No admin was deleted.";
                    }
                }
            }
            catch (Exception ex)
            {
                return $"Error deleting admin: {ex.Message}";
            }
        }
    }
}
