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
    public partial class StudentForm : Form
    {
        private StudentController studentController = new StudentController();
        private CourseController courseController = new CourseController();
        private int selectedStudentId = -1;
        public StudentForm()
        {
            InitializeComponent();
            dataGridView2.CellClick += dataGridView2_CellContentClick;

            User user=new User();
            //if(user.Role=="Admin")
            //{
            //   Add_student.Visible = true;
            //    update_com.Visible = true;
            //    Delete_student.Visible = true; 
            //}

            group_com.Items.AddRange(new [] {"A","B"} );

            
            LoadCourse();
            LoadStudents();
        }
        private void LoadStudents()
        {
            var students = studentController.GetAllStudents();
            dataGridView2.DataSource = students;
            dataGridView2.ClearSelection();
            ClearInputs();
        }
        private void LoadCourse()
        {
            var course = courseController.GetAllCourses();
            course_com.DataSource = course;
            course_com.DisplayMember = "Name";
            course_com.ValueMember = "Id";
            course_com.SelectedIndex = -1;
        }
        private void ClearInputs()
        {
            name.Clear();
            adress.Clear();
            phone_no.Clear();
            age.Clear();
            userid.Clear();
            group_com.SelectedIndex = -1;
            course_com.SelectedIndex = -1;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void group_com_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Add_student_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(name.Text) ||
                string.IsNullOrWhiteSpace(adress.Text) ||
                string.IsNullOrWhiteSpace(phone_no.Text) ||
                string.IsNullOrWhiteSpace(age.Text) ||
                string.IsNullOrEmpty(userid.Text)||
                    group_com.SelectedIndex==-1||
                    course_com.SelectedIndex==-1)

            {
                MessageBox.Show("All fileds are required ");
                return;
            }
            if (
                !int.TryParse(age.Text, out int Age) ||
                !int.TryParse(userid.Text, out int User))
            {
                MessageBox.Show(" Age, and user must be numbers");
                return;
            }
            int slectedCourse = Convert.ToInt32(course_com.SelectedValue); // ✅ Correct
            string selectedGroup = group_com.SelectedItem.ToString(); // ✅ Correct

            var student = new student
            {
                Name = name.Text.Trim(),
                Address = adress.Text.Trim(),
                Phone_no = phone_no.Text.Trim(),
                Age = Age,
                user_ID = User,
                Course_ID = slectedCourse,
                Group = selectedGroup
            };
            MessageBox.Show(studentController.AddStudent(student));
            LoadStudents();
        }

        private void update_com_Click(object sender, EventArgs e)
        {
            if (selectedStudentId == -1)
            {
                MessageBox.Show("Please select a student to update.");
                return;
            }

            if (
                !int.TryParse(age.Text, out int Age) ||
                !int.TryParse(userid.Text, out int User))
            {
                MessageBox.Show("age, and user ID must be numeric.");
                return;
            }
            int slectedCourse = Convert.ToInt32(course_com.SelectedValue); // ✅ Correct
            string selectedGroup = (string)group_com.SelectedItem;

            var student = new student
            {
                Id = selectedStudentId,
                Name = name.Text.Trim(),
                Address = adress.Text.Trim(),
                Phone_no = phone_no.Text.Trim(),
                Age = Age,
                user_ID = User,
                Course_ID = slectedCourse,
                Group = selectedGroup
            };

            MessageBox.Show(studentController.UpdateStudent(student));
            LoadStudents(); // Refresh table
        }

        private void Delete_student_Click(object sender, EventArgs e)
        {
            if (selectedStudentId == -1)
            {
                MessageBox.Show("Please select a student to delete.");
                return;
            }

            var confirmResult = MessageBox.Show("Are you sure to delete this student?",
                                 "Confirm Delete", MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                MessageBox.Show(studentController.DeleteStudent(selectedStudentId));
                LoadStudents(); // Refresh table
            }
        }

        

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView2.Rows[e.RowIndex];
                selectedStudentId = Convert.ToInt32(row.Cells["Id"].Value);
                name.Text = row.Cells["Name"].Value.ToString();
                adress.Text = row.Cells["Address"].Value.ToString();
                phone_no.Text = row.Cells["Phone_no"].Value.ToString();
                age.Text = row.Cells["Age"].Value.ToString();
                userid.Text = row.Cells["user_ID"].Value.ToString();
                course_com.SelectedValue = Convert.ToInt32(row.Cells["Course_ID"].Value);
                group_com.SelectedItem = row.Cells["Group"].Value.ToString();
            }

        }

    }
}


