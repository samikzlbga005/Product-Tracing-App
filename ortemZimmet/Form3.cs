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
    public partial class Form3 : Form
    {
        
        public Form3()
        {
            
            InitializeComponent();
            
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            
            MySqlConnection connection = new MySqlConnection("datasource= 'localhost'; database='ortemzimmet';port='3306'; username = 'root'; password= ''"); //open connection
            string selectq = "select * from ortemzimmet.departman";
            connection.Open();
            MySqlCommand cmd = new MySqlCommand(selectq, connection);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                comboBox1.Items.Add(reader.GetString("dep_ad"));
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            string isim = textBox1.Text;
            string mail = textBox2.Text;
            string tel = textBox3.Text;
            string department = comboBox1.Text;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form5 f5 = new Form5();
            f5.ShowDialog();
        }
    }
}
