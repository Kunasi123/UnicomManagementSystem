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
    public partial class CourseForm : Form
    {
        private CourseController courseController = new CourseController();
        private int selectedCourseId = -1;

        public CourseForm()
        {
            InitializeComponent();
            dataGridView1.CellClick += dataGridView1_CellClick;
            LoadCourses();
            

            User user = new User();
            if (user.Role == "Admin")
            {
                Add_Course.Visible = true;
                Update_course.Visible = true;
                delete_course.Visible = true;
            }
            
        }

        private void LoadCourses()
        {
            var courses = courseController.GetAllCourses();
            dataGridView1.DataSource = courses;
            dataGridView1.ClearSelection();
            clearInput();
            selectedCourseId = -1;

            
        }

        private void clearInput()
        {
            text_name.Clear();
        }

        private void Add_Course_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(text_name.Text))
            {
                MessageBox.Show("Course name is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Course course = new Course
            {
                Name = text_name.Text.Trim()
            };

            string result = courseController.AddCourse(course);
            MessageBox.Show(result);
            LoadCourses();
        }

        private void Update_course_Click(object sender, EventArgs e)
        {
            if (selectedCourseId == -1)
            {
                MessageBox.Show("Please select a course to update.", "Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(text_name.Text))
            {
                MessageBox.Show("Course name is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Course course = new Course
            {
                Id = selectedCourseId,
                Name = text_name.Text.Trim()
            };

            string result = courseController.UpdateCourse(course);
            MessageBox.Show(result);
            LoadCourses();
        }

        private void delete_course_Click(object sender, EventArgs e)
        {
            if (selectedCourseId == -1)
            {
                MessageBox.Show("Please select a course to delete.", "Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var confirm = MessageBox.Show("Are you sure you want to delete this course?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm != DialogResult.Yes) return;

            string result = courseController.DeleteCourse(selectedCourseId);
            MessageBox.Show(result);
            LoadCourses();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dataGridView1.Rows.Count)
            {
                var row = dataGridView1.Rows[e.RowIndex];
                selectedCourseId = Convert.ToInt32(row.Cells["Id"].Value);
                text_name.Text = row.Cells["Name"].Value.ToString();
            }
        }
    }
}
