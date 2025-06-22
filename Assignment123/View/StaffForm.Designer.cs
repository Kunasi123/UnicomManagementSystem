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
            panel1 = new Panel();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Purple;
            label1.Location = new Point(90, 138);
            label1.Name = "label1";
            label1.Size = new Size(82, 25);
            label1.TabIndex = 0;
            label1.Text = "Name :-";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Purple;
            label2.Location = new Point(511, 138);
            label2.Name = "label2";
            label2.Size = new Size(95, 25);
            label2.TabIndex = 1;
            label2.Text = "User ID :-";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Purple;
            label3.Location = new Point(90, 217);
            label3.Name = "label3";
            label3.Size = new Size(159, 25);
            label3.TabIndex = 2;
            label3.Text = "Phone number :-";
            // 
            // delete_staff
            // 
            delete_staff.BackColor = Color.Violet;
            delete_staff.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            delete_staff.Location = new Point(146, 289);
            delete_staff.Name = "delete_staff";
            delete_staff.Size = new Size(112, 34);
            delete_staff.TabIndex = 3;
            delete_staff.Text = "Delete";
            delete_staff.UseVisualStyleBackColor = false;
            delete_staff.Click += delete_staff_Click;
            // 
            // update_staff
            // 
            update_staff.BackColor = Color.Violet;
            update_staff.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            update_staff.Location = new Point(435, 289);
            update_staff.Name = "update_staff";
            update_staff.Size = new Size(112, 34);
            update_staff.TabIndex = 4;
            update_staff.Text = "Update";
            update_staff.UseVisualStyleBackColor = false;
            update_staff.Click += button2_Click;
            // 
            // add_staff
            // 
            add_staff.BackColor = Color.Violet;
            add_staff.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            add_staff.Location = new Point(680, 289);
            add_staff.Name = "add_staff";
            add_staff.Size = new Size(112, 34);
            add_staff.TabIndex = 5;
            add_staff.Text = "Add";
            add_staff.UseVisualStyleBackColor = false;
            add_staff.Click += add_staff_Click;
            // 
            // name
            // 
            name.BackColor = SystemColors.ControlLightLight;
            name.Location = new Point(255, 132);
            name.Name = "name";
            name.Size = new Size(150, 31);
            name.TabIndex = 6;
            // 
            // phone_no
            // 
            phone_no.BackColor = SystemColors.ControlLightLight;
            phone_no.Location = new Point(255, 214);
            phone_no.Name = "phone_no";
            phone_no.Size = new Size(150, 31);
            phone_no.TabIndex = 8;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.LavenderBlush;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(90, 344);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(761, 225);
            dataGridView1.TabIndex = 9;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // id
            // 
            id.BackColor = SystemColors.ControlLightLight;
            id.Location = new Point(612, 132);
            id.Name = "id";
            id.Size = new Size(150, 31);
            id.TabIndex = 11;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Orchid;
            panel1.Controls.Add(label4);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1052, 81);
            panel1.TabIndex = 12;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Black", 11F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.Location = new Point(369, 27);
            label4.Name = "label4";
            label4.Size = new Size(303, 30);
            label4.TabIndex = 0;
            label4.Text = "Staff Management System";
            // 
            // StaffForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1052, 618);
            Controls.Add(panel1);
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
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
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
        private Panel panel1;
        private Label label4;
    }
}