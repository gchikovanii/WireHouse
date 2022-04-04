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
    public partial class AddCategory : Form
    {
        string path = @"Data Source=DESKTOP-SM0C90P\SQLEXPRESS;Initial Catalog=ProductDB;Integrated Security = true";
        SqlConnection con;
        SqlCommand cmd;
        public AddCategory()
        {
            InitializeComponent();
            con = new SqlConnection(path);
            idValueTb.Hide();
            
        }
       
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to Close?", "Add Category", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            } 
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            
            if (MessageBox.Show("Do you want to save This category?", "Add Category", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
                con.Open();
                cmd = new SqlCommand($"insert into category_tb (CategoryName) values ('{categoryTb.Text}')",con);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Category Saved!");
            }

        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to update this Category?", "Category", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                con.Open();
                cmd = new SqlCommand($"update category_tb set CategoryName = '{categoryTb.Text}'", con);
                cmd.ExecuteNonQuery();
                con.Close();
            }
            else
            {
                MessageBox.Show($"You canceled Updating process", "Cancel", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to delete this product?", "DELETE", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                con.Open();
                cmd = new SqlCommand($"delete category_tb where id = '{idValueTb.Text}'", con);
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
