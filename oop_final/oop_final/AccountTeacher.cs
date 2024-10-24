using System;
using System.Collections.Generic;
using System.Linq;
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

        public List<Teacher> teacherAccounts;
        public AccountTeacher()
        {
            teacherAccounts = new List<Teacher>();  
            teacherAccounts.Add(new Teacher { maGV = "GVTOAN", hoVaTen = "Nguyễn Thị Tuyết Nhung", gioiTinh = 0,ngSinh = new DateTime(1990, 5, 15),chucVu= "Giáo viên toán", tenDangNhapGV = "nhungtoan", matKhauGV = "giaovientoan" });
            teacherAccounts.Add(new Teacher { maGV = "GVVAN", hoVaTen = "Trần Ngọc Anh", gioiTinh = 0, ngSinh = new DateTime(1991, 1, 11), chucVu = "Giáo viên ngữ văn", tenDangNhapGV = "anhvan", matKhauGV = "giaovienvan" });
            teacherAccounts.Add(new Teacher { maGV = "GVANH", hoVaTen = "Lê Nguyên Mai Quỳnh", gioiTinh = 0, ngSinh = new DateTime(1994, 1, 21), chucVu = "Giáo viên tiếng anh", tenDangNhapGV = "quynhanh", matKhauGV = "giaovienanh" });
            teacherAccounts.Add(new Teacher { maGV = "GVLY", hoVaTen = "Nguyễn Nhật Ánh", gioiTinh = 0, chucVu = "Giáo viên vật lý", tenDangNhapGV = "anhly", matKhauGV = "giaovienly" });
            teacherAccounts.Add(new Teacher { maGV = "GVHOA", hoVaTen = "Nguyễn Ngọc Thảo Nguyên", gioiTinh = 0, chucVu = "Giáo viên hóa học", ngSinh = new DateTime(1989, 2, 1),tenDangNhapGV = "nguyenhoa", matKhauGV = "giaovienhoa" });
            teacherAccounts.Add(new Teacher { maGV = "GVSINH", hoVaTen = "Nguyễn GiaX  VFDS Huy", gioiTinh = 1, ngSinh = new DateTime(1993, 5, 11), chucVu = "Giáo viên sinh học", tenDangNhapGV = "huysinh", matKhauGV = "giaoviensinh" });
            teacherAccounts.Add(new Teacher { maGV = "GVSU", hoVaTen = "Nguyễn Thành Danh", gioiTinh = 1, ngSinh = new DateTime(1988, 6, 21), chucVu = "Giáo viên lịch sử", tenDangNhapGV = "danhsu", matKhauGV = "giaoviensu" });
            teacherAccounts.Add(new Teacher { maGV = "GVDIA", hoVaTen = "Trần Thị Mỹ Hòa", gioiTinh = 0, ngSinh = new DateTime(1994, 8, 21), chucVu = "Giáo viên địa lý", tenDangNhapGV = "hoadia", matKhauGV = "giaoviendia" });
            teacherAccounts.Add(new Teacher { maGV = "GVGDCD", hoVaTen = "Phạm Mỹ Duyên", gioiTinh = 0, ngSinh = new DateTime(1995, 1, 7), chucVu = "Giáo viên gdcd", tenDangNhapGV = "duyengdcd", matKhauGV = "giaoviengdcd" });
            teacherAccounts.Add(new Teacher { maGV = "GVTIN", hoVaTen = "Lê Huỳnh Mai", gioiTinh = 0, ngSinh = new DateTime(1989, 11, 19), chucVu = "Giáo viên tin học", tenDangNhapGV = "maitin", matKhauGV = "giaovientin" });
            teacherAccounts.Add(new Teacher { maGV = "GVCONGNGHE", hoVaTen = "Phạm Hoàng", gioiTinh = 1, ngSinh = new DateTime(1999, 12, 25), chucVu = "Giáo viên công nghệ", tenDangNhapGV = "hoangcongnghe", matKhauGV = "giaoviencongnghe" });
        }
       
      
    }
}

