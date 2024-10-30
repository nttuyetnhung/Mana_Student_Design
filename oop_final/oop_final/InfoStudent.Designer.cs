namespace oop_final
{
    partial class InfoStudent
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
            tcAccStudent = new TabControl();
            tabPage1 = new TabPage();
            btnExit = new Button();
            panel6 = new Panel();
            txbClass = new TextBox();
            label6 = new Label();
            panel5 = new Panel();
            textBox1 = new TextBox();
            label5 = new Label();
            panel4 = new Panel();
            checkBox2 = new CheckBox();
            checkBox1 = new CheckBox();
            label4 = new Label();
            panel3 = new Panel();
            txbID = new TextBox();
            label3 = new Label();
            panel2 = new Panel();
            txbName = new TextBox();
            label2 = new Label();
            tabPage2 = new TabPage();
            btnSearchUdSor = new Button();
            lvList = new ListView();
            clnMamon = new ColumnHeader();
            clnTenMon = new ColumnHeader();
            ClnDiemMieng = new ColumnHeader();
            clnDiem15p = new ColumnHeader();
            clnDiemGiuaKi = new ColumnHeader();
            clnDiemCuoiKi = new ColumnHeader();
            clnDiemTBM = new ColumnHeader();
            panel7 = new Panel();
            comboBox1 = new ComboBox();
            label7 = new Label();
            lbLogin = new Label();
            tcAccStudent.SuspendLayout();
            tabPage1.SuspendLayout();
            panel6.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            tabPage2.SuspendLayout();
            panel7.SuspendLayout();
            SuspendLayout();
            // 
            // tcAccStudent
            // 
            tcAccStudent.Controls.Add(tabPage1);
            tcAccStudent.Controls.Add(tabPage2);
            tcAccStudent.Location = new Point(-2, 111);
            tcAccStudent.Name = "tcAccStudent";
            tcAccStudent.SelectedIndex = 0;
            tcAccStudent.Size = new Size(974, 545);
            tcAccStudent.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(btnExit);
            tabPage1.Controls.Add(panel6);
            tabPage1.Controls.Add(panel5);
            tabPage1.Controls.Add(panel4);
            tabPage1.Controls.Add(panel3);
            tabPage1.Controls.Add(panel2);
            tabPage1.Font = new Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tabPage1.Location = new Point(4, 34);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(966, 507);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Thông tin học sinh";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.Teal;
            btnExit.FlatAppearance.MouseDownBackColor = Color.Teal;
            btnExit.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 128, 0);
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExit.ForeColor = SystemColors.ButtonHighlight;
            btnExit.Location = new Point(430, 433);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(151, 50);
            btnExit.TabIndex = 11;
            btnExit.Text = "Đăng xuất";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // panel6
            // 
            panel6.Controls.Add(txbClass);
            panel6.Controls.Add(label6);
            panel6.Location = new Point(76, 170);
            panel6.Name = "panel6";
            panel6.Size = new Size(770, 55);
            panel6.TabIndex = 8;
            // 
            // txbClass
            // 
            txbClass.Location = new Point(274, 10);
            txbClass.Name = "txbClass";
            txbClass.Size = new Size(469, 40);
            txbClass.TabIndex = 4;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(42, 18);
            label6.Name = "label6";
            label6.Size = new Size(65, 32);
            label6.TabIndex = 2;
            label6.Text = "Lớp";
            // 
            // panel5
            // 
            panel5.Controls.Add(textBox1);
            panel5.Controls.Add(label5);
            panel5.Location = new Point(76, 289);
            panel5.Name = "panel5";
            panel5.Size = new Size(770, 55);
            panel5.TabIndex = 9;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(274, 9);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(469, 40);
            textBox1.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(42, 12);
            label5.Name = "label5";
            label5.Size = new Size(134, 32);
            label5.TabIndex = 4;
            label5.Text = "Ngày sinh";
            // 
            // panel4
            // 
            panel4.Controls.Add(checkBox2);
            panel4.Controls.Add(checkBox1);
            panel4.Controls.Add(label4);
            panel4.Location = new Point(76, 231);
            panel4.Name = "panel4";
            panel4.Size = new Size(770, 55);
            panel4.TabIndex = 8;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(393, 16);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(77, 36);
            checkBox2.TabIndex = 5;
            checkBox2.Text = "Nữ";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(274, 16);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(103, 36);
            checkBox1.TabIndex = 4;
            checkBox1.Text = "Nam ";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(42, 16);
            label4.Name = "label4";
            label4.Size = new Size(124, 32);
            label4.TabIndex = 3;
            label4.Text = "Giới tính";
            // 
            // panel3
            // 
            panel3.Controls.Add(txbID);
            panel3.Controls.Add(label3);
            panel3.Location = new Point(76, 109);
            panel3.Name = "panel3";
            panel3.Size = new Size(770, 55);
            panel3.TabIndex = 7;
            // 
            // txbID
            // 
            txbID.Location = new Point(274, 10);
            txbID.Name = "txbID";
            txbID.Size = new Size(469, 40);
            txbID.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(42, 13);
            label3.Name = "label3";
            label3.Size = new Size(161, 32);
            label3.TabIndex = 2;
            label3.Text = "Mã học sinh";
            // 
            // panel2
            // 
            panel2.Controls.Add(txbName);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(76, 48);
            panel2.Name = "panel2";
            panel2.Size = new Size(770, 55);
            panel2.TabIndex = 6;
            // 
            // txbName
            // 
            txbName.Location = new Point(274, 9);
            txbName.Name = "txbName";
            txbName.Size = new Size(469, 40);
            txbName.TabIndex = 3;
            txbName.TextChanged += txbName_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(42, 12);
            label2.Name = "label2";
            label2.Size = new Size(129, 32);
            label2.TabIndex = 2;
            label2.Text = "Họ và tên";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(btnSearchUdSor);
            tabPage2.Controls.Add(lvList);
            tabPage2.Controls.Add(panel7);
            tabPage2.Location = new Point(4, 34);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(966, 507);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Bảng điểm";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnSearchUdSor
            // 
            btnSearchUdSor.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearchUdSor.Location = new Point(847, 10);
            btnSearchUdSor.Name = "btnSearchUdSor";
            btnSearchUdSor.Size = new Size(100, 56);
            btnSearchUdSor.TabIndex = 27;
            btnSearchUdSor.Text = "Tìm kiếm";
            btnSearchUdSor.UseVisualStyleBackColor = true;
            // 
            // lvList
            // 
            lvList.Columns.AddRange(new ColumnHeader[] { clnMamon, clnTenMon, ClnDiemMieng, clnDiem15p, clnDiemGiuaKi, clnDiemCuoiKi, clnDiemTBM });
            lvList.Font = new Font("Times New Roman", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lvList.GridLines = true;
            lvList.Location = new Point(12, 72);
            lvList.Name = "lvList";
            lvList.Size = new Size(935, 435);
            lvList.TabIndex = 2;
            lvList.UseCompatibleStateImageBehavior = false;
            lvList.View = View.Details;
            lvList.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // clnMamon
            // 
            clnMamon.Text = "Mã Môn học";
            clnMamon.Width = 130;
            // 
            // clnTenMon
            // 
            clnTenMon.Text = "Môn Học";
            clnTenMon.TextAlign = HorizontalAlignment.Center;
            clnTenMon.Width = 130;
            // 
            // ClnDiemMieng
            // 
            ClnDiemMieng.Text = "Điểm Miệng";
            ClnDiemMieng.TextAlign = HorizontalAlignment.Center;
            ClnDiemMieng.Width = 130;
            // 
            // clnDiem15p
            // 
            clnDiem15p.Text = "Điểm 15 phút";
            clnDiem15p.Width = 130;
            // 
            // clnDiemGiuaKi
            // 
            clnDiemGiuaKi.Text = "Điểm Giữa kì";
            clnDiemGiuaKi.TextAlign = HorizontalAlignment.Center;
            clnDiemGiuaKi.Width = 130;
            // 
            // clnDiemCuoiKi
            // 
            clnDiemCuoiKi.Text = "Điểm Cuối kì";
            clnDiemCuoiKi.TextAlign = HorizontalAlignment.Center;
            clnDiemCuoiKi.Width = 130;
            // 
            // clnDiemTBM
            // 
            clnDiemTBM.Text = "Trung bình môn";
            clnDiemTBM.TextAlign = HorizontalAlignment.Center;
            clnDiemTBM.Width = 150;
            // 
            // panel7
            // 
            panel7.Controls.Add(comboBox1);
            panel7.Controls.Add(label7);
            panel7.Location = new Point(10, 10);
            panel7.Name = "panel7";
            panel7.Size = new Size(497, 56);
            panel7.TabIndex = 1;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(190, 11);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(286, 33);
            comboBox1.TabIndex = 1;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(22, 12);
            label7.Name = "label7";
            label7.Size = new Size(119, 32);
            label7.TabIndex = 0;
            label7.Text = "Năm học";
            // 
            // lbLogin
            // 
            lbLogin.BackColor = Color.Teal;
            lbLogin.Font = new Font("Times New Roman", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbLogin.ForeColor = SystemColors.ControlLightLight;
            lbLogin.Location = new Point(5, 22);
            lbLogin.Name = "lbLogin";
            lbLogin.Size = new Size(967, 75);
            lbLogin.TabIndex = 2;
            lbLogin.Text = "TÀI KHOẢN HỌC SINH";
            lbLogin.TextAlign = ContentAlignment.MiddleCenter;
            lbLogin.UseCompatibleTextRendering = true;
            // 
            // InfoStudent
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(969, 664);
            Controls.Add(lbLogin);
            Controls.Add(tcAccStudent);
            Name = "InfoStudent";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tài khoản học sinh";
            Load += InfoStudent_Load;
            tcAccStudent.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            tabPage2.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tcAccStudent;
        private TabPage tabPage2;
        private Label lbLogin;
        private TabPage tabPage1;
        private Button btnExit;
        private Panel panel6;
        private TextBox txbClass;
        private Label label6;
        private Panel panel5;
        private Label label5;
        private Panel panel4;
        private CheckBox checkBox2;
        private CheckBox checkBox1;
        private Label label4;
        private Panel panel3;
        private TextBox txbID;
        private Label label3;
        private Panel panel2;
        private TextBox txbName;
        private Label label2;
        private Panel panel7;
        private Label label7;
        private ComboBox comboBox1;
        private ListView lvList;
        private ColumnHeader clnMamon;
        private ColumnHeader clnTenMon;
        private ColumnHeader ClnDiemMieng;
        private ColumnHeader clnDiem15p;
        private ColumnHeader clnDiemGiuaKi;
        private ColumnHeader clnDiemCuoiKi;
        private ColumnHeader clnDiemTBM;
        private TextBox textBox1;
        private Button btnSearchUdSor;
    }
}