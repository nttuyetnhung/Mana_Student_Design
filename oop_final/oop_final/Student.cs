using System;
using System.Collections.Generic;
using System.Xml.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Json.Serialization;

namespace oop_final
{
    [Serializable]

    public class Student: Person
    {
        [JsonPropertyName("maHS")]
        public string maHS { get; set; }
        [JsonPropertyName("maLop")]
        public string maLop { get; set; }
        [JsonPropertyName("tenDangNhapHS")]
        public string tenDangNhapHS { get; set; }
        [JsonPropertyName("matKhauHS")]
        public string matKhauHS{ get; set; }

        // Điểm trung bình các môn
        private float mathScore;
        private float literatureScore;
        private float foreignLanguageScore;
        private float physicsScore;
        private float chemistryScore;
        private float biologyScore;
        private float historyScore;
        private float geographyScore;
        private float civicsScore;
        private float itScore;
        private float technologyScore;

        // Properties với getter và setter
        public float MathScore
        {
            get { return mathScore; }
            set { mathScore = value; }
        }

        public float LiteratureScore
        {
            get { return literatureScore; }
            set { literatureScore = value; }
        }

        public float ForeignLanguageScore
        {
            get { return foreignLanguageScore; }
            set { foreignLanguageScore = value; }
        }

        public float PhysicsScore
        {
            get { return physicsScore; }
            set { physicsScore = value; }
        }

        public float ChemistryScore
        {
            get { return chemistryScore; }
            set { chemistryScore = value; }
        }

        public float BiologyScore
        {
            get { return biologyScore; }
            set { biologyScore = value; }
        }

        public float HistoryScore
        {
            get { return historyScore; }
            set { historyScore = value; }
        }

        public float GeographyScore
        {
            get { return geographyScore; }
            set { geographyScore = value; }
        }

        public float CivicsScore
        {
            get { return civicsScore; }
            set { civicsScore = value; }
        }

        public float ITScore
        {
            get { return itScore; }
            set { itScore = value; }
        }

        public float TechnologyScore
        {
            get { return technologyScore; }
            set { technologyScore = value; }
        }
        // Chi tiết điểm từng môn
        public SubjectScore Math { get; set; }
        public SubjectScore Literature { get; set; }
        public SubjectScore ForeignLanguage { get; set; }
        public SubjectScore Physics { get; set; }
        public SubjectScore Chemistry { get; set; }
        public SubjectScore Biology { get; set; }
        public SubjectScore History { get; set; }
        public SubjectScore Geography { get; set; }
        public SubjectScore Civics { get; set; }
        public SubjectScore IT { get; set; }
        public SubjectScore Technology { get; set; }


        public Student()
        {
            // Khởi tạo các đối tượng SubjectScore
            Math = new SubjectScore { MaMon = "MATH", TenMon = "Toán học" };
            Literature = new SubjectScore { MaMon = "LIT", TenMon = "Ngữ văn" };
            ForeignLanguage = new SubjectScore { MaMon = "ENG", TenMon = "Ngoại ngữ" };
            Physics = new SubjectScore { MaMon = "PHY", TenMon = "Vật lý" };
            Chemistry = new SubjectScore { MaMon = "CHEM", TenMon = "Hóa học" };
            Biology = new SubjectScore { MaMon = "BIO", TenMon = "Sinh học" };
            History = new SubjectScore { MaMon = "HIS", TenMon = "Lịch sử" };
            Geography = new SubjectScore { MaMon = "GEO", TenMon = "Địa lý" };
            Civics = new SubjectScore { MaMon = "CIV", TenMon = "GDCD" };
            IT = new SubjectScore { MaMon = "IT", TenMon = "Tin học" };
            Technology = new SubjectScore { MaMon = "TECH", TenMon = "Công nghệ" };

        }
        Student(string tenDangNhapHS, string matKhauHS)
        {
            this.tenDangNhapHS = tenDangNhapHS;
            this.matKhauHS = matKhauHS;
        }
    }
}
