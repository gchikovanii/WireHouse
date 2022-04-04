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
    public partial class addOrderForm : Form
    {
        string path = @"Data Source=DESKTOP-SM0C90P\SQLEXPRESS;Initial Catalog=ProductDB;Integrated Security=True";
        SqlCommand cmd;
        SqlConnection con;
        string qtyU;
        SqlDataReader dataReader;
         

        public addOrderForm()
        {
            InitializeComponent();
            con = new SqlConnection(path);
            getCustomers();
            getProduct();
        }
        public void getCustomers()
        {
            dataGridViewOrderCustomers.Rows.Clear();
            con.Open();
            cmd = new SqlCommand($"select id,CustomerName,CustoemrAddress from customers_tb", con);
            dataReader = cmd.ExecuteReader();
            while (dataReader.Read())
            {
                dataGridViewOrderCustomers.Rows.Add(dataReader[0].ToString(), dataReader[1].ToString(), dataReader[2].ToString());
            }
            dataReader.Close();
            con.Close();
        }
        public void getProduct()
        {
            dataGridViewOrderProduct.Rows.Clear();
            con.Open();
            cmd = new SqlCommand($"select pid,name,qty,price from product_tb", con);
            dataReader = cmd.ExecuteReader();
            while (dataReader.Read())
            {
                dataGridViewOrderProduct.Rows.Add(dataReader[0].ToString(), dataReader[1].ToString(),dataReader[2].ToString(), dataReader[3].ToString());
            }
            dataReader.Close();
            con.Close();
        }




        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
            if (MessageBox.Show("Do you want to Close?", "Add Category", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void dataGridViewCustomers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            customerIdTb.Text = dataGridViewOrderCustomers.Rows[e.RowIndex].Cells[0].Value.ToString();
            customerNameTb.Text = dataGridViewOrderCustomers.Rows[e.RowIndex].Cells[1].Value.ToString();
            customerAddressTb.Text = dataGridViewOrderCustomers.Rows[e.RowIndex].Cells[2].Value.ToString();
        }

        private void dataGridViewProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            productidTb.Text = dataGridViewOrderProduct.Rows[e.RowIndex].Cells[0].Value.ToString();
            productNameTb.Text = dataGridViewOrderProduct.Rows[e.RowIndex].Cells[1].Value.ToString();
            productPriceTb.Text = dataGridViewOrderProduct.Rows[e.RowIndex].Cells[3].Value.ToString();
            string qty = dataGridViewOrderProduct.Rows[e.RowIndex].Cells[2].Value.ToString();
            this.qtyU = qty;
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            customerIdTb.Clear();
            customerNameTb.Clear();
            customerAddressTb.Clear();
            productidTb.Clear();
            productNameTb.Clear();
            productPriceTb.Clear();
            orderQtyTb.Clear();
        }

        private void makeOrderBtn_Click(object sender, EventArgs e)
        {
            if(Convert.ToInt32(orderQtyTb.Text) > Convert.ToInt32(qtyU))
            {
                MessageBox.Show("Out of stock you orderd more products then we have!");
            }
            else if(Convert.ToInt32(orderQtyTb.Text) <= Convert.ToInt32(qtyU) && MessageBox.Show("Do you want to order this product?", "ORDER", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                con.Open();
                cmd = new SqlCommand($"insert into ordeers_tb (orderDate,customerID,customerName,customerAddress,productID,productName,price,qty) values ('{orderDateDtm.Value}','{customerIdTb.Text}','{customerNameTb.Text}', '{customerAddressTb.Text}','{productidTb.Text}','{productNameTb.Text}','{productPriceTb.Text}','{orderQtyTb.Text}')", con);
                cmd.ExecuteNonQuery();
                con.Close();
            }
            else
            {
                MessageBox.Show($"You canceled ordering Mode", "Cancel", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
        }
    }
}
