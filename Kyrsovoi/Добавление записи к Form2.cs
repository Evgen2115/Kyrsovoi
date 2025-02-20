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
    public partial class Добавление_записи_к_Form2 : Form
    {
        DataBase dataBase = new DataBase();


        public Добавление_записи_к_Form2()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Save_Click(object sender, EventArgs e)
        {
            dataBase.openConnection();
            var nazv = textBox_Name2.Text;
            var date = dateTimePicker1.Text;
            var vrem = textBox_vrem2.Text;
            var lab =  textBox_lab.Text;
            int lab2;

            if (int.TryParse(textBox_lab2.Text, out lab2))
            {

                var addQuery = $"insert into Analiz (Nazvanie, Data_sdachi, Vremya_sdachi, ID_Laborant, ID_Posetitel) values ('{nazv}', '{date}', '{vrem}', '{lab}',{lab2})";

                var command = new SqlCommand(addQuery, dataBase.getConnection());
                command.ExecuteNonQuery();

                MessageBox.Show("Запись добавлена");

            }

            else
            {
                MessageBox.Show("Ошибка");

            }
            dataBase.closeConnection();



        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 add = new Form2();
            this.Close();
        }
    }
}
