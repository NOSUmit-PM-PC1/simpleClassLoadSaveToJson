namespace simpleClassLoadSaveToJson
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
            this.buttonLoadFromFile = new System.Windows.Forms.Button();
            this.buttonSaveToFile = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dateTimePickerTime = new System.Windows.Forms.DateTimePicker();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.listBoxMeets = new System.Windows.Forms.ListBox();
            this.buttonAddToList = new System.Windows.Forms.Button();
            this.dateTimePickerDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.labelDeltaTime = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonLoadFromFile
            // 
            this.buttonLoadFromFile.Location = new System.Drawing.Point(59, 34);
            this.buttonLoadFromFile.Name = "buttonLoadFromFile";
            this.buttonLoadFromFile.Size = new System.Drawing.Size(194, 23);
            this.buttonLoadFromFile.TabIndex = 0;
            this.buttonLoadFromFile.Text = "Считать класс из файла";
            this.buttonLoadFromFile.UseVisualStyleBackColor = true;
            this.buttonLoadFromFile.Click += new System.EventHandler(this.buttonLoadFromFile_Click);
            // 
            // buttonSaveToFile
            // 
            this.buttonSaveToFile.Location = new System.Drawing.Point(59, 88);
            this.buttonSaveToFile.Name = "buttonSaveToFile";
            this.buttonSaveToFile.Size = new System.Drawing.Size(194, 23);
            this.buttonSaveToFile.TabIndex = 2;
            this.buttonSaveToFile.Text = "Сохранить класс в файл";
            this.buttonSaveToFile.UseVisualStyleBackColor = true;
            this.buttonSaveToFile.Click += new System.EventHandler(this.buttonSaveToFile_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.labelDeltaTime);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dateTimePickerDate);
            this.panel1.Controls.Add(this.buttonAddToList);
            this.panel1.Controls.Add(this.dateTimePickerTime);
            this.panel1.Controls.Add(this.textBoxName);
            this.panel1.Controls.Add(this.listBoxMeets);
            this.panel1.Location = new System.Drawing.Point(47, 185);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(333, 374);
            this.panel1.TabIndex = 6;
            // 
            // dateTimePickerTime
            // 
            this.dateTimePickerTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePickerTime.Location = new System.Drawing.Point(202, 70);
            this.dateTimePickerTime.Name = "dateTimePickerTime";
            this.dateTimePickerTime.ShowUpDown = true;
            this.dateTimePickerTime.Size = new System.Drawing.Size(96, 20);
            this.dateTimePickerTime.TabIndex = 9;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(22, 96);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(276, 20);
            this.textBoxName.TabIndex = 8;
            // 
            // listBoxMeets
            // 
            this.listBoxMeets.FormattingEnabled = true;
            this.listBoxMeets.Location = new System.Drawing.Point(22, 122);
            this.listBoxMeets.Name = "listBoxMeets";
            this.listBoxMeets.Size = new System.Drawing.Size(288, 121);
            this.listBoxMeets.TabIndex = 7;
            this.listBoxMeets.SelectedIndexChanged += new System.EventHandler(this.listBoxMeets_SelectedIndexChanged);
            // 
            // buttonAddToList
            // 
            this.buttonAddToList.Location = new System.Drawing.Point(22, 21);
            this.buttonAddToList.Name = "buttonAddToList";
            this.buttonAddToList.Size = new System.Drawing.Size(200, 29);
            this.buttonAddToList.TabIndex = 10;
            this.buttonAddToList.Text = "Добавить в список";
            this.buttonAddToList.UseVisualStyleBackColor = true;
            this.buttonAddToList.Click += new System.EventHandler(this.buttonAddToList_Click);
            // 
            // dateTimePickerDate
            // 
            this.dateTimePickerDate.Location = new System.Drawing.Point(22, 70);
            this.dateTimePickerDate.Name = "dateTimePickerDate";
            this.dateTimePickerDate.Size = new System.Drawing.Size(165, 20);
            this.dateTimePickerDate.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 277);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Сколько времени до выбранного события";
            // 
            // labelDeltaTime
            // 
            this.labelDeltaTime.AutoSize = true;
            this.labelDeltaTime.Location = new System.Drawing.Point(22, 309);
            this.labelDeltaTime.Name = "labelDeltaTime";
            this.labelDeltaTime.Size = new System.Drawing.Size(35, 13);
            this.labelDeltaTime.TabIndex = 13;
            this.labelDeltaTime.Text = "label2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 592);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonSaveToFile);
            this.Controls.Add(this.buttonLoadFromFile);
            this.Name = "Form1";
            this.Text = "Пример сохранения и чтения класса из файла JSON";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonLoadFromFile;
        private System.Windows.Forms.Button buttonSaveToFile;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonAddToList;
        private System.Windows.Forms.DateTimePicker dateTimePickerTime;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.ListBox listBoxMeets;
        private System.Windows.Forms.DateTimePicker dateTimePickerDate;
        private System.Windows.Forms.Label labelDeltaTime;
        private System.Windows.Forms.Label label1;
    }
}

