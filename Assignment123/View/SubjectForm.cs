using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Assignment123.Controller;
using Assignment123.Models;

namespace Assignment123.View
{
    public partial class SubjectForm : Form
    {
        SubjectController subjectController = new SubjectController();
        CourseController courseController = new CourseController();
        private int selectedSubjectId = -1;
        public SubjectForm()
        {
            InitializeComponent();
            LoadCourses();
            LoadSubject();
            dataGridView1.CellClick += dataGridView1_CellContentClick;

           

        }
        private void LoadCourses()
        {
            var courses = courseController.GetAllCourses();

            course.DataSource = courses;
            course.DisplayMember = "Name";
            course.ValueMember = "Id";
            course.SelectedIndex = -1;
        }
        private void LoadSubject()
        {
            var subjects = subjectController.GetAllSubjects();
            dataGridView1.DataSource = subjects;
            dataGridView1.ClearSelection();
            ClearInput();
            selectedSubjectId = -1;
        }

        private void ClearInput()
        {
            name.Text = "";
            course.SelectedIndex = -1;

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

            if (selectedSubjectId == -1)
            {
                MessageBox.Show("Please select a subject to delete.");
                return;
            }

            var confirm = MessageBox.Show("Are you sure you want to delete this subject?", "Confirm Delete", MessageBoxButtons.YesNo);
            if (confirm == DialogResult.Yes)
            {
                MessageBox.Show(subjectController.DeleteSubject(selectedSubjectId));
                LoadSubject();
            }
        }



        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                selectedSubjectId = Convert.ToInt32(row.Cells["Id"].Value);
                name.Text = row.Cells["Name"].Value.ToString();
                course.SelectedValue = Convert.ToInt32(row.Cells["Course_ID"].Value);
            }
        }



        private void Add_subject_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(name.Text) || course.SelectedIndex == -1)
            {
                MessageBox.Show("All fields are required.");
                return;
            }

            var subject = new Subject
            {
                Name = name.Text.Trim(),
                Course_ID = (int)course.SelectedValue
            };

            MessageBox.Show(subjectController.AddSubject(subject));
            LoadSubject();
        }



        private void Update_subject_Click(object sender, EventArgs e)
        {

            if (selectedSubjectId == -1)
            {
                MessageBox.Show("Please select a subject to update.");
                return;
            }

            if (string.IsNullOrWhiteSpace(name.Text) || course.SelectedIndex == -1)
            {
                MessageBox.Show("All fields are required.");
                return;
            }

            var subject = new Subject
            {
                Id = selectedSubjectId,
                Name = name.Text.Trim(),
                Course_ID = (int)course.SelectedValue
            };

            MessageBox.Show(subjectController.UpdateSubject(subject));
            LoadSubject();
        }

        private void course_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

