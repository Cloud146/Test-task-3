namespace EmployeeUI
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
            this.BackgroundPanel = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.controlDataPanel = new System.Windows.Forms.Panel();
            this.SaveDataButton = new System.Windows.Forms.Button();
            this.DeleteDataButton = new System.Windows.Forms.Button();
            this.EditDataButton = new System.Windows.Forms.Button();
            this.NewDataButton = new System.Windows.Forms.Button();
            this.ControlDataLabel = new System.Windows.Forms.Label();
            this.newDataPanel = new System.Windows.Forms.Panel();
            this.DateTextBox = new System.Windows.Forms.TextBox();
            this.IDTextBox = new System.Windows.Forms.TextBox();
            this.IDLabel = new System.Windows.Forms.Label();
            this.AboutTextBox = new System.Windows.Forms.TextBox();
            this.AboutLabel = new System.Windows.Forms.Label();
            this.DepartmentTextBox = new System.Windows.Forms.TextBox();
            this.DepartmentLabel = new System.Windows.Forms.Label();
            this.ResidenceTextBox = new System.Windows.Forms.TextBox();
            this.ResidenceLabel = new System.Windows.Forms.Label();
            this.DateLabel = new System.Windows.Forms.Label();
            this.PatronymicTextBox = new System.Windows.Forms.TextBox();
            this.PatronymicLabel = new System.Windows.Forms.Label();
            this.SurnameTextBox = new System.Windows.Forms.TextBox();
            this.SurnameLabel = new System.Windows.Forms.Label();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.mainLabelPanel = new System.Windows.Forms.Panel();
            this.mainLabel = new System.Windows.Forms.Label();
            this.SearchBox = new System.Windows.Forms.TextBox();
            this.picture = new System.Windows.Forms.PictureBox();
            this.CleanPicture = new System.Windows.Forms.PictureBox();
            this.SearchPicture = new System.Windows.Forms.PictureBox();
            this.RefreshButton = new System.Windows.Forms.Button();
            this.BackgroundPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.controlDataPanel.SuspendLayout();
            this.newDataPanel.SuspendLayout();
            this.mainLabelPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CleanPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SearchPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // BackgroundPanel
            // 
            this.BackgroundPanel.BackColor = System.Drawing.Color.LavenderBlush;
            this.BackgroundPanel.Controls.Add(this.dataGridView1);
            this.BackgroundPanel.Controls.Add(this.controlDataPanel);
            this.BackgroundPanel.Controls.Add(this.newDataPanel);
            this.BackgroundPanel.Controls.Add(this.mainLabelPanel);
            this.BackgroundPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BackgroundPanel.Location = new System.Drawing.Point(0, 0);
            this.BackgroundPanel.Name = "BackgroundPanel";
            this.BackgroundPanel.Size = new System.Drawing.Size(967, 646);
            this.BackgroundPanel.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Lavender;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 77);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(943, 294);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // controlDataPanel
            // 
            this.controlDataPanel.BackColor = System.Drawing.Color.Lavender;
            this.controlDataPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.controlDataPanel.Controls.Add(this.SaveDataButton);
            this.controlDataPanel.Controls.Add(this.DeleteDataButton);
            this.controlDataPanel.Controls.Add(this.EditDataButton);
            this.controlDataPanel.Controls.Add(this.NewDataButton);
            this.controlDataPanel.Controls.Add(this.ControlDataLabel);
            this.controlDataPanel.Location = new System.Drawing.Point(687, 377);
            this.controlDataPanel.Name = "controlDataPanel";
            this.controlDataPanel.Size = new System.Drawing.Size(225, 257);
            this.controlDataPanel.TabIndex = 4;
            // 
            // SaveDataButton
            // 
            this.SaveDataButton.BackColor = System.Drawing.Color.LavenderBlush;
            this.SaveDataButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SaveDataButton.Location = new System.Drawing.Point(36, 193);
            this.SaveDataButton.Name = "SaveDataButton";
            this.SaveDataButton.Size = new System.Drawing.Size(150, 46);
            this.SaveDataButton.TabIndex = 4;
            this.SaveDataButton.Text = "Сохранить изменения";
            this.SaveDataButton.UseVisualStyleBackColor = false;
            this.SaveDataButton.Click += new System.EventHandler(this.SaveDataButton_Click);
            // 
            // DeleteDataButton
            // 
            this.DeleteDataButton.BackColor = System.Drawing.Color.LavenderBlush;
            this.DeleteDataButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeleteDataButton.Location = new System.Drawing.Point(36, 141);
            this.DeleteDataButton.Name = "DeleteDataButton";
            this.DeleteDataButton.Size = new System.Drawing.Size(150, 46);
            this.DeleteDataButton.TabIndex = 3;
            this.DeleteDataButton.Text = "Удалить запись";
            this.DeleteDataButton.UseVisualStyleBackColor = false;
            this.DeleteDataButton.Click += new System.EventHandler(this.DeleteDataButton_Click);
            // 
            // EditDataButton
            // 
            this.EditDataButton.BackColor = System.Drawing.Color.LavenderBlush;
            this.EditDataButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EditDataButton.Location = new System.Drawing.Point(36, 89);
            this.EditDataButton.Name = "EditDataButton";
            this.EditDataButton.Size = new System.Drawing.Size(150, 46);
            this.EditDataButton.TabIndex = 2;
            this.EditDataButton.Text = "Редактировать запись";
            this.EditDataButton.UseVisualStyleBackColor = false;
            this.EditDataButton.Click += new System.EventHandler(this.EditDataButton_Click);
            // 
            // NewDataButton
            // 
            this.NewDataButton.BackColor = System.Drawing.Color.LavenderBlush;
            this.NewDataButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NewDataButton.Location = new System.Drawing.Point(36, 37);
            this.NewDataButton.Name = "NewDataButton";
            this.NewDataButton.Size = new System.Drawing.Size(150, 46);
            this.NewDataButton.TabIndex = 1;
            this.NewDataButton.Text = "Создать запись";
            this.NewDataButton.UseVisualStyleBackColor = false;
            this.NewDataButton.Click += new System.EventHandler(this.NewDataButton_Click);
            // 
            // ControlDataLabel
            // 
            this.ControlDataLabel.AutoSize = true;
            this.ControlDataLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ControlDataLabel.Location = new System.Drawing.Point(12, 9);
            this.ControlDataLabel.Name = "ControlDataLabel";
            this.ControlDataLabel.Size = new System.Drawing.Size(201, 25);
            this.ControlDataLabel.TabIndex = 0;
            this.ControlDataLabel.Text = "Управление данными";
            // 
            // newDataPanel
            // 
            this.newDataPanel.BackColor = System.Drawing.Color.Lavender;
            this.newDataPanel.Controls.Add(this.DateTextBox);
            this.newDataPanel.Controls.Add(this.IDTextBox);
            this.newDataPanel.Controls.Add(this.IDLabel);
            this.newDataPanel.Controls.Add(this.AboutTextBox);
            this.newDataPanel.Controls.Add(this.AboutLabel);
            this.newDataPanel.Controls.Add(this.DepartmentTextBox);
            this.newDataPanel.Controls.Add(this.DepartmentLabel);
            this.newDataPanel.Controls.Add(this.ResidenceTextBox);
            this.newDataPanel.Controls.Add(this.ResidenceLabel);
            this.newDataPanel.Controls.Add(this.DateLabel);
            this.newDataPanel.Controls.Add(this.PatronymicTextBox);
            this.newDataPanel.Controls.Add(this.PatronymicLabel);
            this.newDataPanel.Controls.Add(this.SurnameTextBox);
            this.newDataPanel.Controls.Add(this.SurnameLabel);
            this.newDataPanel.Controls.Add(this.NameTextBox);
            this.newDataPanel.Controls.Add(this.NameLabel);
            this.newDataPanel.Controls.Add(this.picture);
            this.newDataPanel.Controls.Add(this.label2);
            this.newDataPanel.Location = new System.Drawing.Point(56, 396);
            this.newDataPanel.Name = "newDataPanel";
            this.newDataPanel.Size = new System.Drawing.Size(566, 219);
            this.newDataPanel.TabIndex = 3;
            // 
            // DateTextBox
            // 
            this.DateTextBox.Location = new System.Drawing.Point(391, 49);
            this.DateTextBox.Name = "DateTextBox";
            this.DateTextBox.Size = new System.Drawing.Size(131, 20);
            this.DateTextBox.TabIndex = 20;
            // 
            // IDTextBox
            // 
            this.IDTextBox.Location = new System.Drawing.Point(138, 49);
            this.IDTextBox.Name = "IDTextBox";
            this.IDTextBox.Size = new System.Drawing.Size(100, 20);
            this.IDTextBox.TabIndex = 19;
            // 
            // IDLabel
            // 
            this.IDLabel.AutoSize = true;
            this.IDLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.IDLabel.Location = new System.Drawing.Point(109, 49);
            this.IDLabel.Name = "IDLabel";
            this.IDLabel.Size = new System.Drawing.Size(23, 17);
            this.IDLabel.TabIndex = 18;
            this.IDLabel.Text = "ID:";
            // 
            // AboutTextBox
            // 
            this.AboutTextBox.Location = new System.Drawing.Point(138, 153);
            this.AboutTextBox.Multiline = true;
            this.AboutTextBox.Name = "AboutTextBox";
            this.AboutTextBox.Size = new System.Drawing.Size(384, 49);
            this.AboutTextBox.TabIndex = 16;
            // 
            // AboutLabel
            // 
            this.AboutLabel.AutoSize = true;
            this.AboutLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AboutLabel.Location = new System.Drawing.Point(79, 153);
            this.AboutLabel.Name = "AboutLabel";
            this.AboutLabel.Size = new System.Drawing.Size(53, 17);
            this.AboutLabel.TabIndex = 15;
            this.AboutLabel.Text = "О себе:";
            // 
            // DepartmentTextBox
            // 
            this.DepartmentTextBox.Location = new System.Drawing.Point(313, 101);
            this.DepartmentTextBox.Name = "DepartmentTextBox";
            this.DepartmentTextBox.Size = new System.Drawing.Size(209, 20);
            this.DepartmentTextBox.TabIndex = 14;
            // 
            // DepartmentLabel
            // 
            this.DepartmentLabel.AutoSize = true;
            this.DepartmentLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DepartmentLabel.Location = new System.Drawing.Point(260, 101);
            this.DepartmentLabel.Name = "DepartmentLabel";
            this.DepartmentLabel.Size = new System.Drawing.Size(47, 17);
            this.DepartmentLabel.TabIndex = 13;
            this.DepartmentLabel.Text = "Отдел:";
            // 
            // ResidenceTextBox
            // 
            this.ResidenceTextBox.Location = new System.Drawing.Point(391, 75);
            this.ResidenceTextBox.Name = "ResidenceTextBox";
            this.ResidenceTextBox.Size = new System.Drawing.Size(131, 20);
            this.ResidenceTextBox.TabIndex = 12;
            // 
            // ResidenceLabel
            // 
            this.ResidenceLabel.AutoSize = true;
            this.ResidenceLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ResidenceLabel.Location = new System.Drawing.Point(251, 75);
            this.ResidenceLabel.Name = "ResidenceLabel";
            this.ResidenceLabel.Size = new System.Drawing.Size(125, 17);
            this.ResidenceLabel.TabIndex = 11;
            this.ResidenceLabel.Text = "Адрес проживания:";
            // 
            // DateLabel
            // 
            this.DateLabel.AutoSize = true;
            this.DateLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DateLabel.Location = new System.Drawing.Point(273, 49);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(103, 17);
            this.DateLabel.TabIndex = 9;
            this.DateLabel.Text = "Дата рождения:";
            // 
            // PatronymicTextBox
            // 
            this.PatronymicTextBox.Location = new System.Drawing.Point(138, 127);
            this.PatronymicTextBox.Name = "PatronymicTextBox";
            this.PatronymicTextBox.Size = new System.Drawing.Size(100, 20);
            this.PatronymicTextBox.TabIndex = 8;
            // 
            // PatronymicLabel
            // 
            this.PatronymicLabel.AutoSize = true;
            this.PatronymicLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PatronymicLabel.Location = new System.Drawing.Point(66, 127);
            this.PatronymicLabel.Name = "PatronymicLabel";
            this.PatronymicLabel.Size = new System.Drawing.Size(66, 17);
            this.PatronymicLabel.TabIndex = 7;
            this.PatronymicLabel.Text = "Отчество:";
            // 
            // SurnameTextBox
            // 
            this.SurnameTextBox.Location = new System.Drawing.Point(138, 101);
            this.SurnameTextBox.Name = "SurnameTextBox";
            this.SurnameTextBox.Size = new System.Drawing.Size(100, 20);
            this.SurnameTextBox.TabIndex = 6;
            // 
            // SurnameLabel
            // 
            this.SurnameLabel.AutoSize = true;
            this.SurnameLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SurnameLabel.Location = new System.Drawing.Point(68, 101);
            this.SurnameLabel.Name = "SurnameLabel";
            this.SurnameLabel.Size = new System.Drawing.Size(64, 17);
            this.SurnameLabel.TabIndex = 5;
            this.SurnameLabel.Text = "Фамилия:";
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(138, 75);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(100, 20);
            this.NameTextBox.TabIndex = 4;
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameLabel.Location = new System.Drawing.Point(95, 75);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(37, 17);
            this.NameLabel.TabIndex = 3;
            this.NameLabel.Text = "Имя:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(79, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(199, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Данные сотрудников:";
            // 
            // mainLabelPanel
            // 
            this.mainLabelPanel.BackColor = System.Drawing.Color.Lavender;
            this.mainLabelPanel.Controls.Add(this.CleanPicture);
            this.mainLabelPanel.Controls.Add(this.SearchPicture);
            this.mainLabelPanel.Controls.Add(this.SearchBox);
            this.mainLabelPanel.Controls.Add(this.RefreshButton);
            this.mainLabelPanel.Controls.Add(this.mainLabel);
            this.mainLabelPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.mainLabelPanel.ForeColor = System.Drawing.Color.Black;
            this.mainLabelPanel.Location = new System.Drawing.Point(0, 0);
            this.mainLabelPanel.Name = "mainLabelPanel";
            this.mainLabelPanel.Size = new System.Drawing.Size(967, 71);
            this.mainLabelPanel.TabIndex = 1;
            // 
            // mainLabel
            // 
            this.mainLabel.AutoSize = true;
            this.mainLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mainLabel.Location = new System.Drawing.Point(12, 21);
            this.mainLabel.Name = "mainLabel";
            this.mainLabel.Size = new System.Drawing.Size(387, 37);
            this.mainLabel.TabIndex = 0;
            this.mainLabel.Text = "Учётные данные сотрудников";
            // 
            // SearchBox
            // 
            this.SearchBox.Location = new System.Drawing.Point(747, 25);
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.Size = new System.Drawing.Size(165, 20);
            this.SearchBox.TabIndex = 2;
            this.SearchBox.TextChanged += new System.EventHandler(this.SearchBox_TextChanged);
            // 
            // picture
            // 
            this.picture.Image = global::EmployeeUI.Properties.Resources.free_icon_contact_data_9256632__2_;
            this.picture.Location = new System.Drawing.Point(3, 4);
            this.picture.Name = "picture";
            this.picture.Size = new System.Drawing.Size(70, 68);
            this.picture.TabIndex = 2;
            this.picture.TabStop = false;
            // 
            // CleanPicture
            // 
            this.CleanPicture.Image = global::EmployeeUI.Properties.Resources.clean_code;
            this.CleanPicture.Location = new System.Drawing.Point(536, 3);
            this.CleanPicture.Name = "CleanPicture";
            this.CleanPicture.Size = new System.Drawing.Size(64, 64);
            this.CleanPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.CleanPicture.TabIndex = 4;
            this.CleanPicture.TabStop = false;
            this.CleanPicture.Click += new System.EventHandler(this.CleanPicture_Click);
            // 
            // SearchPicture
            // 
            this.SearchPicture.Image = global::EmployeeUI.Properties.Resources.free_icon_search_of_knowledge_1810645;
            this.SearchPicture.Location = new System.Drawing.Point(678, 3);
            this.SearchPicture.Name = "SearchPicture";
            this.SearchPicture.Size = new System.Drawing.Size(64, 64);
            this.SearchPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.SearchPicture.TabIndex = 3;
            this.SearchPicture.TabStop = false;
            // 
            // RefreshButton
            // 
            this.RefreshButton.AutoSize = true;
            this.RefreshButton.BackColor = System.Drawing.Color.Lavender;
            this.RefreshButton.BackgroundImage = global::EmployeeUI.Properties.Resources.free_icon_refresh_2691608__1_;
            this.RefreshButton.Location = new System.Drawing.Point(606, 3);
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Size = new System.Drawing.Size(66, 62);
            this.RefreshButton.TabIndex = 1;
            this.RefreshButton.UseVisualStyleBackColor = false;
            this.RefreshButton.Click += new System.EventHandler(this.RefreshButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(967, 646);
            this.Controls.Add(this.BackgroundPanel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.BackgroundPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.controlDataPanel.ResumeLayout(false);
            this.controlDataPanel.PerformLayout();
            this.newDataPanel.ResumeLayout(false);
            this.newDataPanel.PerformLayout();
            this.mainLabelPanel.ResumeLayout(false);
            this.mainLabelPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CleanPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SearchPicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel BackgroundPanel;
        private System.Windows.Forms.Panel controlDataPanel;
        private System.Windows.Forms.Button SaveDataButton;
        private System.Windows.Forms.Button DeleteDataButton;
        private System.Windows.Forms.Button EditDataButton;
        private System.Windows.Forms.Button NewDataButton;
        private System.Windows.Forms.Label ControlDataLabel;
        private System.Windows.Forms.Panel newDataPanel;
        private System.Windows.Forms.PictureBox picture;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel mainLabelPanel;
        private System.Windows.Forms.Label mainLabel;
        private System.Windows.Forms.TextBox AboutTextBox;
        private System.Windows.Forms.Label AboutLabel;
        private System.Windows.Forms.TextBox DepartmentTextBox;
        private System.Windows.Forms.Label DepartmentLabel;
        private System.Windows.Forms.TextBox ResidenceTextBox;
        private System.Windows.Forms.Label ResidenceLabel;
        private System.Windows.Forms.Label DateLabel;
        private System.Windows.Forms.TextBox PatronymicTextBox;
        private System.Windows.Forms.Label PatronymicLabel;
        private System.Windows.Forms.TextBox SurnameTextBox;
        private System.Windows.Forms.Label SurnameLabel;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.TextBox IDTextBox;
        private System.Windows.Forms.Label IDLabel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox DateTextBox;
        private System.Windows.Forms.Button RefreshButton;
        private System.Windows.Forms.PictureBox SearchPicture;
        private System.Windows.Forms.TextBox SearchBox;
        private System.Windows.Forms.PictureBox CleanPicture;
    }
}

