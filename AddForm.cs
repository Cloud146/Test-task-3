using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace EmployeeUI
{
    public partial class AddForm : Form
    {
        DataBase database = new DataBase();

        public AddForm()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            database.openConnection();

            var name = AddNameTextBox.Text;
            var surname = AddSurnameTextBox.Text;
            var patronymic = AddPatronymicTextBox.Text;
            var date = AddDateTextBox.Text;
            var residence = AddResidenceTextBox.Text;
            var department = AddDepartmentTextBox.Text;
            var about = AddAboutTextBox.Text;

            var addQuerry = $"INSERT INTO Employee_db (name, surname, patronymic, date_of_birth, residential_address, department, about_me)" +
                $" values ('{name}', '{surname}','{patronymic}', '{date}', '{residence}', '{department}', '{about}')";

            var command = new SqlCommand(addQuerry, database.GetConnection());

            bool nameAdded = Added(AddNameTextBox);
            bool surnameAdded = Added(AddSurnameTextBox);
            bool patronymicAdded = Added(AddPatronymicTextBox);
            bool dateAdded = Added(AddDateTextBox); 
            bool residenceAdded = Added(AddResidenceTextBox);
            bool departmentAdded = Added(AddDepartmentTextBox);
            bool aboutAdded = Added(AddAboutTextBox);

            if (nameAdded == false || surnameAdded == false || dateAdded  == false || patronymicAdded == false || residenceAdded == false || departmentAdded == false || aboutAdded == false)
            {
                MessageBox.Show("Заполните все ячейки!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Сотрудник успешно добавлен.", "Успешно!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                command.ExecuteNonQuery();
                this.Close();
            }
            
            database.closeConnection();
        }

        public static bool Added(TextBox textBox)
        {
            if (textBox.Text != String.Empty)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
