using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment123.data;
using Assignment123.Models;
using Assignment123.View;

namespace Assignment123.Controller
{
    internal class CourseController
    {
        public string AddCourse(Course course)
        {
            try
            {
                using (var conn = Dataconfig.GetConnection())
                {
                    string query = "INSERT INTO Course(Name) VALUES(@CourseName)";
                    using (var cmd = new SQLiteCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@CourseName", course.Name);
                        cmd.ExecuteNonQuery();
                    }
                }
                return "Course added successfully.";
            }
            catch (Exception ex)
            {
                return $"Error adding course: {ex.Message}";
            }
        }

        public List<Course> GetAllCourses()
        {
            var courses = new List<Course>();

            using (var dbConn = Dataconfig.GetConnection())
            {
                string query = "SELECT * FROM Course";
                using (var cmd = new SQLiteCommand(query, dbConn))
                {
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            courses.Add(new Course
                            {
                                Id = reader.GetInt32(reader.GetOrdinal("ID")),
                                Name = reader.GetString(reader.GetOrdinal("Name"))
                            });
                        }
                    }
                }
            }

            return courses;
        }

        public string UpdateCourse(Course course)
        {
            try
            {
                using (var dbConn = Dataconfig.GetConnection())
                {
                    string query = "UPDATE Course SET Name = @CourseName WHERE ID = @id";
                    using (var cmd = new SQLiteCommand(query, dbConn))
                    {
                        cmd.Parameters.AddWithValue("@CourseName", course.Name);
                        cmd.Parameters.AddWithValue("@id", course.Id);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        return rowsAffected > 0 ? "Course updated successfully." : "No course was updated.";
                    }
                }
            }
            catch (Exception ex)
            {
                return $"Error updating course: {ex.Message}";
            }
        }

        public string DeleteCourse(int courseId)
        {
            try
            {
                using (var dbConn = Dataconfig.GetConnection())
                {
                    string query = "DELETE FROM Course WHERE ID = @id";
                    using (var cmd = new SQLiteCommand(query, dbConn))
                    {
                        cmd.Parameters.AddWithValue("@id", courseId);
                        int rowsAffected = cmd.ExecuteNonQuery();
                        return rowsAffected > 0 ? "Course deleted successfully." : "No course was deleted.";
                    }
                }
            }
            catch (Exception ex)
            {
                return $"Error deleting course: {ex.Message}";
            }
        }
    }
}
