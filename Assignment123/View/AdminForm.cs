using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Assignment123.Controller;
using Assignment123.Models;

namespace Assignment123.View
{
    public partial class AdminForm : Form
    {
        AdminController AdminController = new AdminController();
        private int selectedAdminId = -1; // To track the selected admin for updates
        public AdminForm()
        {
            InitializeComponent();
            dataGridView1.CellClick += dataGridView1_CellClick;
            LoadAdmins();
            User user = new User();
            if (user.Role == "Admin")
            {
                button3.Visible = true;
                Update_admin.Visible = true;
                button1.Visible = true;
            }
            else
            {
                button3.Visible = false;
                Update_admin.Visible = false;
                button1.Visible = false;
            }
        }
        private void LoadAdmins()
        {
            var admins = AdminController.GetAllAdmins();
            dataGridView1.DataSource = admins;
            dataGridView1.ClearSelection(); // Clear any previous selection
            clearinput(); // Clear input fields after loading admins
            selectedAdminId = -1; // Reset the selected admin ID

        }
        private void clearinput()
        {
            name.Clear();
            ages.Clear();
            phoneno.Clear();

        }
        private void AdminForm_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(name.Text) ||
                string.IsNullOrWhiteSpace(ages.Text) ||
                string.IsNullOrWhiteSpace(phoneno.Text))
            {
                MessageBox.Show("All fields are required!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validate age as integer
            if (!int.TryParse(ages.Text, out int age))
            {
                MessageBox.Show("Age must be a valid number.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            string phone = phoneno.Text.Trim();

            Admin admin = new Admin
            {
                Name = name.Text.Trim(),
                Age = age,
                Phoneno = phone
            };

            string result = AdminController.AddAdmin(admin);
            MessageBox.Show(result);
            LoadAdmins();
        }


        private void Update_admin_Click(object sender, EventArgs e)
        {
            if (selectedAdminId == -1)
            {
                MessageBox.Show("Please select an admin to update.", "Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (
                string.IsNullOrWhiteSpace(name.Text) ||
                string.IsNullOrWhiteSpace(ages.Text) ||
                string.IsNullOrWhiteSpace(phoneno.Text))
            {
                MessageBox.Show("All fields are required for updating!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validate age as integer
            if (!int.TryParse(ages.Text, out int age))
            {
                MessageBox.Show("Age must be a valid number.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Phone number left as string
            string phone = phoneno.Text.Trim();

            Admin admin = new Admin
            {
                Id = selectedAdminId,   // important to include the ID here for update
                Name = name.Text.Trim(),
                Age = age,
                Phoneno = phone
            };

            string result = AdminController.UpdateaAdmin(admin);
            MessageBox.Show(result);
            LoadAdmins();
        }



        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dataGridView1.Rows.Count)
            {
                var row = dataGridView1.Rows[e.RowIndex];
                selectedAdminId = Convert.ToInt32(row.Cells["Id"].Value);
                name.Text = row.Cells["Name"].Value.ToString();
                ages.Text = row.Cells["Age"].Value.ToString();
                phoneno.Text = row.Cells["Phoneno"].Value.ToString();
            }
        }



        private void button1_Click(object sender, EventArgs e)
        {
            {
                if (selectedAdminId == -1)
                {
                    MessageBox.Show("Please select an admin to delete.", "Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                var confirmResult = MessageBox.Show("Are you sure you want to delete this admin?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirmResult != DialogResult.Yes)
                {
                    return; // User cancelled the deletion
                }
                string result = AdminController.DeleteAdmin(selectedAdminId);
                MessageBox.Show(result);
                LoadAdmins();
                selectedAdminId = -1; // Reset the selected admin ID after deletion
            }
        }
    }

}
