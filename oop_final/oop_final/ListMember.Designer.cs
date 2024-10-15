namespace oop_final
{
    partial class ListMember
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
            tcListStudent = new TabControl();
            tabPage1 = new TabPage();
            btnExitListTea = new Button();
            panel2 = new Panel();
            comboBox2 = new ComboBox();
            label1 = new Label();
            listView1 = new ListView();
            clnMagv = new ColumnHeader();
            clnTen = new ColumnHeader();
            clnGtinh = new ColumnHeader();
            clnNgsinh = new ColumnHeader();
            clnChucvu = new ColumnHeader();
            tabPage2 = new TabPage();
            btnExitListSt = new Button();
            panel1 = new Panel();
            textBox1 = new TextBox();
            label2 = new Label();
            lvListSt = new ListView();
            clnMaHS = new ColumnHeader();
            clnTenHs = new ColumnHeader();
            Clnlop = new ColumnHeader();
            clnGioitinh = new ColumnHeader();
            clnNgaysinh = new ColumnHeader();
            panel7 = new Panel();
            comboBox1 = new ComboBox();
            label7 = new Label();
            lbListMember = new Label();
            btnSearchSt = new Button();
            button1 = new Button();
            tcListStudent.SuspendLayout();
            tabPage1.SuspendLayout();
            panel2.SuspendLayout();
            tabPage2.SuspendLayout();
            panel1.SuspendLayout();
            panel7.SuspendLayout();
            SuspendLayout();
            // 
            // tcListStudent
            // 
            tcListStudent.Controls.Add(tabPage1);
            tcListStudent.Controls.Add(tabPage2);
            tcListStudent.Location = new Point(12, 90);
            tcListStudent.Name = "tcListStudent";
            tcListStudent.SelectedIndex = 0;
            tcListStudent.Size = new Size(783, 559);
            tcListStudent.TabIndex = 1;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(button1);
            tabPage1.Controls.Add(btnExitListTea);
            tabPage1.Controls.Add(panel2);
            tabPage1.Controls.Add(listView1);
            tabPage1.Font = new Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tabPage1.Location = new Point(4, 34);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(775, 521);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Danh sách giáo viên";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnExitListTea
            // 
            btnExitListTea.Font = new Font("Times New Roman", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExitListTea.Location = new Point(676, 9);
            btnExitListTea.Name = "btnExitListTea";
            btnExitListTea.Size = new Size(93, 56);
            btnExitListTea.TabIndex = 14;
            btnExitListTea.Text = "Thoát";
            btnExitListTea.UseVisualStyleBackColor = true;
            btnExitListTea.Click += btnExitListTea_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(comboBox2);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(6, 6);
            panel2.Name = "panel2";
            panel2.Size = new Size(414, 56);
            panel2.TabIndex = 4;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(162, 9);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(221, 40);
            comboBox2.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(22, 12);
            label1.Name = "label1";
            label1.Size = new Size(119, 32);
            label1.TabIndex = 0;
            label1.Text = "Năm học";
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { clnMagv, clnTen, clnGtinh, clnNgsinh, clnChucvu });
            listView1.Font = new Font("Times New Roman", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            listView1.GridLines = true;
            listView1.Location = new Point(6, 72);
            listView1.Name = "listView1";
            listView1.Size = new Size(764, 443);
            listView1.TabIndex = 3;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // clnMagv
            // 
            clnMagv.Text = "Mã giáo viên";
            clnMagv.Width = 130;
            // 
            // clnTen
            // 
            clnTen.Text = "Họ và tên";
            clnTen.TextAlign = HorizontalAlignment.Center;
            clnTen.Width = 130;
            // 
            // clnGtinh
            // 
            clnGtinh.Text = "Giới tính";
            clnGtinh.TextAlign = HorizontalAlignment.Center;
            clnGtinh.Width = 130;
            // 
            // clnNgsinh
            // 
            clnNgsinh.Text = "Ngày sinh";
            clnNgsinh.TextAlign = HorizontalAlignment.Center;
            clnNgsinh.Width = 130;
            // 
            // clnChucvu
            // 
            clnChucvu.Text = "Chức vụ";
            clnChucvu.TextAlign = HorizontalAlignment.Center;
            clnChucvu.Width = 130;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(btnSearchSt);
            tabPage2.Controls.Add(btnExitListSt);
            tabPage2.Controls.Add(panel1);
            tabPage2.Controls.Add(lvListSt);
            tabPage2.Controls.Add(panel7);
            tabPage2.Location = new Point(4, 34);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(775, 521);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Danh sách học sinh";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnExitListSt
            // 
            btnExitListSt.Font = new Font("Times New Roman", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExitListSt.Location = new Point(672, 459);
            btnExitListSt.Name = "btnExitListSt";
            btnExitListSt.Size = new Size(96, 56);
            btnExitListSt.TabIndex = 14;
            btnExitListSt.Text = "Thoát";
            btnExitListSt.UseVisualStyleBackColor = true;
            btnExitListSt.Click += btnExitListSt_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(408, 10);
            panel1.Name = "panel1";
            panel1.Size = new Size(258, 56);
            panel1.TabIndex = 2;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(115, 10);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(117, 31);
            textBox1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(22, 12);
            label2.Name = "label2";
            label2.Size = new Size(54, 26);
            label2.TabIndex = 0;
            label2.Text = "Lớp";
            // 
            // lvListSt
            // 
            lvListSt.Columns.AddRange(new ColumnHeader[] { clnMaHS, clnTenHs, Clnlop, clnGioitinh, clnNgaysinh });
            lvListSt.Font = new Font("Times New Roman", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lvListSt.GridLines = true;
            lvListSt.Location = new Point(10, 76);
            lvListSt.Name = "lvListSt";
            lvListSt.Size = new Size(656, 442);
            lvListSt.TabIndex = 2;
            lvListSt.UseCompatibleStateImageBehavior = false;
            lvListSt.View = View.Details;
            // 
            // clnMaHS
            // 
            clnMaHS.Text = "Mã học sinh";
            clnMaHS.Width = 130;
            // 
            // clnTenHs
            // 
            clnTenHs.Text = "Họ và tên";
            clnTenHs.TextAlign = HorizontalAlignment.Center;
            clnTenHs.Width = 130;
            // 
            // Clnlop
            // 
            Clnlop.Text = "Lớp";
            Clnlop.TextAlign = HorizontalAlignment.Center;
            Clnlop.Width = 130;
            // 
            // clnGioitinh
            // 
            clnGioitinh.Text = "Giới tính";
            clnGioitinh.TextAlign = HorizontalAlignment.Center;
            clnGioitinh.Width = 130;
            // 
            // clnNgaysinh
            // 
            clnNgaysinh.Text = "Ngày sinh";
            clnNgaysinh.TextAlign = HorizontalAlignment.Center;
            clnNgaysinh.Width = 130;
            // 
            // panel7
            // 
            panel7.Controls.Add(comboBox1);
            panel7.Controls.Add(label7);
            panel7.Location = new Point(10, 10);
            panel7.Name = "panel7";
            panel7.Size = new Size(369, 56);
            panel7.TabIndex = 1;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(143, 11);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(192, 33);
            comboBox1.TabIndex = 1;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(22, 12);
            label7.Name = "label7";
            label7.Size = new Size(102, 26);
            label7.TabIndex = 0;
            label7.Text = "Năm học";
            // 
            // lbListMember
            // 
            lbListMember.BackColor = Color.Teal;
            lbListMember.Font = new Font("Times New Roman", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbListMember.ForeColor = SystemColors.ControlLightLight;
            lbListMember.Location = new Point(0, 9);
            lbListMember.Name = "lbListMember";
            lbListMember.Size = new Size(795, 75);
            lbListMember.TabIndex = 17;
            lbListMember.Text = "CẬP NHẬT HỌC SINH";
            lbListMember.TextAlign = ContentAlignment.MiddleCenter;
            lbListMember.UseCompatibleTextRendering = true;
            // 
            // btnSearchSt
            // 
            btnSearchSt.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearchSt.Location = new Point(672, 10);
            btnSearchSt.Name = "btnSearchSt";
            btnSearchSt.Size = new Size(100, 56);
            btnSearchSt.TabIndex = 15;
            btnSearchSt.Text = "Tìm kiếm";
            btnSearchSt.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(563, 9);
            button1.Name = "button1";
            button1.Size = new Size(100, 56);
            button1.TabIndex = 16;
            button1.Text = "Tìm kiếm";
            button1.UseVisualStyleBackColor = true;
            // 
            // ListMember
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(798, 647);
            Controls.Add(lbListMember);
            Controls.Add(tcListStudent);
            Name = "ListMember";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Danh sách thành viên";
            tcListStudent.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            tabPage2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tcListStudent;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private ListView lvListSt;
        private ColumnHeader clnMaHS;
        private ColumnHeader clnTenHs;
        private ColumnHeader Clnlop;
        private ColumnHeader clnGioitinh;
        private ColumnHeader clnNgaysinh;
        private Panel panel7;
        private ComboBox comboBox1;
        private Label label7;
        private Label lbListMember;
        private Panel panel1;
        private TextBox textBox1;
        private Label label2;
        private Panel panel2;
        private ComboBox comboBox2;
        private Label label1;
        private ListView listView1;
        private ColumnHeader clnMagv;
        private ColumnHeader clnTen;
        private ColumnHeader clnGtinh;
        private ColumnHeader clnNgsinh;
        private ColumnHeader clnChucvu;
        private Button btnExitListTea;
        private Button btnExitListSt;
        private Button btnSearchSt;
        private Button button1;
    }
}