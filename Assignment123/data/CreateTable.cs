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
                // STUDENT TABLE
                string StudentsTable = @"CREATE TABLE IF NOT EXISTS Student(ID INTEGER PRIMARY KEY AUTOINCREMENT,Name TEXT,Address TEXT, Phone_no INTEGER,Age INTEGER,user_ID INTEGER FOREIGN KEY,Course_ID INTEGER FOREIGN KEY);";

                using (SQLiteCommand cmd = new SQLiteCommand(StudentsTable, conn))
                { cmd.ExecuteNonQuery(); }
                MessageBox.Show("Student Table Created");



                //COURSE TABLE
                string CourseTable = @"CREATE TABLE IF NOT EXISTS Course(ID INTEGER PRIMARY KEY AUTOINCREMENT,Name TEXT);";
                using (SQLiteCommand cmd = new SQLiteCommand(CourseTable, conn))
                {
                    cmd.ExecuteNonQuery();
                }
                MessageBox.Show("Course Table created");

                //EXAM TABLE
                string ExamTable = @"CREATE TABLE IF NOT EXISTS Exam(ID INTEGER PRIMARY KEY AUTOINCREMENT , Name TEXT,Date INTEGER,Subject_ID INTEGER FOREIGN KEY);";
                using (SQLiteCommand cmd = new SQLiteCommand(ExamTable, conn))
                    { cmd.ExecuteNonQuery(); }
                MessageBox.Show("Examtable created");

                //LECTURE TABLE
                string Lecturetable = @"CREATE TABLE IF NOT EXISTS Lecture(ID INTEGER PRIMARY KEY AUTOINCREMENT,USER_ID INTEGER FOREIGN KEY ,Department TEXT);";
                using (SQLiteCommand cmd = new SQLiteCommand(Lecturetable, conn))
                    { cmd.ExecuteNonQuery(); }
                MessageBox.Show("Lecturetable created");

                //MARKTABLE
                string Marktable = @"CREATE TABLE IF NOT EXISTS Mark(ID INTEGER PRIMARY KEY AUTOINCREMENT,ExamI_Dd INTEGER FOREIGN KEY,Student_ID INTEGER FOREIGN KEY,Score INTEGER ); );";
                using (SQLiteCommand cmd = new SQLiteCommand(Marktable, conn))
                { cmd.ExecuteNonQuery(); }
                MessageBox.Show("Marktable created");

                //USER TABLE
                string usertable = @"CREATE TABLE IF NOT EXISTS User(ID INTEGER PRIMARY KEY AUTOINCREMENT,  Name TEXT, Password INTEGER ); );";
                using (SQLiteCommand cmd = new SQLiteCommand(usertable, conn))
                { cmd.ExecuteNonQuery(); }
                MessageBox.Show("usertable created");

                // ROOMTABLE
                string RoomTable = @"CREATE TABLE IF NOT EXISTS Room(ID INTEGER PRIMARY KEY AUTOINCREMENT,  Name TEXT,  Type TEXT ); );";
                using (SQLiteCommand cmd = new SQLiteCommand(RoomTable, conn))
                { cmd.ExecuteNonQuery(); }
                MessageBox.Show("RoomTable created");

                //STAFF TABLE
                string Stafftable = @"CREATE TABLE IF NOT EXISTS Staff(ID INTEGER PRIMARY KEY AUTOINCREMENT,  Name TEXT, user_ID  INTEGER FOREIGN KEY );";
                using (SQLiteCommand cmd = new SQLiteCommand(Stafftable, conn))
                { cmd.ExecuteNonQuery(); }
                MessageBox.Show("Stafftable created");

                //SUBJECT TABLE
                string Subjecttable = @"CREATE TABLE IF NOT EXISTS Subject(ID INTEGER PRIMARY KEY AUTOINCREMENT,  Name TEXT, Course_ID  INTEGER FOREIGN KEY );";
                using (SQLiteCommand cmd = new SQLiteCommand(Subjecttable, conn))
                { cmd.ExecuteNonQuery(); }
                MessageBox.Show("Subjecttable created");

                //Timetable
                string TimeTable = @"CREATE TABLE IF NOT EXISTS Timetable(ID INTEGER PRIMARY KEY AUTOINCREMENT, Subject_ID  INTEGER FOREIGN KEY , Lecture_ID INTEGER FOREIGN KEY, Room_ID INTEGER FOREIGN KEY ,Student_ID INTEGER FOREIGN KEY, Time INTEGER, Date INTEGER);";
                using (SQLiteCommand cmd = new SQLiteCommand(TimeTable, conn))
                { cmd.ExecuteNonQuery(); }
                MessageBox.Show("TimeTable created");

                //lECTURE_SUBJECT TABLE
                string lec_Sub = @"CREATE TABLE IF NOT EXISTS lec_sub(lec_ ID INTEGER , Subject_ID  INTEGER   ,PRIMARY KEY(Lec_ID,Sub_ID),FOREIGN KEY(Lec_ID) REFERENCES Lecture(Lec_ID)    ,  FOREIGN KEY (sub_ID )REFERENCES Subject(Sub_ID);";
                using (SQLiteCommand cmd = new SQLiteCommand(lec_Sub, conn))
                { cmd.ExecuteNonQuery(); }
                MessageBox.Show("lec_Student table created");


                //STUDENT_EXAM TABLE
                string Stu_exam = @"CREATE TABLE IF NOT EXISTS stu_exam(Stu_ID INTEGER , Exam_ID  INTEGER   ,PRIMARY KEY(Stu_ID,Exam_ID),FOREIGN KEY(Stu_ID) REFERENCES Student(stu_ID)    ,  FOREIGN KEY (Exam_ID )REFERENCES Exam(Exam_ID);";
                using (SQLiteCommand cmd = new SQLiteCommand(Stu_exam, conn)) 
                { cmd.ExecuteNonQuery(); }
                MessageBox.Show("Stu_exam table created");

                // STUDENT_TIMETABLE  TABLE
                string Stu_timetable = @"CREATE TABLE IF NOT EXISTS Stu_time(Stu_ID INTEGER , Timetable_ID  INTEGER   ,PRIMARY KEY(Stu_ID,Timetable_ID),FOREIGN KEY(Stu_ID) REFERENCES Student(stu_ID)    ,  FOREIGN KEY (Timetable_ID )REFERENCES Timetable(Timetable_ID);";
                using (SQLiteCommand cmd = new SQLiteCommand(Stu_timetable, conn))
                { cmd.ExecuteNonQuery(); }
                MessageBox.Show("Stu_timetable table created");

                //SUB_STUDENT TABLE
                string Stu_Sub = @"CREATE TABLE IF NOT EXISTS Stu_Sub(Stu_ID INTEGER , sub_ID  INTEGER   ,PRIMARY KEY(Stu_ID,Sub_ID),FOREIGN KEY(Stu_ID) REFERENCES Student(stu_ID)    ,  FOREIGN KEY (Sub_ID )REFERENCES Subject(Sub_ID);";
                using (SQLiteCommand cmd = new SQLiteCommand(Stu_Sub, conn))
                { cmd.ExecuteNonQuery(); }
                MessageBox.Show("Stu_Sub table created");

                
               







            }
        }
    }
}
        
    

