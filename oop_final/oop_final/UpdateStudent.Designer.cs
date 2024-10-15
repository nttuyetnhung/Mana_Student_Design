namespace oop_final
{
    partial class AddStudent
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
            panel1 = new Panel();
            btnExitUpSt = new Button();
            btnDeleteSt = new Button();
            lbUpdateSt = new Label();
            btnAddSt = new Button();
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
            txbStudentName = new TextBox();
            label2 = new Label();
            panel1.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnExitUpSt);
            panel1.Controls.Add(btnDeleteSt);
            panel1.Controls.Add(lbUpdateSt);
            panel1.Controls.Add(btnAddSt);
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(-2, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(805, 464);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // btnExitUpSt
            // 
            btnExitUpSt.BackColor = Color.Teal;
            btnExitUpSt.FlatAppearance.BorderColor = Color.Teal;
            btnExitUpSt.FlatAppearance.MouseDownBackColor = Color.Teal;
            btnExitUpSt.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 128, 0);
            btnExitUpSt.FlatStyle = FlatStyle.Flat;
            btnExitUpSt.Font = new Font("Times New Roman", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExitUpSt.ForeColor = SystemColors.ControlLightLight;
            btnExitUpSt.Location = new Point(553, 396);
            btnExitUpSt.Name = "btnExitUpSt";
            btnExitUpSt.Size = new Size(125, 49);
            btnExitUpSt.TabIndex = 19;
            btnExitUpSt.Text = "Thoát";
            btnExitUpSt.UseVisualStyleBackColor = false;
            btnExitUpSt.Click += btnExitUpSt_Click;
            // 
            // btnDeleteSt
            // 
            btnDeleteSt.BackColor = Color.Teal;
            btnDeleteSt.FlatAppearance.BorderColor = Color.Teal;
            btnDeleteSt.FlatAppearance.MouseDownBackColor = Color.Teal;
            btnDeleteSt.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 128, 0);
            btnDeleteSt.FlatStyle = FlatStyle.Flat;
            btnDeleteSt.Font = new Font("Times New Roman", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDeleteSt.ForeColor = SystemColors.ControlLightLight;
            btnDeleteSt.Location = new Point(354, 396);
            btnDeleteSt.Name = "btnDeleteSt";
            btnDeleteSt.Size = new Size(125, 49);
            btnDeleteSt.TabIndex = 17;
            btnDeleteSt.Text = "Xóa";
            btnDeleteSt.UseVisualStyleBackColor = false;
            // 
            // lbUpdateSt
            // 
            lbUpdateSt.BackColor = Color.Teal;
            lbUpdateSt.Font = new Font("Times New Roman", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbUpdateSt.ForeColor = SystemColors.ControlLightLight;
            lbUpdateSt.Location = new Point(3, 22);
            lbUpdateSt.Name = "lbUpdateSt";
            lbUpdateSt.Size = new Size(799, 75);
            lbUpdateSt.TabIndex = 16;
            lbUpdateSt.Text = "CẬP NHẬT HỌC SINH";
            lbUpdateSt.TextAlign = ContentAlignment.MiddleCenter;
            lbUpdateSt.UseCompatibleTextRendering = true;
            // 
            // btnAddSt
            // 
            btnAddSt.BackColor = Color.Teal;
            btnAddSt.FlatAppearance.BorderColor = Color.Teal;
            btnAddSt.FlatAppearance.MouseDownBackColor = Color.Teal;
            btnAddSt.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 128, 0);
            btnAddSt.FlatStyle = FlatStyle.Flat;
            btnAddSt.Font = new Font("Times New Roman", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddSt.ForeColor = SystemColors.ControlLightLight;
            btnAddSt.Location = new Point(143, 396);
            btnAddSt.Name = "btnAddSt";
            btnAddSt.Size = new Size(125, 49);
            btnAddSt.TabIndex = 15;
            btnAddSt.Text = "Thêm ";
            btnAddSt.UseVisualStyleBackColor = false;
            // 
            // panel5
            // 
            panel5.Controls.Add(textBox1);
            panel5.Controls.Add(label5);
            panel5.Location = new Point(14, 325);
            panel5.Name = "panel5";
            panel5.Size = new Size(770, 55);
            panel5.TabIndex = 8;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(269, 13);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(469, 31);
            textBox1.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(10, 10);
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
            panel4.Location = new Point(14, 264);
            panel4.Name = "panel4";
            panel4.Size = new Size(770, 55);
            panel4.TabIndex = 7;
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
            checkBox1.Location = new Point(272, 16);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(81, 29);
            checkBox1.TabIndex = 4;
            checkBox1.Text = "Nam ";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(15, 11);
            label4.Name = "label4";
            label4.Size = new Size(124, 32);
            label4.TabIndex = 3;
            label4.Text = "Giới tính";
            // 
            // panel3
            // 
            panel3.Controls.Add(txbID);
            panel3.Controls.Add(label3);
            panel3.Location = new Point(14, 203);
            panel3.Name = "panel3";
            panel3.Size = new Size(770, 55);
            panel3.TabIndex = 6;
            // 
            // txbID
            // 
            txbID.Location = new Point(272, 13);
            txbID.Name = "txbID";
            txbID.Size = new Size(469, 31);
            txbID.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(10, 13);
            label3.Name = "label3";
            label3.Size = new Size(161, 32);
            label3.TabIndex = 2;
            label3.Text = "Mã học sinh";
            label3.Click += label3_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(txbStudentName);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(14, 142);
            panel2.Name = "panel2";
            panel2.Size = new Size(770, 55);
            panel2.TabIndex = 5;
            // 
            // txbStudentName
            // 
            txbStudentName.Location = new Point(272, 13);
            txbStudentName.Name = "txbStudentName";
            txbStudentName.Size = new Size(469, 31);
            txbStudentName.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(10, 12);
            label2.Name = "label2";
            label2.Size = new Size(129, 32);
            label2.TabIndex = 2;
            label2.Text = "Họ và tên";
            // 
            // AddStudent
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 473);
            Controls.Add(panel1);
            Name = "AddStudent";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cập nhật học sinh";
            panel1.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label3;
        private Label label4;
        private Panel panel2;
        private Panel panel4;
        private Panel panel3;
        private Label label2;
        private TextBox txbID;
        private TextBox txbStudentName;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private Panel panel5;
        private Label label5;
        private TextBox textBox1;
        private Button btnAddSt;
        private Label lbUpdateSt;
        private Button btnDeleteSt;
        private Button btnExitUpSt;
    }
}