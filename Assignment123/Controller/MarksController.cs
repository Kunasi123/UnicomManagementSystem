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
    internal class MarksController
    {
        public string AddMark(Marks marks)
        {
            try
            {
                using (var conn = Dataconfig.GetConnection())
                {
                    string query = @"INSERT INTO Mark 
                        ( Exam_Id,Student_ID,Score, Subject_ID)
                        VALUES 
                        (@examid, @studentId, @score, @subjectid)";

                    using (var cmd = new SQLiteCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@examid", marks.Exam_Id);
                        cmd.Parameters.AddWithValue("@studentId", marks.Student_ID);
                        cmd.Parameters.AddWithValue("@score", marks.Score);
                        cmd.Parameters.AddWithValue("@subjectid", marks.Subject_ID);
                        cmd.ExecuteNonQuery();

                        return "Marks added successfully.";
                    }
                }
            }
            catch (Exception ex)
            {
                return $"Error adding exam: {ex.Message}";
            }
        }

        public List<Marks> GetAllMarks()
        {
            List<Marks> marks = new List<Marks>();

            using (var Conn = Dataconfig.GetConnection())
            {
                string query = "SELECT * FROM Mark";
                using (var cmd = new SQLiteCommand(query, Conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        marks.Add(new Marks
                        {
                            ID = reader.GetInt32(reader.GetOrdinal("Id")),
                            Exam_Id = reader.GetInt32(reader.GetOrdinal("Exam_Id")),
                            Student_ID = reader.GetInt32(reader.GetOrdinal("Student_ID")),
                            Score = reader.GetInt32(reader.GetOrdinal("Score")),
                            Subject_ID = reader.GetInt32(reader.GetOrdinal("Subject_ID"))
                        });
                    }
                }

                return marks;
            }
        }

        public string UpdateMarks(Marks marks)
        {
            try
            {
                using (var Conn = Dataconfig.GetConnection())
                {
                    string query = @"UPDATE Mark 
                        SET Exam_Id = @examid,
                            Student_ID = @studentId,
                            Score = @score,
                            Subject_ID = @subjectid,
                            
                        WHERE ID = @id";

                    using (var cmd = new SQLiteCommand(query, Conn))
                    {
                        cmd.Parameters.AddWithValue("@examid", marks.Exam_Id);
                        cmd.Parameters.AddWithValue("@studentId", marks.Student_ID);
                        cmd.Parameters.AddWithValue("@score", marks.Score);
                        cmd.Parameters.AddWithValue("@subjectid", marks.Subject_ID);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        return rowsAffected > 0 ? "Marks updated successfully." : "No marks was updated.";
                    }
                }
            }
            catch (Exception ex)
            {
                return $"Error updating exam: {ex.Message}";
            }
        }

        public string DeleteMark(int ID)
        {
            try
            {
                using (var Conn = Dataconfig.GetConnection())
                {
                    string query = "DELETE FROM Mark WHERE ID = @id";
                    using (var cmd = new SQLiteCommand(query, Conn))
                    {
                        cmd.Parameters.AddWithValue("@id", ID);
                        int result = cmd.ExecuteNonQuery();
                        return result > 0 ? "Mark deleted successfully." : "No mark found to delete.";
                    }
                }
            }
            catch (Exception ex)
            {
                return $"Error deleting exam: {ex.Message}";
            }
        }
    }

}
