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
    public partial class RoomForm : Form
    {
        RoomController roomController=new RoomController();
        int selectedRoom = -1;
        
        public RoomForm()
        {
            InitializeComponent();
            comboBox1.Items.AddRange(new[] { "Hall", "Lab" });
            comboBox1.DropDownStyle= ComboBoxStyle.DropDownList;

            Add_room.Click += Add_room_Click;
            Update_room.Click += Update_room_Click;
            delete_room.Click += Delete_room_Click;
            dataGridView1.CellClick += DataGridView1_CellClick;

            LoadRooms();
            User user = new User();
            if (user.Role == "Admin")
            {
                Add_room.Visible = true;
                Update_room.Visible = true;
                delete_room.Visible = true;
            }
            
        }
        private void LoadRooms()
        {
            var rooms = roomController.GetAllRooms();
            dataGridView1.DataSource = rooms;
            dataGridView1.ClearSelection();
            ClearInputs();
        }
        private void ClearInputs()
        {
            nameText.Clear();
            comboBox1.SelectedIndex = -1;
            selectedRoom= -1;
        }



        private void DataGridView1_CellClick(object? sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0 && e.RowIndex < dataGridView1.Rows.Count)
            {
                var row = dataGridView1.Rows[e.RowIndex];
                selectedRoom = Convert.ToInt32(row.Cells["ID"].Value);
                nameText.Text = row.Cells["Name"].Value.ToString();
                comboBox1.SelectedItem = row.Cells["Type"].Value.ToString();
            }
        }

        

        private void Delete_room_Click(object? sender, EventArgs e)
        {
        
            if (selectedRoom == -1)
            {
                MessageBox.Show("Please select a room to delete.");
                return;
            }

            var confirm = MessageBox.Show("Are you sure you want to delete this room?", "Confirm", MessageBoxButtons.YesNo);
            if (confirm == DialogResult.Yes)
            {
                string result = roomController.DeleteRoom(selectedRoom);
                MessageBox.Show(result);
                LoadRooms();
            }
        }

        

        private void Update_room_Click(object? sender, EventArgs e)
        {
        
            if (selectedRoom == -1)
            {
                MessageBox.Show("Please select a room to update.");
                return;
            }

            if (string.IsNullOrWhiteSpace(nameText.Text) || comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("All fields are required.");
                return;
            }

            var room = new Room
            {
                ID = selectedRoom,
                Name = nameText.Text.Trim(),
                Type = comboBox1.SelectedItem.ToString()
            };

            string result = roomController.UpdateRoom(room);
            MessageBox.Show(result);
            LoadRooms();
        }

        

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Add_room_Click(object sender, EventArgs e)
        
        {
            if (string.IsNullOrWhiteSpace(nameText.Text) || comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            var room = new Room
            {
                Name = nameText.Text.Trim(),
                Type = comboBox1.SelectedItem.ToString()
            };

            string result = roomController.AddRoom(room);
            MessageBox.Show(result);
            LoadRooms();
        }

    }
}

