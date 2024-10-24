namespace oop_final
{
    partial class InfoTeacher
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
            btnTeacherExit = new Button();
            btnUpdateSorce = new Button();
            btnSeeSorce = new Button();
            panel2 = new Panel();
            txbName = new TextBox();
            label2 = new Label();
            panel3 = new Panel();
            txbMaGV = new TextBox();
            label3 = new Label();
            panel4 = new Panel();
            txbGioitinh = new TextBox();
            label4 = new Label();
            panel5 = new Panel();
            label5 = new Label();
            panel1 = new Panel();
            txbChucvu = new TextBox();
            label1 = new Label();
            txbNgsinh = new TextBox();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lbLogin
            // 
            lbLogin.BackColor = Color.Teal;
            lbLogin.Font = new Font("Times New Roman", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbLogin.ForeColor = SystemColors.ControlLightLight;
            lbLogin.Location = new Point(0, 24);
            lbLogin.Name = "lbLogin";
            lbLogin.Size = new Size(815, 75);
            lbLogin.TabIndex = 3;
            lbLogin.Text = "TÀI KHOẢN GIÁO VIÊN";
            lbLogin.TextAlign = ContentAlignment.MiddleCenter;
            lbLogin.UseCompatibleTextRendering = true;
            lbLogin.Click += lbLogin_Click;
            // 
            // btnTeacherExit
            // 
            btnTeacherExit.BackColor = Color.Teal;
            btnTeacherExit.FlatAppearance.MouseDownBackColor = Color.Teal;
            btnTeacherExit.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 128, 0);
            btnTeacherExit.FlatStyle = FlatStyle.Flat;
            btnTeacherExit.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTeacherExit.ForeColor = SystemColors.ButtonHighlight;
            btnTeacherExit.Location = new Point(613, 533);
            btnTeacherExit.Name = "btnTeacherExit";
            btnTeacherExit.Size = new Size(151, 50);
            btnTeacherExit.TabIndex = 12;
            btnTeacherExit.Text = "Đăng xuất";
            btnTeacherExit.UseVisualStyleBackColor = false;
            btnTeacherExit.Click += btnExit_Click;
            // 
            // btnUpdateSorce
            // 
            btnUpdateSorce.BackColor = Color.Teal;
            btnUpdateSorce.FlatAppearance.MouseDownBackColor = Color.Teal;
            btnUpdateSorce.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 128, 0);
            btnUpdateSorce.FlatStyle = FlatStyle.Flat;
            btnUpdateSorce.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdateSorce.ForeColor = SystemColors.ButtonHighlight;
            btnUpdateSorce.Location = new Point(63, 533);
            btnUpdateSorce.Name = "btnUpdateSorce";
            btnUpdateSorce.Size = new Size(174, 50);
            btnUpdateSorce.TabIndex = 14;
            btnUpdateSorce.Text = "Cập nhật điểm";
            btnUpdateSorce.UseVisualStyleBackColor = false;
            btnUpdateSorce.Click += btnUpdateSorce_Click;
            // 
            // btnSeeSorce
            // 
            btnSeeSorce.BackColor = Color.Teal;
            btnSeeSorce.FlatAppearance.MouseDownBackColor = Color.Teal;
            btnSeeSorce.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 128, 0);
            btnSeeSorce.FlatStyle = FlatStyle.Flat;
            btnSeeSorce.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSeeSorce.ForeColor = SystemColors.ButtonHighlight;
            btnSeeSorce.Location = new Point(343, 533);
            btnSeeSorce.Name = "btnSeeSorce";
            btnSeeSorce.Size = new Size(174, 50);
            btnSeeSorce.TabIndex = 15;
            btnSeeSorce.Text = "Xem điểm";
            btnSeeSorce.UseVisualStyleBackColor = false;
            btnSeeSorce.Click += btnSeeSorce_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(txbName);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(21, 141);
            panel2.Name = "panel2";
            panel2.Size = new Size(770, 55);
            panel2.TabIndex = 16;
            // 
            // txbName
            // 
            txbName.Location = new Point(274, 9);
            txbName.Name = "txbName";
            txbName.ReadOnly = true;
            txbName.Size = new Size(469, 31);
            txbName.TabIndex = 3;
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
            // panel3
            // 
            panel3.Controls.Add(txbMaGV);
            panel3.Controls.Add(label3);
            panel3.Location = new Point(21, 216);
            panel3.Name = "panel3";
            panel3.Size = new Size(770, 55);
            panel3.TabIndex = 17;
            // 
            // txbMaGV
            // 
            txbMaGV.Location = new Point(274, 10);
            txbMaGV.Name = "txbMaGV";
            txbMaGV.ReadOnly = true;
            txbMaGV.Size = new Size(469, 31);
            txbMaGV.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(42, 13);
            label3.Name = "label3";
            label3.Size = new Size(168, 32);
            label3.TabIndex = 2;
            label3.Text = "Mã giáo viên";
            // 
            // panel4
            // 
            panel4.Controls.Add(txbGioitinh);
            panel4.Controls.Add(label4);
            panel4.Location = new Point(21, 292);
            panel4.Name = "panel4";
            panel4.Size = new Size(770, 55);
            panel4.TabIndex = 18;
            // 
            // txbGioitinh
            // 
            txbGioitinh.Location = new Point(274, 16);
            txbGioitinh.Name = "txbGioitinh";
            txbGioitinh.ReadOnly = true;
            txbGioitinh.Size = new Size(469, 31);
            txbGioitinh.TabIndex = 5;
            txbGioitinh.TextChanged += textBox1_TextChanged;
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
            // panel5
            // 
            panel5.Controls.Add(txbNgsinh);
            panel5.Controls.Add(label5);
            panel5.Location = new Point(21, 372);
            panel5.Name = "panel5";
            panel5.Size = new Size(770, 55);
            panel5.TabIndex = 19;
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
            // panel1
            // 
            panel1.Controls.Add(txbChucvu);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(21, 449);
            panel1.Name = "panel1";
            panel1.Size = new Size(770, 55);
            panel1.TabIndex = 10;
            // 
            // txbChucvu
            // 
            txbChucvu.Location = new Point(274, 15);
            txbChucvu.Name = "txbChucvu";
            txbChucvu.ReadOnly = true;
            txbChucvu.Size = new Size(469, 31);
            txbChucvu.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(42, 12);
            label1.Name = "label1";
            label1.Size = new Size(116, 32);
            label1.TabIndex = 4;
            label1.Text = "Chức vụ";
            // 
            // txbNgsinh
            // 
            txbNgsinh.Location = new Point(274, 15);
            txbNgsinh.Name = "txbNgsinh";
            txbNgsinh.ReadOnly = true;
            txbNgsinh.Size = new Size(469, 31);
            txbNgsinh.TabIndex = 6;
            // 
            // InfoTeacher
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(812, 614);
            Controls.Add(panel1);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(btnSeeSorce);
            Controls.Add(btnUpdateSorce);
            Controls.Add(btnTeacherExit);
            Controls.Add(lbLogin);
            Name = "InfoTeacher";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tài khoản giáo viên";
            Load += InfoTeacher_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label lbLogin;
        private Button btnTeacherExit;
        private Button btnUpdateSorce;
        private Button btnSeeSorce;
        private Panel panel2;
        private TextBox txbName;
        private Label label2;
        private Panel panel3;
        private TextBox txbMaGV;
        private Label label3;
        private Panel panel4;
        private Label label4;
        private Panel panel5;
        private Label label5;
        private Panel panel1;
        private Label label1;
        private ComboBox comboBox1;
        private TextBox txbChucvu;
        private TextBox txbGioitinh;
        private TextBox txbNgsinh;
    }
}