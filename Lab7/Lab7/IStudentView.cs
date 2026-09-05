using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab7
{
    public interface IStudentView
    {
        int Id { get; set; }
        string FullName { get; set; }
        string RecordBook { get; set; }
        string Group {  get; set; }
        int Department {  get; set; }
        int Specification { get; set; }
        string Date_of_admission {  get; set; }
        bool IsEdit { get; set; }
        bool IsSuccessful { get; set; }
        event EventHandler AddEvent;
        event EventHandler EditEvent;
        event EventHandler DeleteEvent;
        event EventHandler SaveEvent;
        event EventHandler CancelEvent;
        void SetStudentListBindingSource(BindingSource source);
        void SetDepartments(IEnumerable<DepartmentModel> list);
        void SetSpecifications(IEnumerable<SpecificationModel> list);
    }
}
