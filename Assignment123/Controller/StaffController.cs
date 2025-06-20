using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment123.data;
using Assignment123.Models;

namespace Assignment123.Controller
{
    internal class StaffController
    {
        public string AddStaff(Staff staff)
        {
            try
            {
                using (var conn = Dataconfig.GetConnection())
                {
                    string query = @"INSERT INTO Staff (Name,user_ID,Phone_no  )
                                     VALUES (@name, @user,@phonenumber)";
                    using (var cmd = new SQLiteCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@name", staff.Name);
                        cmd.Parameters.AddWithValue("@user", staff.user_ID);
                        cmd.Parameters.AddWithValue("@phonenumber", staff.Phone_no);


                        cmd.ExecuteNonQuery();
                    }
                }
                return "Staff added successfully.";
            }
            catch (Exception ex)
            {
                return $"Error adding staff: {ex.Message}";
            }
        }

        public List<Staff> GetAllStaff()
        {
            var staff = new List<Staff>();

            using (var conn = Dataconfig.GetConnection())
            {
                string query = "SELECT * FROM Staff";
                using (var cmd = new SQLiteCommand(query, conn))
                {
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            staff.Add(new Staff
                            {
                                Id = reader.GetInt32(reader.GetOrdinal("ID")),
                                Name = reader.GetString(reader.GetOrdinal("Name")),
                                user_ID = reader.GetInt32(reader.GetOrdinal("user_ID")),
                                Phone_no = reader.GetString(reader.GetOrdinal("Phone_no"))
                            });
                        }
                    }
                }
            }

            return staff;
        }

        

        public string UpdateStaff(Staff staff)
        {
            try
            {
                using (var conn = Dataconfig.GetConnection())
                {
                    string query = @"UPDATE Staff 
                                     SET Name = @name,   user_ID=@user, Phone_no=@phonenumber
                                     WHERE ID = @id";
                    using (var cmd = new SQLiteCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@name", staff.Name);
                        cmd.Parameters.AddWithValue("@user", staff.user_ID);
                        cmd.Parameters.AddWithValue("@phonenumber", staff.Phone_no);
                        cmd.Parameters.AddWithValue("@id", staff.Id);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        return rowsAffected > 0 ? "Staff updated successfully." : "No staff was updated.";
                    }
                }
            }
            catch (Exception ex)
            {
                return $"Error updating staff: {ex.Message}";
            }
        }

        public string DeleteStaff(int Id)
        {
            try
            {
                using (var conn = Dataconfig.GetConnection())
                {
                    

                    string query = "DELETE FROM Staff WHERE ID = @id";
                    using (var cmd = new SQLiteCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", Id);
                        int rowsAffected = cmd.ExecuteNonQuery();
                        return rowsAffected > 0 ? "Staff deleted successfully." : "No staff was deleted.";
                    }
                }
            }
            catch (Exception ex)
            {
                return $"Error deleting staff: {ex.Message}";
            }
        }

    }
}

    

