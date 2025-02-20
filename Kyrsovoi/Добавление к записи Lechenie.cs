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
    public partial class Добавление_к_записи_Lechenie : Form
    {
        DataBase dataBase = new DataBase();
        public Добавление_к_записи_Lechenie()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

       

        private void Save_Click_1(object sender, EventArgs e)
        {
            dataBase.openConnection();
            var name = textBox_Name3.Text;
            var dig = textBox_Fam3.Text;
            var kyrs= textBox_Otch3.Text;
            var id = textBox_ID.Text;
            int id2;


            if (int.TryParse(textBox_ID2.Text, out id2))
            {


                var addQuery = $"insert into Lechenie (Imya_posetitelya, Diagnoz, Kyrs_ozdorovleniya, ID_Vrach, ID_Laborant) values ('{name}', '{dig}', '{kyrs}', '{id}', {id2})";

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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox_ID2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Lechenie add = new Lechenie();
            this.Close();
        }
    }
 }

