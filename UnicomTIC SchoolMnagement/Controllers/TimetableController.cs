using System;
using System.Collections.Generic;
using System.Data.SQLite;
using UnicomTIC_SchoolMnagement.Models;
using UnicomTICManagementSystem.Models;
using UnicomTICManagementSystem.Repositories;

namespace UnicomTICManagementSystem.Controllers
{
    public class TimetableController
    {
        // Get all Timetable records
        public List<TimeTable> GetAllTimetables()
        {
            var timetables = new List<TimeTable>();

            using (SQLiteConnection conn = Dbcon.GetConnection())
            {
                conn.Open();
                string query = @"SELECT TimetableID, SubjectID, TimeSlot, RoomID FROM Timetables";

                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                using (SQLiteDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var t = new TimeTable
                        {
                            TimetableID = Convert.ToInt32(reader["TimetableID"]),
                            SubjectID = Convert.ToInt32(reader["SubjectID"]),
                            TimeSlot = reader["TimeSlot"].ToString(),
                            RoomID = Convert.ToInt32(reader["RoomID"])
                        };
                        timetables.Add(t);
                    }
                }
            }
            return timetables;
        }

        // Add new Timetable record
        public bool AddTimetable(TimeTable timetable)
        {
            using (SQLiteConnection conn = Dbcon.GetConnection())
            {
                conn.Open();
                string query = @"INSERT INTO Timetables (SubjectID, TimeSlot, RoomID) 
                                 VALUES (@SubjectID, @TimeSlot, @RoomID)";

                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@SubjectID", timetable.SubjectID);
                    cmd.Parameters.AddWithValue("@TimeSlot", timetable.TimeSlot);
                    cmd.Parameters.AddWithValue("@RoomID", timetable.RoomID);

                    int rows = cmd.ExecuteNonQuery();
                    return rows > 0;
                }
            }
        }

        // Update Timetable record
        public bool UpdateTimetable(TimeTable timetable)
        {
            using (SQLiteConnection conn = Dbcon.GetConnection())
            {
                conn.Open();
                string query = @"UPDATE Timetables 
                                 SET SubjectID = @SubjectID, TimeSlot = @TimeSlot, RoomID = @RoomID 
                                 WHERE TimetableID = @TimetableID";

                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@SubjectID", timetable.SubjectID);
                    cmd.Parameters.AddWithValue("@TimeSlot", timetable.TimeSlot);
                    cmd.Parameters.AddWithValue("@RoomID", timetable.RoomID);
                    cmd.Parameters.AddWithValue("@TimetableID", timetable.TimetableID);

                    int rows = cmd.ExecuteNonQuery();
                    return rows > 0;
                }
            }
        }

        // Delete Timetable by ID
        public bool DeleteTimetable(int timetableID)
        {
            using (SQLiteConnection conn = Dbcon.GetConnection())
            {
                conn.Open();
                string query = "DELETE FROM Timetables WHERE TimetableID = @TimetableID";

                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@TimetableID", timetableID);
                    int rows = cmd.ExecuteNonQuery();
                    return rows > 0;
                }
            }
        }

        // Get Timetable by ID (optional)
        public TimeTable GetTimetableById(int timetableID)
        {
            TimeTable timetable = null;

            using (SQLiteConnection conn = Dbcon.GetConnection())
            {
                conn.Open();
                string query = "SELECT TimetableID, SubjectID, TimeSlot, RoomID FROM Timetables WHERE TimetableID = @TimetableID";

                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@TimetableID", timetableID);
                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            timetable = new TimeTable
                            {
                                TimetableID = Convert.ToInt32(reader["TimetableID"]),
                                SubjectID = Convert.ToInt32(reader["SubjectID"]),
                                TimeSlot = reader["TimeSlot"].ToString(),
                                RoomID = Convert.ToInt32(reader["RoomID"])
                            };
                        }
                    }
                }
            }
            return timetable;
        }
    }
}
