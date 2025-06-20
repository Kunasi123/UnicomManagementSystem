namespace Assignment123.View
{
    partial class TimetableForm
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
            panel1 = new Panel();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            Add_timetable = new Button();
            Update_timetable = new Button();
            Delete_timetable = new Button();
            dataGridView1 = new DataGridView();
            start = new DateTimePicker();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            group = new ComboBox();
            end = new DateTimePicker();
            sub_id = new ComboBox();
            rooms = new ComboBox();
            Stu_id = new ComboBox();
            lec_id = new ComboBox();
            label8 = new Label();
            Dates = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1401, 49);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(42, 78);
            label1.Name = "label1";
            label1.Size = new Size(71, 25);
            label1.TabIndex = 1;
            label1.Text = "Lec_Id:-";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(311, 78);
            label2.Name = "label2";
            label2.Size = new Size(79, 25);
            label2.TabIndex = 2;
            label2.Text = "Sub_ID:-";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(623, 81);
            label3.Name = "label3";
            label3.Size = new Size(96, 25);
            label3.TabIndex = 3;
            label3.Text = "Room_ID:-";
            // 
            // Add_timetable
            // 
            Add_timetable.Location = new Point(827, 380);
            Add_timetable.Name = "Add_timetable";
            Add_timetable.Size = new Size(112, 34);
            Add_timetable.TabIndex = 11;
            Add_timetable.Text = "Add";
            Add_timetable.UseVisualStyleBackColor = true;
            Add_timetable.Click += Add_timetable_Click;
            // 
            // Update_timetable
            // 
            Update_timetable.Location = new Point(538, 368);
            Update_timetable.Name = "Update_timetable";
            Update_timetable.Size = new Size(112, 34);
            Update_timetable.TabIndex = 12;
            Update_timetable.Text = "Update";
            Update_timetable.UseVisualStyleBackColor = true;
            Update_timetable.Click += Update_timetable_Click;
            // 
            // Delete_timetable
            // 
            Delete_timetable.Location = new Point(227, 380);
            Delete_timetable.Name = "Delete_timetable";
            Delete_timetable.Size = new Size(112, 34);
            Delete_timetable.TabIndex = 13;
            Delete_timetable.Text = "Delete";
            Delete_timetable.UseVisualStyleBackColor = true;
            Delete_timetable.Click += Delete_timetable_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(157, 450);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(1008, 225);
            dataGridView1.TabIndex = 15;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // start
            // 
            start.Format = DateTimePickerFormat.Time;
            start.Location = new Point(136, 183);
            start.Name = "start";
            start.Size = new Size(300, 31);
            start.TabIndex = 16;
            start.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(1008, 73);
            label4.Name = "label4";
            label4.Size = new Size(105, 25);
            label4.TabIndex = 17;
            label4.Text = "Student Id:-";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 182);
            label5.Name = "label5";
            label5.Size = new Size(102, 25);
            label5.TabIndex = 18;
            label5.Text = "Start Time:-";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(1052, 169);
            label6.Name = "label6";
            label6.Size = new Size(73, 25);
            label6.TabIndex = 19;
            label6.Text = "Group:-";
            label6.Click += label6_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(487, 183);
            label7.Name = "label7";
            label7.Size = new Size(101, 25);
            label7.TabIndex = 20;
            label7.Text = "End Time :-";
            // 
            // group
            // 
            group.FormattingEnabled = true;
            group.Location = new Point(1158, 161);
            group.Name = "group";
            group.Size = new Size(182, 33);
            group.TabIndex = 22;
            group.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // end
            // 
            end.Format = DateTimePickerFormat.Time;
            end.Location = new Point(602, 177);
            end.Name = "end";
            end.Size = new Size(300, 31);
            end.TabIndex = 23;
            // 
            // sub_id
            // 
            sub_id.FormattingEnabled = true;
            sub_id.Location = new Point(396, 78);
            sub_id.Name = "sub_id";
            sub_id.Size = new Size(182, 33);
            sub_id.TabIndex = 24;
            // 
            // rooms
            // 
            rooms.FormattingEnabled = true;
            rooms.Location = new Point(747, 78);
            rooms.Name = "rooms";
            rooms.Size = new Size(182, 33);
            rooms.TabIndex = 25;
            // 
            // Stu_id
            // 
            Stu_id.FormattingEnabled = true;
            Stu_id.Location = new Point(1158, 70);
            Stu_id.Name = "Stu_id";
            Stu_id.Size = new Size(182, 33);
            Stu_id.TabIndex = 26;
            // 
            // lec_id
            // 
            lec_id.FormattingEnabled = true;
            lec_id.Location = new Point(119, 73);
            lec_id.Name = "lec_id";
            lec_id.Size = new Size(182, 33);
            lec_id.TabIndex = 27;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(42, 290);
            label8.Name = "label8";
            label8.Size = new Size(60, 25);
            label8.TabIndex = 28;
            label8.Text = "Date:-";
            // 
            // Dates
            // 
            Dates.Location = new Point(136, 284);
            Dates.Name = "Dates";
            Dates.Size = new Size(300, 31);
            Dates.TabIndex = 29;
            // 
            // TimetableForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1401, 762);
            Controls.Add(Dates);
            Controls.Add(label8);
            Controls.Add(lec_id);
            Controls.Add(Stu_id);
            Controls.Add(rooms);
            Controls.Add(sub_id);
            Controls.Add(end);
            Controls.Add(group);
            Controls.Add(label5);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(start);
            Controls.Add(dataGridView1);
            Controls.Add(Delete_timetable);
            Controls.Add(Update_timetable);
            Controls.Add(Add_timetable);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel1);
            Name = "TimetableForm";
            Text = "TimetableForm";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button Add_timetable;
        private Button Update_timetable;
        private Button Delete_timetable;
        private DataGridView dataGridView1;
        private DateTimePicker start;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private ComboBox group;
        private DateTimePicker end;
        private ComboBox sub_id;
        private ComboBox rooms;
        private ComboBox Stu_id;
        private ComboBox lec_id;
        private Label label8;
        private DateTimePicker Dates;
    }
}