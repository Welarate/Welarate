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
namespace Zaharov
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBox2.UseSystemPasswordChar = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-UJNMDI1\SQLEXPRESS;Initial Catalog=ZaharovBase;Integrated Security=True");
            con.Open();

            SqlCommand cmd = new SqlCommand("Select login, [password] From Users where login = '" + textBox1.Text + "' and [password] = '" + textBox2.Text + "'", con);
            if (cmd.ExecuteScalar() == null) { MessageBox.Show("Пароль не верен"); } else
            {
                Menu menu = new Menu();
                menu.Show();
                Hide();
                textBox1.Text = "";
                textBox2.Text = "";
            }
            con.Close();

        }
    }
}
