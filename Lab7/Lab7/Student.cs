using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public string RecordBook { get; set; }
        public string FullName { get; set; }
        public string Group { get; set; }
        public string Institute { get; set; }
        public string Specialty { get; set; }
        public DateTime EnrollmentDate { get; set; }

    }
}
