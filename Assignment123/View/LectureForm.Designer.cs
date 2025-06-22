namespace Assignment123.View
{
    partial class LectureForm
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
            label3 = new Label();
            depart_com = new ComboBox();
            name = new TextBox();
            Add_lecture = new Button();
            Update_lecture = new Button();
            delete_lecture = new Button();
            dataGridView1 = new DataGridView();
            userid = new TextBox();
            panel1 = new Panel();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Control;
            label1.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Purple;
            label1.Location = new Point(72, 124);
            label1.Name = "label1";
            label1.Size = new Size(153, 25);
            label1.TabIndex = 0;
            label1.Text = "Lecture Name :-";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Purple;
            label2.Location = new Point(489, 124);
            label2.Name = "label2";
            label2.Size = new Size(95, 25);
            label2.TabIndex = 1;
            label2.Text = "User_Id :-";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Purple;
            label3.Location = new Point(849, 124);
            label3.Name = "label3";
            label3.Size = new Size(129, 25);
            label3.TabIndex = 2;
            label3.Text = "Course Name";
            // 
            // depart_com
            // 
            depart_com.BackColor = Color.Plum;
            depart_com.FormattingEnabled = true;
            depart_com.Location = new Point(992, 116);
            depart_com.Name = "depart_com";
            depart_com.Size = new Size(182, 33);
            depart_com.TabIndex = 3;
            // 
            // name
            // 
            name.BackColor = Color.Plum;
            name.Location = new Point(243, 124);
            name.Name = "name";
            name.Size = new Size(150, 31);
            name.TabIndex = 5;
            // 
            // Add_lecture
            // 
            Add_lecture.BackColor = Color.Thistle;
            Add_lecture.Location = new Point(808, 217);
            Add_lecture.Name = "Add_lecture";
            Add_lecture.Size = new Size(112, 34);
            Add_lecture.TabIndex = 6;
            Add_lecture.Text = "Add";
            Add_lecture.UseVisualStyleBackColor = false;
            Add_lecture.Click += Add_lecture_Click;
            // 
            // Update_lecture
            // 
            Update_lecture.BackColor = Color.Thistle;
            Update_lecture.Location = new Point(535, 217);
            Update_lecture.Name = "Update_lecture";
            Update_lecture.Size = new Size(112, 34);
            Update_lecture.TabIndex = 7;
            Update_lecture.Text = "Update";
            Update_lecture.UseVisualStyleBackColor = false;
            Update_lecture.Click += Update_lecture_Click_1;
            // 
            // delete_lecture
            // 
            delete_lecture.BackColor = Color.Thistle;
            delete_lecture.Location = new Point(243, 217);
            delete_lecture.Name = "delete_lecture";
            delete_lecture.Size = new Size(112, 34);
            delete_lecture.TabIndex = 8;
            delete_lecture.Text = "Delete";
            delete_lecture.UseVisualStyleBackColor = false;
            delete_lecture.Click += delete_lecture_Click_1;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.LavenderBlush;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(217, 275);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(735, 315);
            dataGridView1.TabIndex = 9;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // userid
            // 
            userid.BackColor = Color.Plum;
            userid.Location = new Point(594, 124);
            userid.Name = "userid";
            userid.Size = new Size(150, 31);
            userid.TabIndex = 10;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Orchid;
            panel1.Controls.Add(label4);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1200, 79);
            panel1.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Black", 11F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.Location = new Point(427, 21);
            label4.Name = "label4";
            label4.Size = new Size(328, 30);
            label4.TabIndex = 0;
            label4.Text = "Lecture Management System";
            // 
            // LectureForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1200, 623);
            Controls.Add(panel1);
            Controls.Add(userid);
            Controls.Add(dataGridView1);
            Controls.Add(delete_lecture);
            Controls.Add(Update_lecture);
            Controls.Add(Add_lecture);
            Controls.Add(name);
            Controls.Add(depart_com);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "LectureForm";
            Text = "LectureForm";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private ComboBox depart_com;
        private TextBox name;
        private Button Add_lecture;
        private Button Update_lecture;
        private Button delete_lecture;
        private DataGridView dataGridView1;
        private TextBox userid;
        private Panel panel1;
        private Label label4;
    }
}