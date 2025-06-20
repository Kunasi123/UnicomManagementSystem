namespace Assignment123.View
{
    partial class AdminForm
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
            name = new TextBox();
            ages = new TextBox();
            phoneno = new TextBox();
            button1 = new Button();
            Update_admin = new Button();
            button3 = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(241, 22);
            label1.Name = "label1";
            label1.Size = new Size(75, 25);
            label1.TabIndex = 0;
            label1.Text = "Name :-";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(256, 92);
            label2.Name = "label2";
            label2.Size = new Size(60, 25);
            label2.TabIndex = 1;
            label2.Text = "Age :-";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(207, 151);
            label3.Name = "label3";
            label3.Size = new Size(143, 25);
            label3.TabIndex = 2;
            label3.Text = "Phone Number:-";
            // 
            // name
            // 
            name.Location = new Point(365, 16);
            name.Name = "name";
            name.Size = new Size(150, 31);
            name.TabIndex = 3;
            // 
            // ages
            // 
            ages.Location = new Point(365, 86);
            ages.Name = "ages";
            ages.Size = new Size(150, 31);
            ages.TabIndex = 4;
            // 
            // phoneno
            // 
            phoneno.Location = new Point(365, 148);
            phoneno.Name = "phoneno";
            phoneno.Size = new Size(150, 31);
            phoneno.TabIndex = 5;
            // 
            // button1
            // 
            button1.Location = new Point(139, 253);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 6;
            button1.Text = "Delete";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Update_admin
            // 
            Update_admin.Location = new Point(474, 253);
            Update_admin.Name = "Update_admin";
            Update_admin.Size = new Size(112, 34);
            Update_admin.TabIndex = 7;
            Update_admin.Text = "Update";
            Update_admin.UseVisualStyleBackColor = true;
            Update_admin.Click += Update_admin_Click;
            // 
            // button3
            // 
            button3.Location = new Point(776, 253);
            button3.Name = "button3";
            button3.Size = new Size(112, 34);
            button3.TabIndex = 8;
            button3.Text = "Add";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(121, 315);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(652, 225);
            dataGridView1.TabIndex = 9;
            // 
            // AdminForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1057, 552);
            Controls.Add(dataGridView1);
            Controls.Add(button3);
            Controls.Add(Update_admin);
            Controls.Add(button1);
            Controls.Add(phoneno);
            Controls.Add(ages);
            Controls.Add(name);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AdminForm";
            Text = "AdminForm";
            Load += AdminForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox name;
        private TextBox ages;
        private TextBox phoneno;
        private Button button1;
        private Button Update_admin;
        private Button button3;
        private DataGridView dataGridView1;
    }
}