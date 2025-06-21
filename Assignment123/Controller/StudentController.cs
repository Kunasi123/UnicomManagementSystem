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
    internal class StudentController
    {
        public string AddStudent(student student)
        {
            try
            {
                using (var conn = Dataconfig.GetConnection())
                {
                    string query = "INSERT INTO Student(Name, Address, Phone_no, Age, user_ID, Course_ID, [Group]) VALUES(@name, @address, @phonenumber, @age, @userid, @courseId, @group)";
                    using (var cmd = new SQLiteCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@name", student.Name);
                        cmd.Parameters.AddWithValue("@address", student.Address);
                        cmd.Parameters.AddWithValue("@phonenumber", student.Phone_no);
                        cmd.Parameters.AddWithValue("@age", student.Age);
                        cmd.Parameters.AddWithValue("@userid", student.user_ID);
                        cmd.Parameters.AddWithValue("@courseId", student.Course_ID);
                        cmd.Parameters.AddWithValue("@group", student.Group);

                        cmd.ExecuteNonQuery();
                    }
                }

                return "Student added successfully.";
            }
            catch (Exception ex)
            {
                return $"Error adding student: {ex.Message}";
            }
        }

        public List<student> GetAllStudents()
        {
            List<student> students = new List<student>();

            try
            {
                using (var conn = Dataconfig.GetConnection())
                {
                    string query = "SELECT * FROM Student";
                    using (var cmd = new SQLiteCommand(query, conn))
                    {
                        using (var reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                students.Add(new student
                                {
                                    Id = reader.GetInt32(reader.GetOrdinal("ID")),
                                    Name = reader.GetString(reader.GetOrdinal("Name")),
                                    Address = reader.GetString(reader.GetOrdinal("Address")),
                                    Phone_no = reader.GetString(reader.GetOrdinal("Phone_no")),
                                    Age = reader.GetInt32(reader.GetOrdinal("Age")),
                                    user_ID = reader.GetInt32(reader.GetOrdinal("user_ID")),
                                    Course_ID =reader.IsDBNull(reader.GetOrdinal("Course_ID") )? 0:reader.GetInt32(reader.GetOrdinal("Course_ID")),
                                    Group = reader.GetString(reader.GetOrdinal("Group"))
                                });
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Optional: log or show error
                Console.WriteLine("Error retrieving students: " + ex.Message);
            }

            return students;
        }

        public string UpdateStudent(student student)
        {
            try
            {
                using (var conn = Dataconfig.GetConnection())
                {
                    string query = @"
                        UPDATE Student 
                        SET Name = @name, 
                            Address = @address, 
                            Phone_no = @phonenumber, 
                            Age = @age, 
                            user_ID = @user, 
                            Course_ID = @courseId, 
                            [Group] = @grop
                        WHERE ID = @id";

                    using (var cmd = new SQLiteCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@name", student.Name);
                        cmd.Parameters.AddWithValue("@address", student.Address);
                        cmd.Parameters.AddWithValue("@phonenumber", student.Phone_no);
                        cmd.Parameters.AddWithValue("@age", student.Age);
                        cmd.Parameters.AddWithValue("@user", student.user_ID);
                        cmd.Parameters.AddWithValue("@courseId", student.Course_ID);
                        cmd.Parameters.AddWithValue("@grop", student.Group);
                        cmd.Parameters.AddWithValue("@id", student.Id);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        return rowsAffected > 0 ? "Student updated successfully." : "No student was updated.";
                    }
                }
            }
            catch (Exception ex)
            {
                return $"Error updating student: {ex.Message}";
            }
        }

        public string DeleteStudent(int studentId)
        {
            try
            {
                using (var conn = Dataconfig.GetConnection())
                {
                    string query = "DELETE FROM Student WHERE ID = @id";
                    using (var cmd = new SQLiteCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", studentId);
                        int result = cmd.ExecuteNonQuery();
                        return result > 0 ? "Student deleted successfully." : "No student was deleted.";
                    }
                }
            }
            catch (Exception ex)
            {
                return $"Error deleting student: {ex.Message}";
            }
        }
    }
}

