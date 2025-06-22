namespace Assignment123.View
{
    partial class MarkForm
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
            scores = new TextBox();
            Add_mark = new Button();
            edit_mark = new Button();
            label4 = new Label();
            dataGridView1 = new DataGridView();
            delete_mark = new Button();
            exam_com = new ComboBox();
            comboBox2 = new ComboBox();
            comboBox1 = new ComboBox();
            label5 = new Label();
            panel1 = new Panel();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Teal;
            label1.Location = new Point(123, 106);
            label1.Name = "label1";
            label1.Size = new Size(103, 25);
            label1.TabIndex = 0;
            label1.Text = "Exam ID :-";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Teal;
            label2.Location = new Point(435, 106);
            label2.Name = "label2";
            label2.Size = new Size(120, 25);
            label2.TabIndex = 1;
            label2.Text = "Student ID:-";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Teal;
            label3.Location = new Point(144, 193);
            label3.Name = "label3";
            label3.Size = new Size(78, 25);
            label3.TabIndex = 2;
            label3.Text = "Score :-";
            // 
            // scores
            // 
            scores.Location = new Point(245, 193);
            scores.Name = "scores";
            scores.Size = new Size(150, 31);
            scores.TabIndex = 5;
            // 
            // Add_mark
            // 
            Add_mark.BackColor = Color.Aquamarine;
            Add_mark.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Add_mark.ForeColor = SystemColors.ControlText;
            Add_mark.Location = new Point(865, 119);
            Add_mark.Name = "Add_mark";
            Add_mark.Size = new Size(112, 34);
            Add_mark.TabIndex = 6;
            Add_mark.Text = "Add";
            Add_mark.UseVisualStyleBackColor = false;
            Add_mark.Click += button1_Click;
            // 
            // edit_mark
            // 
            edit_mark.BackColor = Color.Aquamarine;
            edit_mark.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            edit_mark.Location = new Point(865, 212);
            edit_mark.Name = "edit_mark";
            edit_mark.Size = new Size(112, 34);
            edit_mark.TabIndex = 7;
            edit_mark.Text = "Edit";
            edit_mark.UseVisualStyleBackColor = false;
            edit_mark.Click += button2_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Teal;
            label4.Location = new Point(435, 199);
            label4.Name = "label4";
            label4.Size = new Size(116, 25);
            label4.TabIndex = 8;
            label4.Text = "Subject ID:-";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(144, 311);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(556, 225);
            dataGridView1.TabIndex = 10;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // delete_mark
            // 
            delete_mark.BackColor = Color.Aquamarine;
            delete_mark.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            delete_mark.Location = new Point(865, 311);
            delete_mark.Name = "delete_mark";
            delete_mark.Size = new Size(112, 34);
            delete_mark.TabIndex = 11;
            delete_mark.Text = "Delete";
            delete_mark.UseVisualStyleBackColor = false;
            delete_mark.Click += button3_Click;
            // 
            // exam_com
            // 
            exam_com.FormattingEnabled = true;
            exam_com.Location = new Point(231, 106);
            exam_com.Name = "exam_com";
            exam_com.Size = new Size(182, 33);
            exam_com.TabIndex = 12;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(561, 106);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(182, 33);
            comboBox2.TabIndex = 13;
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(561, 196);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(182, 33);
            comboBox1.TabIndex = 14;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.Desktop;
            label5.Location = new Point(214, 270);
            label5.Name = "label5";
            label5.Size = new Size(401, 25);
            label5.TabIndex = 15;
            label5.Text = "If you want to update or Delete click the score ";
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightSeaGreen;
            panel1.Controls.Add(label6);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1101, 64);
            panel1.TabIndex = 16;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Black", 11F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label6.Location = new Point(382, 19);
            label6.Name = "label6";
            label6.Size = new Size(318, 30);
            label6.TabIndex = 0;
            label6.Text = "Marks Management System";
            // 
            // MarkForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1101, 548);
            Controls.Add(panel1);
            Controls.Add(label5);
            Controls.Add(comboBox1);
            Controls.Add(comboBox2);
            Controls.Add(exam_com);
            Controls.Add(delete_mark);
            Controls.Add(dataGridView1);
            Controls.Add(label4);
            Controls.Add(edit_mark);
            Controls.Add(Add_mark);
            Controls.Add(scores);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "MarkForm";
            Text = "MarkForm";
            Load += MarkForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox scores;
        private Button Add_mark;
        private Button edit_mark;
        private Label label4;
        private DataGridView dataGridView1;
        private Button delete_mark;
        private ComboBox exam_com;
        private ComboBox comboBox2;
        private ComboBox comboBox1;
        private Label label5;
        private Panel panel1;
        private Label label6;
    }
}