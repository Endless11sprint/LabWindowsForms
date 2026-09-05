namespace Lab7
{
    partial class FormStudents
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
            this.comboBoxInstitut = new System.Windows.Forms.ComboBox();
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
            this.dataGridViewInformationStudents.AllowUserToAddRows = false;
            this.dataGridViewInformationStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewInformationStudents.Location = new System.Drawing.Point(1, -1);
            this.dataGridViewInformationStudents.MultiSelect = false;
            this.dataGridViewInformationStudents.Name = "dataGridViewInformationStudents";
            this.dataGridViewInformationStudents.ReadOnly = true;
            this.dataGridViewInformationStudents.RowHeadersWidth = 51;
            this.dataGridViewInformationStudents.RowTemplate.Height = 24;
            this.dataGridViewInformationStudents.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewInformationStudents.Size = new System.Drawing.Size(1014, 374);
            this.dataGridViewInformationStudents.TabIndex = 0;
            this.dataGridViewInformationStudents.SelectionChanged += new System.EventHandler(this.dataGridViewInformationStudents_SelectionChanged);
            // 
            // textBoxRecordBook
            // 
            this.textBoxRecordBook.Location = new System.Drawing.Point(12, 406);
            this.textBoxRecordBook.MaxLength = 8;
            this.textBoxRecordBook.Name = "textBoxRecordBook";
            this.textBoxRecordBook.Size = new System.Drawing.Size(220, 22);
            this.textBoxRecordBook.TabIndex = 1;
            this.textBoxRecordBook.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxRecordBook_KeyPress);
            // 
            // textBoxFullName
            // 
            this.textBoxFullName.Location = new System.Drawing.Point(12, 457);
            this.textBoxFullName.MaxLength = 50;
            this.textBoxFullName.Name = "textBoxFullName";
            this.textBoxFullName.Size = new System.Drawing.Size(220, 22);
            this.textBoxFullName.TabIndex = 2;
            this.textBoxFullName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxFullName_KeyPress);
            // 
            // comboBoxInstitut
            // 
            this.comboBoxInstitut.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxInstitut.FormattingEnabled = true;
            this.comboBoxInstitut.Location = new System.Drawing.Point(253, 404);
            this.comboBoxInstitut.Name = "comboBoxInstitut";
            this.comboBoxInstitut.Size = new System.Drawing.Size(400, 24);
            this.comboBoxInstitut.TabIndex = 3;
            this.comboBoxInstitut.SelectedValueChanged += new System.EventHandler(this.comboBoxInstitut_SelectedValueChanged);
            // 
            // dateTimePickerDateOfAdmission
            // 
            this.dateTimePickerDateOfAdmission.Location = new System.Drawing.Point(674, 395);
            this.dateTimePickerDateOfAdmission.MinDate = new System.DateTime(1940, 1, 1, 0, 0, 0, 0);
            this.dateTimePickerDateOfAdmission.Name = "dateTimePickerDateOfAdmission";
            this.dateTimePickerDateOfAdmission.Size = new System.Drawing.Size(187, 22);
            this.dateTimePickerDateOfAdmission.TabIndex = 4;
            this.dateTimePickerDateOfAdmission.Value = new System.DateTime(2025, 12, 27, 0, 0, 0, 0);
            // 
            // comboBoxSpecification
            // 
            this.comboBoxSpecification.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSpecification.FormattingEnabled = true;
            this.comboBoxSpecification.Location = new System.Drawing.Point(253, 455);
            this.comboBoxSpecification.Name = "comboBoxSpecification";
            this.comboBoxSpecification.Size = new System.Drawing.Size(400, 24);
            this.comboBoxSpecification.TabIndex = 5;
            // 
            // labelRecordBook
            // 
            this.labelRecordBook.AutoSize = true;
            this.labelRecordBook.Location = new System.Drawing.Point(13, 380);
            this.labelRecordBook.Name = "labelRecordBook";
            this.labelRecordBook.Size = new System.Drawing.Size(107, 16);
            this.labelRecordBook.TabIndex = 7;
            this.labelRecordBook.Text = "№ студ. билета";
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
            this.labelBoxDepartment.Location = new System.Drawing.Point(260, 381);
            this.labelBoxDepartment.Name = "labelBoxDepartment";
            this.labelBoxDepartment.Size = new System.Drawing.Size(69, 16);
            this.labelBoxDepartment.TabIndex = 9;
            this.labelBoxDepartment.Text = "Институт";
            // 
            // labelSpecification
            // 
            this.labelSpecification.AutoSize = true;
            this.labelSpecification.Location = new System.Drawing.Point(260, 436);
            this.labelSpecification.Name = "labelSpecification";
            this.labelSpecification.Size = new System.Drawing.Size(97, 16);
            this.labelSpecification.TabIndex = 10;
            this.labelSpecification.Text = "Направление";
            // 
            // labelPickerDateOfAdmission
            // 
            this.labelPickerDateOfAdmission.AutoSize = true;
            this.labelPickerDateOfAdmission.Location = new System.Drawing.Point(671, 376);
            this.labelPickerDateOfAdmission.Name = "labelPickerDateOfAdmission";
            this.labelPickerDateOfAdmission.Size = new System.Drawing.Size(120, 16);
            this.labelPickerDateOfAdmission.TabIndex = 11;
            this.labelPickerDateOfAdmission.Text = "Дата зачисления";
            // 
            // labelGroup
            // 
            this.labelGroup.AutoSize = true;
            this.labelGroup.Location = new System.Drawing.Point(671, 433);
            this.labelGroup.Name = "labelGroup";
            this.labelGroup.Size = new System.Drawing.Size(54, 16);
            this.labelGroup.TabIndex = 12;
            this.labelGroup.Text = "Группа";
            // 
            // textBoxGroup
            // 
            this.textBoxGroup.Location = new System.Drawing.Point(674, 454);
            this.textBoxGroup.MaxLength = 20;
            this.textBoxGroup.Name = "textBoxGroup";
            this.textBoxGroup.Size = new System.Drawing.Size(187, 22);
            this.textBoxGroup.TabIndex = 13;
            this.textBoxGroup.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxGroup_KeyPress);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(879, 394);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(125, 23);
            this.buttonAdd.TabIndex = 14;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(879, 426);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(125, 23);
            this.buttonUpdate.TabIndex = 15;
            this.buttonUpdate.Text = "Редактировать";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(879, 455);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(125, 23);
            this.buttonDelete.TabIndex = 16;
            this.buttonDelete.Text = "Удалить";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // FormStudents
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
            this.Controls.Add(this.comboBoxInstitut);
            this.Controls.Add(this.textBoxFullName);
            this.Controls.Add(this.textBoxRecordBook);
            this.Controls.Add(this.dataGridViewInformationStudents);
            this.Name = "FormStudents";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInformationStudents)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewInformationStudents;
        private System.Windows.Forms.TextBox textBoxRecordBook;
        private System.Windows.Forms.TextBox textBoxFullName;
        private System.Windows.Forms.ComboBox comboBoxInstitut;
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

