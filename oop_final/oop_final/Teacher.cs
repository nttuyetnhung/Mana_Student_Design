using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace oop_final
{


    public class Teacher : Person
    {

        public string maGV { get; set; }
        public string chucVu{ get; set; }
        public string tenDangNhapGV { get; set; }
        public string matKhauGV { get; set; }

        public AccountTeacher QuảnLý
        {
            get => default;
            set
            {
            }
        }

        public Teacher ()
        {

        }
        Teacher (string tenDangNhapGV, string matKhauGV)
        {
           this.tenDangNhapGV = tenDangNhapGV;
            this.matKhauGV = matKhauGV;
        }
    }
}
