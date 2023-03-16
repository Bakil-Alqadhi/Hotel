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
    public partial class AddClient : Form
    {
        
        OleDbConnection dbConnection = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\\3-COURSE\\5-семестр\\Базы данных\\Темы курсовых работ по предмету «Базы данных»\\Hotel\\Hotel1.mdb");
        //OleDbCommand command, command2, command3, command4, command5, command6;
        OleDbDataReader reader = null, reader2 = null, reader3=null;
        string myId = "41", the_room_id = "41", reservation_id="41", employee_code="noOne", occup_id="41", _employee_id="0";
        public AddClient()
        {
            InitializeComponent();
        }

        public AddClient(string emp)
        {
            InitializeComponent();
            _employee_id = emp;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
          
            if (FName.Text == "" || LName.Text == "" || Phone.Text == "" || Bed.Text=="" || Price.Text=="" || Type.Text =="" || CheckIn.Value== null || CheckOut.Value==null)
            {
                MessageBox.Show("Messing Information");
            }
            else
            {
                if (isBooked.Text == "NO")
                {
                    try
                    {
                        insert_into_customer();
                        get_last_id();
                        insert_into_reservation();
                        get_room_id();
                        get_reservation_id();
                        insert_into_occupied_room();
                        update_room();
                        get_occupied_id();
                        if (_employee_id != "0")
                        {
                            insert_into_hosted();
                        }
                        //if (employee_code != "noOne")
                        //{
                        //    get_empl_id();
                        //    get_occupied_id();
                        //    insert_into_hosted();
                        //}
                        MessageBox.Show("Added  Successfully!");

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("The Room Is Booked, Choose Another Room!");
                }

            }
        }

        private void insert_into_hosted()
        {
            string query = "insert into hosted_at(client_id, occupied_room_id,add_by_employee_id)  values(@ID, @occupied_id, @employee_id)";
            OleDbCommand command3 = new OleDbCommand(query, dbConnection);
            command3.Parameters.AddWithValue("@ID", myId);
            command3.Parameters.AddWithValue("@occupied_id", occup_id);
            command3.Parameters.AddWithValue("@employee_id", _employee_id);
            dbConnection.Open();
            command3.ExecuteNonQuery();
            dbConnection.Close();
        }
        private void get_empl_id()
        {
            string room_id = "select ID from Employee where [Code]=@theCode";

            OleDbCommand command5 = new OleDbCommand(room_id, dbConnection);
            command5.Parameters.AddWithValue("@theCode", employee_code);
            dbConnection.Open();
            reader3 = command5.ExecuteReader();

            if (reader3.Read())
            {
                _employee_id = reader3["ID"].ToString();
            }
            else
            {
                MessageBox.Show("There is no data!!");
            }
            reader3.Close();
            command5.ExecuteNonQuery();
            dbConnection.Close();
        }
        private void get_occupied_id()
        {
            string room_id = "select ID from occupied_room where [reservation_id]= @reservation_id";

            OleDbCommand command5 = new OleDbCommand(room_id, dbConnection);
            command5.Parameters.AddWithValue("@reservation_id", reservation_id);
            dbConnection.Open();
            reader3 = command5.ExecuteReader();

            if (reader3.Read())
            {
                occup_id = reader3["ID"].ToString();
            }
            else
            {
                MessageBox.Show("There is no data!!");
            }
            reader3.Close();
            command5.ExecuteNonQuery();
            dbConnection.Close();
        }
        private void insert_into_customer()
        {
            dbConnection.Open();
            string query2 = "insert into Customer(FName, LName, phone)  values('" + FName.Text + "','" + LName.Text + "','" + Phone.Text + "')";
            OleDbCommand command = dbConnection.CreateCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = query2;
            command.ExecuteNonQuery();
            dbConnection.Close();
        }

        private void get_last_id()
        {
            dbConnection.Open();
            string id = "SELECT top 1 id_Client FROM Customer ORDER BY id_Client desc ";

            OleDbCommand command2 = new OleDbCommand(id, dbConnection);
            reader = command2.ExecuteReader();

            if (reader.Read())
            {
                myId = reader["id_Client"].ToString();
            }

            reader.Close();
            command2.ExecuteNonQuery();
            dbConnection.Close();
        }

        private void get_room_id()
        {
            
            string room_id = "select room_ID from Room where [room_number]= @thenumber";

            OleDbCommand command5 = new OleDbCommand(room_id, dbConnection);
            command5.Parameters.AddWithValue("@thenumber", Number.Text);
            dbConnection.Open();
            reader2 = command5.ExecuteReader();

            if (reader2.Read())
            {
                the_room_id = reader2["room_ID"].ToString();
            }
            reader2.Close();
            command5.ExecuteNonQuery();
            dbConnection.Close();
        }
        private void get_reservation_id()
        {

            string room_id = "select ID from Reservation where [phone]= @thePhone";

            OleDbCommand command5 = new OleDbCommand(room_id, dbConnection);
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
        private void insert_into_reservation()
        {
            
            string query = "insert into Reservation(FName, LName, customer_id, phone, bed, room_number, room_type, price, check_IN, check_OUT)  values" +
                "(@FNAME, @LNAME, @ID, @PHONE, @BED,@NUMBER, @TYPE, @PRICE, @IN, @OUT )";

            OleDbCommand command3 = new OleDbCommand(query, dbConnection);
            command3.CommandType = CommandType.Text;
            command3.CommandText = query;
            command3.Parameters.AddWithValue("@FNAME", FName.Text);
            command3.Parameters.AddWithValue("@LNAME", LName.Text);
            command3.Parameters.AddWithValue("@ID", myId);
            command3.Parameters.AddWithValue("@PHONE", Phone.Text);
            command3.Parameters.AddWithValue("@BED", Bed.Text);
            command3.Parameters.AddWithValue("@NUMBER", Number.Text);
            command3.Parameters.AddWithValue("@TYPE", Type.Text);
            command3.Parameters.AddWithValue("@PRICE", Price.Text);
            command3.Parameters.AddWithValue("@IN", CheckIn.Value.ToString());
            command3.Parameters.AddWithValue("@OUT", CheckOut.Value.ToString());
            dbConnection.Open();
            command3.ExecuteNonQuery();
            dbConnection.Close();
        }

        private void update_room()
        {
            dbConnection.Open();
            string query3 = "UPDATE Room SET booked='"+"YES"+ "' WHERE [room_number]=@Number";
            OleDbCommand command4 = new OleDbCommand(query3, dbConnection);
            command4.CommandType = CommandType.Text;
            command4.CommandText = query3;
            command4.Parameters.AddWithValue("@Number", Number.Text);
            command4.ExecuteNonQuery();
            dbConnection.Close();
        }
        private void insert_into_occupied_room()
        {
            dbConnection.Open();
            string query6 = "insert into occupied_room(check_in, check_out, room_id, reservation_id)  values('" + CheckIn.Value.ToString() + "','" + CheckOut.Value.ToString() + "','" + the_room_id + "','" + reservation_id + "' )";
            OleDbCommand command6 = dbConnection.CreateCommand();
            command6.CommandType = CommandType.Text;
            command6.CommandText = query6;
            command6.ExecuteNonQuery();
            dbConnection.Close();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label13_Click(object sender, EventArgs e)
        {
            Home adinstrator = new Home();
            adinstrator.Show();
            this.Hide();
        }

        private void AddClient_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hotel1DataSet11.Room' table. You can move, or remove it, as needed.
            this.roomTableAdapter3.Fill(this.hotel1DataSet11.Room);
            // TODO: This line of code loads data into the 'hotel1DataSet10.Room' table. You can move, or remove it, as needed.
            // this.roomTableAdapter2.Fill(this.hotel1DataSet10.Room);
            // TODO: This line of code loads data into the 'hotel1DataSet9.Room' table. You can move, or remove it, as needed.
            //    this.roomTableAdapter1.Fill(this.hotel1DataSet9.Room);
            // TODO: This line of code loads data into the 'hotel1DataSet1.Room' table. You can move, or remove it, as needed.
            //  this.roomTableAdapter.Fill(this.hotel1DataSet1.Room);
            // TODO: This line of code loads data into the 'hotel1DataSet.Заказы' table. You can move, or remove it, as needed.
            //this.заказыTableAdapter.Fill(this.hotel1DataSet.Заказы);

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            filterData(Number.Text);
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        //private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        //{

        //}

        public void filterData(string valueToSearch)
        {
            try
            {
                dbConnection.Open();
                string query = "select * from Room where  `room_number` & `room_type`& `room_bed` & `room_price`  like '%" + valueToSearch + "%'";
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

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            filterData(Price.Text);
        }

        private void CheckOut_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void Bed_SelectedIndexChanged(object sender, EventArgs e)
        {
            filterData(Bed.Text.ToString());
        }

        private void Number_TextChanged(object sender, EventArgs e)
        {
            filterData(Number.Text);
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            Number.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            Type.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            Bed.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            Price.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            isBooked.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
        }

        private void Type_SelectedIndexChanged(object sender, EventArgs e)
        {
            filterData(Type.Text.ToString());
        }
    }
}
