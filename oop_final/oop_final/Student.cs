using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_final
{
    public class Student: Person
    {
        public string maHS { get; set; }
        public string maLop { get; set; }
        public string tenDangNhapHS { get; set; }
        public string matKhauHS{ get; set; }

        public Student()
        {

        }
        Student(string tenDangNhapHS, string matKhauHS)
        {
            this.tenDangNhapHS = tenDangNhapHS;
            this.matKhauHS = matKhauHS;
        }
    }
}
