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
    public partial class MainCustomer : Form
    {
        public MainCustomer()
        {
            InitializeComponent();
        }

        private void label13_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Close();
        }

        private void adding_Click(object sender, EventArgs e)
        {
            infoClient infoClient = new infoClient();
            infoClient.Show();
            this.Hide();
        }

        private void deleting_Click(object sender, EventArgs e)
        {

            AddClient addClient = new AddClient();
            addClient.Show();
            this.Hide();
        }
    }
}
