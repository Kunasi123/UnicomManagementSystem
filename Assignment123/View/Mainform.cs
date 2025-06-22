using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.ApplicationServices;

namespace Assignment123.View
{
    public partial class Mainform : Form
    {
        public Mainform()
        {
            InitializeComponent();
            
        }
        public void LoadForm(Form form)
        {
            if (panel3.Controls.Count > 0)
            {
                panel3.Controls.RemoveAt(0);
            }
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            panel3.Controls.Add(form);
            panel3.Tag = form;
            form.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            LoadForm(new StaffForm());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            LoadForm(new StudentForm());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            LoadForm(new LectureForm());
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            LoadForm(new AdminForm());
        }

        private void coursess_Click(object sender, EventArgs e)
        {
            LoadForm(new CourseForm());
        }

        private void timetabless_Click(object sender, EventArgs e)
        {
            LoadForm(new TimetableForm());
        }

        private void roomss_Click(object sender, EventArgs e)
        {
            LoadForm(new RoomForm());
        }

        private void log_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to log out?", "Confirm Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Hide(); // Close the current form

                LoginForm loginForm = new LoginForm(); // Create a new instance of the login form
                loginForm.ShowDialog();
            }
        }

        private void subjectss_Click(object sender, EventArgs e)
        {
            LoadForm(new SubjectForm());
        }

        private void marksss_Click(object sender, EventArgs e)
        {
            LoadForm(new MarkForm());
        }

        private void examss_Click(object sender, EventArgs e)
        {
            LoadForm(new ExamForm());
        }

        private void Mainform_Load(object sender, EventArgs e)
        {

        }
    }
}
