using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Xml.Serialization;

namespace WindowsFormsLab9
{
    public partial class Form1 : Form
    {
        private List<StudentModel> _students = new List<StudentModel>();
        public Form1()
        {
            InitializeComponent();
            SetupListView();
            InitializeDefaultData();
        }
        private void InitializeDefaultData()
        {
            comboboxSpecification.Items.Clear();
            comboboxSpecification.Items.AddRange(new string[] {
                "Прикладная математика",
                "Прикладная информатика",
                "Информационная безопасность"
            });
            comboboxSpecification.SelectedIndex = 0;
            comboboxTypeFille.Items.Clear();
            comboboxTypeFille.Items.AddRange(new string[] { "JSON", "XML" });
            comboboxTypeFille.SelectedIndex = 0;
            _students.Add(new StudentModel("Иванов Иван Иванович", "20230001", "Прикладная информатика"));
            _students.Add(new StudentModel("Петрова Дарья Сергеевна", "20230002", "Прикладная информатика"));
            UpdateListView();
        }

        private void SetupListView()
        {
            listViewStudent.View = View.Details;
            listViewStudent.FullRowSelect = true;
            listViewStudent.GridLines = true;
            listViewStudent.Columns.Clear();
            listViewStudent.Columns.Add("ФИО", 180);
            listViewStudent.Columns.Add("Зачетка", 100);
            listViewStudent.Columns.Add("Направление", 180);
        }
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxFIO.Text) || string.IsNullOrWhiteSpace(textBoxStudentRecordBook.Text))
            {
                MessageBox.Show("Заполните все поля!");
                return;
            }
            var student = new StudentModel(
                textBoxFIO.Text,
                textBoxStudentRecordBook.Text,
                comboboxSpecification.Text
            );
            _students.Add(student);
            UpdateListView();
            ClearInputs();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (listViewStudent.SelectedIndices.Count > 0)
            {
                int index = listViewStudent.SelectedIndices[0];
                _students.RemoveAt(index);
                UpdateListView();
            }
            else
            {
                MessageBox.Show("Выберите студента для удаления!");
            }
        }
        private void buttonDonwnload_Click(object sender, EventArgs e)
        {
            if (comboboxTypeFille.SelectedItem == null) return;
            string format = comboboxTypeFille.Text;
            string fileName = Path.Combine(Application.StartupPath, $"students.{format.ToLower()}");

            try
            {
                if (format == "JSON")
                {
                    string json = JsonConvert.SerializeObject(_students, Formatting.Indented);
                    File.WriteAllText(fileName, json);
                }
                else if (format == "XML")
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(List<StudentModel>));
                    using (StreamWriter sw = new StreamWriter(fileName))
                    {
                        serializer.Serialize(sw, _students);
                    }
                }
                MessageBox.Show($"Файл успешно создан по пути:\n{fileName}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка сохранения: {ex.Message}");
            }
        }
        private void buttonUpload_Click(object sender, EventArgs e)
        {
            if (comboboxTypeFille.SelectedItem == null) return;

            string format = comboboxTypeFille.Text;
            string fileName = Path.Combine(Application.StartupPath, $"students.{format.ToLower()}");

            if (!File.Exists(fileName))
            {
                MessageBox.Show($"Файл {fileName} не найден! Сначала нажмите 'Download', чтобы создать его.");
                return;
            }

            try
            {
                if (format == "JSON")
                {
                    string json = File.ReadAllText(fileName);
                    _students = JsonConvert.DeserializeObject<List<StudentModel>>(json);
                }
                else if (format == "XML")
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(List<StudentModel>));
                    using (StreamReader sr = new StreamReader(fileName))
                    {
                        _students = (List<StudentModel>)serializer.Deserialize(sr);
                    }
                }
                UpdateListView();
                MessageBox.Show("Данные успешно загружены из файла!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки: {ex.Message}");
            }
        }
        private void UpdateListView()
        {
            listViewStudent.Items.Clear();
            foreach (var s in _students)
            {
                var item = new ListViewItem(new[] { s.fIO, s.studentRecordBook, s.specification });
                listViewStudent.Items.Add(item);
            }
        }
        private void ClearInputs()
        {
            textBoxFIO.Clear();
            textBoxStudentRecordBook.Clear();
            if (comboboxSpecification.Items.Count > 0)
            {
                comboboxSpecification.SelectedIndex = 0;    
            }
        }
    }
}