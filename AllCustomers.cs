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
    public partial class AllClients : Form
    {
        OleDbConnection dbConnection = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\\3-COURSE\\5-семестр\\Базы данных\\Темы курсовых работ по предмету «Базы данных»\\Hotel\\Hotel1.mdb");
        //OleDbCommand command;
        OleDbDataReader reader = null, reader3=null, reader4=null;
        string number = "1", price = "1000", check_in= "22.11.2022 22:27:22", _check_out="22.11.2022 22:27:22";
        string  reservation_id = "41", occup_id = "41";

        string dateTime = DateTime.Now.ToString("dd.mm.yyyy hh: mm:ss");
        //check_in= "dd.mm.yyyy hh: mm:ss"
        public AllClients()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void AllClients_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hotel1DataSet2.Customer' table. You can move, or remove it, as needed.
            this.customerTableAdapter.Fill(this.hotel1DataSet2.Customer);
            // TODO: This line of code loads data into the 'hotel1DataSet.Клиенты' table. You can move, or remove it, as needed.
           // this.клиентыTableAdapter.Fill(this.hotel1DataSet.Customer);

        }
        public void filter()
        {
            try
            {
                dbConnection.Open();
                string query = "select * from Customer where  `FName` & `LName`  like '%" + search.Text + "%'";
                OleDbCommand command = new OleDbCommand(query, dbConnection);
                OleDbDataAdapter da = new OleDbDataAdapter(command);
                DataTable dataTable = new DataTable();
                da.Fill(dataTable);
                dataGridView1.DataSource = dataTable;
               dbConnection.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
            id_Client.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            FName.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            LName.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            Phone.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label13_Click(object sender, EventArgs e)
        {
            Adinstrator adinstrator = new Adinstrator();
            adinstrator.Show();
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            filter();
        }
        //id_Client
        private void check_out_Click(object sender, EventArgs e)
        {
            string id = "12";
            
            if (FName.Text == "" || LName.Text == "" || Phone.Text == "" || id_Client.Text == "")
            {
                MessageBox.Show("Messing Information");
            }
            else
            {
                try
                {

                    string query1 = "select  room_number, price, check_IN, check_OUT from  Reservation where [phone]= @Phone";
                    OleDbCommand command = new OleDbCommand(query1, dbConnection);
                    command.CommandType = CommandType.Text;
                    command.CommandText = query1;
                    command.Parameters.AddWithValue("@Phone", Phone.Text);
                    dbConnection.Open();
                    reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        //   id =reader["customer_id"].ToString();
                        number = reader["room_number"].ToString();
                        price = reader["price"].ToString();
                        check_in = reader["check_IN"].ToString();
                        _check_out = reader["check_OUT"].ToString();
                    }
                    else
                    {
                        MessageBox.Show("Data is't found");
                    }
                    reader.Close();
                    command.ExecuteNonQuery();
                    dbConnection.Close();
                    // get_info();
                    
                    
                    get_reservation_id();
                    
                    inser_into_check_out();
                    get_occupied_id();
                    delete_from_hosted();
                    delete_from_occupied_room();
                    update_room();
                    delete_from_reservation();
                    delete_customer();
                    
                    
                    
                    //command.ExecuteNonQuery();

                    MessageBox.Show("Deleted  Successfully!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }

        private void get_info()
        {
            string query1 = "select  room_number, price, check_IN, check_OUT from  Reservation where [phone]= @Phone";
            OleDbCommand command = new OleDbCommand(query1, dbConnection);
            command.CommandType = CommandType.Text;
            command.CommandText = query1;
            command.Parameters.AddWithValue("@Phone", Phone.Text);
            dbConnection.Open();
            reader = command.ExecuteReader();
            if (reader.Read())
            {
                //   id =reader["customer_id"].ToString();
                number = reader["room_number"].ToString();
                price = reader["price"].ToString();
                check_in = reader["check_IN"].ToString();
                _check_out = reader["check_OUT"].ToString();
            }
            else
            {
                MessageBox.Show("Data is't found");
            }
            reader.Close();
            command.ExecuteNonQuery();
            dbConnection.Close();
        }

        private void delete_customer()
        {
            string queryDel = "delete * from  customer where  [id_Client]= @id";
            OleDbCommand command = new OleDbCommand(queryDel, dbConnection);
            command.Parameters.AddWithValue("@id", id_Client.Text);
            dbConnection.Open();
            command.ExecuteNonQuery();
            dbConnection.Close();
        }
        private void delete_from_reservation()
        {
            string queryDel = "delete * from  Reservation where  [phone]= @phone";
            OleDbCommand command = new OleDbCommand(queryDel, dbConnection);
            command.Parameters.AddWithValue("@phone", Phone.Text);
            dbConnection.Open();
            command.ExecuteNonQuery();
            dbConnection.Close();
        }

        private void get_reservation_id()
        {

            string room_id = "select ID from Reservation where [phone]= @thePhone";

            OleDbCommand command5 = new OleDbCommand(room_id, dbConnection);
            command5.CommandType = CommandType.Text;
            command5.CommandText = room_id;
            command5.Parameters.AddWithValue("@thePhone", Phone.Text);
            dbConnection.Open();
            reader3 = command5.ExecuteReader();

            if (reader3.Read())
            {
                reservation_id = reader3["ID"].ToString();
            }
            reader3.Close();
            command5.ExecuteNonQuery();
            dbConnection.Close();
        }

        private void delete_from_occupied_room()
        {
            
            string query6 = "delete * from occupied_room  where [reservation_id]= @reservation_id";
            OleDbCommand command6 = dbConnection.CreateCommand();
            command6.CommandType = CommandType.Text;
            command6.CommandText = query6;
            command6.Parameters.AddWithValue("@reservation_id", reservation_id);
            dbConnection.Open();
            command6.ExecuteNonQuery();
            dbConnection.Close();
        }
        private void get_occupied_id()
        {
            string res_id = "select ID from occupied_room where [reservation_id]= @reservation_id";

            OleDbCommand command5 = new OleDbCommand(res_id, dbConnection);
            command5.CommandType = CommandType.Text;
            command5.CommandText = res_id;
            command5.Parameters.AddWithValue("@reservation_id", reservation_id);
            dbConnection.Open();
            reader4 = command5.ExecuteReader();

            if (reader4.Read())
            {
                occup_id = reader4["ID"].ToString();
            }
            else
            {
                MessageBox.Show("There is no data!!");
            }
            reader4.Close();
            command5.ExecuteNonQuery();
            dbConnection.Close();
        }

        private void delete_from_hosted()
        {
            string query = "delete * from hosted_at where [occupied_room_id]= @occ_id";
            OleDbCommand command3 = new OleDbCommand(query, dbConnection);
            command3.CommandType = CommandType.Text;
            command3.CommandText = query;
            command3.Parameters.AddWithValue("@occ_id", occup_id);
            dbConnection.Open();
            command3.ExecuteNonQuery();
            dbConnection.Close();
        }

        private void inser_into_check_out()
        {
            string query2 = "insert into Check_Out(FName, LName, Phone, Room_Number, Price, Check_In, Check_Out)  values(@fname, @lname, @phone, @room, @price, @in, @out)";
            //'" + FName.Text + "','" + LName.Text + "','" + Phone.Text + "','" + number + "','" + price + "','" + check_in + "','" + _check_out + "')"
            OleDbCommand command = new OleDbCommand(query2, dbConnection);
            command.CommandType = CommandType.Text;
            command.CommandText = query2;
            command.Parameters.AddWithValue("@fname", FName.Text);
            command.Parameters.AddWithValue("@lname", LName.Text);
            command.Parameters.AddWithValue("@phone", Phone.Text);
            command.Parameters.AddWithValue("@room", number);
            command.Parameters.AddWithValue("@price", price);
            command.Parameters.AddWithValue("@in", check_in);
            command.Parameters.AddWithValue("@out", _check_out);
            dbConnection.Open();
            command.ExecuteNonQuery();
            dbConnection.Close();
        }
        private void update_room()
        {
            
            string query3 = "UPDATE Room SET booked='" + "NO" + "' WHERE [room_number]=@Number";
            OleDbCommand command4 = new OleDbCommand(query3, dbConnection);
            command4.CommandType = CommandType.Text;
            command4.CommandText = query3;
            command4.Parameters.AddWithValue("@Number", number);
            dbConnection.Open();
            command4.ExecuteNonQuery();
            dbConnection.Close();
        }
    }
}
