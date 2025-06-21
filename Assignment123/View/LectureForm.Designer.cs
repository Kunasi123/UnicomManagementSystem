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
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(91, 52);
            label1.Name = "label1";
            label1.Size = new Size(136, 25);
            label1.TabIndex = 0;
            label1.Text = "Lecture Name :-";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(484, 52);
            label2.Name = "label2";
            label2.Size = new Size(86, 25);
            label2.TabIndex = 1;
            label2.Text = "User_Id :-";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(852, 52);
            label3.Name = "label3";
            label3.Size = new Size(119, 25);
            label3.TabIndex = 2;
            label3.Text = "Course Name";
            // 
            // depart_com
            // 
            depart_com.FormattingEnabled = true;
            depart_com.Location = new Point(988, 52);
            depart_com.Name = "depart_com";
            depart_com.Size = new Size(182, 33);
            depart_com.TabIndex = 3;
            // 
            // name
            // 
            name.Location = new Point(243, 49);
            name.Name = "name";
            name.Size = new Size(150, 31);
            name.TabIndex = 5;
            // 
            // Add_lecture
            // 
            Add_lecture.Location = new Point(852, 136);
            Add_lecture.Name = "Add_lecture";
            Add_lecture.Size = new Size(112, 34);
            Add_lecture.TabIndex = 6;
            Add_lecture.Text = "Add";
            Add_lecture.UseVisualStyleBackColor = true;
            Add_lecture.Click += Add_lecture_Click;
            // 
            // Update_lecture
            // 
            Update_lecture.Location = new Point(562, 136);
            Update_lecture.Name = "Update_lecture";
            Update_lecture.Size = new Size(112, 34);
            Update_lecture.TabIndex = 7;
            Update_lecture.Text = "Update";
            Update_lecture.UseVisualStyleBackColor = true;
            Update_lecture.Click += Update_lecture_Click_1;
            // 
            // delete_lecture
            // 
            delete_lecture.Location = new Point(243, 136);
            delete_lecture.Name = "delete_lecture";
            delete_lecture.Size = new Size(112, 34);
            delete_lecture.TabIndex = 8;
            delete_lecture.Text = "Delete";
            delete_lecture.UseVisualStyleBackColor = true;
            delete_lecture.Click += delete_lecture_Click_1;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(243, 197);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(762, 225);
            dataGridView1.TabIndex = 9;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // userid
            // 
            userid.Location = new Point(599, 54);
            userid.Name = "userid";
            userid.Size = new Size(150, 31);
            userid.TabIndex = 10;
            // 
            // LectureForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1200, 450);
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
    }
}