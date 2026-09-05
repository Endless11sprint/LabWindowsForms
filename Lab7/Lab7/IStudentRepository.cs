using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7
{
    public interface IStudentRepository
    {
        void Add(StudentModel studentModel);
        void Edit(StudentModel studentModel);
        void Delete(int id);
        IEnumerable<StudentModel> GetAll();

        IEnumerable<DepartmentModel> GetDepartments();
        IEnumerable<SpecificationModel> GetSpecifications(int deptId);
    }
}
