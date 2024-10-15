namespace oop_final
{
    partial class LoginStudent
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
            lbLogin = new Label();
            label1 = new Label();
            panel1 = new Panel();
            txbStudentName = new TextBox();
            label2 = new Label();
            panel2 = new Panel();
            txbStudentPass = new TextBox();
            label3 = new Label();
            btnStudentLogin = new Button();
            btnStudentExit = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // lbLogin
            // 
            lbLogin.BackColor = Color.Teal;
            lbLogin.Font = new Font("Times New Roman", 28F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbLogin.ForeColor = SystemColors.ControlLightLight;
            lbLogin.Location = new Point(1, 41);
            lbLogin.Name = "lbLogin";
            lbLogin.Size = new Size(804, 71);
            lbLogin.TabIndex = 0;
            lbLogin.Text = "ĐĂNG NHẬP";
            lbLogin.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(249, 131);
            label1.Name = "label1";
            label1.Size = new Size(267, 36);
            label1.TabIndex = 1;
            label1.Text = "Dành cho học sinh";
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(txbStudentName);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(49, 188);
            panel1.Name = "panel1";
            panel1.Size = new Size(707, 77);
            panel1.TabIndex = 2;
            // 
            // txbStudentName
            // 
            txbStudentName.Location = new Point(264, 21);
            txbStudentName.Name = "txbStudentName";
            txbStudentName.Size = new Size(431, 31);
            txbStudentName.TabIndex = 1;
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
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(txbStudentPass);
            panel2.Controls.Add(label3);
            panel2.Location = new Point(49, 284);
            panel2.Name = "panel2";
            panel2.Size = new Size(707, 77);
            panel2.TabIndex = 3;
            // 
            // txbStudentPass
            // 
            txbStudentPass.Location = new Point(264, 21);
            txbStudentPass.Name = "txbStudentPass";
            txbStudentPass.Size = new Size(431, 31);
            txbStudentPass.TabIndex = 1;
            txbStudentPass.UseSystemPasswordChar = true;
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
            // 
            // btnStudentLogin
            // 
            btnStudentLogin.BackColor = Color.Teal;
            btnStudentLogin.FlatAppearance.MouseDownBackColor = Color.Teal;
            btnStudentLogin.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 128, 0);
            btnStudentLogin.FlatStyle = FlatStyle.Flat;
            btnStudentLogin.Font = new Font("Times New Roman", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnStudentLogin.ForeColor = SystemColors.ButtonFace;
            btnStudentLogin.Location = new Point(474, 380);
            btnStudentLogin.Name = "btnStudentLogin";
            btnStudentLogin.Size = new Size(125, 49);
            btnStudentLogin.TabIndex = 4;
            btnStudentLogin.Text = "Đăng nhập";
            btnStudentLogin.UseVisualStyleBackColor = false;
            btnStudentLogin.Click += btnLogin_Click;
            // 
            // btnStudentExit
            // 
            btnStudentExit.Font = new Font("Times New Roman", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnStudentExit.Location = new Point(628, 380);
            btnStudentExit.Name = "btnStudentExit";
            btnStudentExit.Size = new Size(128, 49);
            btnStudentExit.TabIndex = 5;
            btnStudentExit.Text = "Thoát";
            btnStudentExit.UseVisualStyleBackColor = true;
            btnStudentExit.Click += btnStudentExit_Click;
            // 
            // LoginStudent
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(805, 441);
            Controls.Add(btnStudentExit);
            Controls.Add(btnStudentLogin);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label1);
            Controls.Add(lbLogin);
            Name = "LoginStudent";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Học sinh đăng nhập";
           
            Load += LoginStudent_Load;
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
        private Label label2;
        private TextBox txbStudentName;
        private Panel panel2;
        private TextBox txbStudentPass;
        private Label label3;
        private Button btnStudentLogin;
        private Button btnStudentExit;
    }
}
