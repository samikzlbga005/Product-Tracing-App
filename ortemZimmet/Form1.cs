using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace ortemZimmet
{
    public partial class Form1 : Form
    {
        MySqlConnection con;
        public Form1()
        {
            con = new MySqlConnection("datasource= 'localhost'; database='ortemzimmet';port='3306'; username = 'root'; password= ''"); //open connection          con = new MySqlConnection("datasource= 'localhost'; database='ortemzimmet';port='3306'; username = 'root'; password= ''"); //open connection
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string user = textBox1.Text;
            string pass = textBox2.Text;
            
            con.Open();
            MySqlCommand cmd = new MySqlCommand("select * from admin where admin_k_adi = '" + user + "' AND admin_sifre = '" + pass + "'", con);
            MySqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                this.Hide();
                Form2 f = new Form2(user,pass);
                f.ShowDialog();
            }
            else
            {
                MessageBox.Show("Kullanıcı Adı veya Şifre Hatalı");
                textBox1.Text = "";
                textBox2.Text = "";
            }
            con.Close();
        }
    }
}
