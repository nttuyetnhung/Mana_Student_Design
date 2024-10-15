namespace oop_final
{
    partial class LoginAdmin
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
            txbAdminName = new TextBox();
            label2 = new Label();
            panel2 = new Panel();
            txbAdminPass = new TextBox();
            label3 = new Label();
            btnAdminLogin = new Button();
            btnAdminExit = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // lbLogin
            // 
            lbLogin.BackColor = Color.Teal;
            lbLogin.Font = new Font("Times New Roman", 28F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbLogin.ForeColor = SystemColors.ControlLightLight;
            lbLogin.Location = new Point(-1, 28);
            lbLogin.Name = "lbLogin";
            lbLogin.Size = new Size(804, 73);
            lbLogin.TabIndex = 1;
            lbLogin.Text = "ĐĂNG NHẬP";
            lbLogin.TextAlign = ContentAlignment.MiddleCenter;
            lbLogin.UseCompatibleTextRendering = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(263, 121);
            label1.Name = "label1";
            label1.Size = new Size(247, 36);
            label1.TabIndex = 2;
            label1.Text = "Dành cho Admin";
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(txbAdminName);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(47, 187);
            panel1.Name = "panel1";
            panel1.Size = new Size(707, 77);
            panel1.TabIndex = 3;
            // 
            // txbAdminName
            // 
            txbAdminName.Location = new Point(264, 21);
            txbAdminName.Name = "txbAdminName";
            txbAdminName.Size = new Size(431, 31);
            txbAdminName.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(3, 21);
            label2.Name = "label2";
            label2.Size = new Size(222, 36);
            label2.TabIndex = 0;
            label2.Text = "Tên đăng nhập";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(txbAdminPass);
            panel2.Controls.Add(label3);
            panel2.Location = new Point(47, 284);
            panel2.Name = "panel2";
            panel2.Size = new Size(707, 77);
            panel2.TabIndex = 4;
            // 
            // txbAdminPass
            // 
            txbAdminPass.Location = new Point(264, 21);
            txbAdminPass.Name = "txbAdminPass";
            txbAdminPass.Size = new Size(431, 31);
            txbAdminPass.TabIndex = 1;
            txbAdminPass.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(3, 21);
            label3.Name = "label3";
            label3.Size = new Size(150, 36);
            label3.TabIndex = 0;
            label3.Text = "Mật khẩu";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnAdminLogin
            // 
            btnAdminLogin.BackColor = Color.Teal;
            btnAdminLogin.FlatAppearance.MouseDownBackColor = Color.Teal;
            btnAdminLogin.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 128, 0);
            btnAdminLogin.FlatStyle = FlatStyle.Flat;
            btnAdminLogin.Font = new Font("Times New Roman", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdminLogin.ForeColor = SystemColors.ControlLightLight;
            btnAdminLogin.Location = new Point(484, 379);
            btnAdminLogin.Name = "btnAdminLogin";
            btnAdminLogin.Size = new Size(125, 49);
            btnAdminLogin.TabIndex = 5;
            btnAdminLogin.Text = "Đăng nhập";
            btnAdminLogin.UseVisualStyleBackColor = false;
            btnAdminLogin.Click += btnLogin_Click;
            // 
            // btnAdminExit
            // 
            btnAdminExit.Font = new Font("Times New Roman", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdminExit.Location = new Point(626, 379);
            btnAdminExit.Name = "btnAdminExit";
            btnAdminExit.Size = new Size(128, 49);
            btnAdminExit.TabIndex = 6;
            btnAdminExit.Text = "Thoát";
            btnAdminExit.UseVisualStyleBackColor = true;
            btnAdminExit.Click += btnExit_Click;
            // 
            // LoginAdmin
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnAdminExit);
            Controls.Add(btnAdminLogin);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label1);
            Controls.Add(lbLogin);
            Name = "LoginAdmin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Admin Đăng nhập";
            Load += LoginAdmin_Load;
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
        private TextBox txbAdminName;
        private Label label2;
        private Panel panel2;
        private TextBox txbAdminPass;
        private Label label3;
        private Button btnAdminLogin;
        private Button btnAdminExit;
    }
}