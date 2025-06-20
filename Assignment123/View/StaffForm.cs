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
using Microsoft.VisualBasic.ApplicationServices;
using User = Assignment123.Models.User;

namespace Assignment123.View
{
    public partial class StaffForm : Form
    {
        private StaffController staffController = new StaffController();
        private int selectedStaffId = -1;

        public StaffForm()
        {
            InitializeComponent();
            dataGridView1.CellClick += dataGridView1_CellContentClick;
            LoadStaff();
            User user = new User();
            if (user.Role == "Admin")
            {
                add_staff.Visible = true;
                update_staff.Visible = true;
                delete_staff.Visible = true;
            }
            
            
        }
        private void LoadStaff()
        {
            var staffList = staffController.GetAllStaff();
            dataGridView1.DataSource = staffList;
            dataGridView1.ClearSelection();
            ClearInputs();
            selectedStaffId = -1;
        }

        private void ClearInputs()
        {
            name.Clear();
            id.Clear();
            phone_no.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (selectedStaffId == -1)
            {
                MessageBox.Show("Select a staff to update.");
                return;
            }

            if (string.IsNullOrWhiteSpace(name.Text) ||
                string.IsNullOrWhiteSpace(id.Text) ||
                string.IsNullOrWhiteSpace(phone_no.Text))
            {
                MessageBox.Show("All fields are required.");
                return;
            }

            if (!int.TryParse(id.Text, out int parsedUserId) )
            {
                MessageBox.Show("User ID must be numbers.");
                return;
            }

            var staff = new Staff
            {
                Id = selectedStaffId,
                Name = name.Text.Trim(),
                user_ID = parsedUserId,
                Phone_no = phone_no.Text.Trim(),
            };

            var result = staffController.UpdateStaff(staff);
            MessageBox.Show(result);
            LoadStaff();
        }
        

        private void add_staff_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(name.Text) ||
                string.IsNullOrWhiteSpace(id.Text) ||
                string.IsNullOrWhiteSpace(phone_no.Text))
            {
                MessageBox.Show("All fields are required.");
                return;
            }

            if (!int.TryParse(id.Text, out int parsedUserId) )
            {
                MessageBox.Show("User ID   must be numbers.");
                return;
            }

            var staff = new Staff
            {
                Name = name.Text.Trim(),
                user_ID = parsedUserId,
                Phone_no = phone_no.Text.Trim()
            };

            var result = staffController.AddStaff(staff);
            MessageBox.Show(result);
            LoadStaff();
        }
        

        private void delete_staff_Click(object sender, EventArgs e)
        {
            if (selectedStaffId == -1)
            {
                MessageBox.Show("Please select a staff to delete.");
                return;
            }

            var confirm = MessageBox.Show("Are you sure to delete this staff?", "Confirm Delete", MessageBoxButtons.YesNo);
            if (confirm == DialogResult.Yes)
            {
                var result = staffController.DeleteStaff(selectedStaffId);
                MessageBox.Show(result);
                LoadStaff();
            }
        }
        

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
                {
            if (e.RowIndex >= 0 && e.RowIndex < dataGridView1.Rows.Count)
            {
                var row = dataGridView1.Rows[e.RowIndex];
                selectedStaffId = Convert.ToInt32(row.Cells["Id"].Value);
                name.Text = row.Cells["Name"].Value.ToString();
                id.Text = row.Cells["user_ID"].Value.ToString();
                phone_no.Text = row.Cells["Phone_no"].Value.ToString();
            }
        }
    }
}
