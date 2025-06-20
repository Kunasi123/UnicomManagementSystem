namespace Assignment123.View
{
    partial class StudentForm
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
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            panel1 = new Panel();
            label7 = new Label();
            name = new TextBox();
            adress = new TextBox();
            age = new TextBox();
            phone_no = new TextBox();
            Add_student = new Button();
            update_com = new Button();
            Delete_student = new Button();
            dataGridView2 = new DataGridView();
            label8 = new Label();
            course_com = new ComboBox();
            group_com = new ComboBox();
            userid = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(40, 73);
            label1.Name = "label1";
            label1.Size = new Size(104, 25);
            label1.TabIndex = 0;
            label1.Text = "Stu_name :-";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(457, 76);
            label2.Name = "label2";
            label2.Size = new Size(93, 25);
            label2.TabIndex = 1;
            label2.Text = "Address :-";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(68, 143);
            label3.Name = "label3";
            label3.Size = new Size(60, 25);
            label3.TabIndex = 2;
            label3.Text = "Age :-";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(779, 70);
            label4.Name = "label4";
            label4.Size = new Size(102, 25);
            label4.TabIndex = 3;
            label4.Text = "PhoneNo :-";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Assertive;
            label5.Location = new Point(457, 140);
            label5.Name = "label5";
            label5.Size = new Size(88, 25);
            label5.TabIndex = 4;
            label5.Text = "User_ID :-";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(20, 198);
            label6.Name = "label6";
            label6.Size = new Size(108, 25);
            label6.TabIndex = 5;
            label6.Text = "Course_ID :-";
            label6.Click += label6_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(label7);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1174, 48);
            panel1.TabIndex = 7;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(328, 9);
            label7.Name = "label7";
            label7.Size = new Size(188, 25);
            label7.TabIndex = 8;
            label7.Text = "Student Management ";
            // 
            // name
            // 
            name.Location = new Point(152, 70);
            name.Name = "name";
            name.Size = new Size(150, 31);
            name.TabIndex = 9;
            // 
            // adress
            // 
            adress.Location = new Point(566, 73);
            adress.Name = "adress";
            adress.Size = new Size(150, 31);
            adress.TabIndex = 10;
            // 
            // age
            // 
            age.Location = new Point(152, 140);
            age.Name = "age";
            age.Size = new Size(150, 31);
            age.TabIndex = 11;
            // 
            // phone_no
            // 
            phone_no.Location = new Point(908, 70);
            phone_no.Name = "phone_no";
            phone_no.Size = new Size(150, 31);
            phone_no.TabIndex = 12;
            // 
            // Add_student
            // 
            Add_student.Location = new Point(831, 273);
            Add_student.Name = "Add_student";
            Add_student.Size = new Size(112, 34);
            Add_student.TabIndex = 15;
            Add_student.Text = "Add";
            Add_student.UseVisualStyleBackColor = true;
            Add_student.Click += Add_student_Click;
            // 
            // update_com
            // 
            update_com.Location = new Point(524, 273);
            update_com.Name = "update_com";
            update_com.Size = new Size(112, 34);
            update_com.TabIndex = 16;
            update_com.Text = "Update";
            update_com.UseVisualStyleBackColor = true;
            update_com.Click += update_com_Click;
            // 
            // Delete_student
            // 
            Delete_student.Location = new Point(174, 273);
            Delete_student.Name = "Delete_student";
            Delete_student.Size = new Size(112, 34);
            Delete_student.TabIndex = 17;
            Delete_student.Text = "Delete";
            Delete_student.UseVisualStyleBackColor = true;
            Delete_student.Click += Delete_student_Click;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(133, 313);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 62;
            dataGridView2.Size = new Size(842, 225);
            dataGridView2.TabIndex = 18;
            dataGridView2.CellContentClick += dataGridView2_CellContentClick;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(457, 206);
            label8.Name = "label8";
            label8.Size = new Size(78, 25);
            label8.TabIndex = 19;
            label8.Text = "Group :-";
            // 
            // course_com
            // 
            course_com.FormattingEnabled = true;
            course_com.Location = new Point(152, 198);
            course_com.Name = "course_com";
            course_com.Size = new Size(182, 33);
            course_com.TabIndex = 22;
            // 
            // group_com
            // 
            group_com.FormattingEnabled = true;
            group_com.Location = new Point(566, 206);
            group_com.Name = "group_com";
            group_com.Size = new Size(182, 33);
            group_com.TabIndex = 23;
            group_com.SelectedIndexChanged += group_com_SelectedIndexChanged;
            // 
            // userid
            // 
            userid.Location = new Point(566, 137);
            userid.Name = "userid";
            userid.Size = new Size(150, 31);
            userid.TabIndex = 24;
            // 
            // StudentForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1174, 450);
            Controls.Add(userid);
            Controls.Add(group_com);
            Controls.Add(course_com);
            Controls.Add(label8);
            Controls.Add(dataGridView2);
            Controls.Add(Delete_student);
            Controls.Add(update_com);
            Controls.Add(Add_student);
            Controls.Add(name);
            Controls.Add(adress);
            Controls.Add(age);
            Controls.Add(phone_no);
            Controls.Add(panel1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "StudentForm";
            Text = "StudentForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Panel panel1;
        private Label label7;
        private TextBox phone_no;
        private TextBox age;
        private TextBox adress;
        private TextBox name;
        private Button Add_student;
        private Button update_com;
        private Button Delete_student;
        private DataGridView dataGridView2;
        private Label label8;
        private TextBox textBox7;
        private ComboBox comboBox1;
        private ComboBox course_com;
        private ComboBox group_com;
        private TextBox userid;
    }
}