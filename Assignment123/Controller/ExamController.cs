using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment123.data;
using Assignment123.Models;

namespace Assignment123.Controller
{
    internal class ExamController
    {
        public string AddExam(Exam exam)
        {
            try
            {
                using (var Conn = Dataconfig.GetConnection())
                {
                    string query = @"INSERT INTO Exams 
                        (Name, Date, StartTime, EndTime, Subject_ID)
                        VALUES 
                        (@examName, @Date, @startTime, @endTime, @Subject_ID)";

                    using (var cmd = new SQLiteCommand(query, Conn))
                    {
                        cmd.Parameters.AddWithValue("@examName", exam.Name);
                        cmd.Parameters.AddWithValue("@Date", exam.Date.ToString("yyyy-MM-dd"));
                        cmd.Parameters.AddWithValue("@startTime", exam.startTime.ToString("HH:mm"));
                        cmd.Parameters.AddWithValue("@endTime", exam.endTime.ToString("HH:mm"));
                        cmd.Parameters.AddWithValue("@subjectId", exam.Subject_ID);
                        cmd.ExecuteNonQuery();

                        return "Exam added successfully.";
                    }
                }
            }
            catch (Exception ex)
            {
                return $"Error adding exam: {ex.Message}";
            }
        }

        public List<Exam> GetAllExams()
        {
            List<Exam> exams = new List<Exam>();

            using (var Conn = Dataconfig.GetConnection())
            {
                string query = "SELECT * FROM Exam";
                using (var cmd = new SQLiteCommand(query, Conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        exams.Add(new Exam
                        {
                            Id = reader.GetInt32(reader.GetOrdinal("ExamID")),
                            Name = reader.GetString(reader.GetOrdinal("Name")),
                            Date = DateTime.Parse(reader.GetString(reader.GetOrdinal("Date"))),
                            startTime = DateTime.Parse(reader.GetString(reader.GetOrdinal("startTime"))),
                            endTime = DateTime.Parse(reader.GetString(reader.GetOrdinal("endTime"))),
                            Subject_ID=reader.GetInt32(reader.GetOrdinal("Subject_ID"))
                        });
                    }
                }
            }

            return exams;
        }

        public string UpdateExam(Exam exam)
        {
            try
            {
                using (var Conn = Dataconfig.GetConnection())
                {
                    string query = @"UPDATE Exam
                        SET Name = @examName,
                            Date = @date,
                            startTime = @startTime,
                            endTime = @endTime,
                            Subject_ID=@subjectId
                            WHERE Id = @id";

                    using (var cmd = new SQLiteCommand(query, Conn))
                    {
                        cmd.Parameters.AddWithValue("@examName", exam.Name);
                        cmd.Parameters.AddWithValue("@Date", exam.Date.ToString("yyyy-MM-dd"));
                        cmd.Parameters.AddWithValue("@startTime", exam.startTime.ToString("HH:mm"));
                        cmd.Parameters.AddWithValue("@endTime", exam.endTime.ToString("HH:mm"));
                        cmd.Parameters.AddWithValue("@subjectId", exam.Subject_ID);
                        cmd.Parameters.AddWithValue("@id", exam.Id);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        return rowsAffected > 0 ? "Exam updated successfully." : "No exam was updated.";
                    }
                }
            }
            catch (Exception ex)
            {
                return $"Error updating exam: {ex.Message}";
            }
        }

        public string DeleteExam(int Id)
        {
            try
            {
                using (var Conn = Dataconfig.GetConnection())
                {
                    string query = "DELETE FROM Exam WHERE Id = @id";
                    using (var cmd = new SQLiteCommand(query, Conn))
                    {
                        cmd.Parameters.AddWithValue("@id", Id);
                        int result = cmd.ExecuteNonQuery();
                        return result > 0 ? "Exam deleted successfully." : "No exam found to delete.";
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

    
