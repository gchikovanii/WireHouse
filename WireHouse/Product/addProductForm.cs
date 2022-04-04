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
using System.Runtime.InteropServices;


namespace CompanyFullProject
{
    
    public partial class addProductForm : Form
    {
        string path = @"Data Source=DESKTOP-SM0C90P\SQLEXPRESS;Initial Catalog=ProductDB;Integrated Security=True";
        SqlCommand cmd;
        SqlConnection con;
        SqlDataReader dataReader;

        public addProductForm()
        {
            con = new SqlConnection(path);
            InitializeComponent();
            pidValueTb.Hide();
            getCategory();
            
        }
        void getCategory()
        {
            con.Open();
            cmd = new SqlCommand($"select CategoryName from category_tb", con);
            dataReader = cmd.ExecuteReader();
            while (dataReader.Read())
            {
                categoryCb.Items.Add(dataReader[0].ToString());
            }
            dataReader.Close();
            con.Close();
        }
        private void saveBtn_Click(object sender, EventArgs e)
        {
          

            if (MessageBox.Show("Do you want to save this product?","SAVE",MessageBoxButtons.YesNo,MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                con.Open();
                cmd = new SqlCommand($"insert into product_tb (name,qty,price,description,category) values ('{productNameTb.Text}','{Convert.ToInt32(qtyTb.Text)}', '{Convert.ToInt32(priceTb.Text)}','{descriptionTb.Text}','{categoryCb.SelectedItem.ToString()}')", con);
                cmd.ExecuteNonQuery();
                con.Close();
               
            }
            else
            {
                MessageBox.Show($"You canceled savinig of {productNameTb.Text}", "Cancel", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to update this product?", "UPDATE", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                con.Open();
                cmd = new SqlCommand($"update product_tb set name = '{productNameTb.Text}',qty = '{qtyTb.Text}',price ='{priceTb.Text}',description ='{descriptionTb.Text}' ,category ='{categoryCb.Text}' where pid ={pidValueTb.Text}", con);                
                cmd.ExecuteNonQuery();
                con.Close();
            }
            else
            {
                MessageBox.Show($"You canceled Updating process", "Cancel", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to Close?", "Add Category", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to delete this product?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                con.Open();
                cmd = new SqlCommand($"delete product_tb where pid = {pidValueTb.Text}", con);
                cmd.ExecuteNonQuery();
                con.Close();
            }
            else
            {
                MessageBox.Show($"You canceled Deleting", "Cancel", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
           
        }
    }
}
