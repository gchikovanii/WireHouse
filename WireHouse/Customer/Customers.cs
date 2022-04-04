using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CompanyFullProject
{
    public partial class Customers : Form
    {
        string path = @"Data Source=DESKTOP-SM0C90P\SQLEXPRESS;Initial Catalog=ProductDB;Integrated Security=True";
        SqlCommand cmd;
        SqlConnection con;
        SqlDataReader dataReader;
        public Customers()
        {
            InitializeComponent();
            con = new SqlConnection(path);
            getCustomers();
        }
        public void getCustomers()
        {
            dataGridViewCustomers.Rows.Clear();
            con.Open();
            cmd = new SqlCommand($"select * from customers_tb", con);
            dataReader = cmd.ExecuteReader();
            while (dataReader.Read())
            {
                dataGridViewCustomers.Rows.Add(dataReader[0].ToString(), dataReader[1].ToString(), dataReader[2].ToString(), dataReader[3].ToString());
            }
            dataReader.Close();
            con.Close();
        }

        private void addPb_Click(object sender, EventArgs e)
        {
            addCustomerForm addCustomer = new addCustomerForm();
            addCustomer.Show();
            addCustomer.updateBtn.Enabled = false;
            addCustomer.deleteBtn.Enabled = false;
        }

        private void dataGridViewCustomers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewCustomers.Columns[e.ColumnIndex].Name == "Update")
            {
                addCustomerForm addCustomer = new addCustomerForm();
                addCustomer.prid.Text = dataGridViewCustomers.Rows[e.RowIndex].Cells[0].Value.ToString();
                addCustomer.customerNameTb.Text = dataGridViewCustomers.Rows[e.RowIndex].Cells[1].Value.ToString();
                addCustomer.addressTb.Text = dataGridViewCustomers.Rows[e.RowIndex].Cells[2].Value.ToString();
                addCustomer.phoneTb.Text = dataGridViewCustomers.Rows[e.RowIndex].Cells[3].Value.ToString();

                addCustomer.saveBtn.Enabled = false;
                addCustomer.deleteBtn.Enabled = false;
                addCustomer.ShowDialog();
            }
            else if (dataGridViewCustomers.Columns[e.ColumnIndex].Name == "Delete")
            {
                addCustomerForm addCustomer = new addCustomerForm();
                addCustomer.prid.Text = dataGridViewCustomers.Rows[e.RowIndex].Cells[0].Value.ToString();
                addCustomer.customerNameTb.Text = dataGridViewCustomers.Rows[e.RowIndex].Cells[1].Value.ToString();
                addCustomer.addressTb.Text = dataGridViewCustomers.Rows[e.RowIndex].Cells[2].Value.ToString();
                addCustomer.phoneTb.Text = dataGridViewCustomers.Rows[e.RowIndex].Cells[3].Value.ToString();

                addCustomer.saveBtn.Enabled = false;
                addCustomer.updateBtn.Enabled = false;
                addCustomer.ShowDialog();
            }
        }
    }
}
