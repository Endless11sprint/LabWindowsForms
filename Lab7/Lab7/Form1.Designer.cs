namespace Lab7
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridViewInformationStudents = new System.Windows.Forms.DataGridView();
            this.textBoxRecordBook = new System.Windows.Forms.TextBox();
            this.textBoxFullName = new System.Windows.Forms.TextBox();
            this.comboBoxDepartment = new System.Windows.Forms.ComboBox();
            this.dateTimePickerDateOfAdmission = new System.Windows.Forms.DateTimePicker();
            this.comboBoxSpecification = new System.Windows.Forms.ComboBox();
            this.labelRecordBook = new System.Windows.Forms.Label();
            this.labelBoxFullName = new System.Windows.Forms.Label();
            this.labelBoxDepartment = new System.Windows.Forms.Label();
            this.labelSpecification = new System.Windows.Forms.Label();
            this.labelPickerDateOfAdmission = new System.Windows.Forms.Label();
            this.labelGroup = new System.Windows.Forms.Label();
            this.textBoxGroup = new System.Windows.Forms.TextBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInformationStudents)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewInformationStudents
            // 
            this.dataGridViewInformationStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewInformationStudents.Location = new System.Drawing.Point(1, -1);
            this.dataGridViewInformationStudents.Name = "dataGridViewInformationStudents";
            this.dataGridViewInformationStudents.RowHeadersWidth = 51;
            this.dataGridViewInformationStudents.RowTemplate.Height = 24;
            this.dataGridViewInformationStudents.Size = new System.Drawing.Size(1014, 374);
            this.dataGridViewInformationStudents.TabIndex = 0;
            // 
            // textBoxRecordBook
            // 
            this.textBoxRecordBook.Location = new System.Drawing.Point(12, 406);
            this.textBoxRecordBook.Name = "textBoxRecordBook";
            this.textBoxRecordBook.Size = new System.Drawing.Size(150, 22);
            this.textBoxRecordBook.TabIndex = 1;
            // 
            // textBoxFullName
            // 
            this.textBoxFullName.Location = new System.Drawing.Point(12, 454);
            this.textBoxFullName.Name = "textBoxFullName";
            this.textBoxFullName.Size = new System.Drawing.Size(150, 22);
            this.textBoxFullName.TabIndex = 2;
            // 
            // comboBoxDepartment
            // 
            this.comboBoxDepartment.FormattingEnabled = true;
            this.comboBoxDepartment.Location = new System.Drawing.Point(245, 403);
            this.comboBoxDepartment.Name = "comboBoxDepartment";
            this.comboBoxDepartment.Size = new System.Drawing.Size(121, 24);
            this.comboBoxDepartment.TabIndex = 3;
            // 
            // dateTimePickerDateOfAdmission
            // 
            this.dateTimePickerDateOfAdmission.Location = new System.Drawing.Point(420, 406);
            this.dateTimePickerDateOfAdmission.Name = "dateTimePickerDateOfAdmission";
            this.dateTimePickerDateOfAdmission.Size = new System.Drawing.Size(200, 22);
            this.dateTimePickerDateOfAdmission.TabIndex = 4;
            // 
            // comboBoxSpecification
            // 
            this.comboBoxSpecification.FormattingEnabled = true;
            this.comboBoxSpecification.Location = new System.Drawing.Point(245, 454);
            this.comboBoxSpecification.Name = "comboBoxSpecification";
            this.comboBoxSpecification.Size = new System.Drawing.Size(121, 24);
            this.comboBoxSpecification.TabIndex = 5;
            // 
            // labelRecordBook
            // 
            this.labelRecordBook.AutoSize = true;
            this.labelRecordBook.Location = new System.Drawing.Point(13, 380);
            this.labelRecordBook.Name = "labelRecordBook";
            this.labelRecordBook.Size = new System.Drawing.Size(60, 16);
            this.labelRecordBook.TabIndex = 7;
            this.labelRecordBook.Text = "№ студ. ";
            // 
            // labelBoxFullName
            // 
            this.labelBoxFullName.AutoSize = true;
            this.labelBoxFullName.Location = new System.Drawing.Point(13, 435);
            this.labelBoxFullName.Name = "labelBoxFullName";
            this.labelBoxFullName.Size = new System.Drawing.Size(102, 16);
            this.labelBoxFullName.TabIndex = 8;
            this.labelBoxFullName.Text = "ФИО студента";
            // 
            // labelBoxDepartment
            // 
            this.labelBoxDepartment.AutoSize = true;
            this.labelBoxDepartment.Location = new System.Drawing.Point(252, 380);
            this.labelBoxDepartment.Name = "labelBoxDepartment";
            this.labelBoxDepartment.Size = new System.Drawing.Size(69, 16);
            this.labelBoxDepartment.TabIndex = 9;
            this.labelBoxDepartment.Text = "Институт";
            // 
            // labelSpecification
            // 
            this.labelSpecification.AutoSize = true;
            this.labelSpecification.Location = new System.Drawing.Point(252, 435);
            this.labelSpecification.Name = "labelSpecification";
            this.labelSpecification.Size = new System.Drawing.Size(97, 16);
            this.labelSpecification.TabIndex = 10;
            this.labelSpecification.Text = "Направление";
            // 
            // labelPickerDateOfAdmission
            // 
            this.labelPickerDateOfAdmission.AutoSize = true;
            this.labelPickerDateOfAdmission.Location = new System.Drawing.Point(486, 380);
            this.labelPickerDateOfAdmission.Name = "labelPickerDateOfAdmission";
            this.labelPickerDateOfAdmission.Size = new System.Drawing.Size(120, 16);
            this.labelPickerDateOfAdmission.TabIndex = 11;
            this.labelPickerDateOfAdmission.Text = "Дата зачисления";
            // 
            // labelGroup
            // 
            this.labelGroup.AutoSize = true;
            this.labelGroup.Location = new System.Drawing.Point(486, 435);
            this.labelGroup.Name = "labelGroup";
            this.labelGroup.Size = new System.Drawing.Size(54, 16);
            this.labelGroup.TabIndex = 12;
            this.labelGroup.Text = "Группа";
            // 
            // textBoxGroup
            // 
            this.textBoxGroup.Location = new System.Drawing.Point(420, 455);
            this.textBoxGroup.Name = "textBoxGroup";
            this.textBoxGroup.Size = new System.Drawing.Size(200, 22);
            this.textBoxGroup.TabIndex = 13;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(759, 403);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(88, 23);
            this.buttonAdd.TabIndex = 14;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(759, 435);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(119, 23);
            this.buttonUpdate.TabIndex = 15;
            this.buttonUpdate.Text = "Редактировать";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(759, 464);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonDelete.TabIndex = 16;
            this.buttonDelete.Text = "Удалить";
            this.buttonDelete.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 523);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.textBoxGroup);
            this.Controls.Add(this.labelGroup);
            this.Controls.Add(this.labelPickerDateOfAdmission);
            this.Controls.Add(this.labelSpecification);
            this.Controls.Add(this.labelBoxDepartment);
            this.Controls.Add(this.labelBoxFullName);
            this.Controls.Add(this.labelRecordBook);
            this.Controls.Add(this.comboBoxSpecification);
            this.Controls.Add(this.dateTimePickerDateOfAdmission);
            this.Controls.Add(this.comboBoxDepartment);
            this.Controls.Add(this.textBoxFullName);
            this.Controls.Add(this.textBoxRecordBook);
            this.Controls.Add(this.dataGridViewInformationStudents);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInformationStudents)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewInformationStudents;
        private System.Windows.Forms.TextBox textBoxRecordBook;
        private System.Windows.Forms.TextBox textBoxFullName;
        private System.Windows.Forms.ComboBox comboBoxDepartment;
        private System.Windows.Forms.DateTimePicker dateTimePickerDateOfAdmission;
        private System.Windows.Forms.ComboBox comboBoxSpecification;
        private System.Windows.Forms.Label labelRecordBook;
        private System.Windows.Forms.Label labelBoxFullName;
        private System.Windows.Forms.Label labelBoxDepartment;
        private System.Windows.Forms.Label labelSpecification;
        private System.Windows.Forms.Label labelPickerDateOfAdmission;
        private System.Windows.Forms.Label labelGroup;
        private System.Windows.Forms.TextBox textBoxGroup;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonDelete;
    }
}

