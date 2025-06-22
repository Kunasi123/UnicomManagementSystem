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
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(126, 35);
            label1.Name = "label1";
            label1.Size = new Size(93, 25);
            label1.TabIndex = 0;
            label1.Text = "Exam ID :-";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(413, 38);
            label2.Name = "label2";
            label2.Size = new Size(107, 25);
            label2.TabIndex = 1;
            label2.Text = "Student ID:-";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(126, 109);
            label3.Name = "label3";
            label3.Size = new Size(72, 25);
            label3.TabIndex = 2;
            label3.Text = "Score :-";
            // 
            // scores
            // 
            scores.Location = new Point(225, 103);
            scores.Name = "scores";
            scores.Size = new Size(150, 31);
            scores.TabIndex = 5;
            // 
            // Add_mark
            // 
            Add_mark.Location = new Point(526, 212);
            Add_mark.Name = "Add_mark";
            Add_mark.Size = new Size(112, 34);
            Add_mark.TabIndex = 6;
            Add_mark.Text = "Add";
            Add_mark.UseVisualStyleBackColor = true;
            Add_mark.Click += button1_Click;
            // 
            // edit_mark
            // 
            edit_mark.Location = new Point(339, 212);
            edit_mark.Name = "edit_mark";
            edit_mark.Size = new Size(112, 34);
            edit_mark.TabIndex = 7;
            edit_mark.Text = "Edit";
            edit_mark.UseVisualStyleBackColor = true;
            edit_mark.Click += button2_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(416, 109);
            label4.Name = "label4";
            label4.Size = new Size(104, 25);
            label4.TabIndex = 8;
            label4.Text = "Subject ID:-";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(126, 252);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(556, 225);
            dataGridView1.TabIndex = 10;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // delete_mark
            // 
            delete_mark.Location = new Point(144, 212);
            delete_mark.Name = "delete_mark";
            delete_mark.Size = new Size(112, 34);
            delete_mark.TabIndex = 11;
            delete_mark.Text = "Delete";
            delete_mark.UseVisualStyleBackColor = true;
            delete_mark.Click += button3_Click;
            // 
            // exam_com
            // 
            exam_com.FormattingEnabled = true;
            exam_com.Location = new Point(225, 32);
            exam_com.Name = "exam_com";
            exam_com.Size = new Size(182, 33);
            exam_com.TabIndex = 12;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(526, 32);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(182, 33);
            comboBox2.TabIndex = 13;
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(526, 109);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(182, 33);
            comboBox1.TabIndex = 14;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(211, 161);
            label5.Name = "label5";
            label5.Size = new Size(381, 25);
            label5.TabIndex = 15;
            label5.Text = "If you want to update or Delete click the score ";
            // 
            // MarkForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(977, 450);
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
    }
}