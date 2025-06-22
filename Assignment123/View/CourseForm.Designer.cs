namespace Assignment123.View
{
    partial class CourseForm
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
            text_name = new TextBox();
            Add_Course = new Button();
            Update_course = new Button();
            delete_course = new Button();
            dataGridView1 = new DataGridView();
            panel1 = new Panel();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.SteelBlue;
            label1.Location = new Point(244, 85);
            label1.Name = "label1";
            label1.Size = new Size(154, 25);
            label1.TabIndex = 0;
            label1.Text = "Course_Name :- ";
            // 
            // text_name
            // 
            text_name.BackColor = SystemColors.ControlLightLight;
            text_name.Location = new Point(416, 85);
            text_name.Name = "text_name";
            text_name.Size = new Size(150, 31);
            text_name.TabIndex = 2;
            // 
            // Add_Course
            // 
            Add_Course.BackColor = Color.LightSkyBlue;
            Add_Course.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Add_Course.Location = new Point(596, 181);
            Add_Course.Name = "Add_Course";
            Add_Course.Size = new Size(112, 34);
            Add_Course.TabIndex = 4;
            Add_Course.Text = "Add";
            Add_Course.UseVisualStyleBackColor = false;
            Add_Course.Click += Add_Course_Click;
            // 
            // Update_course
            // 
            Update_course.BackColor = Color.LightSkyBlue;
            Update_course.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Update_course.Location = new Point(398, 181);
            Update_course.Name = "Update_course";
            Update_course.Size = new Size(112, 34);
            Update_course.TabIndex = 5;
            Update_course.Text = "Update";
            Update_course.UseVisualStyleBackColor = false;
            Update_course.Click += Update_course_Click;
            // 
            // delete_course
            // 
            delete_course.BackColor = Color.LightSkyBlue;
            delete_course.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            delete_course.Location = new Point(199, 181);
            delete_course.Name = "delete_course";
            delete_course.Size = new Size(112, 34);
            delete_course.TabIndex = 6;
            delete_course.Text = "Delete";
            delete_course.UseVisualStyleBackColor = false;
            delete_course.Click += delete_course_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ControlLightLight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.GridColor = SystemColors.ControlDark;
            dataGridView1.Location = new Point(232, 246);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(440, 267);
            dataGridView1.TabIndex = 7;
            // 
            // panel1
            // 
            panel1.BackColor = Color.SteelBlue;
            panel1.Controls.Add(label2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(957, 62);
            panel1.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.InactiveCaptionText;
            label2.Location = new Point(322, 19);
            label2.Name = "label2";
            label2.Size = new Size(302, 30);
            label2.TabIndex = 0;
            label2.Text = "Course Management System";
            // 
            // CourseForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(957, 654);
            Controls.Add(panel1);
            Controls.Add(dataGridView1);
            Controls.Add(delete_course);
            Controls.Add(Update_course);
            Controls.Add(Add_Course);
            Controls.Add(text_name);
            Controls.Add(label1);
            Name = "CourseForm";
            Text = "CourseForm";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox text_name;
        private Button Add_Course;
        private Button Update_course;
        private Button delete_course;
        private DataGridView dataGridView1;
        private Panel panel1;
        private Label label2;
    }
}