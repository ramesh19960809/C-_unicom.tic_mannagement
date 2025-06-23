using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Threading.Tasks;

namespace UnicomTICManagementSystem.Repositories
{
    public static class DatabaseManager
    {
        private static readonly string connectionString = "Data Source=Unicom.db;Version=3;";

        // Always return NEW connection
        public static SQLiteConnection GetConnection()
        {
            return new SQLiteConnection(connectionString);
        }

        // Create all tables in correct order
        public static void InitializeDatabase()
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var cmd = connection.CreateCommand())
                {
                    // 1. Users
                    cmd.CommandText = @"
                        CREATE TABLE IF NOT EXISTS Users (
                            UserID   INTEGER PRIMARY KEY AUTOINCREMENT,
                            Username TEXT    NOT NULL UNIQUE,
                            Password TEXT    NOT NULL,
                            Role     TEXT    NOT NULL
                        );";
                    cmd.ExecuteNonQuery();

                    // Insert default admin & lecturer
                    cmd.CommandText = @"
                        INSERT OR IGNORE INTO Users (Username, Password, Role)
                        VALUES 
                            ('admin',    'admin123', 'Admin'),
                            ('lecturer', 'lec123',   'Lecturer');";
                    cmd.ExecuteNonQuery();

                    // 2. Courses
                    cmd.CommandText = @"
                        CREATE TABLE IF NOT EXISTS Courses (
                            CourseID       INTEGER PRIMARY KEY AUTOINCREMENT,
                            CourseName     TEXT    NOT NULL,
                            Description    TEXT,
                            DurationMonths INTEGER
                        );";
                    cmd.ExecuteNonQuery();

                    // 3. Subjects
                    cmd.CommandText = @"
                        CREATE TABLE IF NOT EXISTS Subjects (
                            SubjectID   INTEGER PRIMARY KEY AUTOINCREMENT,
                            SubjectName TEXT    NOT NULL,
                            CourseID    INTEGER,
                            FOREIGN KEY(CourseID) REFERENCES Courses(CourseID)
                        );";
                    cmd.ExecuteNonQuery();

                    // 4. Students
                    cmd.CommandText = @"
                        CREATE TABLE IF NOT EXISTS Students (
                            StudentID INTEGER PRIMARY KEY AUTOINCREMENT,
                            Name      TEXT    NOT NULL,
                            CourseID  INTEGER,
                            FOREIGN KEY(CourseID) REFERENCES Courses(CourseID)
                        );";
                    cmd.ExecuteNonQuery();

                    // 5. Exams
                    cmd.CommandText = @"
                        CREATE TABLE IF NOT EXISTS Exams (
                            ExamID    INTEGER PRIMARY KEY AUTOINCREMENT,
                            ExamName  TEXT    NOT NULL,
                            SubjectID INTEGER,
                            FOREIGN KEY(SubjectID) REFERENCES Subjects(SubjectID)
                        );";
                    cmd.ExecuteNonQuery();

                    // 6. Marks
                    cmd.CommandText = @"
                        CREATE TABLE IF NOT EXISTS Marks (
                            MarkID    INTEGER PRIMARY KEY AUTOINCREMENT,
                            StudentID INTEGER,
                            ExamID    INTEGER,
                            Score     INTEGER,
                            FOREIGN KEY(StudentID) REFERENCES Students(StudentID),
                            FOREIGN KEY(ExamID)    REFERENCES Exams(ExamID)
                        );";
                    cmd.ExecuteNonQuery();

                    // 7. Rooms
                    cmd.CommandText = @"
                        CREATE TABLE IF NOT EXISTS Rooms (
                            RoomID   INTEGER PRIMARY KEY AUTOINCREMENT,
                            RoomName TEXT    NOT NULL,
                            RoomType TEXT    NOT NULL
                        );";
                    cmd.ExecuteNonQuery();

                    // 8. Timetables
                    cmd.CommandText = @"
                        CREATE TABLE IF NOT EXISTS Timetables (
                            TimetableID INTEGER PRIMARY KEY AUTOINCREMENT,
                            SubjectID   INTEGER,
                            TimeSlot    TEXT    NOT NULL,
                            RoomID      INTEGER,
                            FOREIGN KEY(SubjectID) REFERENCES Subjects(SubjectID),
                            FOREIGN KEY(RoomID)    REFERENCES Rooms(RoomID)
                        );";
                    cmd.ExecuteNonQuery();
                }
                connection.Close();
            }
        }

        public static void ExecuteNonQuery(string query, params SQLiteParameter[] parameters)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var cmd = new SQLiteCommand(query, connection))
                {
                    if (parameters != null)
                        cmd.Parameters.AddRange(parameters);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static DataTable ExecuteQuery(string query, params SQLiteParameter[] parameters)
        {
            var dt = new DataTable();
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var cmd = new SQLiteCommand(query, connection))
                {
                    if (parameters != null)
                        cmd.Parameters.AddRange(parameters);
                    using (var reader = cmd.ExecuteReader())
                        dt.Load(reader);
                }
            }
            return dt;
        }

        internal static async Task<DataTable> ExecuteQueryAsync(string query, Dictionary<string, object> parameters)
        {
            var dt = new DataTable();
            using (var connection = GetConnection())
            {
                await connection.OpenAsync();
                using (var cmd = new SQLiteCommand(query, connection))
                {
                    if (parameters != null)
                        foreach (var p in parameters)
                            cmd.Parameters.AddWithValue(p.Key, p.Value);
                    using (var reader = await cmd.ExecuteReaderAsync())
                        dt.Load(reader);
                }
            }
            return dt;
        }

        internal static async Task<int> ExecuteNonQueryAsync(string query, Dictionary<string, object> parameters)
        {
            using (var connection = GetConnection())
            {
                await connection.OpenAsync();
                using (var cmd = new SQLiteCommand(query, connection))
                {
                    if (parameters != null)
                        foreach (var p in parameters)
                            cmd.Parameters.AddWithValue(p.Key, p.Value);
                    return await cmd.ExecuteNonQueryAsync();
                }
            }
        }

        internal static async Task<DataTable> ExecuteQueryAsync(string query)
        {
            var dt = new DataTable();
            using (var connection = GetConnection())
            {
                await connection.OpenAsync();
                using (var cmd = new SQLiteCommand(query, connection))
                using (var reader = await cmd.ExecuteReaderAsync())
                    dt.Load(reader);
            }
            return dt;
        }
    }
}
