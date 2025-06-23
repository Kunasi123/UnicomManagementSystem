namespace Assignment123.View
{
    partial class Register
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
            user = new TextBox();
            pw = new TextBox();
            conpass = new TextBox();
            com1 = new ComboBox();
            label4 = new Label();
            login = new Button();
            label5 = new Label();
            REId = new TextBox();
            label6 = new Label();
            panel1 = new Panel();
            label7 = new Label();
            no = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(100, 23);
            label1.TabIndex = 12;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.DeepPink;
            label2.Location = new Point(110, 197);
            label2.Name = "label2";
            label2.Size = new Size(109, 25);
            label2.TabIndex = 1;
            label2.Text = "Password :-";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.DeepPink;
            label3.Location = new Point(588, 197);
            label3.Name = "label3";
            label3.Size = new Size(182, 25);
            label3.TabIndex = 2;
            label3.Text = "Confirm Password :-";
            label3.Click += label3_Click;
            // 
            // user
            // 
            user.Location = new Point(235, 135);
            user.Name = "user";
            user.Size = new Size(150, 31);
            user.TabIndex = 3;
            // 
            // pw
            // 
            pw.Location = new Point(235, 197);
            pw.Name = "pw";
            pw.Size = new Size(150, 31);
            pw.TabIndex = 4;
            pw.TextChanged += textBox2_TextChanged;
            // 
            // conpass
            // 
            conpass.Location = new Point(795, 191);
            conpass.Name = "conpass";
            conpass.Size = new Size(150, 31);
            conpass.TabIndex = 5;
            conpass.TextChanged += textBox3_TextChanged;
            // 
            // com1
            // 
            com1.FormattingEnabled = true;
            com1.Items.AddRange(new object[] { "Admin", "Student", "Staff", "Lecture" });
            com1.Location = new Point(235, 269);
            com1.Name = "com1";
            com1.Size = new Size(182, 33);
            com1.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.DeepPink;
            label4.Location = new Point(110, 269);
            label4.Name = "label4";
            label4.Size = new Size(67, 25);
            label4.TabIndex = 7;
            label4.Text = "Role :-";
            label4.Click += label4_Click;
            // 
            // login
            // 
            login.BackColor = Color.MediumVioletRed;
            login.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            login.ForeColor = SystemColors.ActiveCaptionText;
            login.Location = new Point(931, 362);
            login.Name = "login";
            login.Size = new Size(111, 45);
            login.TabIndex = 11;
            login.Text = "Sign up";
            login.UseVisualStyleBackColor = false;
            login.Click += login_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.DeepPink;
            label5.Location = new Point(588, 135);
            label5.Name = "label5";
            label5.Size = new Size(129, 25);
            label5.TabIndex = 9;
            label5.Text = "ReferenceID:-";
            // 
            // REId
            // 
            REId.Location = new Point(795, 129);
            REId.Name = "REId";
            REId.Size = new Size(150, 31);
            REId.TabIndex = 10;
            REId.TextChanged += REId_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.DeepPink;
            label6.Location = new Point(110, 135);
            label6.Name = "label6";
            label6.Size = new Size(114, 25);
            label6.TabIndex = 13;
            label6.Text = "Username :-";
            // 
            // panel1
            // 
            panel1.BackColor = Color.MediumVioletRed;
            panel1.Controls.Add(label7);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1067, 75);
            panel1.TabIndex = 14;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Black", 11F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.ActiveCaptionText;
            label7.Location = new Point(483, 21);
            label7.Name = "label7";
            label7.Size = new Size(153, 30);
            label7.TabIndex = 0;
            label7.Text = "SignUp Form";
            // 
            // no
            // 
            no.BackColor = Color.MediumVioletRed;
            no.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            no.Location = new Point(84, 362);
            no.Name = "no";
            no.Size = new Size(112, 44);
            no.TabIndex = 15;
            no.Text = "Not now";
            no.UseVisualStyleBackColor = false;
            no.Click += no_Click;
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1067, 450);
            Controls.Add(no);
            Controls.Add(panel1);
            Controls.Add(label6);
            Controls.Add(REId);
            Controls.Add(label5);
            Controls.Add(login);
            Controls.Add(label4);
            Controls.Add(com1);
            Controls.Add(conpass);
            Controls.Add(pw);
            Controls.Add(user);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Register";
            Text = "LoginForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox user;
        private TextBox pw;
        private TextBox conpass;
        private ComboBox com1;
        private Label label4;
        private Button login;
        private Label label5;
        private TextBox REId;
        private Label label6;
        private Panel panel1;
        private Label label7;
        private Button no;
    }
}