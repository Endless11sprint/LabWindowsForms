using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Lab7
{
    internal class Student
    {
        private string _recordBook;
        private string _fullName;
        private string _group;
        private string _institute;
        private string _specialty;
        private DateTime _enrollmentDate;
        public Student(string recordBook, string fullName, string group, string institute, string specialty, DateTime enrollmentDate)
        {
            _recordBook = recordBook;
            _fullName = fullName;
            _group = group;
            _institute = institute;
            _specialty = specialty;
            _enrollmentDate = enrollmentDate;
        }

        public string RecordBook
        {
            get => _recordBook;
            set => _recordBook = value;
        }
        public string FullName
        {
            get => _fullName;
            set => _fullName = value;
        }
        public string Group
        {
            get => _group;
            set => _group = value;
        }
        public string Institute
        {
            get => _institute;
            set => _institute = value;
        }
        public string Specialty
        {
            get => _specialty;
            set => _specialty = value;
        }
        public DateTime EnrollmentDate
        {
            get => _enrollmentDate;
            set => _enrollmentDate = value;
        }
    }
}
