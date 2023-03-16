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
    public partial class Adinstrator : Form
    {
        public Adinstrator()
        {
            InitializeComponent();
        }
        public Adinstrator(string name, string pass)
        {
            InitializeComponent();
            title.Text = "Wellcom Bakil :)";
            button1.Visible = true;
            button2.Visible = true;
            button3.Visible = true;
            button4.Visible = true;
            button5.Visible = true;
            button6.Visible = true;
            enter.Visible = false;
            user1.Visible = false;
            user2.Visible = false;
            pass2.Visible = false;
            pass1.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
           Employee pp= new Employee();
            pp.Show();
            this.Hide();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddClient addClient = new AddClient();
            addClient.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DeleteClient deleteClient = new DeleteClient();
            deleteClient.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            AddEmployee addPers = new AddEmployee();
            addPers.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //DeleteEmloyee deletePers = new DeleteEmloyee();
            //deletePers.Show();
            //this.Hide();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            AllClients allClients = new AllClients();
            allClients.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AllEmployees allPerson = new AllEmployees();
            allPerson.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            AddRoom addRoom = new AddRoom();
            addRoom.Show();
            this.Hide();
        }

        private void label13_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        private void enter_Click(object sender, EventArgs e)
        {
            if(user2.Text =="Bakil" && pass2.Text == "123")
            {
                title.Text = "Wellcom Bakil :)";
                button1.Visible = true;
                button2.Visible = true;
                button3.Visible = true;
                button4.Visible = true;
                button5.Visible = true;
                button6.Visible = true;
                enter.Visible = false;
                user1.Visible = false;
                user2.Visible = false;
                pass2.Visible = false;
                pass1.Visible = false;
            }
            else
            {
                MessageBox.Show("Not correct, try again!");
            }
        }

        private void title_Click(object sender, EventArgs e)
        {

        }
    }
}
