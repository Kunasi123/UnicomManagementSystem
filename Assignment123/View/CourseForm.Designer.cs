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
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(188, 79);
            label1.Name = "label1";
            label1.Size = new Size(142, 25);
            label1.TabIndex = 0;
            label1.Text = "Course_Name :- ";
            // 
            // text_name
            // 
            text_name.Location = new Point(360, 79);
            text_name.Name = "text_name";
            text_name.Size = new Size(150, 31);
            text_name.TabIndex = 2;
            // 
            // Add_Course
            // 
            Add_Course.Location = new Point(596, 181);
            Add_Course.Name = "Add_Course";
            Add_Course.Size = new Size(112, 34);
            Add_Course.TabIndex = 4;
            Add_Course.Text = "Add";
            Add_Course.UseVisualStyleBackColor = true;
            Add_Course.Click += Add_Course_Click;
            // 
            // Update_course
            // 
            Update_course.Location = new Point(398, 181);
            Update_course.Name = "Update_course";
            Update_course.Size = new Size(112, 34);
            Update_course.TabIndex = 5;
            Update_course.Text = "Update";
            Update_course.UseVisualStyleBackColor = true;
            Update_course.Click += Update_course_Click;
            // 
            // delete_course
            // 
            delete_course.Location = new Point(199, 181);
            delete_course.Name = "delete_course";
            delete_course.Size = new Size(112, 34);
            delete_course.TabIndex = 6;
            delete_course.Text = "Delete";
            delete_course.UseVisualStyleBackColor = true;
            delete_course.Click += delete_course_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(188, 293);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(555, 145);
            dataGridView1.TabIndex = 7;
            // 
            // CourseForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1188, 450);
            Controls.Add(dataGridView1);
            Controls.Add(delete_course);
            Controls.Add(Update_course);
            Controls.Add(Add_Course);
            Controls.Add(text_name);
            Controls.Add(label1);
            Name = "CourseForm";
            Text = "CourseForm";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
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
    }
}