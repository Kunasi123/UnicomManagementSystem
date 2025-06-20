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
    public partial class ExamForm : Form
    {
        ExamController examController = new ExamController();
        SubjectController subjectController = new SubjectController();
        private int selectedExamId = -1;

        public ExamForm()
        {
            InitializeComponent();
            LoadSubjects();
            LoadExams();
            dataGridView1.CellClick += dataGridView1_CellClick;

            User user = new User();
            if (user.Role == "Admin")
            {
                Add_exam.Visible = true;
                edit_exam.Visible = true;
                delete_exam.Visible = true;
            }
            else if (user.Role == "Staff")
            {
                Add_exam.Visible = true;
                edit_exam.Visible = true;
                delete_exam.Visible = false;
            }
            

        }

        private void LoadSubjects()
        {
            var subjects = subjectController.GetAllSubjects();
            sub_box.DataSource = subjects;
            sub_box.DisplayMember = "Name";
            sub_box.ValueMember = "Id";
        }

        private void LoadExams()
        {
            var exams = examController.GetAllExams();
            dataGridView1.DataSource = exams;
            ClearInputs();
            selectedExamId = -1;
        }

        private void ClearInputs()
        {
            name_text.Clear();
            date.Value = DateTime.Now;
            start.Value = DateTime.Now;
            end.Value = DateTime.Now;
            sub_box.SelectedIndex = -1;
        }

        private void Add_exam_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(name_text.Text) || sub_box.SelectedValue == null)
            {
                MessageBox.Show("Exam name and subject are required.");
                return;
            }

            var exam = new Exam
            {
                Name = name_text.Text.Trim(),
                Date = date.Value.Date,
                startTime = start.Value,
                endTime = end.Value,
                Subject_ID = (int)sub_box.SelectedValue
            };

            string result = examController.AddExam(exam);
            MessageBox.Show(result);
            LoadExams();
        }

        private void Update_exam_Click(object sender, EventArgs e)
        {
            if (selectedExamId == -1)
            {
                MessageBox.Show("Please select an exam to update.");
                return;
            }

            if (string.IsNullOrWhiteSpace(name_text.Text) || sub_box.SelectedValue == null)
            {
                MessageBox.Show("Exam name and subject are required.");
                return;
            }

            var exam = new Exam
            {
                Id = selectedExamId,
                Name = name_text.Text.Trim(),
                Date = date.Value.Date,
                startTime = start.Value,
                endTime = end.Value,
                Subject_ID = (int)sub_box.SelectedValue
            };

            string result = examController.UpdateExam(exam);
            MessageBox.Show(result);
            LoadExams();
        }

        private void Delete_exam_Click(object sender, EventArgs e)
        {
            if (selectedExamId == -1)
            {
                MessageBox.Show("Please select an exam to delete.");
                return;
            }

            var confirm = MessageBox.Show("Are you sure you want to delete this exam?", "Confirm", MessageBoxButtons.YesNo);
            if (confirm != DialogResult.Yes) return;

            string result = examController.DeleteExam(selectedExamId);
            MessageBox.Show(result);
            LoadExams();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dataGridView1.Rows.Count)
            {
                var row = dataGridView1.Rows[e.RowIndex];

                selectedExamId = Convert.ToInt32(row.Cells["Id"].Value);
                name_text.Text = row.Cells["Name"].Value.ToString();
                date.Value = Convert.ToDateTime(row.Cells["Date"].Value);
                start.Value = Convert.ToDateTime(row.Cells["startTime"].Value);
                end.Value = Convert.ToDateTime(row.Cells["endTime"].Value);
                sub_box.SelectedValue = Convert.ToInt32(row.Cells["Subject_ID"].Value);
            }
        }
    

        private void label3_Click(object sender, EventArgs e)
        {

        }

        


        
    }
}
