namespace Assignment123.View
{
    partial class Mainform
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
            stu = new Button();
            staf = new Button();
            lec = new Button();
            add = new Button();
            panel2 = new Panel();
            timetabless = new Button();
            log = new Button();
            coursess = new Button();
            subjectss = new Button();
            roomss = new Button();
            marksss = new Button();
            examss = new Button();
            panel3 = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkMagenta;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1660, 80);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Purple;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(650, 21);
            label1.Name = "label1";
            label1.Size = new Size(412, 38);
            label1.TabIndex = 0;
            label1.Text = "Unicom Management System ";
            label1.Click += label1_Click;
            // 
            // stu
            // 
            stu.BackColor = Color.MediumVioletRed;
            stu.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            stu.Location = new Point(60, 208);
            stu.Name = "stu";
            stu.Size = new Size(123, 34);
            stu.TabIndex = 4;
            stu.Text = "Student";
            stu.UseVisualStyleBackColor = false;
            stu.Click += button4_Click;
            // 
            // staf
            // 
            staf.BackColor = Color.MediumVioletRed;
            staf.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            staf.Location = new Point(62, 82);
            staf.Name = "staf";
            staf.Size = new Size(123, 34);
            staf.TabIndex = 2;
            staf.Text = "Staff";
            staf.UseVisualStyleBackColor = false;
            staf.Click += button2_Click;
            // 
            // lec
            // 
            lec.BackColor = Color.MediumVioletRed;
            lec.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lec.Location = new Point(62, 143);
            lec.Name = "lec";
            lec.Size = new Size(123, 34);
            lec.TabIndex = 5;
            lec.Text = "Lecture";
            lec.UseVisualStyleBackColor = false;
            lec.Click += button5_Click;
            // 
            // add
            // 
            add.BackColor = Color.MediumVioletRed;
            add.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            add.Location = new Point(62, 21);
            add.Name = "add";
            add.Size = new Size(123, 34);
            add.TabIndex = 6;
            add.Text = "Admin";
            add.UseVisualStyleBackColor = false;
            add.Click += button1_Click_1;
            // 
            // panel2
            // 
            panel2.Controls.Add(staf);
            panel2.Controls.Add(stu);
            panel2.Controls.Add(timetabless);
            panel2.Controls.Add(log);
            panel2.Controls.Add(lec);
            panel2.Controls.Add(coursess);
            panel2.Controls.Add(subjectss);
            panel2.Controls.Add(roomss);
            panel2.Controls.Add(marksss);
            panel2.Controls.Add(examss);
            panel2.Controls.Add(add);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 80);
            panel2.Name = "panel2";
            panel2.Size = new Size(235, 650);
            panel2.TabIndex = 7;
            // 
            // timetabless
            // 
            timetabless.BackColor = Color.MediumVioletRed;
            timetabless.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            timetabless.Location = new Point(62, 550);
            timetabless.Name = "timetabless";
            timetabless.Size = new Size(122, 34);
            timetabless.TabIndex = 0;
            timetabless.Text = "Timetable";
            timetabless.UseVisualStyleBackColor = false;
            timetabless.Click += timetabless_Click;
            // 
            // log
            // 
            log.BackColor = Color.MediumVioletRed;
            log.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            log.Location = new Point(61, 602);
            log.Name = "log";
            log.Size = new Size(122, 34);
            log.TabIndex = 13;
            log.Text = "LogOut";
            log.UseVisualStyleBackColor = false;
            log.Click += log_Click;
            // 
            // coursess
            // 
            coursess.BackColor = Color.MediumVioletRed;
            coursess.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            coursess.Location = new Point(60, 265);
            coursess.Name = "coursess";
            coursess.Size = new Size(123, 34);
            coursess.TabIndex = 11;
            coursess.Text = "Course";
            coursess.UseVisualStyleBackColor = false;
            coursess.Click += coursess_Click;
            // 
            // subjectss
            // 
            subjectss.BackColor = Color.MediumVioletRed;
            subjectss.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            subjectss.Location = new Point(62, 322);
            subjectss.Name = "subjectss";
            subjectss.Size = new Size(123, 34);
            subjectss.TabIndex = 10;
            subjectss.Text = "Subject";
            subjectss.UseVisualStyleBackColor = false;
            subjectss.Click += subjectss_Click;
            // 
            // roomss
            // 
            roomss.BackColor = Color.MediumVioletRed;
            roomss.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            roomss.Location = new Point(61, 489);
            roomss.Name = "roomss";
            roomss.Size = new Size(122, 34);
            roomss.TabIndex = 9;
            roomss.Text = "Room";
            roomss.UseVisualStyleBackColor = false;
            roomss.Click += roomss_Click;
            // 
            // marksss
            // 
            marksss.BackColor = Color.MediumVioletRed;
            marksss.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            marksss.Location = new Point(62, 436);
            marksss.Name = "marksss";
            marksss.Size = new Size(123, 34);
            marksss.TabIndex = 8;
            marksss.Text = "Mark";
            marksss.UseVisualStyleBackColor = false;
            marksss.Click += marksss_Click;
            // 
            // examss
            // 
            examss.BackColor = Color.MediumVioletRed;
            examss.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            examss.Location = new Point(62, 383);
            examss.Name = "examss";
            examss.Size = new Size(123, 34);
            examss.TabIndex = 7;
            examss.Text = "Exam";
            examss.UseVisualStyleBackColor = false;
            examss.Click += examss_Click;
            // 
            // panel3
            // 
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(235, 80);
            panel3.Name = "panel3";
            panel3.Size = new Size(1425, 650);
            panel3.TabIndex = 8;
            // 
            // Mainform
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1660, 730);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Mainform";
            Text = "Mainform";
            Load += Mainform_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Button stu;
        private Button staf;
        private Button lec;
        private Button add;
        private Panel panel2;
        private Button log;
        private Button coursess;
        private Button subjectss;
        private Button roomss;
        private Button marksss;
        private Button examss;
        private Button timetabless;
        private Panel panel3;
    }
}