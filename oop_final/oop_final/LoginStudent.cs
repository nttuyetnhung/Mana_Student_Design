namespace oop_final
{
    public partial class LoginStudent : Form
    {
        private List<Student> students;

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

            Student matchedStudent = students.Find(student =>
                student.tenDangNhapHS == username &&
                student.matKhauHS == password);

            if (matchedStudent != null)
            {
                Dictionary<string, List<SubjectScore>> scoreboard = CreateScoreboardForStudent(matchedStudent);
                InfoStudent infoStudent = new InfoStudent(matchedStudent, scoreboard);
                this.Hide();
                infoStudent.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không chính xác.", "Thông báo");
            }
        }
        private Dictionary<string, List<SubjectScore>> CreateScoreboardForStudent(Student student)
        {
            var scoreboard = new Dictionary<string, List<SubjectScore>>();
            var subjectScores = new List<SubjectScore>
            {
                student.Math,
                student.Literature,
                student.ForeignLanguage,
                student.Physics,
                student.Chemistry,
                student.Biology,
                student.History,
                student.Geography,
                student.Civics,
                student.IT,
                student.Technology
            };

            scoreboard[student.maHS] = subjectScores;
            return scoreboard;
        }

        public bool checkLogin(string username, string password)
        {
            return students.Exists(student =>
                student.tenDangNhapHS == username &&
                student.matKhauHS == password);

        }
        private void LoginStudent_Load(object sender, EventArgs e)
        {

        }
    }
}
