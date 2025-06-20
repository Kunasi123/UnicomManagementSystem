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
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1499, 51);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(559, 9);
            label1.Name = "label1";
            label1.Size = new Size(373, 25);
            label1.TabIndex = 0;
            label1.Text = "====SCHOOL MANAGEMENT SYSTEM====";
            label1.Click += label1_Click;
            // 
            // stu
            // 
            stu.Location = new Point(32, 115);
            stu.Name = "stu";
            stu.Size = new Size(123, 34);
            stu.TabIndex = 4;
            stu.Text = "Student";
            stu.UseVisualStyleBackColor = true;
            stu.Click += button4_Click;
            // 
            // staf
            // 
            staf.Location = new Point(32, 56);
            staf.Name = "staf";
            staf.Size = new Size(123, 34);
            staf.TabIndex = 2;
            staf.Text = "Staff";
            staf.UseVisualStyleBackColor = true;
            staf.Click += button2_Click;
            // 
            // lec
            // 
            lec.Location = new Point(32, 173);
            lec.Name = "lec";
            lec.Size = new Size(123, 34);
            lec.TabIndex = 5;
            lec.Text = "Lecture";
            lec.UseVisualStyleBackColor = true;
            lec.Click += button5_Click;
            // 
            // add
            // 
            add.Location = new Point(31, 3);
            add.Name = "add";
            add.Size = new Size(123, 34);
            add.TabIndex = 6;
            add.Text = "Admin";
            add.UseVisualStyleBackColor = true;
            add.Click += button1_Click_1;
            // 
            // panel2
            // 
            panel2.Controls.Add(timetabless);
            panel2.Controls.Add(log);
            panel2.Controls.Add(coursess);
            panel2.Controls.Add(subjectss);
            panel2.Controls.Add(roomss);
            panel2.Controls.Add(marksss);
            panel2.Controls.Add(examss);
            panel2.Controls.Add(add);
            panel2.Controls.Add(lec);
            panel2.Controls.Add(staf);
            panel2.Controls.Add(stu);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 51);
            panel2.Name = "panel2";
            panel2.Size = new Size(186, 665);
            panel2.TabIndex = 7;
            // 
            // timetabless
            // 
            timetabless.Location = new Point(31, 472);
            timetabless.Name = "timetabless";
            timetabless.Size = new Size(122, 34);
            timetabless.TabIndex = 0;
            timetabless.Text = "Timetable";
            timetabless.UseVisualStyleBackColor = true;
            timetabless.Click += timetabless_Click;
            // 
            // log
            // 
            log.Location = new Point(32, 601);
            log.Name = "log";
            log.Size = new Size(122, 34);
            log.TabIndex = 13;
            log.Text = "LogOut";
            log.UseVisualStyleBackColor = true;
            log.Click += log_Click;
            // 
            // coursess
            // 
            coursess.Location = new Point(31, 413);
            coursess.Name = "coursess";
            coursess.Size = new Size(123, 34);
            coursess.TabIndex = 11;
            coursess.Text = "Course";
            coursess.UseVisualStyleBackColor = true;
            coursess.Click += coursess_Click;
            // 
            // subjectss
            // 
            subjectss.Location = new Point(32, 355);
            subjectss.Name = "subjectss";
            subjectss.Size = new Size(123, 34);
            subjectss.TabIndex = 10;
            subjectss.Text = "Subject";
            subjectss.UseVisualStyleBackColor = true;
            subjectss.Click += subjectss_Click;
            // 
            // roomss
            // 
            roomss.Location = new Point(32, 535);
            roomss.Name = "roomss";
            roomss.Size = new Size(122, 34);
            roomss.TabIndex = 9;
            roomss.Text = "Room";
            roomss.UseVisualStyleBackColor = true;
            roomss.Click += roomss_Click;
            // 
            // marksss
            // 
            marksss.Location = new Point(32, 293);
            marksss.Name = "marksss";
            marksss.Size = new Size(123, 34);
            marksss.TabIndex = 8;
            marksss.Text = "Mark";
            marksss.UseVisualStyleBackColor = true;
            marksss.Click += marksss_Click;
            // 
            // examss
            // 
            examss.Location = new Point(32, 233);
            examss.Name = "examss";
            examss.Size = new Size(123, 34);
            examss.TabIndex = 7;
            examss.Text = "Exam";
            examss.UseVisualStyleBackColor = true;
            examss.Click += examss_Click;
            // 
            // panel3
            // 
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(186, 51);
            panel3.Name = "panel3";
            panel3.Size = new Size(1313, 665);
            panel3.TabIndex = 8;
            // 
            // Mainform
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1499, 716);
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