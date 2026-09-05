using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Lab7
{
    public partial class FormStudents : Form
    {
        DataTable dataTableStudents = new DataTable();
        private List<Student> _students = new List<Student>
        {
            new Student("20230001", "Иванов Иван Иванович", "131а-ПИо", "Институт точных наук и информатики", "Прикладная информатиа (09.03.03)", new DateTime(2023, 8, 31)),
        };
        private List<string> _instituts = new List<string>
        {
            "Институт гуманитарных наук",
            "Институт естественных наук",
            "Институт иностранных языков",
            "Институт культуры и искусства",
            "Институт педагогики и психологии",
            "Институт точных наук и информационных технологий",
            "Институт управления, права и повышения квалификации",
            "Медицинский институт",
            "Институт экономики и финансов",
            "Институт социальных технологий",
            "Институт непрерывного образования"
        };

        private List<string> _instituteHumanitarianSpecialities = new List<string>
        {
            "История (46.03.01)",
            "Документоведение и архивоведение (46.03.02)",
            "Теология (48.03.01)",
            "Философия (47.03.01)",
            "Филология (45.03.01)",
            "Отечественная филология (45.03.01)",
            "Журналистика (42.03.02)",
            "Реклама и связи с общественностью (42.03.01)"
        };

        private List<string> _instituteNaturalSciencesSpecialities = new List<string>
        {
            "Биология (06.03.01)",
            "Экология и природопользование (05.03.06)",
            "Химия (04.03.01)",
            "География (05.03.02)",
            "Картография и геоинформатика (05.03.03)",
            "Туризм (43.03.02)"
        };

        private List<string> _instituteForeignLanguagesSpecialities = new List<string>
        {
            "Лингвистика (45.03.02)",
            "Перевод и переводоведение (45.03.02)",
            "Педагогическое образование (44.03.01) - иностранные языки",
            "Зарубежная филология (45.03.01)"
        };

        private List<string> _instituteCultureArtSpecialities = new List<string>
        {
            "Народная художественная культура (51.03.02)",
            "Дизайн (54.03.01)",
            "Декоративно-прикладное искусство и народные промыслы (54.03.02)",
            "Социально-культурная деятельность (51.03.03)",
            "Библиотечно-информационная деятельность (51.03.06)",
            "Музыкальное искусство эстрады (53.03.01)"
        };

        private List<string> _institutePedagogyPsychologySpecialities = new List<string>
        {
            "Педагогическое образование (44.03.01)",
            "Психолого-педагогическое образование (44.03.02)",
            "Специальное (дефектологическое) образование (44.03.03)",
            "Психология (37.03.01)",
            "Дошкольное образование (44.03.01)"
        };

        private List<string> _instituteExactSciencesITSpecialities = new List<string>
        {
            "Прикладная информатика (09.03.03)",
            "Информационные системы и технологии (09.03.02)",
            "Математика (01.03.01)",
            "Математика и компьютерные науки (02.03.01)",
            "Физика (03.03.02)",
            "Радиофизика (03.03.03)"
        };

        private List<string> _instituteManagementLawSpecialities = new List<string>
        {
            "Юриспруденция (40.03.01)",
            "Государственное и муниципальное управление (38.03.04)",
            "Правовое обеспечение национальной безопасности (40.05.01)",
            "Таможенное дело (38.05.02)"
        };

        private List<string> _medicalInstituteSpecialities = new List<string>
        {
            "Лечебное дело (31.05.01)",
            "Педиатрия (31.05.02)",
            "Стоматология (31.05.03)",
            "Фармация (33.05.01)",
            "Сестринское дело (34.03.01)"
        };

        private List<string> _instituteEconomicsFinanceSpecialities = new List<string>
        {
            "Экономика (38.03.01)",
            "Менеджмент (38.03.02)",
            "Бизнес-информатика (38.03.05)",
            "Управление персоналом (38.03.03)",
            "Финансы и кредит (38.03.01)",
            "Бухгалтерский учет, анализ и аудит (38.03.01)"
        };

        private List<string> _instituteSocialTechnologiesSpecialities = new List<string>
        {
            "Социология (39.03.01)",
            "Социальная работа (39.03.02)",
            "Организация работы с молодежью (39.03.03)",
            "Конфликтология (37.03.02)"
        };

        private List<string> _instituteContinuingEducationSpecialities = new List<string>
        {
            "Педагогическое образование (44.03.01) - различные профили",
            "Дополнительное образование",
            "Программы профессиональной переподготовки"
        };

        public FormStudents()
        {
            InitializeComponent();
            dataTableStudents.Columns.Add("№ студ. билета", typeof(string));
            dataTableStudents.Columns.Add("ФИО", typeof(string));
            dataTableStudents.Columns.Add("Группа", typeof(string));
            dataTableStudents.Columns.Add("Институт", typeof(string));
            dataTableStudents.Columns.Add("Направление", typeof(string));
            dataTableStudents.Columns.Add("Дата зачисления", typeof(string));
            comboBoxInstitut.DataSource = _instituts;
            dateTimePickerDateOfAdmission.MaxDate = DateTime.Now;
            ShowStudent();
        }
        private void ShowStudent()
        {
            foreach (var student in _students)
            {
                dataTableStudents.Rows.Add(student.RecordBook, student.FullName, student.Group, student.Institute, student.Specialty, student.EnrollmentDate.ToString());

            }
            dataGridViewInformationStudents.DataSource = dataTableStudents;
        }
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (InputValidation() == true && InputValidationRecordBook() == true)
            {
                _students.Add(new Student(textBoxRecordBook.Text, textBoxFullName.Text, textBoxGroup.Text, comboBoxInstitut.Text, comboBoxSpecification.Text, dateTimePickerDateOfAdmission.Value));
                dataTableStudents.Clear();
                ShowStudent();
                MessageBox.Show("Студент добавлен!", "Сообщение",
                           MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (dataGridViewInformationStudents.SelectedRows.Count > 0 && InputValidation() == true && InputValidationRecordBook() == true)
            {
                _students[GetPositionOfTheSelectedItemInTheDataSource()] = new Student(textBoxRecordBook.Text, textBoxFullName.Text, textBoxGroup.Text, comboBoxInstitut.Text, comboBoxSpecification.Text, dateTimePickerDateOfAdmission.Value);
                dataTableStudents.Clear();
                ShowStudent();
                MessageBox.Show("Информация о студенте " + _students[GetPositionOfTheSelectedItemInTheDataSource()].FullName + " обновлена!", "Сообщение",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else 
            {
                MessageBox.Show("Выберите студента для редактирования!", "Сообщение",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewInformationStudents.SelectedRows.Count > 0)
            {
                _students.RemoveAt(GetPositionOfTheSelectedItemInTheDataSource());
                dataTableStudents.Clear();
                ShowStudent();
                MessageBox.Show("Студент удален!", "Сообщение",
                       MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else 
            {
                MessageBox.Show("Выберите студента для удаления!", "Сообщение",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void comboBoxInstitut_SelectedValueChanged(object sender, EventArgs e)
        {
            switch (comboBoxInstitut.SelectedIndex)
            {
                case 0:
                    comboBoxSpecification.DataSource = _instituteHumanitarianSpecialities;
                    break;
                case 1:
                    comboBoxSpecification.DataSource = _instituteNaturalSciencesSpecialities;
                    break;
                case 2:
                    comboBoxSpecification.DataSource = _instituteForeignLanguagesSpecialities;
                    break;
                case 3:
                    comboBoxSpecification.DataSource = _instituteCultureArtSpecialities;
                    break;
                case 4:
                    comboBoxSpecification.DataSource = _institutePedagogyPsychologySpecialities;
                    break;
                case 5:
                    comboBoxSpecification.DataSource = _instituteExactSciencesITSpecialities;
                    break;
                case 6:
                    comboBoxSpecification.DataSource = _instituteManagementLawSpecialities;
                    break;
                case 7:
                    comboBoxSpecification.DataSource = _medicalInstituteSpecialities;
                    break;
                case 8: 
                    comboBoxSpecification.DataSource = _instituteEconomicsFinanceSpecialities;
                    break;
                case 9:
                    comboBoxSpecification.DataSource = _instituteSocialTechnologiesSpecialities;
                    break;
                case 10:
                    comboBoxSpecification.DataSource = _instituteContinuingEducationSpecialities;
                    break;
                default:
                    MessageBox.Show("Вы выбрали несуществующий институт", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;
            }
        }
        private int GetPositionOfTheSelectedItemInTheDataSource()
        {
            CurrencyManager cm = (CurrencyManager)this.BindingContext[dataGridViewInformationStudents.DataSource];
            return cm.Position;
        }

        private void dataGridViewInformationStudents_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewInformationStudents.SelectedRows.Count > 0)
            {
                textBoxRecordBook.Text = _students[GetPositionOfTheSelectedItemInTheDataSource()].RecordBook;
                textBoxFullName.Text = _students[GetPositionOfTheSelectedItemInTheDataSource()].FullName;
                textBoxGroup.Text = _students[GetPositionOfTheSelectedItemInTheDataSource()].Group;
                comboBoxInstitut.Text = _students[GetPositionOfTheSelectedItemInTheDataSource()].Institute;
                comboBoxSpecification.Text = _students[GetPositionOfTheSelectedItemInTheDataSource()].Specialty;
                dateTimePickerDateOfAdmission.Text = _students[GetPositionOfTheSelectedItemInTheDataSource()].EnrollmentDate.ToString();
            }
            else
            {
                textBoxRecordBook.Text = "";
                textBoxFullName.Text = "";
                textBoxGroup.Text = "";
                dateTimePickerDateOfAdmission.Text = "";
            }
        }

        private void textBoxRecordBook_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBoxFullName_KeyPress(object sender, KeyPressEventArgs e)
        {
            string allowedChars = " абвгдеёжзийклмнопрстуфхцчшщъыьэюяАБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ-`";

            if (!allowedChars.Contains(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBoxGroup_KeyPress(object sender, KeyPressEventArgs e)
        {
            string allowedChars = "абвгдеёжзийклмнопрстуфхцчшщъыьэюяАБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ-";

            if (!allowedChars.Contains(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        public bool InputValidation() 
        { 
            if(textBoxRecordBook.Text.Length == 0 || textBoxFullName.Text.Length == 0 || textBoxGroup.Text.Length == 0)
            {
                MessageBox.Show("Заполниете все текстовые поля!", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            return true;
        }
        public bool InputValidationRecordBook()
        {
            for (int i = 0; i < _students.Count; i++)
            {
                if (_students[i].RecordBook == textBoxRecordBook.Text)
                {
                    MessageBox.Show("Номера студенчсеких билетов повторяться не могут!", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }
            }
            return true;
        }

    }
}