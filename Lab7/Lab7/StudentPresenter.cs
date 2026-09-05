using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Lab7
{
    public class StudentPresenter
    {
        private IStudentView _view;
        private IStudentRepository _repository;
        private BindingSource _studentBindingSource;
        private IEnumerable<StudentModel> _studentList;

        public StudentPresenter(IStudentView view, IStudentRepository repository)
        {
            this._view = view;
            this._repository = repository;
            this._studentBindingSource = new BindingSource();

            // Подписки на события View
            this._view.AddEvent += AddStudent;
            this._view.EditEvent += LoadSelectedStudent;
            this._view.DeleteEvent += DeleteStudent;
            this._view.SaveEvent += SaveStudent;

            // Новое событие для работы ComboBox (выбор института)
            this._view.DepartmentChanged += OnDepartmentChanged;

            // Инициализация данных при запуске
            LoadAllStudentList();
            LoadInitialComboboxData();

            // Привязываем источник данных к таблице во View
            this._view.SetStudentListBindingSource(_studentBindingSource);
        }

        // 1. Загрузка всех студентов в таблицу
        private void LoadAllStudentList()
        {
            _studentList = _repository.GetAll();
            _studentBindingSource.DataSource = _studentList;
        }

        // 2. Начальная загрузка первого ComboBox (Институты)
        private void LoadInitialComboboxData()
        {
            var departments = _repository.GetDepartments();
            _view.SetDepartmentList(departments);
        }

        // 3. Логика каскадного ComboBox: когда выбрали Институт, грузим его Направления
        private void OnDepartmentChanged(object sender, EventArgs e)
        {
            int selectedDeptId = _view.SelectedDepartmentId;
            var specifications = _repository.GetSpecificationsByDept(selectedDeptId);

            // Передаем список направлений во второй ComboBox
            _view.SetSpecificationList(specifications);
        }

        private void AddStudent(object sender, EventArgs e)
        {
            _view.IsEdit = false;
            // Очистка полей во View через интерфейс
        }

        private void LoadSelectedStudent(object sender, EventArgs e)
        {
            var student = (StudentModel)_studentBindingSource.Current;
            _view.Id = student.Id;
            _view.FullName = student.FullName;
            _view.RecordBook = student.RecordBook;
            _view.Group = student.Group;
            // Устанавливаем значения в ComboBox по ID
            // _view.SelectedDepartmentId = student.Department;
            _view.IsEdit = true;
        }

        private void SaveStudent(object sender, EventArgs e)
        {
            var model = new StudentModel
            {
                Id = _view.Id,
                FullName = _view.FullName,
                RecordBook = _view.RecordBook,
                Group = _view.Group,
                Department = _view.SelectedDepartmentId, // ID из ComboBox
                Specification = _view.SelectedSpecificationId, // ID из ComboBox
                Date_of_admission = _view.Date_of_admission
            };

            try
            {
                if (_view.IsEdit)
                    _repository.Edit(model);
                else
                    _repository.Add(model);

                LoadAllStudentList(); // Обновляем таблицу
                _view.IsSuccessful = true;
            }
            catch (Exception ex)
            {
                _view.IsSuccessful = false;
                MessageBox.Show(ex.Message);
            }
        }

        private void DeleteStudent(object sender, EventArgs e)
        {
            try
            {
                var student = (StudentModel)_studentBindingSource.Current;
                _repository.Delete(student.Id);
                LoadAllStudentList();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка удаления: " + ex.Message);
            }
        }
    }
}