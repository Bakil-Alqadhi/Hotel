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
    public partial class AllEmployees : Form
    {
        public AllEmployees()
        {
            InitializeComponent();
        }

        private void label13_Click(object sender, EventArgs e)
        {
            Adinstrator adinstrator = new Adinstrator();
            adinstrator.Show();
            this.Hide();
        }

        private void AllPerson_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hotel1DataSet6.Employee' table. You can move, or remove it, as needed.
            this.employeeTableAdapter3.Fill(this.hotel1DataSet6.Employee);
            // TODO: This line of code loads data into the 'hotel1DataSet5.Employee' table. You can move, or remove it, as needed.
            this.employeeTableAdapter2.Fill(this.hotel1DataSet5.Employee);
            // TODO: This line of code loads data into the 'hotel1DataSet4.Employee' table. You can move, or remove it, as needed.
            this.employeeTableAdapter1.Fill(this.hotel1DataSet4.Employee);
            // TODO: This line of code loads data into the 'hotel1DataSet3.Employee' table. You can move, or remove it, as needed.
            this.employeeTableAdapter.Fill(this.hotel1DataSet3.Employee);
            // TODO: This line of code loads data into the 'hotel1DataSet2.Customer' table. You can move, or remove it, as needed.
            this.customerTableAdapter.Fill(this.hotel1DataSet2.Customer);
            // TODO: This line of code loads data into the 'hotel1DataSet.Персонал' table. You can move, or remove it, as needed.
           // this.персоналTableAdapter.Fill(this.hotel1DataSet.Персонал);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
