using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Adinstrator adinstrator= new Adinstrator();
            adinstrator.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MainCustomer  mainCustomer = new MainCustomer();
            mainCustomer.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Employee pp = new Employee();
            pp.Show();
            this.Hide();
        }
    }
}
