namespace oop_final
{
    partial class Login
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
            label1 = new Label();
            btnTeacher = new Button();
            btnStudent = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = Color.Teal;
            label1.Font = new Font("Times New Roman", 22F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(409, 50);
            label1.Name = "label1";
            label1.Size = new Size(407, 61);
            label1.TabIndex = 0;
            label1.Text = "ĐĂNG NHẬP";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnTeacher
            // 
            btnTeacher.Font = new Font("Times New Roman", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTeacher.Location = new Point(451, 162);
            btnTeacher.Name = "btnTeacher";
            btnTeacher.Size = new Size(330, 52);
            btnTeacher.TabIndex = 2;
            btnTeacher.Text = "Tài khoản giáo viên";
            btnTeacher.UseVisualStyleBackColor = true;
            btnTeacher.Click += btnTeacher_Click;
            // 
            // btnStudent
            // 
            btnStudent.Font = new Font("Times New Roman", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnStudent.Location = new Point(451, 236);
            btnStudent.Name = "btnStudent";
            btnStudent.Size = new Size(330, 52);
            btnStudent.TabIndex = 3;
            btnStudent.Text = "Tài khoản học sinh";
            btnStudent.UseVisualStyleBackColor = true;
            btnStudent.Click += btnStudent_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Nam_Sai_Gon_310518_7;
            pictureBox1.Location = new Point(-76, -10);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(509, 329);
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(814, 317);
            Controls.Add(pictureBox1);
            Controls.Add(btnStudent);
            Controls.Add(btnTeacher);
            Controls.Add(label1);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Đăng nhập";
            FormClosing += Login_FormClosing;
            Load += Login_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Button btnTeacher;
        private Button btnStudent;
        private PictureBox pictureBox1;
    }
}