﻿using System;
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
    enum RowState1
    {
        Existed,
        New,
        Modified,
        ModifiedNew,
        Deleted
    }

    public partial class Laboeant : Form
    {
        DataBase dataBase = new DataBase();
        int selectedRow;
        public Laboeant()
        {
            InitializeComponent();
        }

        private void CreateColumns()
        {
            dataGridView1.Columns.Add("ID_Laborant", "ID");
            dataGridView1.Columns.Add("Imya", "Имя");
            dataGridView1.Columns.Add("Familiya", "Фамилия");
            dataGridView1.Columns.Add("Nazvanie_diagnoza", "Название диагноза");
            dataGridView1.Columns.Add("IsNew", String.Empty);
        }

        private void ReadSingleRow(DataGridView dgw, IDataRecord record)
        {
            dgw.Rows.Add(record.GetInt32(0), record.GetString(1), record.GetString(2), record.GetString(3), RowState.ModifiedNew);

        }

        private void RefreshDataGrid(DataGridView dgw)
        {
            dgw.Rows.Clear();
            string queryString = $"select * from Laborant";

            SqlCommand command = new SqlCommand(queryString, dataBase.getConnection());

            dataBase.openConnection();
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                ReadSingleRow(dgw, reader);
            }
            reader.Close();
        }


       



        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[selectedRow];
                textBox_ID.Text = row.Cells[0].Value.ToString();
                textBox_Name.Text = row.Cells[1].Value.ToString();
                textBox_Fam.Text = row.Cells[2].Value.ToString();
                textBox_Nazv.Text = row.Cells[3].Value.ToString();
            }

        }

        private void Laboeant_Load(object sender, EventArgs e)
        {
            CreateColumns();
            RefreshDataGrid(dataGridView1);
        }

        private void Refresh_Click(object sender, EventArgs e)
        {
            RefreshDataGrid(dataGridView1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Добавление_к_Laborant add = new Добавление_к_Laborant();
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
                    dataGridView1.Rows[index].Cells[4].Value = RowState.Deleted;
                }
                else
                {
                    dataGridView1.Rows[index].Cells[4].Value = RowState.Deleted; // Помечаем строку как удаленную
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
                var rowState = (RowState)dataGridView1.Rows[index].Cells[4].Value;

                if (rowState == RowState.Deleted)
                {
                    var ID_Laborant = Convert.ToInt32(dataGridView1.Rows[index].Cells[0].Value);

                    var deleteQuery = "DELETE FROM Laborant WHERE ID_Laborant = @IDLaborant";
                    using (var command = new SqlCommand(deleteQuery, dataBase.getConnection()))
                    {
                        command.Parameters.AddWithValue("@IDLaborant", ID_Laborant);
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
    }
}
