using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Lab7
{
    public partial class Form1 : Form, IStudentView
    {
        // Поля для реализации интерфейса IStudentView
        public string FullName { get => textBoxFullName.Text; set => textBoxFullName.Text = value; }
        public string RecordBook { get => textBoxRecordBook.Text; set => textBoxRecordBook.Text = value; }
        public string Group { get => textBoxGroup.Text; set => textBoxGroup.Text = value; }
        public string Date_of_admission { get => dateTimePickerDateOfAdmission.Value.ToString("dd.MM.yyyy"); set => dateTimePickerDateOfAdmission.Value = DateTime.Parse(value); }
        public int Id { get; set; }
        public bool IsEdit { get; set; }
        public bool IsSuccessful { get; set; }

        // Свойства для получения ID из ComboBox
        public int SelectedDepartmentId => comboBoxDepartment.SelectedValue is int id ? id : 0;
        public int SelectedSpecificationId => comboBoxSpecification.SelectedValue is int id ? id : 0;

        // События
        public event EventHandler AddEvent;
        public event EventHandler EditEvent;
        public event EventHandler DeleteEvent;
        public event EventHandler SaveEvent;
        public event EventHandler CancelEvent;
        public event EventHandler DepartmentChanged;

        public Form1()
        {
            InitializeComponent();
            AssociateAndRaiseEvents();
        }

        // Привязка UI-событий (нажатий кнопок) к событиям интерфейса
        private void AssociateAndRaiseEvents()
        {
            // Кнопки
            buttonAdd.Click += (s, e) => AddEvent?.Invoke(this, EventArgs.Empty);
            buttonEdit.Click += (s, e) => EditEvent?.Invoke(this, EventArgs.Empty);
            buttonDelete.Click += (s, e) => DeleteEvent?.Invoke(this, EventArgs.Empty);
            buttonSave.Click += (s, e) => SaveEvent?.Invoke(this, EventArgs.Empty);
            buttonCancel.Click += (s, e) => CancelEvent?.Invoke(this, EventArgs.Empty);

            // Магия связанных списков: при выборе Института уведомляем Презентер
            comboBoxDepartment.SelectedIndexChanged += (s, e) =>
            {
                if (comboBoxDepartment.SelectedValue is int)
                    DepartmentChanged?.Invoke(this, EventArgs.Empty);
            };
        }

        // Методы для заполнения данных из Презентера
        public void SetStudentListBindingSource(BindingSource studentList)
        {
            dataGridViewInformationStudents.DataSource = studentList;

            // Настройка колонок (скрываем ненужные ID, если нужно)
            if (dataGridViewInformationStudents.Columns["Id"] != null)
                dataGridViewInformationStudents.Columns["Id"].Visible = false;
        }

        public void SetDepartmentList(IEnumerable<DepartmentModel> departments)
        {
            comboBoxDepartment.DataSource = departments;
            comboBoxDepartment.DisplayMember = "Name"; // Что видит пользователь
            comboBoxDepartment.ValueMember = "Id";      // Что получает код (ID)
        }

        public void SetSpecificationList(IEnumerable<SpecificationModel> specifications)
        {
            comboBoxSpecification.DataSource = specifications;
            comboBoxSpecification.DisplayMember = "Name";
            comboBoxSpecification.ValueMember = "Id";
        }
    }
}