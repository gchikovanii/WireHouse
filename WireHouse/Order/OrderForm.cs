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
    public partial class OrderForm : Form
    {
        string path = @"Data Source=DESKTOP-SM0C90P\SQLEXPRESS;Initial Catalog=ProductDB;Integrated Security=True";
        SqlCommand cmd;
        SqlConnection con;
        SqlDataReader dataReader;
        public OrderForm()
        {
            InitializeComponent();
            con = new SqlConnection(path);
            getOrders();
        }
        public void getOrders()
        {
            dataGridViewOrders.Rows.Clear();
            con.Open();
            cmd = new SqlCommand($"select * from ordeers_tb", con);
            dataReader = cmd.ExecuteReader();
            while (dataReader.Read())
            {
                dataGridViewOrders.Rows.Add(dataReader[0].ToString(), dataReader[1].ToString(), dataReader[2].ToString(), dataReader[3].ToString(), dataReader[4].ToString(), dataReader[5].ToString(), dataReader[6].ToString(), dataReader[7].ToString(), dataReader[8].ToString());
            }
            dataReader.Close();
            con.Close();
        }

        private void addPb_Click(object sender, EventArgs e)
        {
            addOrderForm addOrderForm = new addOrderForm();
            addOrderForm.Show();
            addOrderForm.customerNameTb.Enabled = false;
            addOrderForm.customerAddressTb.Enabled = false;
            addOrderForm.productNameTb.Enabled = false;
            addOrderForm.productPriceTb.Enabled = false;
            addOrderForm.customerIdTb.Enabled = false;
            addOrderForm.productidTb.Enabled = false;
        }

        private void dataGridViewOrders_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            addOrderForm addOrderForm = new addOrderForm();
            addOrderForm.orderDateDtm.Text = dataGridViewOrders.Rows[e.RowIndex].Cells[1].Value.ToString();
            addOrderForm.customerIdTb.Text = dataGridViewOrders.Rows[e.RowIndex].Cells[2].Value.ToString();
            addOrderForm.customerNameTb.Text = dataGridViewOrders.Rows[e.RowIndex].Cells[3].Value.ToString();
            addOrderForm.customerAddressTb.Text = dataGridViewOrders.Rows[e.RowIndex].Cells[4].Value.ToString();
            addOrderForm.productidTb.Text = dataGridViewOrders.Rows[e.RowIndex].Cells[5].Value.ToString();
            addOrderForm.productNameTb.Text = dataGridViewOrders.Rows[e.RowIndex].Cells[6].Value.ToString();
            addOrderForm.productPriceTb.Text = dataGridViewOrders.Rows[e.RowIndex].Cells[7].Value.ToString();
            addOrderForm.orderQtyTb.Text = dataGridViewOrders.Rows[e.RowIndex].Cells[8].Value.ToString();
            
            
            
        }
    }
}
