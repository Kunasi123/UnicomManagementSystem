namespace Assignment123.View
{
    partial class SubjectForm
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
            label2 = new Label();
            label3 = new Label();
            name = new TextBox();
            Add_subject = new Button();
            Update_subject = new Button();
            Delete_subject = new Button();
            dataGridView1 = new DataGridView();
            course = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(109, 62);
            label2.Name = "label2";
            label2.Size = new Size(118, 25);
            label2.TabIndex = 1;
            label2.Text = "Sub_Name :- ";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(121, 151);
            label3.Name = "label3";
            label3.Size = new Size(106, 25);
            label3.TabIndex = 2;
            label3.Text = "Course_Id :-";
            // 
            // name
            // 
            name.Location = new Point(233, 62);
            name.Name = "name";
            name.Size = new Size(150, 31);
            name.TabIndex = 4;
            // 
            // Add_subject
            // 
            Add_subject.Location = new Point(477, 270);
            Add_subject.Name = "Add_subject";
            Add_subject.Size = new Size(112, 34);
            Add_subject.TabIndex = 6;
            Add_subject.Text = "Add";
            Add_subject.UseVisualStyleBackColor = true;
            Add_subject.Click += Add_subject_Click;
            // 
            // Update_subject
            // 
            Update_subject.Location = new Point(311, 270);
            Update_subject.Name = "Update_subject";
            Update_subject.Size = new Size(112, 34);
            Update_subject.TabIndex = 7;
            Update_subject.Text = "Update";
            Update_subject.UseVisualStyleBackColor = true;
            Update_subject.Click += Update_subject_Click;
            // 
            // Delete_subject
            // 
            Delete_subject.Location = new Point(138, 270);
            Delete_subject.Name = "Delete_subject";
            Delete_subject.Size = new Size(112, 34);
            Delete_subject.TabIndex = 8;
            Delete_subject.Text = "Delete";
            Delete_subject.UseVisualStyleBackColor = true;
            Delete_subject.Click += button3_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(121, 332);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(529, 115);
            dataGridView1.TabIndex = 9;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // course
            // 
            course.FormattingEnabled = true;
            course.Location = new Point(233, 151);
            course.Name = "course";
            course.Size = new Size(182, 33);
            course.TabIndex = 11;
            course.SelectedIndexChanged += course_SelectedIndexChanged;
            // 
            // SubjectForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(863, 450);
            Controls.Add(course);
            Controls.Add(dataGridView1);
            Controls.Add(Delete_subject);
            Controls.Add(Update_subject);
            Controls.Add(Add_subject);
            Controls.Add(name);
            Controls.Add(label3);
            Controls.Add(label2);
            Name = "SubjectForm";
            Text = "SubjectForm";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private TextBox name;
        private TextBox textBox3;
        private Button Add_subject;
        private Button Update_subject;
        private Button Delete_subject;
        private DataGridView dataGridView1;
        private ComboBox course;
    }
}