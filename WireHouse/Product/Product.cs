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
    public partial class Product : Form
    {
        string path = @"Data Source=DESKTOP-SM0C90P\SQLEXPRESS;Initial Catalog=ProductDB;Integrated Security=True";
        SqlCommand cmd;
        SqlConnection con;
        SqlDataReader dataReader;

        public Product()
        {
            con = new SqlConnection(path);
            InitializeComponent();
            getProduct();
            


        }
        public void getProduct()
        {
            dataGridViewProduct.Rows.Clear();
            con.Open();
            cmd = new SqlCommand($"select * from product_tb", con);
            dataReader = cmd.ExecuteReader();
            while (dataReader.Read())
            {
                dataGridViewProduct.Rows.Add(dataReader[0].ToString(), dataReader[1].ToString(), dataReader[2].ToString(), dataReader[3].ToString(), dataReader[4].ToString(), dataReader[5].ToString());
            }
            dataReader.Close();
            con.Close();
        }


        private void addPb_Click_1(object sender, EventArgs e)
        {
            addProductForm addProduct = new addProductForm();
            addProduct.ShowDialog();
            Product product = new Product();
            product.getProduct();
        }

        private void dataGridViewProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dataGridViewProduct.Columns[e.ColumnIndex].Name == "Update")
            {
                addProductForm addProductForm = new addProductForm();
                addProductForm.pidValueTb.Text = dataGridViewProduct.Rows[e.RowIndex].Cells[0].Value.ToString();
                addProductForm.productNameTb.Text = dataGridViewProduct.Rows[e.RowIndex].Cells[1].Value.ToString();
                addProductForm.priceTb.Text = dataGridViewProduct.Rows[e.RowIndex].Cells[2].Value.ToString();
                addProductForm.qtyTb.Text = dataGridViewProduct.Rows[e.RowIndex].Cells[3].Value.ToString();
                addProductForm.descriptionTb.Text = dataGridViewProduct.Rows[e.RowIndex].Cells[4].Value.ToString();
                addProductForm.categoryCb.Text = dataGridViewProduct.Rows[e.RowIndex].Cells[5].Value.ToString();

                addProductForm.saveBtn.Enabled = false;
                addProductForm.deleteBtn.Enabled = false;
                addProductForm.ShowDialog();
            }
            else if(dataGridViewProduct.Columns[e.ColumnIndex].Name == "Delete")
            {
                addProductForm addProductForm = new addProductForm();
                addProductForm.pidValueTb.Text = dataGridViewProduct.Rows[e.RowIndex].Cells[0].Value.ToString();
                addProductForm.productNameTb.Text = dataGridViewProduct.Rows[e.RowIndex].Cells[1].Value.ToString();
                addProductForm.priceTb.Text = dataGridViewProduct.Rows[e.RowIndex].Cells[2].Value.ToString();
                addProductForm.qtyTb.Text = dataGridViewProduct.Rows[e.RowIndex].Cells[3].Value.ToString();
                addProductForm.descriptionTb.Text = dataGridViewProduct.Rows[e.RowIndex].Cells[4].Value.ToString();
                addProductForm.categoryCb.Text = dataGridViewProduct.Rows[e.RowIndex].Cells[5].Value.ToString();

                addProductForm.saveBtn.Enabled = false;
                addProductForm.updateBtn.Enabled = false;
                addProductForm.ShowDialog();
            }
           
        }
        
    }
}
