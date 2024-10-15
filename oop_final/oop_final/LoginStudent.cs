namespace oop_final
{
    public partial class LoginStudent : Form
    {
        public LoginStudent()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            InfoStudent f = new InfoStudent();
            this.Hide();
            f.ShowDialog();
            this.Show();
           
        }
        private void btnStudentExit_Click(object sender, EventArgs e)
        {
            Login f = new Login();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

       

        private void LoginStudent_Load(object sender, EventArgs e)
        {

        }
    }
}
