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

    public partial class Form1 : Form
    {
        DataBase dataBase = new DataBase();

        public Form1()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void label1_Click(object sender, EventArgs e)
        {
   
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox_password.PasswordChar = '*';    

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var loginUser = textBox_login.Text;
            var passUser = textBox_password.Text;

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();

            string querystring = $"select ID_Vxod, Login, Password from Vxod where Login = '{loginUser}' and Password ='{passUser}' ";

            SqlCommand command = new SqlCommand(querystring, dataBase.getConnection());

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count == 1)
            {
                MessageBox.Show("Вы успешно вошли!");
                Form2 form2 = new Form2();
                this.Hide();
                form2.ShowDialog();
                this.Show();
            }
            else 
            {
                MessageBox.Show("Вы не вошли :(");
            }

        }

        

        private void login_TextChanged(object sender, EventArgs e)
        {

        }

        private void password_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
