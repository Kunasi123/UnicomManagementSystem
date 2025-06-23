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
    public class Timetablecontroller
    {
        public bool IsRoomAvailable(int roomId, DateTime date, DateTime startTime, DateTime endTime, int? excludeId = null)
        {
            using (var conn = Dataconfig.GetConnection())
            {
                string query = @"
            SELECT COUNT(*) FROM Timetable 
            WHERE Room_ID = @roomId AND Date = @date
              AND ((StartTime < @endTime AND Endtime > @startTime))";

                if (excludeId.HasValue)
                {
                    query += " AND ID != @excludeId";
                }

                using (var cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@roomId", roomId);
                    cmd.Parameters.AddWithValue("@date", date.Date);
                    cmd.Parameters.AddWithValue("@startTime", startTime.ToString("HH:mm"));
                    cmd.Parameters.AddWithValue("@endTime", endTime.ToString("HH:mm"));
                    if (excludeId.HasValue)
                        cmd.Parameters.AddWithValue("@excludeId", excludeId.Value);

                    long count = (long)cmd.ExecuteScalar();
                    return count == 0; // true if room is free
                }
            }
        }



        public string AddTimetable(Timetable timetable)
        {
            try
            {
                if (!IsRoomAvailable(timetable.Room_ID, timetable.Date, timetable.StartTime, timetable.Endtime))
                {
                    return "Error: This room is already booked at the selected time.";
                }



                if (IsTimetableConflict(timetable))
                {
                    return "Error: A timetable with the same lecture, room, group, date, and time already exists.";
                }

                using (var conn = Dataconfig.GetConnection())
                {
                    string query = @"INSERT INTO Timetable 
                (Subject_ID, Lecture_ID, Room_ID, Student_ID, StartTime, Endtime, [Group], Date)
                VALUES (@subid, @lecid, @room, @stuid, @start, @end, @group, @date)";
                    using (var cmd = new SQLiteCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@subid", timetable.Subject_ID);
                        cmd.Parameters.AddWithValue("@lecid", timetable.Lecture_ID);
                        cmd.Parameters.AddWithValue("@room", timetable.Room_ID);
                        cmd.Parameters.AddWithValue("@stuid", timetable.Student_ID);
                        cmd.Parameters.AddWithValue("@start", timetable.StartTime.ToString("HH:mm"));
                        cmd.Parameters.AddWithValue("@end", timetable.Endtime.ToString("HH:mm"));
                        cmd.Parameters.AddWithValue("@group", timetable.Group);
                        cmd.Parameters.AddWithValue("@date", timetable.Date.ToString("yyyy-MM-dd"));

                        cmd.ExecuteNonQuery();
                    }
                }
                return "Timetable added successfully.";
            }
            catch (Exception ex)
            {
                return $"Error adding timetable: {ex.Message}";
            }
        }



        public List<Timetable> GetAllTimetable()
        {
            var Timetable = new List<Timetable>();

            try
            {
                using (var conn = Dataconfig.GetConnection())
                {
                    string query = "SELECT * FROM Timetable";
                    using (var cmd = new SQLiteCommand(query, conn))
                    {
                        using (var reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Timetable.Add(new Timetable
                                {
                                    Id = reader.GetInt32(reader.GetOrdinal("ID")),
                                    Subject_ID = reader.GetInt32(reader.GetOrdinal("Subject_ID")),
                                    Lecture_ID = reader.GetInt32(reader.GetOrdinal("Lecture_ID")),
                                    Room_ID = reader.GetInt32(reader.GetOrdinal("Room_ID")),
                                    Student_ID = reader.GetInt32(reader.GetOrdinal("Student_ID")),
                                    StartTime = DateTime.Parse(reader.GetString(reader.GetOrdinal("StartTime"))),
                                    Endtime = DateTime.Parse(reader.GetString(reader.GetOrdinal("Endtime"))),
                                    Group = reader.GetString(reader.GetOrdinal("Group")),
                                    Date = DateTime.Parse(reader.GetString(reader.GetOrdinal("Date"))),

                                });
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error retrieving timetable: {ex.Message}");
            }

            return Timetable;
        }


        public string Updateatimetable(Timetable timetable)
        {

            try
            {
                if (!IsRoomAvailable(timetable.Room_ID, timetable.Date, timetable.StartTime, timetable.Endtime, timetable.Id))
                {
                    return "Error: This room is already booked at the selected time.";
                }


                if (IsTimetableConflict(timetable, timetable.Id))
                {
                    return "Error: A timetable with the same lecture, room, group, date, and time already exists.";
                }

                using (var conn = Dataconfig.GetConnection())
                {
                    string query = @"UPDATE Timetable 
                    SET Subject_ID = @subid, Lecture_ID = @lecid, Room_ID = @room, Student_ID = @stuid, 
                        StartTime = @start, Endtime = @end, [Group] = @group, Date = @date
                    WHERE Id = @id";
                    using (var cmd = new SQLiteCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", timetable.Id);
                        cmd.Parameters.AddWithValue("@subid", timetable.Subject_ID);
                        cmd.Parameters.AddWithValue("@lecid", timetable.Lecture_ID);
                        cmd.Parameters.AddWithValue("@room", timetable.Room_ID);
                        cmd.Parameters.AddWithValue("@stuid", timetable.Student_ID);
                        cmd.Parameters.AddWithValue("@start", timetable.StartTime.ToString("HH:mm"));
                        cmd.Parameters.AddWithValue("@end", timetable.Endtime.ToString("HH:mm"));
                        cmd.Parameters.AddWithValue("@group", timetable.Group);
                        cmd.Parameters.AddWithValue("@date", timetable.Date.ToString("yyyy-MM-dd"));

                        int rowsAffected = cmd.ExecuteNonQuery();
                        return rowsAffected > 0 ? "Timetable updated successfully." : "No timetable was updated.";
                    }
                }
            }
            catch (Exception ex)
            {
                return $"Error updating timetable: {ex.Message}";
            }
        }


        public string Deletetimetable(int id)
        {
            try
            {
                using (var conn = Dataconfig.GetConnection())
                {
                    string query = "DELETE FROM Timetable WHERE Id = @id";
                    using (var cmd = new SQLiteCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", id);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        return rowsAffected > 0 ? "Timetable deleted successfully." : "No timetable was deleted.";
                    }
                }
            }
            catch (Exception ex)
            {
                return $"Error deleting timetable: {ex.Message}";
            }
        }
        public bool IsTimetableConflict(Timetable timetable, int? excludeId = null)
        {
            using (var conn = Dataconfig.GetConnection())
            {
                string query = @"
            SELECT COUNT(*) FROM Timetable 
            WHERE Lecture_ID = @lecId 
              AND Room_ID = @roomId 
              AND [Group] = @group 
              AND Date = @date 
              AND StartTime = @start 
              AND Endtime = @end";

                if (excludeId.HasValue)
                {
                    query += " AND ID != @excludeId";
                }

                using (var cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@lecId", timetable.Lecture_ID);
                    cmd.Parameters.AddWithValue("@roomId", timetable.Room_ID);
                    cmd.Parameters.AddWithValue("@group", timetable.Group);
                    cmd.Parameters.AddWithValue("@date", timetable.Date.ToString("yyyy-MM-dd"));
                    cmd.Parameters.AddWithValue("@start", timetable.StartTime.ToString("HH:mm"));
                    cmd.Parameters.AddWithValue("@end", timetable.Endtime.ToString("HH:mm"));

                    if (excludeId.HasValue)
                        cmd.Parameters.AddWithValue("@excludeId", excludeId.Value);

                    long count = (long)cmd.ExecuteScalar();
                    return count > 0;
                }
            }
        }

















































        //        public string AddTimetable(Timetable timetable)
        //        {
        //            try
        //            {
        //                using (var conn = Dataconfig.GetConnection())
        //                {
        //                    string query = @"INSERT INTO Timetable (Subject_ID, Lecture_ID, Room_ID,Student_ID,StartTime,Endtime,Group,Date)
        //                                     VALUES (@subid, @lecid, @room,@stuid,@start,@end,@group,@date)";
        //                    using (var cmd = new SQLiteCommand(query, conn))
        //                    {
        //                        cmd.Parameters.AddWithValue("@subid", timetable.Subject_ID);
        //                        cmd.Parameters.AddWithValue("@lecid", timetable.Lecture_ID);
        //                        cmd.Parameters.AddWithValue("@room", timetable.Room_ID);
        //                        cmd.Parameters.AddWithValue("@stuid", timetable.Student_ID);
        //                        cmd.Parameters.AddWithValue("@start", timetable.StartTime);
        //                        cmd.Parameters.AddWithValue("@end", timetable.Endtime);
        //                        cmd.Parameters.AddWithValue("@group", timetable.Group);
        //                        cmd.Parameters.AddWithValue("@date", timetable.Date);



        //                        cmd.ExecuteNonQuery();
        //                    }
        //                }
        //                return "Timetable added successfully.";
        //            }
        //            catch (Exception ex)
        //            {
        //                return $"Error adding timetable: {ex.Message}";
        //            }
        //        }

        //        // Get all Admin
        //public List<Timetable> GetAllTimetable()
        //{
        //    var Timetable = new List<Timetable>();

        //    try
        //    {
        //        using (var conn = Dataconfig.GetConnection())
        //        {
        //            string query = "SELECT * FROM Timetable";
        //            using (var cmd = new SQLiteCommand(query, conn))
        //            {
        //                using (var reader = cmd.ExecuteReader())
        //                {
        //                    while (reader.Read())
        //                    {
        //                        Timetable.Add(new Timetable
        //                        {
        //                            Id = reader.GetInt32(reader.GetOrdinal("ID")),
        //                            Subject_ID = reader.GetInt32(reader.GetOrdinal("Subject_ID")),
        //                            Lecture_ID = reader.GetInt32(reader.GetOrdinal("Lecture_ID")),
        //                            Room_ID = reader.GetInt32(reader.GetOrdinal("Room_ID")),
        //                            Student_ID = reader.GetInt32(reader.GetOrdinal("Student_ID")),
        //                            StartTime = DateTime.Parse(reader.GetString(reader.GetOrdinal("StartTime"))),
        //                            Endtime = DateTime.Parse(reader.GetString(reader.GetOrdinal("Endtime"))),
        //                            Group = reader.GetString(reader.GetOrdinal("Group")),
        //                            Date = DateTime.Parse(reader.GetString(reader.GetOrdinal("Date"))),

        //                        });
        //                    }
        //                }
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new Exception($"Error retrieving timetable: {ex.Message}");
        //    }

        //    return Timetable;
        //}
    }
}

//        public string Updateatimetable(Timetable timetable)
//        {
//            try
//            {
//                using (var conn = Dataconfig.GetConnection())
//                {
//                    string query = @"UPDATE Timetable 
//                                     SET Subject_ID = @subid,Lecture_ID=@lecid ,Room_ID=@room,Student_ID=@stuid,StartTime=@start,Endtime=@end,Group=@group,Date=@date
//                                     WHERE Id = @id";
//                    using (var cmd = new SQLiteCommand(query, conn))
//                    {
//                        cmd.Parameters.AddWithValue("@subid", timetable.Subject_ID);
//                        cmd.Parameters.AddWithValue("@lecid", timetable.Lecture_ID);
//                        cmd.Parameters.AddWithValue("@room", timetable.Room_ID);
//                        cmd.Parameters.AddWithValue("@stuid", timetable.Student_ID);
//                        cmd.Parameters.AddWithValue("@startTime", timetable.StartTime.ToString("HH:mm"));
//                        cmd.Parameters.AddWithValue("@endTime", timetable.Endtime.ToString("HH:mm"));
//                        cmd.Parameters.AddWithValue("@group", timetable.Group);
//                        cmd.Parameters.AddWithValue("@Date", timetable.Date.ToString("yyyy-MM-dd"));

//                        int rowsAffected = cmd.ExecuteNonQuery();
//                        return rowsAffected > 0 ? "Timetable updated successfully." : "No timetable was updated.";
//                    }
//                }
//            }
//            catch (Exception ex)
//            {
//                return $"Error updating timetable: {ex.Message}";
//            }
//        }

//        public string Deletetimetable(int id)
//        {
//            try
//            {
//                using (var conn = Dataconfig.GetConnection())
//                {
//                    string query = "DELETE FROM Timetable WHERE Id = @id";
//                    using (var cmd = new SQLiteCommand(query, conn))
//                    {
//                        cmd.Parameters.AddWithValue("@id", id);

//                        int rowsAffected = cmd.ExecuteNonQuery();
//                        return rowsAffected > 0 ? "Timetable deleted successfully." : "No timetable was deleted.";
//                    }
//                }
//            }
//            catch (Exception ex)
//            {
//                return $"Error deleting timetable: {ex.Message}";
//            }
//        }
//    }
//}


