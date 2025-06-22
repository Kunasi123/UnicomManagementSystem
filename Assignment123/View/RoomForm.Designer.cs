namespace Assignment123.View
{
    partial class RoomForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            nameText = new TextBox();
            comboBox1 = new ComboBox();
            delete_room = new Button();
            Update_room = new Button();
            Add_room = new Button();
            dataGridView1 = new DataGridView();
            panel1 = new Panel();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Control;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DarkBlue;
            label1.Location = new Point(203, 125);
            label1.Name = "label1";
            label1.Size = new Size(79, 25);
            label1.TabIndex = 0;
            label1.Text = "Name :-";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.MidnightBlue;
            label2.Location = new Point(203, 206);
            label2.Name = "label2";
            label2.Size = new Size(65, 25);
            label2.TabIndex = 1;
            label2.Text = "Type:-";
            // 
            // nameText
            // 
            nameText.Location = new Point(299, 125);
            nameText.Name = "nameText";
            nameText.Size = new Size(150, 31);
            nameText.TabIndex = 2;
            nameText.TextChanged += textBox1_TextChanged;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(299, 203);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(182, 33);
            comboBox1.TabIndex = 3;
            // 
            // delete_room
            // 
            delete_room.BackColor = SystemColors.ActiveCaption;
            delete_room.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            delete_room.Location = new Point(151, 308);
            delete_room.Name = "delete_room";
            delete_room.Size = new Size(112, 34);
            delete_room.TabIndex = 4;
            delete_room.Text = "Delete";
            delete_room.UseVisualStyleBackColor = false;
            // 
            // Update_room
            // 
            Update_room.BackColor = SystemColors.ActiveCaption;
            Update_room.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Update_room.Location = new Point(322, 308);
            Update_room.Name = "Update_room";
            Update_room.Size = new Size(112, 34);
            Update_room.TabIndex = 5;
            Update_room.Text = "Update";
            Update_room.UseVisualStyleBackColor = false;
            // 
            // Add_room
            // 
            Add_room.BackColor = SystemColors.ActiveCaption;
            Add_room.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Add_room.Location = new Point(514, 308);
            Add_room.Name = "Add_room";
            Add_room.Size = new Size(112, 34);
            Add_room.TabIndex = 6;
            Add_room.Text = "Add";
            Add_room.UseVisualStyleBackColor = false;
            Add_room.Click += Add_room_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(170, 367);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(471, 225);
            dataGridView1.TabIndex = 7;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(label3);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(983, 74);
            panel1.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.MidnightBlue;
            label3.Location = new Point(288, 19);
            label3.Name = "label3";
            label3.Size = new Size(338, 32);
            label3.TabIndex = 0;
            label3.Text = "Room Management System";
            // 
            // RoomForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(983, 623);
            Controls.Add(panel1);
            Controls.Add(dataGridView1);
            Controls.Add(Add_room);
            Controls.Add(Update_room);
            Controls.Add(delete_room);
            Controls.Add(comboBox1);
            Controls.Add(nameText);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "RoomForm";
            Text = "RoomForm";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox nameText;
        private ComboBox comboBox1;
        private Button delete_room;
        private Button Update_room;
        private Button Add_room;
        private DataGridView dataGridView1;
        private Panel panel1;
        private Label label3;
    }
}