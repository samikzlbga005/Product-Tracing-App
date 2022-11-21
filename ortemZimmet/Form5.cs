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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
            
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection("datasource= 'localhost'; database='ortemzimmet';port='3306'; username = 'root'; password= ''");
            connection.Open();
            MySqlDataAdapter adap = new MySqlDataAdapter("select * from ortemzimmet.urun'", connection);
            DataTable table = new DataTable();
            adap.Fill(table);
            listBox1.DataSource = table;
            listBox1.DisplayMember = "u_adi";
            listBox1.ValueMember = "u_id";
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
                
        }
    }
}
