using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using Assignment123.Models;

namespace Assignment123.data
{
    internal class CreateTable
    {
        public void createtable()
        {
            using (var conn = Dataconfig.GetConnection())
            {
                string StudentsTable = @"CREATE TABLE IF NOT EXISTS Student(ID INTEGER PRIMARY KEY AUTOINCREMENT,Name TEXT,Address TEXT, Stream TEXT);";

                using (SQLiteCommand cmd = new SQLiteCommand(StudentsTable, conn))
                { cmd.ExecuteNonQuery(); }
                MessageBox.Show("Student Table Created");




                string CourseTable = @"CREATE TABLE IF NOT EXISTS Course(ID INTEGER PRIMARY KEY AUTOINCREMENT,Name TEXT);";
                using (SQLiteCommand cmd = new SQLiteCommand(CourseTable, conn))
                {
                    cmd.ExecuteNonQuery();
                }
                MessageBox.Show("Course Table created");

                string ExamTable=@"CREATE TABLE IF NOT EXISTS Exam(ID INTEGER PRIMARY KEY AUTOINCREMENT , "
            }
        }
    }
}
