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
    enum RowState
    {
        Existed,
        New,
        Modified,
        ModifiedNew,
        Deleted
    }



    public partial class Form2 : Form
    {
        DataBase dataBase = new DataBase();
        int selectedRow;

        public Form2()
        {
            InitializeComponent();
        }

        private void CreateColumns()
        {
            dataGridView1.Columns.Add("ID_Analiz","ID");
            dataGridView1.Columns.Add("Nazvanie", "Название");
            dataGridView1.Columns.Add("Data_sdachi", "Дата сдачи");
            dataGridView1.Columns.Add("Vremya_sdachi", "Время сдачи");
            dataGridView1.Columns.Add("ID_Laborant", "ID_Laborant");
            dataGridView1.Columns.Add("ID_Posetitel", "ID_Posetitel");
            dataGridView1.Columns.Add("IsNew", String.Empty);
        }

        private void ReadSingleRow (DataGridView dgw, IDataRecord record)
        {
            dgw.Rows.Add(record.GetInt32(0), record.GetString(1), record.GetString(2), record.GetString(3), record.GetInt32(4), record.GetInt32(5), RowState.ModifiedNew);

        }

private void RefreshDataGrid(DataGridView dgw)
        {
            dgw.Rows.Clear();
            string queryString = $"select * from Analiz";

            SqlCommand command = new SqlCommand(queryString, dataBase.getConnection());

            dataBase.openConnection();
            SqlDataReader reader = command.ExecuteReader();

            while(reader.Read())
            {
                ReadSingleRow(dgw, reader);
            }
            reader.Close();
        }




        private void Form2_Load(object sender, EventArgs e)
        {
            CreateColumns();
            RefreshDataGrid(dataGridView1);




        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;

            if(e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[selectedRow];
                textBox_ID.Text = row.Cells[0].Value.ToString();
                textBox_Name.Text = row.Cells[1].Value.ToString();
                textBox_date.Text = row.Cells[2].Value.ToString();
                textBox_vrem.Text = row.Cells[3].Value.ToString();
                textBox_lab.Text = row.Cells[4].Value.ToString();
                textBox_lab2.Text = row.Cells[5].Value.ToString();
            }


        }

        private void Refresh_Click(object sender, EventArgs e)
        {
            RefreshDataGrid(dataGridView1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Добавление_записи_к_Form2 add = new Добавление_записи_к_Form2();
            add.Show();
        }

        private void deleteRow()
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
            deleteRow();
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
                    var ID_Analiz = Convert.ToInt32(dataGridView1.Rows[index].Cells[0].Value);

                    var deleteQuery = "DELETE FROM Analiz WHERE ID_Analiz = @IDAnaliz";
                    using (var command = new SqlCommand(deleteQuery, dataBase.getConnection()))
                    {
                        command.Parameters.AddWithValue("@IDAnaliz", ID_Analiz);
                        command.ExecuteNonQuery();
                    }
                }
            }

            dataBase.closeConnection();
        }


        private void Laborant_Click(object sender, EventArgs e)
        {
            Laboeant add = new Laboeant();
            add.Show();
        }

        private void Lechenie_Click(object sender, EventArgs e)
        {
            Vrach add = new Vrach();
            add.Show();
        }

        private void Posetitel_Click(object sender, EventArgs e)
        {
            Posetitel add = new Posetitel();
            add.Show();
        }

        private void Vrach_Click(object sender, EventArgs e)
        {
            Lechenie add = new Lechenie();
            add.Show();
        }

    }
}
