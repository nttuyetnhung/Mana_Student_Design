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
        public Dictionary<string, Student> studentAccounts;

        public AccountStudent()
        {
            studentAccounts = new Dictionary<string, Student>();

            studentAccounts.Add("HS1", new Student { maHS = "HS1", maLop = "10A1", hoVaTen = "Trần Ngọc Mỹ", gioiTinh = 1, tenDangNhapHS = "mytran", matKhauHS = "mytran", ngSinh = new DateTime(2009, 5, 12) });
            studentAccounts.Add("HS2", new Student { maHS = "HS2", maLop = "10A1", hoVaTen = "Nguyễn Thiên Ân", gioiTinh = 0, tenDangNhapHS = "annguyen", matKhauHS = "annguyen", ngSinh = new DateTime(2009, 3, 8) });
            studentAccounts.Add("HS3", new Student { maHS = "HS3", maLop = "10A1", hoVaTen = "Lê An", gioiTinh = 1, tenDangNhapHS = "anle", matKhauHS = "anle", ngSinh = new DateTime(2009, 11, 22) });
            studentAccounts.Add("HS4", new Student { maHS = "HS4", maLop = "10A2", hoVaTen = "Lê Hoàng Phương", gioiTinh = 0, tenDangNhapHS = "phuongle", matKhauHS = "phuongle", ngSinh = new DateTime(2009, 7, 18) });
            studentAccounts.Add("HS5", new Student { maHS = "HS5", maLop = "10A2", hoVaTen = "Nguyễn Thúc Thùy Tiên", gioiTinh = 0, tenDangNhapHS = "tiennguyen", matKhauHS = "tiennguyen", ngSinh = new DateTime(2009, 10, 15) });
            studentAccounts.Add("HS6", new Student { maHS = "HS6", maLop = "10A2", hoVaTen = "Nguyễn Quốc Thiên", gioiTinh = 1, tenDangNhapHS = "thiennguyen", matKhauHS = "thiennguyen", ngSinh = new DateTime(2009, 4, 2) });

            studentAccounts.Add("HS7", new Student { maHS = "HS7", maLop = "11A1", hoVaTen = "Trần Văn Bình", gioiTinh = 1, tenDangNhapHS = "binhtran", matKhauHS = "binhtran", ngSinh = new DateTime(2008, 9, 25) });
            studentAccounts.Add("HS8", new Student { maHS = "HS8", maLop = "11A1", hoVaTen = "Nguyễn Thị Hạnh", gioiTinh = 0, tenDangNhapHS = "hanhnguyen", matKhauHS = "hanhnguyen", ngSinh = new DateTime(2008, 12, 3) });
            studentAccounts.Add("HS9", new Student { maHS = "HS9", maLop = "11A1", hoVaTen = "Lê Quang Huy", gioiTinh = 1, tenDangNhapHS = "huyle", matKhauHS = "huyle", ngSinh = new DateTime(2008, 2, 14) });
            studentAccounts.Add("HS10", new Student { maHS = "HS10", maLop = "11A2", hoVaTen = "Trần Minh Hoàng", gioiTinh = 1, tenDangNhapHS = "hoangtran", matKhauHS = "hoangtran", ngSinh = new DateTime(2008, 6, 9) });
            studentAccounts.Add("HS11", new Student { maHS = "HS11", maLop = "11A2", hoVaTen = "Lê Thị Thu Hà", gioiTinh = 0, tenDangNhapHS = "hale", matKhauHS = "hale", ngSinh = new DateTime(2008, 8, 27) });
            studentAccounts.Add("HS12", new Student { maHS = "HS12", maLop = "11A2", hoVaTen = "Ngô Quang Vinh", gioiTinh = 1, tenDangNhapHS = "vinhngo", matKhauHS = "vinhngo", ngSinh = new DateTime(2008, 11, 16) });

            studentAccounts.Add("HS13", new Student { maHS = "HS13", maLop = "12A1", hoVaTen = "Lê Thị Minh Anh", gioiTinh = 0, tenDangNhapHS = "anhle", matKhauHS = "anhle", ngSinh = new DateTime(2007, 1, 5) });
            studentAccounts.Add("HS14", new Student { maHS = "HS14", maLop = "12A1", hoVaTen = "Nguyễn Văn Hùng", gioiTinh = 1, tenDangNhapHS = "hungnguyen", matKhauHS = "hungnguyen", ngSinh = new DateTime(2007, 3, 11) });
            studentAccounts.Add("HS15", new Student { maHS = "HS15", maLop = "12A1", hoVaTen = "Phạm Thị Quỳnh Như", gioiTinh = 0, tenDangNhapHS = "quynhpham", matKhauHS = "quynhpham", ngSinh = new DateTime(2007, 5, 23) });
            studentAccounts.Add("HS16", new Student { maHS = "HS16", maLop = "12A2", hoVaTen = "Trần Minh Tuấn", gioiTinh = 1, tenDangNhapHS = "tuantran", matKhauHS = "tuantran", ngSinh = new DateTime(2007, 7, 17) });
            studentAccounts.Add("HS17", new Student { maHS = "HS17", maLop = "12A2", hoVaTen = "Lê Thị Hồng", gioiTinh = 0, tenDangNhapHS = "hongle", matKhauHS = "hongle", ngSinh = new DateTime(2007, 9, 30) });
            studentAccounts.Add("HS18", new Student { maHS = "HS18", maLop = "12A2", hoVaTen = "Phạm Quang Anh", gioiTinh = 1, tenDangNhapHS = "anhpham", matKhauHS = "anhpham", ngSinh = new DateTime(2007, 12, 12) });
        }
    }
}
