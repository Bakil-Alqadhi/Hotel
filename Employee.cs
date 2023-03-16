using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel
{
    public partial class Employee : Form
    {
        OleDbConnection dbConnection = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\\3-COURSE\\5-семестр\\Базы данных\\Темы курсовых работ по предмету «Базы данных»\\Hotel\\Hotel1.mdb");
        OleDbCommand command;
        string Employee_id;
        public Employee()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AllClients allClients = new AllClients();
            allClients.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddClient addClient = new AddClient(Employee_id);
            addClient.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AllClients deleteClient = new AllClients();
            deleteClient.Show();
            this.Hide();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {
            if (deleting.Visible == true)
            {
                Employee employee = new Employee();
                employee.Show();
                this.Hide();
            }
            else
            {
                Home home = new Home();
                home.Show();
                this.Hide();
            }
         
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string thisCode="noOne";
            OleDbDataReader reader = null;
            if ( Code.Text== "" )
            {
                MessageBox.Show("Messing Information");
            }
            else
            {
                try
                {
                    dbConnection.Open();
                    string query = "select ID, FName, LName, Code, Phone,Salary from  Employee where [Code]= '" + Code.Text + "'"; 
                    command = new OleDbCommand(query, dbConnection);
                    command.Parameters.AddWithValue("FName", Code.Text);
                    reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        Employee_id= reader["ID"].ToString();
                        myLName.Text = reader["LName"].ToString();
                        myFName.Text = reader["FName"].ToString();             
                        myCode.Text = reader["Code"].ToString(); 
                        myPhone.Text= reader["Phone"].ToString() ;
                        mySalary.Text = reader["Salary"].ToString();
                        title.Text = "Welcome "+ reader["LName"].ToString();
                        deleting.Visible = true;
                        adding.Visible = true;
                        all.Visible = true;
                        Code.Visible = false;
                        find.Visible = false;
                        info.Text =myFName.Text + " "+ myLName.Text;
                        //  emloyee = new Emloyee(fName, lName, code, phone, salary);
                    }
                    else
                    {
                        MessageBox.Show("Data not found");
                    }
                    dbConnection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void label6_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
