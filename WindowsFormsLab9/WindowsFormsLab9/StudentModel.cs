using System;

namespace WindowsFormsLab9
{
    public class StudentModel
    {
        public string fIO { get; set; }
        public string studentRecordBook { get; set; }
        public string specification { get; set; }

        public StudentModel() { }

        public StudentModel(string fio, string recordBook, string spec)
        {
            fIO = fio;
            studentRecordBook = recordBook;
            specification = spec;
        }
    }
}