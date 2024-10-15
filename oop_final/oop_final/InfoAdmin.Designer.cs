namespace oop_final
{
    partial class InfoAdmin
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
            panel3 = new Panel();
            txbIdAdmin = new TextBox();
            label3 = new Label();
            panel2 = new Panel();
            txbNameAdmin = new TextBox();
            label2 = new Label();
            panel5 = new Panel();
            txbDate = new TextBox();
            label5 = new Label();
            panel4 = new Panel();
            checkBox2 = new CheckBox();
            checkBox1 = new CheckBox();
            label4 = new Label();
            btnExitAdmin = new Button();
            btnInfo = new Button();
            btnUpdateTea = new Button();
            btnUpdateSt = new Button();
            groupBox1 = new GroupBox();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // lbLogin
            // 
            lbLogin.BackColor = Color.Teal;
            lbLogin.Font = new Font("Times New Roman", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbLogin.ForeColor = SystemColors.ControlLightLight;
            lbLogin.Location = new Point(1, 20);
            lbLogin.Name = "lbLogin";
            lbLogin.Size = new Size(809, 75);
            lbLogin.TabIndex = 3;
            lbLogin.Text = "TÀI KHOẢN ADMIN";
            lbLogin.TextAlign = ContentAlignment.MiddleCenter;
            lbLogin.UseCompatibleTextRendering = true;
            // 
            // panel3
            // 
            panel3.Controls.Add(txbIdAdmin);
            panel3.Controls.Add(label3);
            panel3.Location = new Point(12, 217);
            panel3.Name = "panel3";
            panel3.Size = new Size(770, 55);
            panel3.TabIndex = 9;
            // 
            // txbIdAdmin
            // 
            txbIdAdmin.Location = new Point(274, 10);
            txbIdAdmin.Name = "txbIdAdmin";
            txbIdAdmin.Size = new Size(469, 31);
            txbIdAdmin.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(42, 13);
            label3.Name = "label3";
            label3.Size = new Size(141, 32);
            label3.TabIndex = 2;
            label3.Text = "Mã Admin";
            // 
            // panel2
            // 
            panel2.Controls.Add(txbNameAdmin);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(12, 140);
            panel2.Name = "panel2";
            panel2.Size = new Size(770, 55);
            panel2.TabIndex = 8;
            // 
            // txbNameAdmin
            // 
            txbNameAdmin.Location = new Point(274, 9);
            txbNameAdmin.Name = "txbNameAdmin";
            txbNameAdmin.Size = new Size(469, 31);
            txbNameAdmin.TabIndex = 3;
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
            // panel5
            // 
            panel5.Controls.Add(txbDate);
            panel5.Controls.Add(label5);
            panel5.Location = new Point(12, 357);
            panel5.Name = "panel5";
            panel5.Size = new Size(770, 55);
            panel5.TabIndex = 12;
            // 
            // txbDate
            // 
            txbDate.Location = new Point(274, 9);
            txbDate.Name = "txbDate";
            txbDate.Size = new Size(469, 31);
            txbDate.TabIndex = 5;
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
            panel4.Location = new Point(12, 287);
            panel4.Name = "panel4";
            panel4.Size = new Size(770, 55);
            panel4.TabIndex = 11;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(393, 16);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(62, 29);
            checkBox2.TabIndex = 5;
            checkBox2.Text = "Nữ";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(274, 16);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(81, 29);
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
            // btnExitAdmin
            // 
            btnExitAdmin.BackColor = Color.Teal;
            btnExitAdmin.FlatAppearance.MouseDownBackColor = Color.Teal;
            btnExitAdmin.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 128, 0);
            btnExitAdmin.FlatStyle = FlatStyle.Flat;
            btnExitAdmin.Font = new Font("Times New Roman", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExitAdmin.ForeColor = SystemColors.ControlLightLight;
            btnExitAdmin.Location = new Point(610, 34);
            btnExitAdmin.Name = "btnExitAdmin";
            btnExitAdmin.Size = new Size(125, 49);
            btnExitAdmin.TabIndex = 14;
            btnExitAdmin.Text = "Đăng xuất";
            btnExitAdmin.UseVisualStyleBackColor = false;
            btnExitAdmin.Click += btnExitAdmin_Click;
            // 
            // btnInfo
            // 
            btnInfo.BackColor = Color.Teal;
            btnInfo.FlatAppearance.MouseDownBackColor = Color.Teal;
            btnInfo.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 128, 0);
            btnInfo.FlatStyle = FlatStyle.Flat;
            btnInfo.Font = new Font("Times New Roman", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnInfo.ForeColor = SystemColors.ControlLightLight;
            btnInfo.Location = new Point(17, 34);
            btnInfo.Name = "btnInfo";
            btnInfo.Size = new Size(175, 49);
            btnInfo.TabIndex = 15;
            btnInfo.Text = "Xem danh sách";
            btnInfo.UseVisualStyleBackColor = false;
            btnInfo.Click += btnInfo_Click;
            // 
            // btnUpdateTea
            // 
            btnUpdateTea.BackColor = Color.Teal;
            btnUpdateTea.FlatAppearance.MouseDownBackColor = Color.Teal;
            btnUpdateTea.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 128, 0);
            btnUpdateTea.FlatStyle = FlatStyle.Flat;
            btnUpdateTea.Font = new Font("Times New Roman", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdateTea.ForeColor = SystemColors.ControlLightLight;
            btnUpdateTea.Location = new Point(215, 34);
            btnUpdateTea.Name = "btnUpdateTea";
            btnUpdateTea.Size = new Size(175, 49);
            btnUpdateTea.TabIndex = 16;
            btnUpdateTea.Text = "Cập nhật giáo viên";
            btnUpdateTea.UseVisualStyleBackColor = false;
            btnUpdateTea.Click += btnUpdateTea_Click;
            // 
            // btnUpdateSt
            // 
            btnUpdateSt.BackColor = Color.Teal;
            btnUpdateSt.FlatAppearance.MouseDownBackColor = Color.Teal;
            btnUpdateSt.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 128, 0);
            btnUpdateSt.FlatStyle = FlatStyle.Flat;
            btnUpdateSt.Font = new Font("Times New Roman", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdateSt.ForeColor = SystemColors.ControlLightLight;
            btnUpdateSt.Location = new Point(412, 34);
            btnUpdateSt.Name = "btnUpdateSt";
            btnUpdateSt.Size = new Size(175, 49);
            btnUpdateSt.TabIndex = 17;
            btnUpdateSt.Text = "Cập nhật học sinh";
            btnUpdateSt.UseVisualStyleBackColor = false;
            btnUpdateSt.Click += btnUpdateSt_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnUpdateTea);
            groupBox1.Controls.Add(btnExitAdmin);
            groupBox1.Controls.Add(btnUpdateSt);
            groupBox1.Controls.Add(btnInfo);
            groupBox1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(25, 464);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(742, 91);
            groupBox1.TabIndex = 18;
            groupBox1.TabStop = false;
            groupBox1.Text = "Chức năng";
            // 
            // InfoAdmin
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 569);
            Controls.Add(groupBox1);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(lbLogin);
            Name = "InfoAdmin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tài khoản Admin";
            Load += InfoAdmin_Load;
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label lbLogin;
        private Panel panel3;
        private TextBox txbIdAdmin;
        private Label label3;
        private Panel panel2;
        private TextBox txbNameAdmin;
        private Label label2;
        private Panel panel1;
        private ComboBox cbAdminYears;
        private Label label1;
        private Panel panel5;
        private TextBox txbDate;
        private Label label5;
        private Panel panel4;
        private CheckBox checkBox2;
        private CheckBox checkBox1;
        private Label label4;
        private Button btnExitAdmin;
        private Button btnInfo;
        private Button btnUpdateTea;
        private Button btnUpdateSt;
        private GroupBox groupBox1;
    }
}