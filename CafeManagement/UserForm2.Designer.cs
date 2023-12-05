namespace CafeManagement
{
    partial class UserForm2
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
            label4 = new Label();
            button4 = new Button();
            button3 = new Button();
            label6 = new Label();
            panel1 = new Panel();
            dataGridView1 = new DataGridView();
            label7 = new Label();
            label3 = new Label();
            label2 = new Label();
            button5 = new Button();
            button1 = new Button();
            label1 = new Label();
            UpassTb = new TextBox();
            UphoneTb = new TextBox();
            UnameTb = new TextBox();
            button2 = new Button();
            label5 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Malgun Gothic", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Teal;
            label4.Location = new Point(22, 520);
            label4.Name = "label4";
            label4.Size = new Size(66, 21);
            label4.TabIndex = 18;
            label4.Text = "LogOut";
            label4.Click += label4_Click;
            // 
            // button4
            // 
            button4.BackColor = SystemColors.Control;
            button4.Font = new Font("Microsoft JhengHei UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button4.ForeColor = Color.Maroon;
            button4.Location = new Point(6, 133);
            button4.Margin = new Padding(5);
            button4.Name = "button4";
            button4.Size = new Size(108, 32);
            button4.TabIndex = 17;
            button4.Text = "Items";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.Control;
            button3.Font = new Font("Microsoft JhengHei UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.Maroon;
            button3.Location = new Point(6, 75);
            button3.Margin = new Padding(5);
            button3.Name = "button3";
            button3.Size = new Size(108, 32);
            button3.TabIndex = 16;
            button3.Text = "Order";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft JhengHei UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.DarkRed;
            label6.Location = new Point(955, 6);
            label6.Name = "label6";
            label6.Size = new Size(26, 26);
            label6.TabIndex = 15;
            label6.Text = "X";
            label6.Click += label6_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Control;
            panel1.Controls.Add(dataGridView1);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(button5);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(UpassTb);
            panel1.Controls.Add(UphoneTb);
            panel1.Controls.Add(UnameTb);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(label5);
            panel1.Location = new Point(122, 44);
            panel1.Name = "panel1";
            panel1.Size = new Size(844, 507);
            panel1.TabIndex = 14;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.Control;
            dataGridView1.BorderStyle = BorderStyle.Fixed3D;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.GridColor = SystemColors.Window;
            dataGridView1.Location = new Point(447, 135);
            dataGridView1.Margin = new Padding(0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(322, 344);
            dataGridView1.TabIndex = 4;
            dataGridView1.Tag = " ";
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Comic Sans MS", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Firebrick;
            label7.Location = new Point(130, 297);
            label7.Name = "label7";
            label7.Size = new Size(74, 20);
            label7.TabIndex = 23;
            label7.Text = "Password";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Comic Sans MS", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Firebrick;
            label3.Location = new Point(141, 247);
            label3.Name = "label3";
            label3.Size = new Size(49, 20);
            label3.TabIndex = 22;
            label3.Text = "Phone";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Comic Sans MS", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Firebrick;
            label2.Location = new Point(130, 198);
            label2.Name = "label2";
            label2.Size = new Size(81, 20);
            label2.TabIndex = 21;
            label2.Text = "User name";
            label2.Click += label2_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.LightCoral;
            button5.Font = new Font("Microsoft JhengHei UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button5.ForeColor = Color.Maroon;
            button5.Location = new Point(287, 342);
            button5.Margin = new Padding(5);
            button5.Name = "button5";
            button5.Size = new Size(75, 32);
            button5.TabIndex = 20;
            button5.Text = "Delete";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.LightCoral;
            button1.Font = new Font("Microsoft JhengHei UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Maroon;
            button1.Location = new Point(192, 342);
            button1.Margin = new Padding(5);
            button1.Name = "button1";
            button1.Size = new Size(74, 32);
            button1.TabIndex = 19;
            button1.Text = "Edit";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft JhengHei UI", 15.75F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DarkRed;
            label1.Location = new Point(548, 95);
            label1.Name = "label1";
            label1.Size = new Size(108, 26);
            label1.TabIndex = 18;
            label1.Text = "Users List";
            label1.Click += label1_Click;
            // 
            // UpassTb
            // 
            UpassTb.BackColor = Color.MistyRose;
            UpassTb.Location = new Point(237, 294);
            UpassTb.Name = "UpassTb";
            UpassTb.Size = new Size(125, 23);
            UpassTb.TabIndex = 15;
            // 
            // UphoneTb
            // 
            UphoneTb.BackColor = Color.MistyRose;
            UphoneTb.Location = new Point(237, 244);
            UphoneTb.Name = "UphoneTb";
            UphoneTb.Size = new Size(125, 23);
            UphoneTb.TabIndex = 14;
            // 
            // UnameTb
            // 
            UnameTb.BackColor = Color.MistyRose;
            UnameTb.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            UnameTb.Location = new Point(237, 195);
            UnameTb.Margin = new Padding(0);
            UnameTb.Name = "UnameTb";
            UnameTb.Size = new Size(125, 23);
            UnameTb.TabIndex = 13;
            // 
            // button2
            // 
            button2.BackColor = Color.LightCoral;
            button2.Font = new Font("Microsoft JhengHei UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.Maroon;
            button2.Location = new Point(96, 342);
            button2.Margin = new Padding(5);
            button2.Name = "button2";
            button2.Size = new Size(67, 32);
            button2.TabIndex = 9;
            button2.Text = "Add";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft JhengHei UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.DarkRed;
            label5.Location = new Point(338, 9);
            label5.Name = "label5";
            label5.Size = new Size(200, 35);
            label5.TabIndex = 7;
            label5.Text = "Manage Users";
            // 
            // UserForm2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Salmon;
            ClientSize = new Size(986, 556);
            Controls.Add(label4);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(label6);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "UserForm2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UserForm2";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private Button button4;
        private Button button3;
        private Label label6;
        private Panel panel1;
        private Label label7;
        private Label label3;
        private Label label2;
        private Button button5;
        private Button button1;
        private Label label1;
        private TextBox UpassTb;
        private TextBox UphoneTb;
        private TextBox UnameTb;
        private Button button2;
        private Label label5;
        private DataGridView dataGridView1;
    }
}