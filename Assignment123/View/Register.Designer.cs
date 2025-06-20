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
            label2.Location = new Point(97, 135);
            label2.Name = "label2";
            label2.Size = new Size(103, 25);
            label2.TabIndex = 1;
            label2.Text = "Password :-";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(601, 129);
            label3.Name = "label3";
            label3.Size = new Size(172, 25);
            label3.TabIndex = 2;
            label3.Text = "Confirm Password :-";
            label3.Click += label3_Click;
            // 
            // user
            // 
            user.Location = new Point(235, 51);
            user.Name = "user";
            user.Size = new Size(150, 31);
            user.TabIndex = 3;
            // 
            // pw
            // 
            pw.Location = new Point(235, 129);
            pw.Name = "pw";
            pw.Size = new Size(150, 31);
            pw.TabIndex = 4;
            pw.TextChanged += textBox2_TextChanged;
            // 
            // conpass
            // 
            conpass.Location = new Point(804, 129);
            conpass.Name = "conpass";
            conpass.Size = new Size(150, 31);
            conpass.TabIndex = 5;
            conpass.TextChanged += textBox3_TextChanged;
            // 
            // com1
            // 
            com1.FormattingEnabled = true;
            com1.Items.AddRange(new object[] { "Admin", "Student", "Staff", "Lecture" });
            com1.Location = new Point(235, 196);
            com1.Name = "com1";
            com1.Size = new Size(182, 33);
            com1.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(97, 204);
            label4.Name = "label4";
            label4.Size = new Size(62, 25);
            label4.TabIndex = 7;
            label4.Text = "Role :-";
            label4.Click += label4_Click;
            // 
            // login
            // 
            login.Location = new Point(933, 295);
            login.Name = "login";
            login.Size = new Size(111, 37);
            login.TabIndex = 11;
            login.Text = "Sign up";
            login.Click += login_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(601, 51);
            label5.Name = "label5";
            label5.Size = new Size(117, 25);
            label5.TabIndex = 9;
            label5.Text = "ReferenceID:-";
            // 
            // REId
            // 
            REId.Location = new Point(804, 54);
            REId.Name = "REId";
            REId.Size = new Size(150, 31);
            REId.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(97, 51);
            label6.Name = "label6";
            label6.Size = new Size(105, 25);
            label6.TabIndex = 13;
            label6.Text = "username :-";
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1198, 450);
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
    }
}