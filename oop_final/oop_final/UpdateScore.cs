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
                // Thêm các học sinh khác...
            };

            var uniqueClasses = studentAccounts.Select(s => s.maLop).Distinct().ToList();
            comboBox1.Items.AddRange(uniqueClasses.ToArray());
            var uniqueIDs = studentAccounts.Select(s => s.maHS).Distinct().ToList();
            comboBox7.Items.AddRange(uniqueIDs.ToArray());
            var uniqueNames = studentAccounts.Select(s => s.hoVaTen).Distinct().ToList();
            comboBox8.Items.AddRange(uniqueNames.ToArray());

            comboBox3.Items.AddRange(new string[] { "Ky1", "Ky2" });
            comboBox4.Items.AddRange(new string[] { "2023-2024", "2024-2025" });
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
                var student = studentAccounts.FirstOrDefault(s => s.maHS == selectedID);
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
                double diemTBC = (diem15P + diemMieng + diemGiuaKy * 2 + diemCuoiKy * 3) / 7;

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

            var student = studentAccounts.Find(s =>
                s.maLop == selectedClass &&
                s.maHS == selectedID &&
                s.hoVaTen == selectedStudentName);

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
