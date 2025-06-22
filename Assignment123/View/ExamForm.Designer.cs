namespace Assignment123.View
{
    partial class ExamForm
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
            name_text = new TextBox();
            Add_exam = new Button();
            delete_exam = new Button();
            dataGridView1 = new DataGridView();
            edit_exam = new Button();
            sub_box = new ComboBox();
            date = new DateTimePicker();
            label4 = new Label();
            label5 = new Label();
            start = new DateTimePicker();
            end = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 63);
            label1.Name = "label1";
            label1.Size = new Size(117, 25);
            label1.TabIndex = 0;
            label1.Text = "ExamName :-";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(32, 142);
            label2.Name = "label2";
            label2.Size = new Size(109, 25);
            label2.TabIndex = 1;
            label2.Text = "Subject ID :-";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(783, 57);
            label3.Name = "label3";
            label3.Size = new Size(65, 25);
            label3.TabIndex = 2;
            label3.Text = "Date :-";
            label3.Click += label3_Click;
            // 
            // name_text
            // 
            name_text.Location = new Point(147, 60);
            name_text.Name = "name_text";
            name_text.Size = new Size(150, 31);
            name_text.TabIndex = 3;
            // 
            // Add_exam
            // 
            Add_exam.Location = new Point(836, 236);
            Add_exam.Name = "Add_exam";
            Add_exam.Size = new Size(112, 34);
            Add_exam.TabIndex = 6;
            Add_exam.Text = "Add";
            Add_exam.UseVisualStyleBackColor = true;
            Add_exam.Click += Add_exam_Click;
            // 
            // delete_exam
            // 
            delete_exam.Location = new Point(211, 227);
            delete_exam.Name = "delete_exam";
            delete_exam.Size = new Size(112, 34);
            delete_exam.TabIndex = 8;
            delete_exam.Text = "Delete";
            delete_exam.UseVisualStyleBackColor = true;
            delete_exam.Click += delete_exam_Click_1;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(58, 276);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(997, 387);
            dataGridView1.TabIndex = 9;
            // 
            // edit_exam
            // 
            edit_exam.Location = new Point(536, 227);
            edit_exam.Name = "edit_exam";
            edit_exam.Size = new Size(112, 34);
            edit_exam.TabIndex = 10;
            edit_exam.Text = "Edit";
            edit_exam.UseVisualStyleBackColor = true;
            edit_exam.Click += edit_exam_Click;
            // 
            // sub_box
            // 
            sub_box.FormattingEnabled = true;
            sub_box.Location = new Point(147, 145);
            sub_box.Name = "sub_box";
            sub_box.Size = new Size(182, 33);
            sub_box.TabIndex = 11;
            // 
            // date
            // 
            date.Location = new Point(874, 57);
            date.Name = "date";
            date.Size = new Size(300, 31);
            date.TabIndex = 12;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(341, 60);
            label4.Name = "label4";
            label4.Size = new Size(90, 25);
            label4.TabIndex = 13;
            label4.Text = "Start_time";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(341, 145);
            label5.Name = "label5";
            label5.Size = new Size(98, 25);
            label5.TabIndex = 14;
            label5.Text = "End_Time:-";
            // 
            // start
            // 
            start.Format = DateTimePickerFormat.Time;
            start.Location = new Point(466, 62);
            start.Name = "start";
            start.Size = new Size(300, 31);
            start.TabIndex = 15;
            // 
            // end
            // 
            end.Format = DateTimePickerFormat.Time;
            end.Location = new Point(466, 136);
            end.Name = "end";
            end.Size = new Size(300, 31);
            end.TabIndex = 16;
            // 
            // ExamForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1241, 700);
            Controls.Add(end);
            Controls.Add(start);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(date);
            Controls.Add(sub_box);
            Controls.Add(edit_exam);
            Controls.Add(dataGridView1);
            Controls.Add(delete_exam);
            Controls.Add(Add_exam);
            Controls.Add(name_text);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ExamForm";
            Text = "ExamForm";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox name_text;
        private Button Add_exam;
        private Button delete_exam;
        private DataGridView dataGridView1;
        private Button edit_exam;
        private ComboBox sub_box;
        private DateTimePicker date;
        private Label label4;
        private Label label5;
        private DateTimePicker start;
        private DateTimePicker end;
    }
}