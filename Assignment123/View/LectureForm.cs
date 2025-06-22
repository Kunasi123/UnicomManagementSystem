using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Assignment123.Controller;
using Assignment123.Models;

namespace Assignment123.View
{
    public partial class LectureForm : Form
    {
        LectureController LectureController = new LectureController();
        CourseController CourseController = new CourseController();

        private int selectedLectureId = -1;

        public LectureForm()
        {
            InitializeComponent();
            LoadCourses();
            LoadLectures();
            dataGridView1.CellClick += dataGridView1_CellClick;

            User user = new User();
            if (user.Role == "Admin")
            {
                Add_lecture.Visible = true;
                Update_lecture.Visible = true;
                delete_lecture.Visible = true;
            }
        }

        private void LoadCourses()
        {
            var courses = CourseController.GetAllCourses();

            depart_com.DataSource = courses;
            depart_com.DisplayMember = "Name";
            depart_com.ValueMember = "Id";
            depart_com.SelectedIndex = -1;
        }

        private void LoadLectures()
        {
            var lectures = LectureController.GetAllLecture();
            dataGridView1.DataSource = lectures;
            dataGridView1.ClearSelection();
            ClearInput();
            selectedLectureId = -1;


        }

        private void ClearInput()
        {
            name.Text = "";
            userid.Text = "";
            depart_com.SelectedIndex = -1;
            //int selectedCourseId = (int)depart_com.SelectedValue;
        }

        private void Add_lecture_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(name.Text) ||
                string.IsNullOrWhiteSpace(userid.Text) ||
                depart_com.SelectedIndex == -1)
            {
                MessageBox.Show("All fields are required.");
                return;
            }

            if (!int.TryParse(userid.Text, out int parsedUserId))
            {
                MessageBox.Show("User ID must be a valid number.");
                return;
            }

            int selectedCourseId = (int)depart_com.SelectedValue;

            var lecture = new Lecture
            {
                Name = name.Text.Trim(),
                User_ID = parsedUserId,
                Course_ID = selectedCourseId
            };

            string result = LectureController.AddLecturer(lecture);
            MessageBox.Show(result);
            LoadLectures();
        }

        private void Update_lecture_Click(object sender, EventArgs e)
        {
            //if (selectedLectureId == -1)
            //{
            //    MessageBox.Show("Please select a lecture to update.");
            //    return;
            //}

            //if (string.IsNullOrWhiteSpace(name.Text) ||
            //    string.IsNullOrWhiteSpace(userid.Text) ||
            //    depart_com.SelectedIndex == -1)
            //{
            //    MessageBox.Show("All fields are required.");
            //    return;
            //}

            //if (!int.TryParse(userid.Text, out int parsedUserId))
            //{
            //    MessageBox.Show("User ID must be a valid number.");
            //    return;
            //}

            //int selectedCourseId = (int)depart_com.SelectedValue;

            //var lecture = new Lecture
            //{
            //    Id = selectedLectureId,
            //    Name = name.Text.Trim(),
            //    User_ID = parsedUserId,
            //    Course_ID = selectedCourseId
            //};

            //string result = LectureController.UpdateLecture(lecture);
            //MessageBox.Show(result);
            //LoadLectures();
        }

        private void Delete_lecture_Click(object sender, EventArgs e)
        {
            //if (selectedLectureId == -1)
            //{
            //    MessageBox.Show("Please select a lecture to delete.");
            //    return;
            //}

            //var confirm = MessageBox.Show("Are you sure you want to delete this lecture?", "Confirm", MessageBoxButtons.YesNo);
            //if (confirm == DialogResult.Yes)
            //{
            //    string result = LectureController.DeleteLecturer(selectedLectureId);
            //    MessageBox.Show(result);
            //    LoadLectures();
            //}
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dataGridView1.Rows.Count)
            {
                var row = dataGridView1.Rows[e.RowIndex];

                selectedLectureId = Convert.ToInt32(row.Cells["Id"].Value);
                name.Text = row.Cells["Name"].Value.ToString();
                userid.Text = row.Cells["User_ID"].Value.ToString();

                // Safely get Course_ID
                if (row.Cells["Course_ID"].Value != null &&
                    int.TryParse(row.Cells["Course_ID"].Value.ToString(), out int courseId))
                {
                    depart_com.SelectedValue = courseId;
                }
                else
                {
                    depart_com.SelectedIndex = -1;
                }
            }
        }

        private void Update_lecture_Click_1(object sender, EventArgs e)
        {
            if (selectedLectureId == -1)
            {
                MessageBox.Show("Please select a lecture to update.");
                return;
            }

            if (string.IsNullOrWhiteSpace(name.Text) ||
                string.IsNullOrWhiteSpace(userid.Text) ||
                depart_com.SelectedIndex == -1)
            {
                MessageBox.Show("All fields are required.");
                return;
            }

            if (!int.TryParse(userid.Text, out int parsedUserId))
            {
                MessageBox.Show("User ID must be a valid number.");
                return;
            }

            int selectedCourseId = (int)depart_com.SelectedValue;

            var lecture = new Lecture
            {
                Id = selectedLectureId,
                Name = name.Text.Trim(),
                User_ID = parsedUserId,
                Course_ID = selectedCourseId
            };

            string result = LectureController.UpdateLecture(lecture);
            MessageBox.Show(result);
            LoadLectures();
        }

        private void delete_lecture_Click_1(object sender, EventArgs e)
        {
            if (selectedLectureId == -1)
            {
                MessageBox.Show("Please select a lecture to delete.");
                return;
            }

            var confirm = MessageBox.Show("Are you sure you want to delete this lecture?", "Confirm", MessageBoxButtons.YesNo);
            if (confirm == DialogResult.Yes)
            {
                string result = LectureController.DeleteLecturer(selectedLectureId);
                MessageBox.Show(result);
                LoadLectures();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dataGridView1.Rows.Count)
            {
                var row = dataGridView1.Rows[e.RowIndex];

                selectedLectureId = Convert.ToInt32(row.Cells["Id"].Value);
                name.Text = row.Cells["Name"].Value.ToString();
                userid.Text = row.Cells["User_ID"].Value.ToString();

                // Safely get Course_ID
                if (row.Cells["Course_ID"].Value != null &&
                    int.TryParse(row.Cells["Course_ID"].Value.ToString(), out int courseId))
                {
                    depart_com.SelectedValue = courseId;
                }
                else
                {
                    depart_com.SelectedIndex = -1;
                }
            }
        }
    }
}
