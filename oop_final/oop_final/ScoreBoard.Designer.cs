namespace oop_final
{
    partial class ScoreBoard
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
            lbLogin = new Label();
            tcScore = new TabControl();
            tabPage1 = new TabPage();
            btnSearchScore = new Button();
            btnExitScore = new Button();
            lvSBTeacher = new ListView();
            clnSTT = new ColumnHeader();
            clnMaHS = new ColumnHeader();
            clnTen = new ColumnHeader();
            ClnToan = new ColumnHeader();
            clnVan = new ColumnHeader();
            clnNgoaingu = new ColumnHeader();
            clnVat = new ColumnHeader();
            clnHoa = new ColumnHeader();
            clnSinh = new ColumnHeader();
            clnSu = new ColumnHeader();
            clnDia = new ColumnHeader();
            clnGDCD = new ColumnHeader();
            clnTin = new ColumnHeader();
            clnCongnghe = new ColumnHeader();
            comboBox2 = new ComboBox();
            comboBox1 = new ComboBox();
            label2 = new Label();
            label1 = new Label();
            tabPage2 = new TabPage();
            button1 = new Button();
            listView1 = new ListView();
            columnHeader1 = new ColumnHeader();
            clnMamon = new ColumnHeader();
            clnTenMon = new ColumnHeader();
            ClnDiemMieng = new ColumnHeader();
            clnDiem15p = new ColumnHeader();
            clnDiemGiuaKi = new ColumnHeader();
            clnDiemCuoiKi = new ColumnHeader();
            clnDiemTBM = new ColumnHeader();
            textBox1 = new TextBox();
            label5 = new Label();
            comboBox3 = new ComboBox();
            comboBox4 = new ComboBox();
            label3 = new Label();
            label4 = new Label();
            tcScore.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // lbLogin
            // 
            lbLogin.BackColor = Color.Teal;
            lbLogin.Font = new Font("Times New Roman", 28F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbLogin.ForeColor = SystemColors.ControlLightLight;
            lbLogin.Location = new Point(-1, 36);
            lbLogin.Name = "lbLogin";
            lbLogin.Size = new Size(1651, 71);
            lbLogin.TabIndex = 2;
            lbLogin.Text = "BẢNG ĐIỂM";
            lbLogin.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tcScore
            // 
            tcScore.Controls.Add(tabPage1);
            tcScore.Controls.Add(tabPage2);
            tcScore.Location = new Point(-1, 122);
            tcScore.Name = "tcScore";
            tcScore.SelectedIndex = 0;
            tcScore.Size = new Size(1651, 647);
            tcScore.TabIndex = 3;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(btnSearchScore);
            tabPage1.Controls.Add(btnExitScore);
            tabPage1.Controls.Add(lvSBTeacher);
            tabPage1.Controls.Add(comboBox2);
            tabPage1.Controls.Add(comboBox1);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(label1);
            tabPage1.Location = new Point(4, 34);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1643, 609);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Bảng điểm theo lớp";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnSearchScore
            // 
            btnSearchScore.Font = new Font("Times New Roman", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearchScore.Location = new Point(1417, 9);
            btnSearchScore.Name = "btnSearchScore";
            btnSearchScore.Size = new Size(106, 56);
            btnSearchScore.TabIndex = 14;
            btnSearchScore.Text = "Tìm kiếm";
            btnSearchScore.UseVisualStyleBackColor = true;
            btnSearchScore.Click += btnSearchScore_Click;
            // 
            // btnExitScore
            // 
            btnExitScore.Font = new Font("Times New Roman", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExitScore.Location = new Point(1529, 9);
            btnExitScore.Name = "btnExitScore";
            btnExitScore.Size = new Size(106, 56);
            btnExitScore.TabIndex = 13;
            btnExitScore.Text = "Thoát";
            btnExitScore.UseVisualStyleBackColor = true;
            btnExitScore.Click += btnExitScore_Click;
            // 
            // lvSBTeacher
            // 
            lvSBTeacher.Columns.AddRange(new ColumnHeader[] { clnSTT, clnMaHS, clnTen, ClnToan, clnVan, clnNgoaingu, clnVat, clnHoa, clnSinh, clnSu, clnDia, clnGDCD, clnTin, clnCongnghe });
            lvSBTeacher.Font = new Font("Times New Roman", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lvSBTeacher.GridLines = true;
            lvSBTeacher.Location = new Point(4, 85);
            lvSBTeacher.Name = "lvSBTeacher";
            lvSBTeacher.Size = new Size(1631, 528);
            lvSBTeacher.TabIndex = 5;
            lvSBTeacher.UseCompatibleStateImageBehavior = false;
            lvSBTeacher.View = View.Details;
            // 
            // clnSTT
            // 
            clnSTT.Text = "STT";
            clnSTT.Width = 70;
            // 
            // clnMaHS
            // 
            clnMaHS.Text = "Mã số học sinh";
            clnMaHS.TextAlign = HorizontalAlignment.Center;
            clnMaHS.Width = 140;
            // 
            // clnTen
            // 
            clnTen.Text = "Họ và tên";
            clnTen.TextAlign = HorizontalAlignment.Center;
            clnTen.Width = 120;
            // 
            // ClnToan
            // 
            ClnToan.Text = "Toán học";
            ClnToan.TextAlign = HorizontalAlignment.Center;
            ClnToan.Width = 120;
            // 
            // clnVan
            // 
            clnVan.Text = "Ngữ Văn";
            clnVan.TextAlign = HorizontalAlignment.Center;
            clnVan.Width = 120;
            // 
            // clnNgoaingu
            // 
            clnNgoaingu.Text = "Ngoại Ngữ";
            clnNgoaingu.TextAlign = HorizontalAlignment.Center;
            clnNgoaingu.Width = 120;
            // 
            // clnVat
            // 
            clnVat.Text = "Vật Lý";
            clnVat.TextAlign = HorizontalAlignment.Center;
            clnVat.Width = 120;
            // 
            // clnHoa
            // 
            clnHoa.Text = "Hóa học";
            clnHoa.TextAlign = HorizontalAlignment.Center;
            clnHoa.Width = 120;
            // 
            // clnSinh
            // 
            clnSinh.Text = "Sinh học";
            clnSinh.TextAlign = HorizontalAlignment.Center;
            clnSinh.Width = 120;
            // 
            // clnSu
            // 
            clnSu.Text = "Lịch sử ";
            clnSu.TextAlign = HorizontalAlignment.Center;
            clnSu.Width = 120;
            // 
            // clnDia
            // 
            clnDia.Text = "Địa Lý";
            clnDia.TextAlign = HorizontalAlignment.Center;
            clnDia.Width = 120;
            // 
            // clnGDCD
            // 
            clnGDCD.Text = "GDCD";
            clnGDCD.TextAlign = HorizontalAlignment.Center;
            clnGDCD.Width = 120;
            // 
            // clnTin
            // 
            clnTin.Text = "Tin học";
            clnTin.TextAlign = HorizontalAlignment.Center;
            clnTin.Width = 110;
            // 
            // clnCongnghe
            // 
            clnCongnghe.Text = "Công nghệ";
            clnCongnghe.TextAlign = HorizontalAlignment.Center;
            clnCongnghe.Width = 110;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(590, 16);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(213, 33);
            comboBox2.TabIndex = 4;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(131, 17);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(213, 33);
            comboBox1.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(473, 19);
            label2.Name = "label2";
            label2.Size = new Size(96, 26);
            label2.TabIndex = 2;
            label2.Text = "Lớp học";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 23);
            label1.Name = "label1";
            label1.Size = new Size(102, 26);
            label1.TabIndex = 1;
            label1.Text = "Năm học";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(button1);
            tabPage2.Controls.Add(listView1);
            tabPage2.Controls.Add(textBox1);
            tabPage2.Controls.Add(label5);
            tabPage2.Controls.Add(comboBox3);
            tabPage2.Controls.Add(comboBox4);
            tabPage2.Controls.Add(label3);
            tabPage2.Controls.Add(label4);
            tabPage2.Location = new Point(4, 34);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1643, 609);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Bảng điểm theo môn ";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Font = new Font("Times New Roman", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(1519, 15);
            button1.Name = "button1";
            button1.Size = new Size(106, 56);
            button1.TabIndex = 15;
            button1.Text = "Tìm kiếm";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader1, clnMamon, clnTenMon, ClnDiemMieng, clnDiem15p, clnDiemGiuaKi, clnDiemCuoiKi, clnDiemTBM });
            listView1.Font = new Font("Times New Roman", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listView1.GridLines = true;
            listView1.Location = new Point(86, 72);
            listView1.Name = "listView1";
            listView1.Size = new Size(1387, 534);
            listView1.TabIndex = 9;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "STT";
            columnHeader1.Width = 120;
            // 
            // clnMamon
            // 
            clnMamon.Text = "Mã Môn học";
            clnMamon.Width = 180;
            // 
            // clnTenMon
            // 
            clnTenMon.Text = "Môn Học";
            clnTenMon.TextAlign = HorizontalAlignment.Center;
            clnTenMon.Width = 180;
            // 
            // ClnDiemMieng
            // 
            ClnDiemMieng.Text = "Điểm Miệng";
            ClnDiemMieng.TextAlign = HorizontalAlignment.Center;
            ClnDiemMieng.Width = 180;
            // 
            // clnDiem15p
            // 
            clnDiem15p.Text = "Điểm 15 phút";
            clnDiem15p.TextAlign = HorizontalAlignment.Center;
            clnDiem15p.Width = 180;
            // 
            // clnDiemGiuaKi
            // 
            clnDiemGiuaKi.Text = "Điểm Giữa kì";
            clnDiemGiuaKi.TextAlign = HorizontalAlignment.Center;
            clnDiemGiuaKi.Width = 180;
            // 
            // clnDiemCuoiKi
            // 
            clnDiemCuoiKi.Text = "Điểm Cuối kì";
            clnDiemCuoiKi.TextAlign = HorizontalAlignment.Center;
            clnDiemCuoiKi.Width = 180;
            // 
            // clnDiemTBM
            // 
            clnDiemTBM.Text = "Trung bình môn";
            clnDiemTBM.TextAlign = HorizontalAlignment.Center;
            clnDiemTBM.Width = 180;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(265, 25);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(331, 31);
            textBox1.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(86, 27);
            label5.Name = "label5";
            label5.Size = new Size(141, 26);
            label5.TabIndex = 7;
            label5.Text = "Tên học sinh";
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(795, 27);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(213, 33);
            comboBox3.TabIndex = 6;
            // 
            // comboBox4
            // 
            comboBox4.FormattingEnabled = true;
            comboBox4.Location = new Point(1246, 25);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(227, 33);
            comboBox4.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(677, 27);
            label3.Name = "label3";
            label3.Size = new Size(96, 26);
            label3.TabIndex = 4;
            label3.Text = "Lớp học";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(1138, 29);
            label4.Name = "label4";
            label4.Size = new Size(102, 26);
            label4.TabIndex = 3;
            label4.Text = "Năm học";
            // 
            // ScoreBoard
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1650, 767);
            Controls.Add(tcScore);
            Controls.Add(lbLogin);
            Name = "ScoreBoard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Bảng điểm";
            Load += ScoreBoard_Load;
            tcScore.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label lbLogin;
        private TabControl tcScore;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Label label1;
        private ComboBox comboBox2;
        private ComboBox comboBox1;
        private Label label2;
        private ListView lvSBTeacher;
        private ColumnHeader clnSTT;
        private ColumnHeader clnMaHS;
        private ColumnHeader clnTen;
        private ColumnHeader ClnToan;
        private ColumnHeader clnVan;
        private ColumnHeader clnDiemGiuaKi;
        private ColumnHeader clnNgoaingu;
        private ColumnHeader clnVat;
        private ColumnHeader clnHoa;
        private ColumnHeader clnSinh;
        private ColumnHeader clnSu;
        private ColumnHeader clnDia;
        private ColumnHeader clnGDCD;
        private ColumnHeader clnTin;
        private ColumnHeader clnCongnghe;
        private ComboBox comboBox3;
        private ComboBox comboBox4;
        private Label label3;
        private Label label4;
        private TextBox textBox1;
        private Label label5;
        private ListView listView1;
        private ColumnHeader clnMamon;
        private ColumnHeader clnTenMon;
        private ColumnHeader ClnDiemMieng;
        private ColumnHeader clnDiem15p;
        private ColumnHeader clnDiemCuoiKi;
        private ColumnHeader clnDiemTBM;
        private ColumnHeader columnHeader1;
        private Button btnExitScore;
        private Button btnSearchScore;
        private Button button1;
    }
}