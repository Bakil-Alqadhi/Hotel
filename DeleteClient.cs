using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel
{
    public partial class DeleteClient : Form
    {
        public DeleteClient()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label13_Click(object sender, EventArgs e)
        {
            Adinstrator adinstrator = new Adinstrator();
            adinstrator.Show();
            this.Hide();
        }
        OleDbConnection dbConnection = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\\3-COURSE\\5-семестр\\Базы данных\\Темы курсовых работ по предмету «Базы данных»\\Hotel\\Hotel1.mdb");
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
                    string query = "delete  from Customer where [Phone]= '" + phone.Text + "'";
                    // and [plName]= '" + cliFam.Text + "' "
                    OleDbCommand command = new OleDbCommand();
                    command.CommandText = query;
                    command.Connection = dbConnection;
                    command.Parameters.AddWithValue("pfName", phone.Text);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Deleted  Successfully!");
                    //  SqlCommand command = new SqlCommand(query);
                    ////  command.ExecuteNonQuery
                    // command.ExecuteNonQuery();
                    // MessageBox.Show("Deleted  Successfully!");
                    dbConnection.Close();
                    //person pp = new person();
                    //pp.Show();
                    Adinstrator adinstrator = new Adinstrator();
                    adinstrator.Show();
                    this.Hide();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void phone_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
