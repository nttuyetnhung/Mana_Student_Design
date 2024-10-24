namespace oop_final
{
    public partial class LoginStudent : Form
    {
        public LoginStudent()
        {
            InitializeComponent();
        }

      
        private void btnStudentExit_Click(object sender, EventArgs e)
        {
            Login f = new Login();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        List<Student> studentAccount = AccountStudent.Instance.studentAccounts;
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (checkLogin(txbStudentName.Text, txbStudentPass.Text))
            {
                InfoStudent f = new InfoStudent();
                this.Hide();
                f.ShowDialog();
                this.Show();

            }
            else
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không chính xác.", "Thông báo");
            }

        }
        public bool checkLogin(string username, string password)
        {
            for (int i = 0; i < studentAccount.Count; i++)
            {
                if (username == studentAccount[i].tenDangNhapHS && password == studentAccount[i].matKhauHS)
                {
                    return true;
                }
            }
            return false;
        }

        private void LoginStudent_Load(object sender, EventArgs e)
        {

        }
    }
}
