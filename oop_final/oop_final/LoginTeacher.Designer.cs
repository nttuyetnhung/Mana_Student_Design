namespace oop_final
{
    partial class LoginTeacher
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
            label1 = new Label();
            panel1 = new Panel();
            txbTeacherName = new TextBox();
            label2 = new Label();
            panel2 = new Panel();
            txbTeacherPass = new TextBox();
            label3 = new Label();
            btnTeacherLogin = new Button();
            btnTeacherExit = new Button();
            label4 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // lbLogin
            // 
            lbLogin.BackColor = Color.Teal;
            lbLogin.Font = new Font("Times New Roman", 28F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbLogin.ForeColor = SystemColors.ControlLightLight;
            lbLogin.ImageAlign = ContentAlignment.TopLeft;
            lbLogin.Location = new Point(-3, 38);
            lbLogin.Name = "lbLogin";
            lbLogin.Size = new Size(804, 75);
            lbLogin.TabIndex = 1;
            lbLogin.Text = "ĐĂNG NHẬP";
            lbLogin.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(256, 128);
            label1.Name = "label1";
            label1.Size = new Size(0, 36);
            label1.TabIndex = 2;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(txbTeacherName);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(47, 187);
            panel1.Name = "panel1";
            panel1.Size = new Size(707, 77);
            panel1.TabIndex = 3;
            // 
            // txbTeacherName
            // 
            txbTeacherName.Location = new Point(264, 21);
            txbTeacherName.Name = "txbTeacherName";
            txbTeacherName.Size = new Size(431, 31);
            txbTeacherName.TabIndex = 1;
            txbTeacherName.TextChanged += txbTeacherName_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(13, 16);
            label2.Name = "label2";
            label2.Size = new Size(222, 36);
            label2.TabIndex = 0;
            label2.Text = "Tên đăng nhập";
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(txbTeacherPass);
            panel2.Controls.Add(label3);
            panel2.Location = new Point(47, 281);
            panel2.Name = "panel2";
            panel2.Size = new Size(707, 77);
            panel2.TabIndex = 4;
            // 
            // txbTeacherPass
            // 
            txbTeacherPass.Location = new Point(264, 21);
            txbTeacherPass.Name = "txbTeacherPass";
            txbTeacherPass.Size = new Size(431, 31);
            txbTeacherPass.TabIndex = 1;
            txbTeacherPass.UseSystemPasswordChar = true;
            txbTeacherPass.TextChanged += txbTeacherPass_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(13, 16);
            label3.Name = "label3";
            label3.Size = new Size(150, 36);
            label3.TabIndex = 0;
            label3.Text = "Mật khẩu";
            // 
            // btnTeacherLogin
            // 
            btnTeacherLogin.BackColor = Color.Teal;
            btnTeacherLogin.FlatAppearance.MouseDownBackColor = Color.Teal;
            btnTeacherLogin.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 128, 0);
            btnTeacherLogin.FlatStyle = FlatStyle.Flat;
            btnTeacherLogin.Font = new Font("Times New Roman", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTeacherLogin.ForeColor = Color.White;
            btnTeacherLogin.Location = new Point(480, 376);
            btnTeacherLogin.Name = "btnTeacherLogin";
            btnTeacherLogin.Size = new Size(128, 49);
            btnTeacherLogin.TabIndex = 5;
            btnTeacherLogin.Text = "Đăng nhập";
            btnTeacherLogin.UseVisualStyleBackColor = false;
            btnTeacherLogin.Click += btnLogin_Click;
            // 
            // btnTeacherExit
            // 
            btnTeacherExit.Font = new Font("Times New Roman", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTeacherExit.Location = new Point(614, 376);
            btnTeacherExit.Name = "btnTeacherExit";
            btnTeacherExit.Size = new Size(128, 49);
            btnTeacherExit.TabIndex = 6;
            btnTeacherExit.Text = "Thoát";
            btnTeacherExit.UseVisualStyleBackColor = true;
            btnTeacherExit.Click += btnExit_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(256, 128);
            label4.Name = "label4";
            label4.Size = new Size(276, 36);
            label4.TabIndex = 7;
            label4.Text = "Dành cho giáo viên";
            // 
            // LoginTeacher
            // 
            AcceptButton = btnTeacherLogin;
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(btnTeacherExit);
            Controls.Add(btnTeacherLogin);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label1);
            Controls.Add(lbLogin);
            Name = "LoginTeacher";
            StartPosition = FormStartPosition.CenterScreen;
            Text = " Giáo viên đăng nhập";
            Load += LoginTeacher_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbLogin;
        private Label label1;
        private Panel panel1;
        private TextBox txbTeacherName;
        private Label label2;
        private Panel panel2;
        private TextBox txbTeacherPass;
        private Label label3;
        private Button btnTeacherLogin;
        private Button btnTeacherExit;
        private Label label4;
    }
}