using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Lab7
{
    public class StudentModel
    {
        private int _id;
        private string _fullNaame;
        private string _recordBook;
        private string _group;
        private int _department;
        private int _specification;
        private string _date_of_admission;
        public int Id
        {
            get => _id; set => _id = value;
        }
        public string FullName
        {
            get => _fullNaame; set => _fullNaame = value;
        }
        public string RecordBook
        {
            get => _recordBook; set => _recordBook = value;
        }
        public string Group
        {
            get => _group; set => _group = value;
        }
        public int Department
        {
            get => _department; set => _department = value;
        }
        public int Specification
        {
            get => _specification; set => _specification = value;
        }
        public string Date_of_admission
        {
            get => _date_of_admission; set => _date_of_admission = value;
        }
    }

}
