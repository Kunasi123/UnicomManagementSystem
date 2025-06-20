using Assignment123.data;
using Assignment123.View;

using System.Windows.Forms;

namespace Assignment123
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            //CreateTable.createdTables(); // Ensure the database tables are created before running the application  
           // Application.Run(new LoginForm());
           //Application.Run(new AdminForm()); // Start with AdminForm instead of LoginForm
            //Application.Run(new CourseForm()); // Start with CourseForm instead of LoginForm
            Application.Run(new ExamForm()); // Start with StudentForm instead of LoginForm
            Application.Run(new LectureForm());
            Application.Run(new MarkForm());
            //Application.Run(new RoomForm());
            //Application.Run(new StaffForm());
            Application.Run(new StudentForm()); // Start with StudentForm instead of LoginForm
            Application.Run(new SubjectForm()); // Start with SubjectForm instead of LoginForm
            Application.Run(new TimetableForm()); // Start with TimetableForm instead of LoginForm
            //Application.Run(new Register()); // Start with Register form instead of LoginForm
            //Application.Run(new LoginForm()); // Start with LoginForm
        }
    }
}