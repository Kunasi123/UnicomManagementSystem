using System.Data.SQLite;
using Assignment123.data;

internal class CreateTable
{
    internal static void createdTables()
    {
        using (var conn = Dataconfig.GetConnection())
        {
            //conn.Open();

            //// Enable foreign key constraints
            //using (var pragmaCmd = new SQLiteCommand("PRAGMA foreign_keys = ON;", conn))
            //{
            //    pragmaCmd.ExecuteNonQuery();
            //}

            // USER TABLE
            string usertable = @"
                CREATE TABLE IF NOT EXISTS User (
                    ID INTEGER PRIMARY KEY AUTOINCREMENT,
                    Name TEXT,
                    Password INTEGER,
                    Role TEXT,
                    ReferenceID INTEGER
                );";
            new SQLiteCommand(usertable, conn).ExecuteNonQuery();

            // COURSE TABLE
            string CourseTable = @"
                CREATE TABLE IF NOT EXISTS Course (
                    ID INTEGER PRIMARY KEY AUTOINCREMENT,
                    Name TEXT
                );";
            new SQLiteCommand(CourseTable, conn).ExecuteNonQuery();

            // SUBJECT TABLE
            string SubjectTable = @"
                CREATE TABLE IF NOT EXISTS Subject (
                    ID INTEGER PRIMARY KEY AUTOINCREMENT,
                    Name TEXT,
                    Course_ID INTEGER,
                    FOREIGN KEY (Course_ID) REFERENCES Course(ID)
                );";
            new SQLiteCommand(SubjectTable, conn).ExecuteNonQuery();

            // STUDENT TABLE
            string StudentTable = @"
                CREATE TABLE IF NOT EXISTS Student (
                    ID INTEGER PRIMARY KEY AUTOINCREMENT,
                    Name TEXT,
                    Address TEXT,
                    Phone_no TEXT,
                    Age INTEGER,
                    user_ID INTEGER,
                    Course_ID INTEGER,
                    [Group] TEXT,
                    FOREIGN KEY (user_ID) REFERENCES User(ID),
                    FOREIGN KEY (Course_ID) REFERENCES Course(ID)
                );";
            new SQLiteCommand(StudentTable, conn).ExecuteNonQuery();

            // EXAM TABLE
            string ExamTable = @"
                CREATE TABLE IF NOT EXISTS Exam (
                    ID INTEGER PRIMARY KEY AUTOINCREMENT,
                    Name TEXT,
                    Date TEXT,
                    startTime TEXT,
                    endtime TEXT,
                    Subject_ID INTEGER,
                    FOREIGN KEY (Subject_ID) REFERENCES Subject(ID)
                );";
            new SQLiteCommand(ExamTable, conn).ExecuteNonQuery();

            // LECTURE TABLE
            string LectureTable = @"
                CREATE TABLE IF NOT EXISTS Lecture (
                    ID INTEGER PRIMARY KEY AUTOINCREMENT,
                    Name TEXT,
                    User_ID INTEGER,
                   Course_ID INTEGER,
                    FOREIGN KEY(Course_ID) REFERENCES Course(ID)
                    FOREIGN KEY (User_ID) REFERENCES User(ID)
                );";
            new SQLiteCommand(LectureTable, conn).ExecuteNonQuery();

            // ROOM TABLE
            string RoomTable = @"
                CREATE TABLE IF NOT EXISTS Room (
                    ID INTEGER PRIMARY KEY AUTOINCREMENT,
                    Name TEXT,
                    Type TEXT
                );";
            new SQLiteCommand(RoomTable, conn).ExecuteNonQuery();

            // TIMETABLE
            string TimeTable = @"
                CREATE TABLE IF NOT EXISTS Timetable (
                    ID INTEGER PRIMARY KEY AUTOINCREMENT,
                    Subject_ID INTEGER,
                    Lecture_ID INTEGER,
                    Room_ID INTEGER,
                    Student_ID INTEGER,
                    StartTime TEXT,
                    Endtime TEXT,
                    [Group] TEXT,
                    Date TEXT,
                    FOREIGN KEY (Subject_ID) REFERENCES Subject(ID),
                    FOREIGN KEY (Lecture_ID) REFERENCES Lecture(ID),
                    FOREIGN KEY (Room_ID) REFERENCES Room(ID),
                    FOREIGN KEY (Student_ID) REFERENCES Student(ID)
                );";
            new SQLiteCommand(TimeTable, conn).ExecuteNonQuery();

            // MARK TABLE
            string MarkTable = @"
                CREATE TABLE IF NOT EXISTS Mark (
                    ID INTEGER PRIMARY KEY AUTOINCREMENT,
                    Exam_Id INTEGER,
                    Student_ID INTEGER,
                    Score INTEGER,
                    Subject_ID INTEGER,
                    FOREIGN KEY (Exam_Id) REFERENCES Exam(ID),
                    FOREIGN KEY (Student_ID) REFERENCES Student(ID),
                    FOREIGN KEY (Subject_ID) REFERENCES Subject(ID)
                );";
            new SQLiteCommand(MarkTable, conn).ExecuteNonQuery();

            // STAFF TABLE
            string StaffTable = @"
                CREATE TABLE IF NOT EXISTS Staff (
                    ID INTEGER PRIMARY KEY AUTOINCREMENT,
                    Name TEXT,
                    user_ID INTEGER,
                    Phone_no TEXT NOT NULL,
                    FOREIGN KEY (user_ID) REFERENCES User(ID)
                );";
            new SQLiteCommand(StaffTable, conn).ExecuteNonQuery();

            // LEC_SUB TABLE (Many-to-Many)
            string LecSub = @"
                CREATE TABLE IF NOT EXISTS Lec_Sub (
                    Lec_ID INTEGER,
                    Sub_ID INTEGER,
                    PRIMARY KEY (Lec_ID, Sub_ID),
                    FOREIGN KEY (Lec_ID) REFERENCES Lecture(ID),
                    FOREIGN KEY (Sub_ID) REFERENCES Subject(ID)
                );";
            new SQLiteCommand(LecSub, conn).ExecuteNonQuery();

            // STUDENT_EXAM TABLE (Many-to-Many)
            string StuExam = @"
                CREATE TABLE IF NOT EXISTS Stu_Exam (
                    Stu_ID INTEGER,
                    Exam_ID INTEGER,
                    PRIMARY KEY (Stu_ID, Exam_ID),
                    FOREIGN KEY (Stu_ID) REFERENCES Student(ID),
                    FOREIGN KEY (Exam_ID) REFERENCES Exam(ID)
                );";
            new SQLiteCommand(StuExam, conn).ExecuteNonQuery();

            // STUDENT_TIMETABLE TABLE (Many-to-Many)
            string StuTime = @"
                CREATE TABLE IF NOT EXISTS Stu_Time (
                    Stu_ID INTEGER,
                    Timetable_ID INTEGER,
                    PRIMARY KEY (Stu_ID, Timetable_ID),
                    FOREIGN KEY (Stu_ID) REFERENCES Student(ID),
                    FOREIGN KEY (Timetable_ID) REFERENCES Timetable(ID)
                );";
            new SQLiteCommand(StuTime, conn).ExecuteNonQuery();

            // SUBJECT_STUDENT TABLE (Many-to-Many)
            string StuSub = @"
                CREATE TABLE IF NOT EXISTS Stu_Sub (
                    Stu_ID INTEGER,
                    Sub_ID INTEGER,
                    PRIMARY KEY (Stu_ID, Sub_ID),
                    FOREIGN KEY (Stu_ID) REFERENCES Student(ID),
                    FOREIGN KEY (Sub_ID) REFERENCES Subject(ID)
                );";
            new SQLiteCommand(StuSub, conn).ExecuteNonQuery();

            // ADMINS TABLE
            string AdminsTable = @"
                CREATE TABLE IF NOT EXISTS Admins (
                    ID INTEGER PRIMARY KEY AUTOINCREMENT,
                    Name TEXT NOT NULL,
                    Age INTEGER NOT NULL,
                    Phoneno TEXT NOT NULL
                );";
            new SQLiteCommand(AdminsTable, conn).ExecuteNonQuery();
            MessageBox.Show("All tables created");
        }
    }
}
