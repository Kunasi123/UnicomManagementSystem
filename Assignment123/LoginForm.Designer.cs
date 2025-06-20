namespace Assignment123
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            button2 = new Button();
            User = new TextBox();
            pw = new TextBox();
            panel1 = new Panel();
            label3 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(191, 68);
            label1.Name = "label1";
            label1.Size = new Size(115, 25);
            label1.TabIndex = 0;
            label1.Text = "User Name :-";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(191, 120);
            label2.Name = "label2";
            label2.Size = new Size(103, 25);
            label2.TabIndex = 1;
            label2.Text = "Password :-";
            // 
            // button1
            // 
            button1.Location = new Point(643, 228);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 2;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(153, 218);
            button2.Name = "button2";
            button2.Size = new Size(112, 34);
            button2.TabIndex = 3;
            button2.Text = "Sign up";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // User
            // 
            User.Location = new Point(306, 62);
            User.Name = "User";
            User.Size = new Size(150, 31);
            User.TabIndex = 4;
            // 
            // pw
            // 
            pw.Location = new Point(306, 120);
            pw.Name = "pw";
            pw.Size = new Size(150, 31);
            pw.TabIndex = 5;
            // 
            // panel1
            // 
            panel1.Controls.Add(label3);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1135, 42);
            panel1.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(556, 9);
            label3.Name = "label3";
            label3.Size = new Size(127, 25);
            label3.TabIndex = 0;
            label3.Text = "Login & Sign up";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1135, 450);
            Controls.Add(panel1);
            Controls.Add(pw);
            Controls.Add(User);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "LoginForm";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button button1;
        private Button button2;
        private TextBox User;
        private TextBox pw;
        private Panel panel1;
        private Label label3;
    }
}
