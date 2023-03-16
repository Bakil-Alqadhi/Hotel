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
    public partial class AddRoom : Form
    {
        OleDbConnection dbConnection = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\\3-COURSE\\5-семестр\\Базы данных\\Темы курсовых работ по предмету «Базы данных»\\Hotel\\Hotel1.mdb");
        OleDbCommand command;
        public AddRoom()
        {
            InitializeComponent();
        }

        private void AddRoom_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hotel1DataSet8.Room' table. You can move, or remove it, as needed.
            this.roomTableAdapter1.Fill(this.hotel1DataSet8.Room);
            // TODO: This line of code loads data into the 'hotel1DataSet7.Room' table. You can move, or remove it, as needed.
            this.roomTableAdapter.Fill(this.hotel1DataSet7.Room);

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //if(e.RowIndex == 0)
            //{
            //    DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
            //    number.Text = row.Cells["room_number"].Value.ToString();
            //  //  bed.Text = row.Cells["room_bed"].Value.ToString();
            //    type.Text = row.Cells["room_type"].Value.ToString();
            //    price.Text = row.Cells["room_price"].Value.ToString();

            //}
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (number.Text == "" || type.Text == "" || bed.Text == "" || price.Text=="")
            {
                MessageBox.Show("Messing Information");
            }
            else
            {
                try
                {
                    dbConnection.Open();
                    string query = "insert into Room(room_number, room_type, room_bed, room_price)  values('" + number.Text + "','" + type.Text + "','" + bed.Text + "','" + price.Text + "' )";
                    command = new OleDbCommand(query, dbConnection);
                    command.ExecuteNonQuery();
                    //dataGridView1.Refresh();
                    //dataGridView1.Update();
                    dbConnection.Close();

                    MessageBox.Show("Added  Successfully!");
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
    }
}
