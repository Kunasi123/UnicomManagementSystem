namespace Assignment123.View
{
    partial class RoomForm
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
            nameText = new TextBox();
            comboBox1 = new ComboBox();
            delete_room = new Button();
            Update_room = new Button();
            Add_room = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(203, 44);
            label1.Name = "label1";
            label1.Size = new Size(75, 25);
            label1.TabIndex = 0;
            label1.Text = "Name :-";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(203, 118);
            label2.Name = "label2";
            label2.Size = new Size(60, 25);
            label2.TabIndex = 1;
            label2.Text = "Type:-";
            // 
            // nameText
            // 
            nameText.Location = new Point(331, 38);
            nameText.Name = "nameText";
            nameText.Size = new Size(150, 31);
            nameText.TabIndex = 2;
            nameText.TextChanged += textBox1_TextChanged;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(331, 110);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(182, 33);
            comboBox1.TabIndex = 3;
            // 
            // delete_room
            // 
            delete_room.Location = new Point(150, 175);
            delete_room.Name = "delete_room";
            delete_room.Size = new Size(112, 34);
            delete_room.TabIndex = 4;
            delete_room.Text = "Delete";
            delete_room.UseVisualStyleBackColor = true;
            // 
            // Update_room
            // 
            Update_room.Location = new Point(331, 175);
            Update_room.Name = "Update_room";
            Update_room.Size = new Size(112, 34);
            Update_room.TabIndex = 5;
            Update_room.Text = "Update";
            Update_room.UseVisualStyleBackColor = true;
            // 
            // Add_room
            // 
            Add_room.Location = new Point(519, 175);
            Add_room.Name = "Add_room";
            Add_room.Size = new Size(112, 34);
            Add_room.TabIndex = 6;
            Add_room.Text = "Add";
            Add_room.UseVisualStyleBackColor = true;
            Add_room.Click += Add_room_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(160, 215);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(471, 225);
            dataGridView1.TabIndex = 7;
            // 
            // RoomForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(983, 450);
            Controls.Add(dataGridView1);
            Controls.Add(Add_room);
            Controls.Add(Update_room);
            Controls.Add(delete_room);
            Controls.Add(comboBox1);
            Controls.Add(nameText);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "RoomForm";
            Text = "RoomForm";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox nameText;
        private ComboBox comboBox1;
        private Button delete_room;
        private Button Update_room;
        private Button Add_room;
        private DataGridView dataGridView1;
    }
}