using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_final
{
    public class SubjectScore
    {
        public string MaMon { get; set; }
        public string TenMon { get; set; }
        public double DiemMieng { get; set; }
        public double Diem15Phut { get; set; }
        public double DiemGiuaKi { get; set; }
        public double DiemCuoiKi { get; set; }
        public double DiemTBM
        {
            get
            {
                return (DiemMieng + Diem15Phut + DiemGiuaKi * 2 + DiemCuoiKi * 3) / 7;
            }
        }
    }
}
