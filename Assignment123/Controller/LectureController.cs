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
    internal class LectureController
    {
        public string AddLecturer(Lecture lecture)
        {
            using (var conn = Dataconfig.GetConnection())
            {
                string query = @"INSERT INTO Lecture (Name,  User_ID,Course_ID)
                                 VALUES (@name, @userId,@department)";
                using (var cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@name", lecture.Name);
                    cmd.Parameters.AddWithValue("@userId", lecture.User_ID);
                    cmd.Parameters.AddWithValue("@department", lecture.Course_ID);


                    cmd.ExecuteNonQuery();
                }
            }

            return "Lecturer added successfully.";
        }

        public List<Lecture> GetAllLecture()
        {
            var lecture = new List<Lecture>();

            using (var Conn = Dataconfig.GetConnection())
            {
                string query = "SELECT * FROM Lecture";
                using (var cmd = new SQLiteCommand(query, Conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        lecture.Add(new Lecture
                        {
                            Id = reader.GetInt32(reader.GetOrdinal("Id")),
                            Name = reader.GetString(reader.GetOrdinal("Name")),
                            User_ID = reader.IsDBNull(reader.GetOrdinal("User_ID")) ? 0 : reader.GetInt32(reader.GetOrdinal("User_ID")),

                            Course_ID = reader.GetInt32(reader.GetOrdinal("Course_ID"))
                        });
                    }
                }
            }

            return lecture; 
        }

        public string UpdateLecture(Lecture lecturer)
        {
            using (var Conn = Dataconfig.GetConnection())
            {
                string query = @"UPDATE Lecture
                                 SET Name = @name,  User_ID = @userId,  Course_ID=@course
                                 WHERE ID= @id";
                using (var cmd = new SQLiteCommand(query, Conn))
                {
                    cmd.Parameters.AddWithValue("@name", lecturer.Name);
                    cmd.Parameters.AddWithValue("@userId", lecturer.User_ID);
                    cmd.Parameters.AddWithValue("@course", lecturer.Course_ID);
                    cmd.Parameters.AddWithValue("@id", lecturer.Id);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected > 0 ? "Lecturer updated successfully." : "No lecturer was updated.";
                }
            }
        }

        public string DeleteLecturer(int Id)
        {
            using (var Conn = Dataconfig.GetConnection())
            {
                string query = "DELETE FROM Lecture WHERE ID = @id";
                using (var cmd = new SQLiteCommand(query, Conn))
                {
                    cmd.Parameters.AddWithValue("@id", Id);
                    int result = cmd.ExecuteNonQuery();
                    return result > 0 ? "Lecturer deleted successfully." : "No lecturer was deleted.";
                }
            }
        }
    }
}
