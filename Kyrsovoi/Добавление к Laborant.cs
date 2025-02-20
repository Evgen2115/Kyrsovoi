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
    public partial class Добавление_к_Laborant : Form
    {
        DataBase dataBase = new DataBase();

        public Добавление_к_Laborant()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void Save_Click(object sender, EventArgs e)
        {
            dataBase.openConnection();
            var name = textBox_Name2.Text;
            var fam = textBox_Fam2.Text;
            var nazv = textBox_Nazv2.Text;

            if (!string.IsNullOrWhiteSpace(nazv)) // Проверяем, что название не пустое
            {
                var addQuery = "INSERT INTO Laborant (Imya, Familiya, Nazvanie_diagnoza) VALUES (@name, @fam, @nazv)";

                using (var command = new SqlCommand(addQuery, dataBase.getConnection()))
                {
                    command.Parameters.AddWithValue("@name", name);
                    command.Parameters.AddWithValue("@fam", fam);
                    command.Parameters.AddWithValue("@nazv", nazv);
                    command.ExecuteNonQuery();
                }

                MessageBox.Show("Запись добавлена");
            }
            else
            {
                MessageBox.Show("Ошибка: название диагноза не может быть пустым");
            }

            dataBase.closeConnection();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Laboeant add = new Laboeant();
            this.Close();
        }
    }
}
