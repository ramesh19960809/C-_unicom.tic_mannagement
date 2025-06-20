using System;
using System.Collections.Generic;
using System.Data.SQLite;
using StudentManagementSystem.Models;

namespace StudentManagementSystem.Controllers
{
    public class StudentController
    {
        private readonly string _connectionString = "Data Source=unicomtic.db;Version=3;";

        public StudentController()
        {
            CreateTableIfNotExists(); //  Table create
        }

        private void CreateTableIfNotExists()
        {
            using (var conn = new SQLiteConnection(_connectionString))
            {
                conn.Open();
                string sql = @"
                CREATE TABLE IF NOT EXISTS Student (
                    StudentId INTEGER PRIMARY KEY AUTOINCREMENT,
                    Name TEXT NOT NULL,
                    Email TEXT,
                    Gender TEXT,
                    DOB TEXT,
                    Phone TEXT,
                    CourseId INTEGER
                );";
                using (var cmd = new SQLiteCommand(sql, conn))
                {
                    cmd.ExecuteNonQuery();
                }
            }
        }

        //  Add Student
        public bool AddStudent(Student student)
        {
            using (var conn = new SQLiteConnection(_connectionString))
            {
                conn.Open();
                string sql = "INSERT INTO Student (Name, Email, Gender, DOB, Phone, CourseId) VALUES (@name, @mail, @gender, @dob, @phone, @courseId)";
                using (var cmd = new SQLiteCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@name", student.Name);
                    cmd.Parameters.AddWithValue("@mail", student.Email ?? "");
                    cmd.Parameters.AddWithValue("@gender", student.Gender ?? "");
                    cmd.Parameters.AddWithValue("@dob", student.DOB.ToString("yyyy-MM-dd"));
                    cmd.Parameters.AddWithValue("@phone", student.Phone ?? "");
                    cmd.Parameters.AddWithValue("@courseId", student.CourseId);

                    int rows = cmd.ExecuteNonQuery();
                    return rows > 0;
                }
            }
        }

        //  Update Student
        public bool UpdateStudent(Student student)
        {
            using (var conn = new SQLiteConnection(_connectionString))
            {
                conn.Open();
                string sql = "UPDATE Student SET Name=@name, Email=@mail, Gender=@gender, DOB=@dob, Phone=@phone, CourseId=@courseId WHERE StudentId=@id";
                using (var cmd = new SQLiteCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@name", student.Name);
                    cmd.Parameters.AddWithValue("@mail", student.Email ?? "");
                    cmd.Parameters.AddWithValue("@gender", student.Gender ?? "");
                    cmd.Parameters.AddWithValue("@dob", student.DOB.ToString("yyyy-MM-dd"));
                    cmd.Parameters.AddWithValue("@phone", student.Phone ?? "");
                    cmd.Parameters.AddWithValue("@courseId", student.CourseId);
                    cmd.Parameters.AddWithValue("@id", student.StudentId);

                    int rows = cmd.ExecuteNonQuery();
                    return rows > 0;
                }
            }
        }

        //  Delete Student
        public bool DeleteStudent(int studentId)
        {
            using (var conn = new SQLiteConnection(_connectionString))
            {
                conn.Open();
                string sql = "DELETE FROM Student WHERE StudentId=@id";
                using (var cmd = new SQLiteCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@id", studentId);
                    int rows = cmd.ExecuteNonQuery();
                    return rows > 0;
                }
            }
        }

        //  Get All Students
        public List<Student> GetAllStudents()
        {
            List<Student> students = new List<Student>();
            using (var conn = new SQLiteConnection(_connectionString))
            {
                conn.Open();
                string sql = "SELECT StudentId, Name, Email, Gender, DOB, Phone, CourseId FROM Student";
                using (var cmd = new SQLiteCommand(sql, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        students.Add(new Student

                        {
                            StudentId = reader.GetInt32(0),
                            Name = reader.GetString(1),
                            Email = reader.IsDBNull(2) ? "" : reader.GetString(2),
                            Gender = reader.IsDBNull(3) ? "" : reader.GetString(3),
                            DOB = reader.IsDBNull(4) ? DateTime.MinValue : DateTime.Parse(reader.GetString(4)),
                            Phone = reader.IsDBNull(5) ? "" : reader.GetString(5),
                            CourseId = reader.GetInt32(6)
                        });
                    }
                }
            }
            return students;
        }
    }
}
