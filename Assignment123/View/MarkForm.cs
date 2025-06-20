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
    public partial class MarkForm : Form
    {
        MarksController marksController = new MarksController();
        ExamController examController = new ExamController();
        StudentController studentController = new StudentController();
        SubjectController subjectController = new SubjectController();

        private int selectedMarkId = -1;
        public MarkForm()
        {
            InitializeComponent();
        }
        private void MarkForm_Load(object sender, EventArgs e)
        {
            LoadExams();
            LoadStudents();
            LoadSubjects();
            LoadMarks();
            dataGridView1 = new DataGridView();
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            User user = new User();
            if (user.Role == "Admin")
            {
                Add_mark.Visible = true;
                edit_mark.Visible = true;
                delete_mark.Visible = true;
            }
            else if (user.Role == "Staff")
            {
                Add_mark.Visible = true;
                edit_mark.Visible = true;
                delete_mark.Visible = false;
            }
            else if(user.Role == "Lecture")
            {
                Add_mark.Visible = true;
                edit_mark.Visible = true;
                delete_mark.Visible = false;
            }
        }

        private void LoadExams()
        {
            var exams = examController.GetAllExams();
            exam_com.DataSource = exams;
            exam_com.DisplayMember = "Name";
            exam_com.ValueMember = "Id";
            exam_com.SelectedIndex = -1;
        }

        private void LoadStudents()
        {
            var students = studentController.GetAllStudents();
            comboBox2.DataSource = students;
            comboBox2.DisplayMember = "Name";
            comboBox2.ValueMember = "Id";
            comboBox2.SelectedIndex = -1;
        }

        private void LoadSubjects()
        {
            var subjects = subjectController.GetAllSubjects();
            comboBox1.DataSource = subjects;
            comboBox1.DisplayMember = "Name";
            comboBox1.ValueMember = "Id";
            comboBox1.SelectedIndex = -1;
        }

        private void LoadMarks()
        {
            var marks = marksController.GetAllMarks();
            dataGridView1.DataSource = marks;
            dataGridView1.ClearSelection();
            ClearInputs();
            selectedMarkId = -1;
        }

        private void ClearInputs()
        {
            scores.Clear();
        }





        private void button2_Click(object sender, EventArgs e)
        {
            if (selectedMarkId == -1)
            {
                MessageBox.Show("Please select a mark to update.");
                return;
            }

            if (!ValidateInputs()) return;

            var mark = new Assignment123.Models.Marks
            {
                ID = selectedMarkId,
                Exam_Id = (int)exam_com.SelectedValue,
                Student_ID = (int)comboBox2.SelectedValue,
                Score = int.Parse(scores.Text),
                Subject_ID = (int)comboBox1.SelectedValue
            };

            string result = marksController.UpdateMarks(mark);
            MessageBox.Show(result);
            LoadMarks();
        }

        

        private void button1_Click(object sender, EventArgs e)
        
        {
            if (!ValidateInputs()) return;

            var mark = new Assignment123.Models.Marks
            {
                Exam_Id = (int)exam_com.SelectedValue,
                Student_ID = (int)comboBox2.SelectedValue,
                Score = int.Parse(scores.Text),
                Subject_ID = (int)comboBox1.SelectedValue
            };

            string result = marksController.AddMark(mark);
            MessageBox.Show(result);
            LoadMarks();
        }

        

        private void button3_Click(object sender, EventArgs e)
        {
            if (selectedMarkId == -1)
            {
                MessageBox.Show("Please select a mark to delete.");
                return;
            }

            var confirm = MessageBox.Show("Are you sure you want to delete this mark?", "Confirm", MessageBoxButtons.YesNo);
            if (confirm == DialogResult.Yes)
            {
                string result = marksController.DeleteMark(selectedMarkId);
                MessageBox.Show(result);
                LoadMarks();
            }
        }

        

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dataGridView1.Rows.Count)
            {
                var row = dataGridView1.Rows[e.RowIndex];
                selectedMarkId = Convert.ToInt32(row.Cells["ID"].Value);

                exam_com.SelectedValue = Convert.ToInt32(row.Cells["Exam_Id"].Value);
                comboBox2.SelectedValue = Convert.ToInt32(row.Cells["Student_ID"].Value);
                comboBox1.SelectedValue = Convert.ToInt32(row.Cells["Subject_ID"].Value);
                scores.Text = row.Cells["Score"].Value.ToString();
            }
        }

        
      

        

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private bool ValidateInputs()
        {
            if (exam_com.SelectedIndex == -1 ||
                comboBox2.SelectedIndex == -1 ||
                comboBox1.SelectedIndex == -1 ||
                string.IsNullOrWhiteSpace(scores.Text) ||
                !int.TryParse(scores.Text, out int score) ||
                score < 0 || score > 100)
            {
                MessageBox.Show("All fields are required. Score must be a number between 0 and 100.");
                return false;
            }

            return true;
        }

    }
}
