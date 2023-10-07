namespace MyHotelApp
{
    partial class Room
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Room));
            panel1 = new Panel();
            panel2 = new Panel();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            RoomDGV = new DataGridView();
            RNameCol = new TextBox();
            RStatusCol = new ComboBox();
            RoomTypecol = new ComboBox();
            label9 = new Label();
            label8 = new Label();
            pictureBox2 = new PictureBox();
            pictureBox7 = new PictureBox();
            label2 = new Label();
            pictureBox5 = new PictureBox();
            label7 = new Label();
            label5 = new Label();
            pictureBox4 = new PictureBox();
            pictureBox6 = new PictureBox();
            label4 = new Label();
            label6 = new Label();
            panel3 = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            panel4 = new Panel();
            label3 = new Label();
            pictureBox3 = new PictureBox();
            sqlCommandBuilder1 = new Microsoft.Data.SqlClient.SqlCommandBuilder();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)RoomDGV).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.WhiteSmoke;
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(pictureBox7);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(pictureBox5);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(pictureBox4);
            panel1.Controls.Add(pictureBox6);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(panel3);
            panel1.Location = new Point(10, 9);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1258, 566);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // panel2
            // 
            panel2.BackColor = Color.DarkGray;
            panel2.Controls.Add(button3);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(RoomDGV);
            panel2.Controls.Add(RNameCol);
            panel2.Controls.Add(RStatusCol);
            panel2.Controls.Add(RoomTypecol);
            panel2.Controls.Add(label9);
            panel2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            panel2.ForeColor = Color.White;
            panel2.Location = new Point(178, 68);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(1077, 496);
            panel2.TabIndex = 0;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(64, 68, 0);
            button3.ForeColor = Color.White;
            button3.Location = new Point(439, 110);
            button3.Margin = new Padding(3, 2, 3, 2);
            button3.Name = "button3";
            button3.Size = new Size(108, 31);
            button3.TabIndex = 21;
            button3.Text = "Save";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(64, 68, 0);
            button2.ForeColor = Color.White;
            button2.Location = new Point(599, 110);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(108, 31);
            button2.TabIndex = 20;
            button2.Text = "Delete";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(64, 68, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(285, 110);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(108, 31);
            button1.TabIndex = 19;
            button1.Text = "Edit";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // RoomDGV
            // 
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(0, 64, 64);
            dataGridViewCellStyle1.SelectionBackColor = Color.Silver;
            dataGridViewCellStyle1.SelectionForeColor = Color.Blue;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            RoomDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            RoomDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            RoomDGV.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            RoomDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.ActiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            RoomDGV.DefaultCellStyle = dataGridViewCellStyle2;
            RoomDGV.GridColor = SystemColors.MenuHighlight;
            RoomDGV.Location = new Point(3, 182);
            RoomDGV.Margin = new Padding(3, 2, 3, 2);
            RoomDGV.Name = "RoomDGV";
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            RoomDGV.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            RoomDGV.RowHeadersWidth = 51;
            RoomDGV.RowTemplate.Height = 29;
            RoomDGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            RoomDGV.Size = new Size(1072, 311);
            RoomDGV.StandardTab = true;
            RoomDGV.TabIndex = 18;
            RoomDGV.CellContentClick += RoomDGV_CellContentClick;
            // 
            // RNameCol
            // 
            RNameCol.Location = new Point(194, 64);
            RNameCol.Margin = new Padding(3, 2, 3, 2);
            RNameCol.Name = "RNameCol";
            RNameCol.Size = new Size(200, 26);
            RNameCol.TabIndex = 17;
            RNameCol.Text = "Name";
            RNameCol.TextAlign = HorizontalAlignment.Center;
            RNameCol.TextChanged += RNameCol_TextChanged;
            // 
            // RStatusCol
            // 
            RStatusCol.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            RStatusCol.FormattingEnabled = true;
            RStatusCol.Items.AddRange(new object[] { "Booked", "Available" });
            RStatusCol.Location = new Point(609, 63);
            RStatusCol.Margin = new Padding(3, 2, 3, 2);
            RStatusCol.Name = "RStatusCol";
            RStatusCol.Size = new Size(133, 27);
            RStatusCol.TabIndex = 15;
            RStatusCol.Text = "Status";
            // 
            // RoomTypecol
            // 
            RoomTypecol.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            RoomTypecol.FormattingEnabled = true;
            RoomTypecol.Items.AddRange(new object[] { "Standard", "Single", "Vip", "King" });
            RoomTypecol.Location = new Point(426, 61);
            RoomTypecol.Margin = new Padding(3, 2, 3, 2);
            RoomTypecol.Name = "RoomTypecol";
            RoomTypecol.Size = new Size(133, 27);
            RoomTypecol.TabIndex = 14;
            RoomTypecol.Text = "Rooms Types";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(390, 20);
            label9.Name = "label9";
            label9.Size = new Size(113, 19);
            label9.TabIndex = 12;
            label9.Text = "Manage Rooms";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(178, 23);
            label8.Name = "label8";
            label8.Size = new Size(252, 25);
            label8.TabIndex = 11;
            label8.Text = "Hotel Management System";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(3, 320);
            pictureBox2.Margin = new Padding(3, 2, 3, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(32, 23);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // pictureBox7
            // 
            pictureBox7.Image = (Image)resources.GetObject("pictureBox7.Image");
            pictureBox7.Location = new Point(3, 276);
            pictureBox7.Margin = new Padding(3, 2, 3, 2);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(32, 23);
            pictureBox7.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox7.TabIndex = 3;
            pictureBox7.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(36, 320);
            label2.Name = "label2";
            label2.Size = new Size(109, 25);
            label2.TabIndex = 0;
            label2.Text = "Dashboard";
            label2.TextAlign = ContentAlignment.TopCenter;
            label2.Click += label2_Click;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(3, 236);
            pictureBox5.Margin = new Padding(3, 2, 3, 2);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(32, 23);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 9;
            pictureBox5.TabStop = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(36, 276);
            label7.Name = "label7";
            label7.Size = new Size(96, 25);
            label7.TabIndex = 4;
            label7.Text = "Bookings";
            label7.TextAlign = ContentAlignment.TopCenter;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(36, 236);
            label5.Name = "label5";
            label5.Size = new Size(106, 25);
            label5.TabIndex = 10;
            label5.Text = "Customers";
            label5.TextAlign = ContentAlignment.TopCenter;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(3, 202);
            pictureBox4.Margin = new Padding(3, 2, 3, 2);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(32, 23);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 3;
            pictureBox4.TabStop = false;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(3, 165);
            pictureBox6.Margin = new Padding(3, 2, 3, 2);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(32, 23);
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox6.TabIndex = 7;
            pictureBox6.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(36, 202);
            label4.Name = "label4";
            label4.Size = new Size(60, 25);
            label4.TabIndex = 4;
            label4.Text = "Users";
            label4.TextAlign = ContentAlignment.TopCenter;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(36, 165);
            label6.Name = "label6";
            label6.Size = new Size(106, 25);
            label6.TabIndex = 8;
            label6.Text = "Categories";
            label6.TextAlign = ContentAlignment.TopCenter;
            label6.Click += label6_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(64, 64, 0);
            panel3.Controls.Add(pictureBox1);
            panel3.Controls.Add(label1);
            panel3.Location = new Point(0, 528);
            panel3.Margin = new Padding(3, 2, 3, 2);
            panel3.Name = "panel3";
            panel3.Size = new Size(181, 38);
            panel3.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.download__1_;
            pictureBox1.Location = new Point(131, 10);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(32, 23);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(3, 10);
            label1.Name = "label1";
            label1.Size = new Size(77, 25);
            label1.TabIndex = 0;
            label1.Text = "Logout";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(64, 64, 0);
            panel4.Controls.Add(label3);
            panel4.Controls.Add(pictureBox3);
            panel4.Location = new Point(10, 115);
            panel4.Margin = new Padding(3, 2, 3, 2);
            panel4.Name = "panel4";
            panel4.Size = new Size(181, 46);
            panel4.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(46, 12);
            label3.Name = "label3";
            label3.Size = new Size(73, 25);
            label3.TabIndex = 2;
            label3.Text = "Rooms";
            label3.TextAlign = ContentAlignment.TopCenter;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(9, 12);
            pictureBox3.Margin = new Padding(3, 2, 3, 2);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(32, 23);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 1;
            pictureBox3.TabStop = false;
            // 
            // Room
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Blue;
            ClientSize = new Size(1279, 584);
            Controls.Add(panel4);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "Room";
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)RoomDGV).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Label label1;
        private Panel panel4;
        private PictureBox pictureBox2;
        private Label label2;
        private PictureBox pictureBox1;
        private PictureBox pictureBox7;
        private PictureBox pictureBox5;
        private Label label7;
        private Label label5;
        private PictureBox pictureBox4;
        private PictureBox pictureBox6;
        private Label label4;
        private Label label6;
        private PictureBox pictureBox3;
        private Label label3;
        private Label label8;
        private Label label9;
        private ComboBox RStatusCol;
        private ComboBox RoomTypecol;
        private Microsoft.Data.SqlClient.SqlCommandBuilder sqlCommandBuilder1;
        private DataGridView RoomDGV;
        private TextBox RNameCol;
        private Button button1;
        private Button button3;
        private Button button2;
    }
}