using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Hotel
{
    public partial class AddEmployee : Form
    {
        public AddEmployee()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void label6_Click_1(object sender, EventArgs e)
        {
             Application.Exit();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {
            Adinstrator home = new Adinstrator("Bakil","123");
            home.Show();
            this.Hide();
        }
        
        OleDbConnection dbConnection =new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\\3-COURSE\\5-семестр\\Базы данных\\Темы курсовых работ по предмету «Базы данных»\\Hotel\\Hotel1.mdb");

        private void button1_Click(object sender, EventArgs e)
        {
            if(FName.Text=="" || LName.Text=="" || Phone.Text=="" || Code.Text=="" || Salary.Text=="")
            {
                MessageBox.Show("Messing Information");
            }
            else
            {
                try
                {
                    dbConnection.Open();
                    string query = "insert into Employee(FName,LName, Phone, Code, Salary) values('" + FName.Text + "','" + LName.Text + "','" + Phone.Text + "','" + Code.Text + "','" + Salary.Text + "' )";
                    OleDbCommand command = new OleDbCommand(query, dbConnection);
                    command.ExecuteNonQuery();
                    dbConnection.Close();
                    MessageBox.Show("Added  Successfully!");
                }
                catch (Exception ex)
                {
                       MessageBox.Show(ex.Message);
                }

            }
        }

        private void AddEmployee_Load(object sender, EventArgs e)
        {

        }

      

        private void LName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FName_TextChanged(object sender, EventArgs e)
        {

        }

        private void Code_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Phone_TextChanged(object sender, EventArgs e)
        {

        }

        private void Salary_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
