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
    public partial class infoClient : Form
    {
        OleDbDataReader reader = null, reader2 = null;
         
        OleDbConnection dbConnection = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\\3-COURSE\\5-семестр\\Базы данных\\Темы курсовых работ по предмету «Базы данных»\\Hotel\\Hotel1.mdb");
        public infoClient()
        {
            InitializeComponent();
        }

        public void readData()
        {
            string query1 = "select * from  Reservation where [phone]= '" + phone.Text + "'";

            OleDbCommand command1 = new OleDbCommand(query1, dbConnection);
            command1.Parameters.AddWithValue("phone", phone.Text);
            reader2 = command1.ExecuteReader();
             if (reader2.Read())
            {
                room_number.Text = reader2["room_number"].ToString();
                Price.Text = reader2["price"].ToString();
                check_in.Text = reader2["check_IN"].ToString();
            }
        }
      private void button2_Click(object sender, EventArgs e)
        {
            if (phone.Text == "")
            {
                MessageBox.Show("Messing Information");
            }
            else
            {
                try
                {
                    dbConnection.Open();
                     string query = "select  FName, LName, Phone from Customer  where [Phone]=@phone";
                    OleDbCommand command = new OleDbCommand(query, dbConnection);
                    command.Parameters.AddWithValue("@phone", phone.Text);
                    reader = command.ExecuteReader();
                    if (reader.Read() )
                    {
                        readData();
                        name.Text = reader["FName"].ToString();
                        LName.Text = reader["LName"].ToString();
                        number.Text = reader["Phone"].ToString();
                    }   
                    string query1 = "select room_number, price, check_IN from  Reservation where [FName]= '" + name.Text + "'";

                    OleDbCommand command1 = new OleDbCommand(query1, dbConnection);
                    command1.Parameters.AddWithValue("phone", phone.Text);
                    reader2 = command1.ExecuteReader();
                   if (reader2.Read())
                    {
                        room_number.Text = reader2["room_number"].ToString();
                        Price.Text = reader2["price"].ToString();
                        check_in.Text = reader2["check_IN"].ToString();
                    }
                    dbConnection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void label13_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }
    }
}
