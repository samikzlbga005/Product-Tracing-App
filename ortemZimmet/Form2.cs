using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ortemZimmet
{
    public partial class Form2 : Form
    {
        string user;
        string pass;
        public Form2(string user, string pass)
        {
            InitializeComponent();
            this.user = user;
            this.pass = pass;
            label1.Text = user + " " + pass;
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void kişiEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.ShowDialog();
        }
    }
}
