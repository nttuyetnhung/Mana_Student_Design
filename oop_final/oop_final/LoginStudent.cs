namespace oop_final
{
    public partial class LoginStudent : Form
    {
        private Dictionary<string, Student> studentAccounts = AccountStudent.Instance.studentAccounts;

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

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txbStudentName.Text;
            string password = txbStudentPass.Text;

            foreach (var student in studentAccounts.Values)
            {
                if (username == student.tenDangNhapHS && password == student.matKhauHS)
                {
                    InfoStudent infoStudent = new InfoStudent(student);
                    this.Hide();
                    infoStudent.ShowDialog();
                    this.Show();
                    return;
                }
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không chính xác.", "Thông báo");

            }
        }
        public bool checkLogin(string username, string password)
        {
            foreach (var student in studentAccounts.Values)
            {
                if (username == student.tenDangNhapHS && password == student.matKhauHS)
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
