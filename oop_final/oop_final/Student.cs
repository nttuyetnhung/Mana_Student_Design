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
        public double MathScore { get; set; }
        public double LiteratureScore { get; set; }
        public double ForeignLanguageScore { get; set; }
        public double PhysicsScore { get; set; }
        public double ChemistryScore { get; set; }
        public double BiologyScore { get; set; }
        public double HistoryScore { get; set; }
        public double GeographyScore { get; set; }
        public double CivicsScore { get; set; }
        public double ITScore { get; set; }
        public double TechnologyScore { get; set; }

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
