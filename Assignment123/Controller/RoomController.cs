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
    internal class RoomController
    {
        public string AddRoom(Room room)
        {
            try
            {
                using (var conn = Dataconfig.GetConnection())
                {
                    string query = "INSERT INTO Room (Name, Type) VALUES (@RoomName, @RoomType)";
                    using (var cmd = new SQLiteCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@RoomName", room.Name);
                        cmd.Parameters.AddWithValue("@RoomType", room.Type);
                        cmd.ExecuteNonQuery();
                    }
                }
                return "Room added successfully.";
            }
            catch (Exception ex)
            {
                return $"Error adding room: {ex.Message}";
            }
        }


        public List<Room> GetAllRooms()
        {
            var rooms = new List<Room>();
            using (var Conn = Dataconfig.GetConnection())
            {
                string query = "SELECT * FROM Room";
                using (var cmd = new SQLiteCommand(query, Conn))
                {
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            rooms.Add(new Room

                            {
                                ID = reader.GetInt32(reader.GetOrdinal("ID")),
                                Name = reader.GetString(reader.GetOrdinal("Name")),
                                Type = reader.GetString(reader.GetOrdinal("Type"))
                            });
                        }
                    }
                }
            }
            return rooms;
        }


        public string UpdateRoom(Room room)
        {
            try
            {
                using (var Conn = Dataconfig.GetConnection())
                {
                    string query = "UPDATE Room SET Name = @RoomName, Type = @RoomType WHERE ID = @RoomID";
                    using (var cmd = new SQLiteCommand(query, Conn))
                    {
                        cmd.Parameters.AddWithValue("@RoomName", room.Name);
                        cmd.Parameters.AddWithValue("@RoomType", room.Type);
                        cmd.Parameters.AddWithValue("@RoomID", room.ID);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        return rowsAffected > 0 ? "Room updated successfully." : "No room was updated.";
                    }
                }
            }
            catch (Exception ex)
            {
                return $"Error updating room: {ex.Message}";
            }
        }


        public string DeleteRoom(int roomId)
        {
            try
            {
                using (var Conn = Dataconfig.GetConnection())
                {
                    string query = "DELETE FROM Room WHERE ID = @RoomID";
                    using (var cmd = new SQLiteCommand(query, Conn))
                    {
                        cmd.Parameters.AddWithValue("@RoomID", roomId);
                        int rowsAffected = cmd.ExecuteNonQuery();
                        return rowsAffected > 0 ? "Room deleted successfully." : "No room was deleted.";
                    }
                }
            }
            catch (Exception ex)
            {
                return $"Error deleting room: {ex.Message}";
            }
        }
    }
}

