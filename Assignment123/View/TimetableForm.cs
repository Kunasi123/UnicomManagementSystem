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
using Microsoft.VisualBasic;
using Assignment123.Models;

namespace Assignment123.View
{
    public partial class TimetableForm : Form
    {
        Timetablecontroller timetableController = new Timetablecontroller();
        int selectedId = -1;

        public TimetableForm()
        {
            InitializeComponent();
            LoadDropdowns();
            LoadTimetable();
            dataGridView1.CellClick += dataGridView1_CellContentClick;
            group.Items.AddRange(new[] { "A", "B" });

            User user = new User();
            if (user.Role == "Admin")
            {
                Add_timetable.Visible = true;
                Update_timetable.Visible = true;
                Delete_timetable.Visible = true;
            }
            else if (user.Role == "Staff")
            {
                Add_timetable.Visible = true;
                Update_timetable.Visible = true;
                Delete_timetable.Visible = false;
            }
        }

        private void LoadDropdowns()
        {
            // You should replace these with your own controllers and data retrieval
            // Example data binding (you must create these controllers):
            sub_id.DataSource = new SubjectController().GetAllSubjects();
            sub_id.DisplayMember = "Name";
            sub_id.ValueMember = "Id";

            lec_id.DataSource = new LectureController().GetAllLecture();
            lec_id.DisplayMember = "Name";
            lec_id.ValueMember = "Id";

            rooms.DataSource = new RoomController().GetAllRooms();
            rooms.DisplayMember = "RoomNumber";
            rooms.ValueMember = "Id";

            Stu_id.DataSource = new StudentController().GetAllStudents();
            Stu_id.DisplayMember = "Name";
            Stu_id.ValueMember = "Id";

            sub_id.SelectedIndex = -1;
            lec_id.SelectedIndex = -1;
            rooms.SelectedIndex = -1;
            Stu_id.SelectedIndex = -1;
        }

        private void LoadTimetable()
        {
            dataGridView1.DataSource = timetableController.GetAllTimetable();
            dataGridView1.ClearSelection();
        }

        private void ClearForm()
        {
            sub_id.SelectedIndex = -1;
            lec_id.SelectedIndex = -1;
            rooms.SelectedIndex = -1;
            Stu_id.SelectedIndex = -1;
            group.SelectedIndex = -1;
            start.Value = DateTime.Now;
            end.Value = DateTime.Now;
            Dates.Value = DateTime.Now;
            selectedId = -1;
        }

        //public partial class TimetableForm : Form
        //{
        //    Timetablecontroller timetableController = new Timetablecontroller();
        //    LectureController lectureController = new LectureController();
        //    SubjectController subjectController = new SubjectController();
        //    RoomController roomController = new RoomController();
        //    StudentController studentController = new StudentController();
        //    private int selectedTimetableId = -1;

        //    public TimetableForm()
        //    {
        //        InitializeComponent();
        //        dataGridView1.CellClick += dataGridView1_CellContentClick;
        //        group.Items.AddRange(new[] { "A", "B" });
        //        LoadTimetable();
        //        LoadLecture();
        //        Loadsubject();
        //        Loadroom();
        //        Loadstudent();

        //    }
        //    private void LoadTimetable()
        //    {
        //        var timetable = timetableController.GetAllTimetable();
        //        dataGridView1.DataSource = timetable;
        //        dataGridView1.ClearSelection();
        //        ClearInputs();
        //    }
        //    private void LoadLecture()
        //    {
        //        var Lecture = lectureController.GetAllLecture();
        //        lec_id.DataSource = Lecture;
        //        lec_id.DisplayMember = "Name";
        //        lec_id.ValueMember = "Id";
        //        lec_id.SelectedIndex = -1;
        //    }
        //    private void Loadsubject()
        //    {
        //        var Subject = subjectController.GetAllSubjects();
        //        sub_id.DataSource = Subject;
        //        sub_id.DisplayMember = "Name";
        //        sub_id.ValueMember = "Id";
        //        sub_id.SelectedIndex = -1;
        //    }
        //    private void Loadroom()
        //    {
        //        var room = roomController.GetAllRooms();
        //        rooms.DataSource = room;
        //        rooms.DisplayMember = "Name";
        //        rooms.ValueMember = "Id";
        //        rooms.SelectedIndex = -1;
        //    }
        //    private void Loadstudent()
        //    {
        //        var student = studentController.GetAllStudents();
        //        Stu_id.DataSource = student;
        //        sub_id.DisplayMember = "Name";
        //        sub_id.ValueMember = "Id";
        //        sub_id.SelectedIndex = -1;
        //    }
        //    private void ClearInputs()
        //    {
        //        start.Value = DateTime.Now;
        //        end.Value = DateTime.Now;
        //        Dates.Value = DateTime.Now;

        //    }



        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Add_timetable_Click(object sender, EventArgs e)
        {
            var timetable = GetFormData();
            if (timetable == null)
            {
                MessageBox.Show("Please fill all fields.");
                return;
            }
            string result = timetableController.AddTimetable(timetable);
            MessageBox.Show(result);
            LoadTimetable();
            ClearForm();
        }

        private void Update_timetable_Click(object sender, EventArgs e)
        {
            if (selectedId < 0)
            {
                MessageBox.Show("Please select a timetable to update.");
                return;
            }

            var timetable = GetFormData();
            if (timetable == null)
            {
                MessageBox.Show("Please fill all fields.");
                return;
            }
            timetable.Id = selectedId;

            string result = timetableController.Updateatimetable(timetable);
            MessageBox.Show(result);
            LoadTimetable();
            ClearForm();
        }


        private void Delete_timetable_Click(object sender, EventArgs e)
        {
            if (selectedId < 0)
            {
                MessageBox.Show("Please select a timetable to delete.");
                return;
            }

            var confirm = MessageBox.Show("Are you sure you want to delete this timetable?", "Confirm", MessageBoxButtons.YesNo);
            if (confirm == DialogResult.Yes)
            {
                string result = timetableController.Deletetimetable(selectedId);
                MessageBox.Show(result);
                LoadTimetable();
                ClearForm();
            }
        }



        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dataGridView1.Rows[e.RowIndex];
                selectedId = Convert.ToInt32(row.Cells["Id"].Value);
                sub_id.SelectedValue = row.Cells["Subject_ID"].Value;
                lec_id.SelectedValue = row.Cells["Lecture_ID"].Value;
                rooms.SelectedValue = row.Cells["Room_ID"].Value;
                Stu_id.SelectedValue = row.Cells["Student_ID"].Value;
                start.Value = DateTime.Parse(row.Cells["StartTime"].Value.ToString());
                end.Value = DateTime.Parse(row.Cells["Endtime"].Value.ToString());
                group.SelectedItem = row.Cells["Group"].Value.ToString();
                Dates.Value = DateTime.Parse(row.Cells["Date"].Value.ToString());
            }
        }
        private Assignment123.Models.Timetable GetFormData()
        {
            if (sub_id.SelectedIndex == -1 || lec_id.SelectedIndex == -1 || rooms.SelectedIndex == -1 || Stu_id.SelectedIndex == -1)
            {
                MessageBox.Show("Please fill all fields.");
                return null;
            }
            return new Timetable
            {
                Subject_ID = (int)sub_id.SelectedValue,
                Lecture_ID = (int)lec_id.SelectedValue,
                Room_ID = (int)rooms.SelectedValue,
                Student_ID = (int)Stu_id.SelectedValue,
                StartTime = start.Value,
                Endtime = end.Value,
                Group = group.SelectedItem.ToString(),
                Date = Dates.Value
            };
        }
    }
}
