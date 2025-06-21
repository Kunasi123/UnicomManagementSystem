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
    internal class SubjectController
    {
        public string AddSubject(Subject subject)
        {
            using (var conn = Dataconfig.GetConnection())
            {
                string query = "INSERT INTO Subject (Name, Course_ID) VALUES (@name, @courseId)";
                using (var cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@name", subject.Name);
                    cmd.Parameters.AddWithValue("@courseId", subject.Course_ID);
                    cmd.ExecuteNonQuery();
                }
            }
            return "Subject added successfully.";
        }

        public List<Subject> GetAllSubjects()
        {
            List<Subject> subjects = new List<Subject>();
            using (var conn = Dataconfig.GetConnection())
            {
                string query = "SELECT * FROM Subject";
                using (var cmd = new SQLiteCommand(query, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        subjects.Add(new Subject
                        {
                            Id= reader.GetInt32(reader.GetOrdinal("ID")),
                            Name = reader.GetString(reader.GetOrdinal("Name")),
                            Course_ID = reader.GetInt32(reader.GetOrdinal("Course_ID"))
                        });
                    }
                }
            }
            return subjects;
        }

        public string UpdateSubject(Subject subject)
        {
            using (var conn = Dataconfig.GetConnection())
            {
                string query = "UPDATE Subject SET Name = @name, Course_ID = @courseId WHERE ID = @id";
                using (var cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@name", subject.Name);
                    cmd.Parameters.AddWithValue("@courseId", subject.Course_ID);
                    cmd.Parameters.AddWithValue("@id", subject.Id);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected > 0 ? "Subject updated successfully." : "No subject was updated.";
                }
            }
        }

        public string DeleteSubject(int subjectId)
        {
            using (var conn = Dataconfig.GetConnection())
            {
                string query = "DELETE FROM Subject WHERE ID = @id";
                using (var cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", subjectId);
                    int result = cmd.ExecuteNonQuery();
                    return result > 0 ? "Subject deleted successfully." : "No subject was deleted.";
                }
            }
        }
    }
}

