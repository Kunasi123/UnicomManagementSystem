using System.Data.SQLite;
using System.Security.Cryptography.Xml;
using Assignment123.Models;
using Assignment123.View;


namespace Assignment123
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = User.Text.Trim();
            string password = pw.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter both username and password.");
                return;
            }

            using (SQLiteConnection conn = new SQLiteConnection("Data Source=Unicom.db"))
            {
                conn.Open();
                string query = "SELECT Role, ReferenceID FROM User WHERE Name = @username AND Password = @password";
                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);

                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string Role = reader["Role"].ToString();
                            int referenceid = Convert.ToInt32(reader["ReferenceID"]);

                            Login2.LoggedInRole = Role;
                            Login2.ReferenceID = referenceid;

                            OpenDashboard(Role, referenceid);
                            this.Hide();

                            Mainform mainform = new Mainform();
                            mainform.Show();
                        }
                        else
                        {
                            MessageBox.Show("Invalid username or password.");
                        }
                    }
                }
            }
        }



        private void OpenDashboard(string role, int ReferenceId)
        {
            Form dashboard = null;

            switch (role.ToLower())
            {
                case "admin":
                    dashboard = new Register();
                    break;
                case "staff":
                    dashboard = new Register();
                    break;
                case "lecturer":
                    dashboard = new Register();
                    break;
                case "student":
                    dashboard = new Register();
                    break;
                default:
                    MessageBox.Show("Unknown role!");
                    return;
            }

            dashboard.Show();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Register register = new Register();
            register.Show();


        }

        private void outin_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to log out?", "Confirm Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                MessageBox.Show("You have been logged out successfully.", "Logout", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide(); // Close the current form


            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
