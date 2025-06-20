using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment123.View
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
            com1.Items.AddRange(new object[] { "Admin", "Staff", "Lecture", "Student" });
            com1.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
















        private void login_Click(object sender, EventArgs e)
        {
            string username = user.Text.Trim();
            string password = pw.Text.Trim();
            string confirmPassword = conpass.Text.Trim();
            string reference = REId.Text.Trim();
            string role = com1.SelectedItem?.ToString();

            if(string.IsNullOrEmpty(username) || 
                string.IsNullOrEmpty(password) || 
                string.IsNullOrEmpty(confirmPassword) || 
                string.IsNullOrEmpty(reference) || 
                string.IsNullOrEmpty(role))
            {
                MessageBox.Show("Please fill all fields.");
                return;
            }
            if(password!=confirmPassword)
            {                 MessageBox.Show("Password and Confirm Password do not match.");
                return;
            }
            if(!int.TryParse(reference, out int referenceId))
            {
                MessageBox.Show("Reference ID must be a valid number.");
                return;
            }
            if (role == "Admin" || role == "Staff")
            {
                if (referenceId <= 0)
                {
                    MessageBox.Show("Reference ID must be greater than 0 for Admin and Staff.");
                    return;
                }
            }
            else if (role == "Lecture" || role == "Student")
            {
                if (referenceId < 0)
                {
                    MessageBox.Show("Reference ID must be a valid number for Lecture and Student.");
                    return;
                }
            }
            if (!Rolecheck(role, referenceId))
            {
                MessageBox.Show($"Reference ID does not exist in the {role} table.");
                return;
            }


            try
            {
                using (SQLiteConnection conn = new SQLiteConnection("Data Source=Unicom.db;"))
                {
                    conn.Open();
                    string query = "INSERT INTO User (Name, Password, Role, ReferenceId) VALUES (@usernames, @password, @role, @referenceId)";
                    using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@usernames", username);
                        cmd.Parameters.AddWithValue("@password", password);
                        cmd.Parameters.AddWithValue("@role", role);
                        cmd.Parameters.AddWithValue("@referenceId", referenceId);
                        cmd.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Registration successful!");
                this.Close(); // Close the registration form after successful registration
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
            if(role == "Admin")
            {
                // Redirect to Admin Dashboard or perform admin-specific actions
                MessageBox.Show("Welcome Admin!");
            }
            else if (role == "Staff")
            {
                // Redirect to Staff Dashboard or perform staff-specific actions
                MessageBox.Show("Welcome Staff!");
            }
            else if (role == "Lecture")
            {
                // Redirect to Lecture Dashboard or perform lecture-specific actions
                MessageBox.Show("Welcome Lecture!");
            }
            else if (role == "Student")
            {
                // Redirect to Student Dashboard or perform student-specific actions
                MessageBox.Show("Welcome Student!");
            }  
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(confirmPassword) || string.IsNullOrEmpty(reference) || string.IsNullOrEmpty(role))
            {
                MessageBox.Show("Please fill all fields.");
                return;
            }
           
            
            

        }
        private bool Rolecheck(string role, int referenceId)
        {
            string tablename=null;
            string columnname = null;

            switch (role)
            {
                case "Admin":
                    tablename = "Admins"; // Replace with actual admin table name
                    columnname = "ID"; // Replace with actual admin ID column name
                    break;
                case "Staff":
                    tablename = "Staff"; // Replace with actual staff table name
                    columnname = "ID"; // Replace with actual staff ID column name
                    break;
                case "Lecture":
                    tablename = "Lecture"; // Replace with actual lecture table name
                    columnname = "ID"; // Replace with actual lecture ID column name
                    break;
                case "Student":
                    tablename = "Student"; // Replace with actual student table name
                    columnname = "ID"; // Replace with actual student ID column name
                    break;
                default:
                    return false; // Invalid role
            }
            using (SQLiteConnection conn = new SQLiteConnection("Data Source=unicom.db;"))
            {
                conn.Open();
                string query = $"SELECT COUNT(*) FROM {tablename} WHERE {columnname} = @referenceId";
                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@referenceId", referenceId);
                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    return count > 0; // Returns true if the reference ID exists in the specified table
                }
            }
        }







    }
}




        
    

