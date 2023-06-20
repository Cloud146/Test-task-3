namespace EmployeeUI
{
    partial class AddForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.newDataPanel = new System.Windows.Forms.Panel();
            this.AddDateTextBox = new System.Windows.Forms.TextBox();
            this.AddAboutTextBox = new System.Windows.Forms.TextBox();
            this.AboutLabel = new System.Windows.Forms.Label();
            this.AddDepartmentTextBox = new System.Windows.Forms.TextBox();
            this.DepartmentLabel = new System.Windows.Forms.Label();
            this.AddResidenceTextBox = new System.Windows.Forms.TextBox();
            this.ResidenceLabel = new System.Windows.Forms.Label();
            this.DateLabel = new System.Windows.Forms.Label();
            this.AddPatronymicTextBox = new System.Windows.Forms.TextBox();
            this.PatronymicLabel = new System.Windows.Forms.Label();
            this.AddSurnameTextBox = new System.Windows.Forms.TextBox();
            this.SurnameLabel = new System.Windows.Forms.Label();
            this.AddNameTextBox = new System.Windows.Forms.TextBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.picture = new System.Windows.Forms.PictureBox();
            this.SaveButton = new System.Windows.Forms.Button();
            this.newDataPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).BeginInit();
            this.SuspendLayout();
            // 
            // newDataPanel
            // 
            this.newDataPanel.BackColor = System.Drawing.Color.Lavender;
            this.newDataPanel.Controls.Add(this.SaveButton);
            this.newDataPanel.Controls.Add(this.AddDateTextBox);
            this.newDataPanel.Controls.Add(this.AddAboutTextBox);
            this.newDataPanel.Controls.Add(this.AboutLabel);
            this.newDataPanel.Controls.Add(this.AddDepartmentTextBox);
            this.newDataPanel.Controls.Add(this.DepartmentLabel);
            this.newDataPanel.Controls.Add(this.AddResidenceTextBox);
            this.newDataPanel.Controls.Add(this.ResidenceLabel);
            this.newDataPanel.Controls.Add(this.DateLabel);
            this.newDataPanel.Controls.Add(this.AddPatronymicTextBox);
            this.newDataPanel.Controls.Add(this.PatronymicLabel);
            this.newDataPanel.Controls.Add(this.AddSurnameTextBox);
            this.newDataPanel.Controls.Add(this.SurnameLabel);
            this.newDataPanel.Controls.Add(this.AddNameTextBox);
            this.newDataPanel.Controls.Add(this.NameLabel);
            this.newDataPanel.Controls.Add(this.picture);
            this.newDataPanel.Controls.Add(this.label2);
            this.newDataPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.newDataPanel.Location = new System.Drawing.Point(0, 0);
            this.newDataPanel.Name = "newDataPanel";
            this.newDataPanel.Size = new System.Drawing.Size(701, 337);
            this.newDataPanel.TabIndex = 4;
            // 
            // AddDateTextBox
            // 
            this.AddDateTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddDateTextBox.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.AddDateTextBox.Location = new System.Drawing.Point(442, 97);
            this.AddDateTextBox.Name = "AddDateTextBox";
            this.AddDateTextBox.Size = new System.Drawing.Size(131, 20);
            this.AddDateTextBox.TabIndex = 20;
            this.AddDateTextBox.Text = "01.01.2000 0:00:00";
            // 
            // AddAboutTextBox
            // 
            this.AddAboutTextBox.Location = new System.Drawing.Point(189, 189);
            this.AddAboutTextBox.Multiline = true;
            this.AddAboutTextBox.Name = "AddAboutTextBox";
            this.AddAboutTextBox.Size = new System.Drawing.Size(384, 49);
            this.AddAboutTextBox.TabIndex = 16;
            // 
            // AboutLabel
            // 
            this.AboutLabel.AutoSize = true;
            this.AboutLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AboutLabel.Location = new System.Drawing.Point(130, 189);
            this.AboutLabel.Name = "AboutLabel";
            this.AboutLabel.Size = new System.Drawing.Size(53, 17);
            this.AboutLabel.TabIndex = 15;
            this.AboutLabel.Text = "О себе:";
            // 
            // AddDepartmentTextBox
            // 
            this.AddDepartmentTextBox.Location = new System.Drawing.Point(364, 149);
            this.AddDepartmentTextBox.Name = "AddDepartmentTextBox";
            this.AddDepartmentTextBox.Size = new System.Drawing.Size(209, 20);
            this.AddDepartmentTextBox.TabIndex = 14;
            // 
            // DepartmentLabel
            // 
            this.DepartmentLabel.AutoSize = true;
            this.DepartmentLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DepartmentLabel.Location = new System.Drawing.Point(311, 149);
            this.DepartmentLabel.Name = "DepartmentLabel";
            this.DepartmentLabel.Size = new System.Drawing.Size(47, 17);
            this.DepartmentLabel.TabIndex = 13;
            this.DepartmentLabel.Text = "Отдел:";
            // 
            // AddResidenceTextBox
            // 
            this.AddResidenceTextBox.Location = new System.Drawing.Point(442, 123);
            this.AddResidenceTextBox.Name = "AddResidenceTextBox";
            this.AddResidenceTextBox.Size = new System.Drawing.Size(131, 20);
            this.AddResidenceTextBox.TabIndex = 12;
            // 
            // ResidenceLabel
            // 
            this.ResidenceLabel.AutoSize = true;
            this.ResidenceLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ResidenceLabel.Location = new System.Drawing.Point(302, 123);
            this.ResidenceLabel.Name = "ResidenceLabel";
            this.ResidenceLabel.Size = new System.Drawing.Size(125, 17);
            this.ResidenceLabel.TabIndex = 11;
            this.ResidenceLabel.Text = "Адрес проживания:";
            // 
            // DateLabel
            // 
            this.DateLabel.AutoSize = true;
            this.DateLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DateLabel.Location = new System.Drawing.Point(324, 97);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(103, 17);
            this.DateLabel.TabIndex = 9;
            this.DateLabel.Text = "Дата рождения:";
            // 
            // AddPatronymicTextBox
            // 
            this.AddPatronymicTextBox.Location = new System.Drawing.Point(189, 152);
            this.AddPatronymicTextBox.Name = "AddPatronymicTextBox";
            this.AddPatronymicTextBox.Size = new System.Drawing.Size(100, 20);
            this.AddPatronymicTextBox.TabIndex = 8;
            // 
            // PatronymicLabel
            // 
            this.PatronymicLabel.AutoSize = true;
            this.PatronymicLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PatronymicLabel.Location = new System.Drawing.Point(117, 152);
            this.PatronymicLabel.Name = "PatronymicLabel";
            this.PatronymicLabel.Size = new System.Drawing.Size(66, 17);
            this.PatronymicLabel.TabIndex = 7;
            this.PatronymicLabel.Text = "Отчество:";
            // 
            // AddSurnameTextBox
            // 
            this.AddSurnameTextBox.Location = new System.Drawing.Point(189, 126);
            this.AddSurnameTextBox.Name = "AddSurnameTextBox";
            this.AddSurnameTextBox.Size = new System.Drawing.Size(100, 20);
            this.AddSurnameTextBox.TabIndex = 6;
            // 
            // SurnameLabel
            // 
            this.SurnameLabel.AutoSize = true;
            this.SurnameLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SurnameLabel.Location = new System.Drawing.Point(119, 126);
            this.SurnameLabel.Name = "SurnameLabel";
            this.SurnameLabel.Size = new System.Drawing.Size(64, 17);
            this.SurnameLabel.TabIndex = 5;
            this.SurnameLabel.Text = "Фамилия:";
            // 
            // AddNameTextBox
            // 
            this.AddNameTextBox.Location = new System.Drawing.Point(189, 100);
            this.AddNameTextBox.Name = "AddNameTextBox";
            this.AddNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.AddNameTextBox.TabIndex = 4;
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameLabel.Location = new System.Drawing.Point(146, 100);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(37, 17);
            this.NameLabel.TabIndex = 3;
            this.NameLabel.Text = "Имя:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(79, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(270, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Добавить нового сотрудника:";
            // 
            // picture
            // 
            this.picture.Image = global::EmployeeUI.Properties.Resources.free_icon_add_2821367;
            this.picture.Location = new System.Drawing.Point(3, 4);
            this.picture.Name = "picture";
            this.picture.Size = new System.Drawing.Size(70, 68);
            this.picture.TabIndex = 2;
            this.picture.TabStop = false;
            // 
            // SaveButton
            // 
            this.SaveButton.BackColor = System.Drawing.Color.LavenderBlush;
            this.SaveButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SaveButton.Location = new System.Drawing.Point(277, 260);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(150, 46);
            this.SaveButton.TabIndex = 21;
            this.SaveButton.Text = "Сохранить";
            this.SaveButton.UseVisualStyleBackColor = false;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // AddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 337);
            this.Controls.Add(this.newDataPanel);
            this.Name = "AddForm";
            this.Text = "AddForm";
            this.newDataPanel.ResumeLayout(false);
            this.newDataPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel newDataPanel;
        private System.Windows.Forms.TextBox AddDateTextBox;
        private System.Windows.Forms.TextBox AddAboutTextBox;
        private System.Windows.Forms.Label AboutLabel;
        private System.Windows.Forms.TextBox AddDepartmentTextBox;
        private System.Windows.Forms.Label DepartmentLabel;
        private System.Windows.Forms.TextBox AddResidenceTextBox;
        private System.Windows.Forms.Label ResidenceLabel;
        private System.Windows.Forms.Label DateLabel;
        private System.Windows.Forms.TextBox AddPatronymicTextBox;
        private System.Windows.Forms.Label PatronymicLabel;
        private System.Windows.Forms.TextBox AddSurnameTextBox;
        private System.Windows.Forms.Label SurnameLabel;
        private System.Windows.Forms.TextBox AddNameTextBox;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.PictureBox picture;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button SaveButton;
    }
}