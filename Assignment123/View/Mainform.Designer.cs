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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 68);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(193, 24);
            label1.Name = "label1";
            label1.Size = new Size(373, 25);
            label1.TabIndex = 0;
            label1.Text = "====SCHOOL MANAGEMENT SYSTEM====";
            label1.Click += label1_Click;
            // 
            // button1
            // 
            button1.Location = new Point(268, 111);
            button1.Name = "button1";
            button1.Size = new Size(222, 34);
            button1.TabIndex = 1;
            button1.Text = "Login System";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(268, 190);
            button2.Name = "button2";
            button2.Size = new Size(222, 34);
            button2.TabIndex = 2;
            button2.Text = "Course_Subject Management System";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(268, 263);
            button3.Name = "button3";
            button3.Size = new Size(222, 34);
            button3.TabIndex = 3;
            button3.Text = "Student Management System";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(264, 335);
            button4.Name = "button4";
            button4.Size = new Size(226, 34);
            button4.TabIndex = 4;
            button4.Text = "Exam_Marks Management System";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(264, 404);
            button5.Name = "button5";
            button5.Size = new Size(226, 34);
            button5.TabIndex = 5;
            button5.Text = "Timetable Management System";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // Mainform
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 466);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(panel1);
            Name = "Mainform";
            Text = "Mainform";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Label label1;
    }
}