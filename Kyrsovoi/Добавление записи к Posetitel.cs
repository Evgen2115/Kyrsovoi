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

    public partial class Добавление_записи_к_Posetitel : Form
    {
        DataBase dataBase = new DataBase();
        public Добавление_записи_к_Posetitel()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void Save_Click(object sender, EventArgs e)
        {
            dataBase.openConnection();
            var name = textBox_Name3.Text;
            var fam = textBox_Fam3.Text;
            var otch = textBox_Otch3.Text;
            var date = DATE.Text;

            if (DATE.Text != "")
            {


                var addQuery = $"insert into Posetitel (Imya, Familiya, Otchestvo, Data_rozhdeniya) values ('{name}', '{fam}', '{otch}', {@date})";

                var command = new SqlCommand(addQuery, dataBase.getConnection());
                command.Parameters.AddWithValue("@date", date);
                command.ExecuteNonQuery();

                MessageBox.Show("Запись добавлена");
            }

            else
            {
                MessageBox.Show("Ошибка");

            }
            dataBase.closeConnection();


        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Posetitel add = new Posetitel();
            this.Close();
        }
    }
}
