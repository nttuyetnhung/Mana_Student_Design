using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_final
{
    public class AccountStudent
    {
        public static AccountStudent instance;
        public static AccountStudent Instance
        {
            get
            {
                if (instance == null)
                    instance = new AccountStudent();

                return instance;
            }
            set { instance = value; }
        }

        public List<Student> studentAccounts;
        public AccountStudent()
        {
            studentAccounts = new List<Student>();
            studentAccounts.Add(new Student { maHS = "HS1", maLop = "10A1", hoVaTen = "Trần Ngọc Mỹ", gioiTinh = 0, tenDangNhapHS = "mytran", matKhauHS = "mytran" });
            studentAccounts.Add(new Student { maHS = "HS2", maLop = "10A1", hoVaTen = "Nguyễn Thiên Ân", gioiTinh = 0, tenDangNhapHS = "annguyen", matKhauHS = "annguyen" });
            studentAccounts.Add(new Student { maHS = "HS3", maLop = "10A1", hoVaTen = "Lê An", gioiTinh = 1, tenDangNhapHS = "anle", matKhauHS = "anle" });
            studentAccounts.Add(new Student { maHS = "HS4", maLop = "10A1", hoVaTen = "Lê Hoàng Phương", gioiTinh = 0, tenDangNhapHS = "phuongle", matKhauHS = "phuongle" });
            studentAccounts.Add(new Student { maHS = "HS5", maLop = "10A1", hoVaTen = "Nguyễn Thúc Thùy Tiên", gioiTinh = 0, tenDangNhapHS = "tiennguyen", matKhauHS = "tiennguyen" });
            studentAccounts.Add(new Student { maHS = "HS6", maLop = "10A1", hoVaTen = "Nguyễn Quốc Thiên", gioiTinh = 1, tenDangNhapHS = "thiennguyen", matKhauHS = "thiennguyen" });
            studentAccounts.Add(new Student { maHS = "HS7", maLop = "11A1", hoVaTen = "Trần Văn Bình", gioiTinh = 1, tenDangNhapHS = "binhtran", matKhauHS = "binhtran" });
            studentAccounts.Add(new Student { maHS = "HS8", maLop = "11A1", hoVaTen = "Nguyễn Thị Hạnh", gioiTinh = 0, tenDangNhapHS = "hanhnguyen", matKhauHS = "hanhnguyen" });
            studentAccounts.Add(new Student { maHS = "HS9", maLop = "11A1", hoVaTen = "Lê Quang Huy", gioiTinh = 1, tenDangNhapHS = "huyle", matKhauHS = "huyle" });
            studentAccounts.Add(new Student { maHS = "HS10", maLop = "11A1", hoVaTen = "Trần Minh Hoàng", gioiTinh = 1, tenDangNhapHS = "hoangtran", matKhauHS = "hoangtran" });
            studentAccounts.Add(new Student { maHS = "HS11", maLop = "11A1", hoVaTen = "Lê Thị Thu Hà", gioiTinh = 0, tenDangNhapHS = "hale", matKhauHS = "hale" });
            studentAccounts.Add(new Student { maHS = "HS12", maLop = "11A1", hoVaTen = "Ngô Quang Vinh", gioiTinh = 1, tenDangNhapHS = "vinhngo", matKhauHS = "vinhngo" });
            studentAccounts.Add(new Student { maHS = "HS13", maLop = "12A1", hoVaTen = "Lê Thị Minh Anh", gioiTinh = 0, tenDangNhapHS = "anhle", matKhauHS = "anhle" });
            studentAccounts.Add(new Student { maHS = "HS14", maLop = "12A1", hoVaTen = "Nguyễn Văn Hùng", gioiTinh = 1, tenDangNhapHS = "hungnguyen", matKhauHS = "hungnguyen" });
            studentAccounts.Add(new Student { maHS = "HS15", maLop = "12A1", hoVaTen = "Phạm Thị Quỳnh Như", gioiTinh = 0, tenDangNhapHS = "quynhpham", matKhauHS = "quynhpham" });
            studentAccounts.Add(new Student { maHS = "HS16", maLop = "12A1", hoVaTen = "Trần Minh Tuấn", gioiTinh = 1, tenDangNhapHS = "tuantran", matKhauHS = "tuantran" });
            studentAccounts.Add(new Student { maHS = "HS17", maLop = "12A1", hoVaTen = "Lê Thị Hồng", gioiTinh = 0, tenDangNhapHS = "hongle", matKhauHS = "hongle" });
            studentAccounts.Add(new Student { maHS = "HS18", maLop = "12A1", hoVaTen = "Phạm Quang Anh", gioiTinh = 1, tenDangNhapHS = "anhpham", matKhauHS = "anhpham" });

        }
    }
}
