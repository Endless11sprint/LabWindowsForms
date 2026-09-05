namespace WindowsFormsLab9
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
            this.listViewStudent = new System.Windows.Forms.ListView();
            this.comboboxSpecification = new System.Windows.Forms.ComboBox();
            this.comboboxTypeFille = new System.Windows.Forms.ComboBox();
            this.textBoxFIO = new System.Windows.Forms.TextBox();
            this.textBoxStudentRecordBook = new System.Windows.Forms.TextBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonDonwnload = new System.Windows.Forms.Button();
            this.buttonUpload = new System.Windows.Forms.Button();
            this.labelFIO = new System.Windows.Forms.Label();
            this.labelRecordBook = new System.Windows.Forms.Label();
            this.labelSpecification = new System.Windows.Forms.Label();
            this.labelTypeFille = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listViewStudent
            // 
            this.listViewStudent.HideSelection = false;
            this.listViewStudent.Location = new System.Drawing.Point(12, 12);
            this.listViewStudent.Name = "listViewStudent";
            this.listViewStudent.Size = new System.Drawing.Size(435, 426);
            this.listViewStudent.TabIndex = 0;
            this.listViewStudent.UseCompatibleStateImageBehavior = false;
            // 
            // comboboxSpecification
            // 
            this.comboboxSpecification.FormattingEnabled = true;
            this.comboboxSpecification.Location = new System.Drawing.Point(513, 194);
            this.comboboxSpecification.Name = "comboboxSpecification";
            this.comboboxSpecification.Size = new System.Drawing.Size(216, 24);
            this.comboboxSpecification.TabIndex = 1;
            // 
            // comboboxTypeFille
            // 
            this.comboboxTypeFille.FormattingEnabled = true;
            this.comboboxTypeFille.Location = new System.Drawing.Point(513, 255);
            this.comboboxTypeFille.Name = "comboboxTypeFille";
            this.comboboxTypeFille.Size = new System.Drawing.Size(216, 24);
            this.comboboxTypeFille.TabIndex = 2;
            // 
            // textBoxFIO
            // 
            this.textBoxFIO.Location = new System.Drawing.Point(513, 48);
            this.textBoxFIO.Name = "textBoxFIO";
            this.textBoxFIO.Size = new System.Drawing.Size(216, 22);
            this.textBoxFIO.TabIndex = 3;
            // 
            // textBoxStudentRecordBook
            // 
            this.textBoxStudentRecordBook.Location = new System.Drawing.Point(513, 104);
            this.textBoxStudentRecordBook.Name = "textBoxStudentRecordBook";
            this.textBoxStudentRecordBook.Size = new System.Drawing.Size(216, 22);
            this.textBoxStudentRecordBook.TabIndex = 4;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(513, 132);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(88, 23);
            this.buttonAdd.TabIndex = 5;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(654, 132);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonDelete.TabIndex = 6;
            this.buttonDelete.Text = "Удалить";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonDonwnload
            // 
            this.buttonDonwnload.Location = new System.Drawing.Point(513, 301);
            this.buttonDonwnload.Name = "buttonDonwnload";
            this.buttonDonwnload.Size = new System.Drawing.Size(91, 23);
            this.buttonDonwnload.TabIndex = 7;
            this.buttonDonwnload.Text = "Загрузить";
            this.buttonDonwnload.UseVisualStyleBackColor = true;
            this.buttonDonwnload.Click += new System.EventHandler(this.buttonDonwnload_Click);
            // 
            // buttonUpload
            // 
            this.buttonUpload.Location = new System.Drawing.Point(637, 301);
            this.buttonUpload.Name = "buttonUpload";
            this.buttonUpload.Size = new System.Drawing.Size(92, 23);
            this.buttonUpload.TabIndex = 8;
            this.buttonUpload.Text = "Выгрузить";
            this.buttonUpload.UseVisualStyleBackColor = true;
            this.buttonUpload.Click += new System.EventHandler(this.buttonUpload_Click);
            // 
            // labelFIO
            // 
            this.labelFIO.AutoSize = true;
            this.labelFIO.Location = new System.Drawing.Point(510, 12);
            this.labelFIO.Name = "labelFIO";
            this.labelFIO.Size = new System.Drawing.Size(102, 16);
            this.labelFIO.TabIndex = 9;
            this.labelFIO.Text = "ФИО студента";
            // 
            // labelRecordBook
            // 
            this.labelRecordBook.AutoSize = true;
            this.labelRecordBook.Location = new System.Drawing.Point(513, 82);
            this.labelRecordBook.Name = "labelRecordBook";
            this.labelRecordBook.Size = new System.Drawing.Size(166, 16);
            this.labelRecordBook.TabIndex = 10;
            this.labelRecordBook.Text = "Номер зачетной книжки";
            // 
            // labelSpecification
            // 
            this.labelSpecification.AutoSize = true;
            this.labelSpecification.Location = new System.Drawing.Point(516, 172);
            this.labelSpecification.Name = "labelSpecification";
            this.labelSpecification.Size = new System.Drawing.Size(108, 16);
            this.labelSpecification.TabIndex = 11;
            this.labelSpecification.Text = "Специальность";
            // 
            // labelTypeFille
            // 
            this.labelTypeFille.AutoSize = true;
            this.labelTypeFille.Location = new System.Drawing.Point(513, 233);
            this.labelTypeFille.Name = "labelTypeFille";
            this.labelTypeFille.Size = new System.Drawing.Size(134, 16);
            this.labelTypeFille.TabIndex = 12;
            this.labelTypeFille.Text = "Расширение файла";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelTypeFille);
            this.Controls.Add(this.labelSpecification);
            this.Controls.Add(this.labelRecordBook);
            this.Controls.Add(this.labelFIO);
            this.Controls.Add(this.buttonUpload);
            this.Controls.Add(this.buttonDonwnload);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.textBoxStudentRecordBook);
            this.Controls.Add(this.textBoxFIO);
            this.Controls.Add(this.comboboxTypeFille);
            this.Controls.Add(this.comboboxSpecification);
            this.Controls.Add(this.listViewStudent);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewStudent;
        private System.Windows.Forms.ComboBox comboboxSpecification;
        private System.Windows.Forms.ComboBox comboboxTypeFille;
        private System.Windows.Forms.TextBox textBoxFIO;
        private System.Windows.Forms.TextBox textBoxStudentRecordBook;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonDonwnload;
        private System.Windows.Forms.Button buttonUpload;
        private System.Windows.Forms.Label labelFIO;
        private System.Windows.Forms.Label labelRecordBook;
        private System.Windows.Forms.Label labelSpecification;
        private System.Windows.Forms.Label labelTypeFille;
    }
}

