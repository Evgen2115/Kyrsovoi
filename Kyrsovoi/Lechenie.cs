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

namespace Kyrsovoi
{
    enum RowState6
    {
        Existed,
        New,
        Modified,
        ModifiedNew,
        Deleted
    }
    public partial class Lechenie : Form
    {
        DataBase dataBase = new DataBase();
        int selectedRow;

        public Lechenie()
        {
            InitializeComponent();
            
        }

        private void CreateColumns()
        {
            dataGridView1.Columns.Add("ID_Lechenie", "ID");
            dataGridView1.Columns.Add("Imya_posetitelya", "Имя посетителя");
            dataGridView1.Columns.Add("Diagnoz", "Диагноз");
            dataGridView1.Columns.Add("Kyrs_ozdorovleniya", "Курс оздоровления");
            dataGridView1.Columns.Add("ID_Vrach", "ID_Vrach");
            dataGridView1.Columns.Add("ID_Laborant", "ID_Laborant");
            
        }
        private void ReadSingleRow(DataGridView dgw, IDataRecord record)
        {
            dgw.Rows.Add(record.GetInt32(0), record.GetString(1), record.GetString(2), record.GetString(3), record.GetInt32(4), record.GetInt32(5), RowState.ModifiedNew);

        }

        private void RefreshDataGrid(DataGridView dgw)
        {
            try
            {
                dgw.Rows.Clear();
                string queryString = $"SELECT * FROM Lechenie";

                using (SqlCommand command = new SqlCommand(queryString, dataBase.getConnection()))
                {
                    dataBase.openConnection();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            ReadSingleRow(dgw, reader);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при загрузке данных: {ex.Message}");
            }
            finally
            {
                dataBase.closeConnection(); // Закрываем соединение после работы
            }
        }

       


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[selectedRow];
                textBox_ID.Text = row.Cells[0].Value.ToString();
                textBox_Name.Text = row.Cells[1].Value.ToString();
                textBox_Diag.Text = row.Cells[2].Value.ToString();
                textBox_Kyrs.Text = row.Cells[3].Value.ToString();
                textBox_Vrach.Text = row.Cells[4].Value.ToString();
                textBox_Lab.Text = row.Cells[5].Value.ToString();
            }

        }

        





        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void Refresh_Click(object sender, EventArgs e)
        {
            RefreshDataGrid(dataGridView1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Добавление_к_записи_Lechenie add = new Добавление_к_записи_Lechenie();
            add.Show();
        }

        private void deleteRow1()
        {
            int index = dataGridView1.CurrentCell.RowIndex;

            if (index >= 0) // Проверяем, что индекс валиден
            {
                dataGridView1.Rows[index].Visible = false;

                if (dataGridView1.Rows[index].Cells[0].Value.ToString() == string.Empty)
                {
                    dataGridView1.Rows[index].Cells[6].Value = RowState.Deleted;
                }
                else
                {
                    dataGridView1.Rows[index].Cells[6].Value = RowState.Deleted; // Помечаем строку как удаленную
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            deleteRow1();
        }

        private void button4_Click(object sender, EventArgs e)
        {

            SaveChanges();
            RefreshDataGrid(dataGridView1); // Обновляем DataGridView после сохранения
        }

        private void SaveChanges()
        {
            dataBase.openConnection();

            for (int index = 0; index < dataGridView1.Rows.Count; index++)
            {
                var rowState = (RowState)dataGridView1.Rows[index].Cells[6].Value;

                if (rowState == RowState.Deleted)
                {
                    var ID_Lechenie = Convert.ToInt32(dataGridView1.Rows[index].Cells[0].Value);

                    var deleteQuery = "DELETE FROM Lechenie WHERE ID_Lechenie = @IDLecheniet";
                    using (var command = new SqlCommand(deleteQuery, dataBase.getConnection()))
                    {
                        command.Parameters.AddWithValue("@IDLechenie", ID_Lechenie);
                        command.ExecuteNonQuery();
                    }
                }
            }

            dataBase.closeConnection();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 add = new Form2();
            this.Close();
        }

        private void Lechenie_Load_1(object sender, EventArgs e)
        {
            CreateColumns();
            RefreshDataGrid(dataGridView1);
        }
    }
}
