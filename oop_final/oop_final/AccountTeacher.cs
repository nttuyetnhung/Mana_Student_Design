using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace oop_final
{
    public class AccountTeacher 
    {
        
        
        public static AccountTeacher instance ;
        public static AccountTeacher Instance
        { get
            {
                if (instance == null)
                    instance = new AccountTeacher();
           
             return instance ; 
            } 
            set { instance = value ; }
        }

        private Dictionary<string, Teacher> teacherAccounts;

        private AccountTeacher()
        {
            teacherAccounts = new Dictionary<string, Teacher>();
            AddTeacher(new Teacher
            {
                maGV = "GVTOAN",
                hoVaTen = "Nguyễn Thị Tuyết Nhung",
                gioiTinh = 0,
                ngSinh = new DateTime(1990, 5, 15),
                chucVu = "Giáo viên toán",
                tenDangNhapGV = "nhungtoan",
                matKhauGV = "giaovientoan"
            });
            AddTeacher(new Teacher
            {
                maGV = "GVHOA",
                hoVaTen = "Trần Văn Hùng",
                gioiTinh = 1,
                ngSinh = new DateTime(1985, 8, 20),
                chucVu = "Giáo viên hóa",
                tenDangNhapGV = "hunghoa",
                matKhauGV = "giaovienHoa"
            });
            AddTeacher(new Teacher
            {
                maGV = "GVAN",
                hoVaTen = "Lê Thị Bích Ngọc",
                gioiTinh = 0,
                ngSinh = new DateTime(1992, 3, 10),
                chucVu = "Giáo viên anh văn",
                tenDangNhapGV = "ngocanh",
                matKhauGV = "giaovienAnh"
            });
        }

        private void AddTeacher(Teacher teacher)
        {
            teacherAccounts[teacher.tenDangNhapGV] = teacher;
        }

        public Teacher GetTeacherByUsername(string username)
        {
            if (teacherAccounts.ContainsKey(username))
                return teacherAccounts[username];
            return null;
        }
    }
}

