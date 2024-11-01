using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oop_final
{
    public partial class UpdateScore : Form
    {
        private ListView listViewScores;

        public UpdateScore()
        {
            InitializeComponent();
            InitializeData();
            comboBox7.SelectedIndexChanged += ComboBox7_SelectedIndexChanged;
        }

        private void btnExitScore_Click(object sender, EventArgs e)
        {
            InfoTeacher f = new InfoTeacher();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void UpdateScore_Load(object sender, EventArgs e)
        {
        }

        List<Student> studentAccounts;

        private void InitializeData()
        {
            studentAccounts = new List<Student>
            {
                new Student { maHS = "HS1", maLop = "10A1", hoVaTen = "Trần Ngọc Mỹ", gioiTinh = 0, tenDangNhapHS = "mytran", matKhauHS = "mytran" },
                new Student { maHS = "HS2", maLop = "10A1", hoVaTen = "Nguyễn Thiên Ân", gioiTinh = 0, tenDangNhapHS = "annguyen", matKhauHS = "annguyen" },
                new Student { maHS = "HS3", maLop = "10A1", hoVaTen = "Lê An", gioiTinh = 1, tenDangNhapHS = "anle", matKhauHS = "anle" },
            };

            // Tạo danh sách các lớp duy nhất
            List<string> uniqueClasses = new List<string>();
            foreach (Student s in studentAccounts)
            {
                if (!uniqueClasses.Contains(s.maLop))
                {
                    uniqueClasses.Add(s.maLop);
                }
            }
            comboBox1.Items.AddRange(uniqueClasses.ToArray());

            // Tạo danh sách các mã học sinh (IDs) duy nhất
            List<string> uniqueIDs = new List<string>();
            foreach (Student s in studentAccounts)
            {
                if (!uniqueIDs.Contains(s.maHS))
                {
                    uniqueIDs.Add(s.maHS);
                }
            }
            comboBox7.Items.AddRange(uniqueIDs.ToArray());

            // Tạo danh sách các tên học sinh duy nhất
            List<string> uniqueNames = new List<string>();
            foreach (Student s in studentAccounts)
            {
                if (!uniqueNames.Contains(s.hoVaTen))
                {
                    uniqueNames.Add(s.hoVaTen);
                }
            }
            comboBox8.Items.AddRange(uniqueNames.ToArray());


            comboBox3.Items.AddRange(new string[] { "Kỳ 1", "Kỳ 2" });
            comboBox4.Items.AddRange(new string[] { "2023-2024"});
            comboBox2.Items.AddRange(new string[]
            {
                "Toán Học", "Ngữ Văn", "Ngoại Ngữ", "Vật Lý", "Hóa học", "Sinh Học",
                "Lịch Sử", "Địa Lý", "GDCD", "Tin Học", "Công Nghệ"
            });
        }

        private void ComboBox7_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedID = comboBox7.SelectedItem?.ToString();

            if (!string.IsNullOrEmpty(selectedID))
            {
                Student student = null;
                foreach (Student s in studentAccounts)
                {
                    if (s.maHS == selectedID)
                    {
                        student = s;
                        break;
                    }
                }

                if (student != null)
                {
                    comboBox8.Text = student.hoVaTen;
                }
            }
        }

        private void btnSaveSc_Click(object sender, EventArgs e)
        {
            if (listView1.Items.Count > 0)
            {
                string selectedID = comboBox7.Text;

                // Lấy dữ liệu điểm từ các TextBox
                double.TryParse(txb2.Text, out double diem15P);
                double.TryParse(txb1.Text, out double diemMieng);
                double.TryParse(txb3.Text, out double diemGiuaKy);
                double.TryParse(txb4.Text, out double diemCuoiKy);

                // Tính điểm trung bình
                double diemTBC = Math.Round((diem15P + diemMieng + diemGiuaKy * 2 + diemCuoiKy * 3) / 7, 2);
                // Cập nhật các cột điểm trong ListView
                foreach (ListViewItem item in listView1.Items)
                {
                    if (item.SubItems[1].Text == selectedID)
                    {
                        item.SubItems[3].Text = diemMieng.ToString();
                        item.SubItems[4].Text = diem15P.ToString();
                        item.SubItems[5].Text = diemGiuaKy.ToString();
                        item.SubItems[6].Text = diemCuoiKy.ToString();
                        item.SubItems[7].Text = diemTBC.ToString();
                        break;
                    }
                }

                MessageBox.Show("Lưu điểm thành công!");
            }
            else
            {
                MessageBox.Show("Không có dữ liệu để lưu.");
            }
        }

        private void btnSearchUpdate_Click(object sender, EventArgs e)
        {
            string selectedClass = comboBox1.Text;
            string selectedID = comboBox7.Text;
            string selectedStudentName = comboBox8.Text;

            Student student = null;
            foreach (Student s in studentAccounts)
            {
                if (s.maLop == selectedClass && s.maHS == selectedID && s.hoVaTen == selectedStudentName)
                {
                    student = s;
                    break;
                }
            }


            if (student != null)
            {
                // Xóa dữ liệu cũ trong ListView
                listView1.Items.Clear();
                var item = new ListViewItem(new string[]
                {
                    "1", // STT
                    student.maHS,
                    student.hoVaTen,
                    "",  // Điểm miệng
                    "",  // Điểm 15p
                    "",  // Điểm giữa kỳ
                    "",  // Điểm cuối kỳ
                    ""   // Điểm TBC
                });
                listView1.Items.Add(item);
            }
            else
            {
                MessageBox.Show("Không tìm thấy học sinh");
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
