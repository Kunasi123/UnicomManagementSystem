namespace Assignment123.View
{
    partial class StaffForm
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
            delete_staff = new Button();
            update_staff = new Button();
            add_staff = new Button();
            name = new TextBox();
            phone_no = new TextBox();
            dataGridView1 = new DataGridView();
            id = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(146, 40);
            label1.Name = "label1";
            label1.Size = new Size(75, 25);
            label1.TabIndex = 0;
            label1.Text = "Name :-";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(146, 104);
            label2.Name = "label2";
            label2.Size = new Size(86, 25);
            label2.TabIndex = 1;
            label2.Text = "User ID :-";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(143, 161);
            label3.Name = "label3";
            label3.Size = new Size(145, 25);
            label3.TabIndex = 2;
            label3.Text = "Phone number :-";
            // 
            // delete_staff
            // 
            delete_staff.Location = new Point(130, 221);
            delete_staff.Name = "delete_staff";
            delete_staff.Size = new Size(112, 34);
            delete_staff.TabIndex = 3;
            delete_staff.Text = "Delete";
            delete_staff.UseVisualStyleBackColor = true;
            delete_staff.Click += delete_staff_Click;
            // 
            // update_staff
            // 
            update_staff.Location = new Point(344, 221);
            update_staff.Name = "update_staff";
            update_staff.Size = new Size(112, 34);
            update_staff.TabIndex = 4;
            update_staff.Text = "Update";
            update_staff.UseVisualStyleBackColor = true;
            update_staff.Click += button2_Click;
            // 
            // add_staff
            // 
            add_staff.Location = new Point(544, 221);
            add_staff.Name = "add_staff";
            add_staff.Size = new Size(112, 34);
            add_staff.TabIndex = 5;
            add_staff.Text = "Add";
            add_staff.UseVisualStyleBackColor = true;
            add_staff.Click += add_staff_Click;
            // 
            // name
            // 
            name.Location = new Point(294, 37);
            name.Name = "name";
            name.Size = new Size(150, 31);
            name.TabIndex = 6;
            // 
            // phone_no
            // 
            phone_no.Location = new Point(294, 158);
            phone_no.Name = "phone_no";
            phone_no.Size = new Size(150, 31);
            phone_no.TabIndex = 8;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(130, 278);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(761, 225);
            dataGridView1.TabIndex = 9;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // id
            // 
            id.Location = new Point(294, 101);
            id.Name = "id";
            id.Size = new Size(150, 31);
            id.TabIndex = 11;
            // 
            // StaffForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1052, 450);
            Controls.Add(id);
            Controls.Add(dataGridView1);
            Controls.Add(phone_no);
            Controls.Add(name);
            Controls.Add(add_staff);
            Controls.Add(update_staff);
            Controls.Add(delete_staff);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "StaffForm";
            Text = "StaffForm";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Button delete_staff;
        private Button update_staff;
        private Button add_staff;
        private TextBox name;
        private TextBox phone_no;
        private DataGridView dataGridView1;
        private TextBox id;
    }
}