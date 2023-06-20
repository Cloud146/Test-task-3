using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeUI
{
    enum RowState
    {
        Existed,
        New,
        Modified,
        ModifiedNew,
        Deleted
    }

    public partial class Form1 : Form
    {

        DataBase database = new DataBase();
        int selectedRow;

        public Form1()
        {
            InitializeComponent();
        }

        private void CreateColumns()
        {
            dataGridView1.Columns.Add("id", "id");
            dataGridView1.Columns.Add("name", "Имя");
            dataGridView1.Columns.Add("surname", "Фамилия");
            dataGridView1.Columns.Add("patronymic", "Отчество");
            dataGridView1.Columns.Add("date_of_birth", "Дата рождения");
            dataGridView1.Columns.Add("residential_adress", "Адрес проживания");
            dataGridView1.Columns.Add("department", "Отдел");
            dataGridView1.Columns.Add("about_me", "О себе");
            dataGridView1.Columns.Add("IsNew", String.Empty);
        }

        private void ReadSingleRow(DataGridView dgw, IDataRecord record)
        {
            dgw.Rows.Add(record.GetInt32(0), record.GetString(1), record.GetString(2), record.GetString(3), record.GetDateTime(4), record.GetString(5), record.GetString(6), record.GetString(7), RowState.ModifiedNew);
        }

        private void RefreshDataGrid(DataGridView dgw)
        {
            dgw.Rows.Clear();
            string queryString = $"SELECT * FROM Employee_db";

            SqlCommand command = new SqlCommand(queryString, database.GetConnection());

            database.openConnection();

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                ReadSingleRow(dgw, reader);
            }
            reader.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CreateColumns();
            RefreshDataGrid(dataGridView1);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Diagnostics.Process.GetCurrentProcess().Kill();
        }

        private void ClearFields()
        {
            IDTextBox.Text = "";
            NameTextBox.Text = "";
            SurnameTextBox.Text = "";
            PatronymicTextBox.Text = "";
            DateTextBox.Text = "";
            ResidenceTextBox.Text = "";
            DepartmentTextBox.Text = "";
            AboutTextBox.Text = "";
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[selectedRow];

                IDTextBox.Text = row.Cells[0].Value.ToString();
                NameTextBox.Text = row.Cells[1].Value.ToString();
                SurnameTextBox.Text = row.Cells[2].Value.ToString();
                PatronymicTextBox.Text = row.Cells[3].Value.ToString();
                DateTextBox.Text = row.Cells[4].Value.ToString();
                ResidenceTextBox.Text = row.Cells[5].Value.ToString();
                DepartmentTextBox.Text = row.Cells[6].Value.ToString();
                AboutTextBox.Text = row.Cells[7].Value.ToString();
            }
        }

        private void NewDataButton_Click(object sender, EventArgs e)
        {
            AddForm addForm = new AddForm();
            addForm.Show();
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            RefreshDataGrid(dataGridView1);
            ClearFields();
        }

        private void Search(DataGridView dgw)
        {
            dgw.Rows.Clear();

            string searchString = $"SELECT * FROM Employee_db WHERE CONCAT (id, name, surname, patronymic, date_of_birth, residential_address, department, about_me) LIKE '%" +SearchBox.Text +"%'";

            SqlCommand com = new SqlCommand(searchString, database.GetConnection());
            database.openConnection();

            SqlDataReader read = com.ExecuteReader();
            while (read.Read())
            {
                ReadSingleRow(dgw, read);
            }
            read.Close();
        }

        private void SearchBox_TextChanged(object sender, EventArgs e)
        {
            Search(dataGridView1);
        }

        private void deleteRow()
        {
            int index = dataGridView1.CurrentCell.RowIndex;
            dataGridView1.Rows[index].Visible = false;
            if (dataGridView1.Rows[index].Cells[0].Value.ToString() == string.Empty)
            {
                dataGridView1.Rows[index].Cells[8].Value = RowState.Deleted;
                return;
            }
            dataGridView1.Rows[index].Cells[8].Value = RowState.Deleted;
        }

        private void Update()
        {
            database.openConnection();

            for(int index = 0; index < dataGridView1.Rows.Count; index++)
            {
                var rowState = (RowState)dataGridView1.Rows[index].Cells[8].Value;
                if (rowState == RowState.Existed)
                {
                    continue;
                }
                if (rowState == RowState.Deleted)
                {
                    var id = Convert.ToInt32(dataGridView1.Rows[index].Cells[0].Value);
                    var deleteQuerry = $"DELETE FROM Employee_db WHERE id = {id}";
                    var command = new SqlCommand(deleteQuerry, database.GetConnection());
                    command.ExecuteNonQuery();
                }

                if(rowState == RowState.Modified)
                {
                    var id = dataGridView1.Rows[index].Cells[0].Value.ToString();
                    var name = dataGridView1.Rows[index].Cells[1].Value.ToString();
                    var surname = dataGridView1.Rows[index].Cells[2].Value.ToString();
                    var patronymic = dataGridView1.Rows[index].Cells[3].Value.ToString();
                    var date = dataGridView1.Rows[index].Cells[4].Value.ToString();
                    var residence = dataGridView1.Rows[index].Cells[5].Value.ToString();
                    var department = dataGridView1.Rows[index].Cells[6].Value.ToString();
                    var about = dataGridView1.Rows[index].Cells[7].Value.ToString();

                    var changeQuerry = $"UPDATE Employee_db SET name = '{name}',  surname = '{surname}', patronymic = '{patronymic}',  date_of_birth = '{date}',  residential_address = '{residence}',  department = '{department}', about_me = '{about}' WHERE id = '{id}'";
                    var command = new SqlCommand(changeQuerry, database.GetConnection());
                    command.ExecuteNonQuery();
                }
            }

            database.closeConnection();
        }

        private void DeleteDataButton_Click(object sender, EventArgs e)
        {
            deleteRow();
            ClearFields();
        }

        private void SaveDataButton_Click(object sender, EventArgs e)
        {
            Update();
        }

        private void Edit()
        {
            var selectedRowIndex = dataGridView1.CurrentCell.RowIndex;

            var id = IDTextBox.Text;
            var name = NameTextBox.Text;
            var surname = SurnameTextBox.Text;
            var patronymic = PatronymicTextBox.Text;
            var date = DateTextBox.Text;
            var residence = ResidenceTextBox.Text;
            var department = DepartmentTextBox.Text;
            var about = AboutTextBox.Text;

            if (dataGridView1.Rows[selectedRowIndex].Cells[0].Value.ToString() != String.Empty)
            {
                dataGridView1.Rows[selectedRowIndex].SetValues(id, name, surname, patronymic, date, residence, department, about);
                dataGridView1.Rows[selectedRowIndex].Cells[8].Value = RowState.Modified;
            }
        }

        private void EditDataButton_Click(object sender, EventArgs e)
        {
            Edit();
            ClearFields();
        }

        private void CleanPicture_Click(object sender, EventArgs e)
        {
            ClearFields();
        }
    }
}
