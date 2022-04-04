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
    public partial class addUserForm : Form
    {
        string path = @"Data Source=DESKTOP-SM0C90P\SQLEXPRESS;Initial Catalog=ProductDB;Integrated Security=True";
        SqlCommand cmd;
        SqlConnection con;
        public addUserForm()
        {
            InitializeComponent();
            con = new SqlConnection(path);
            userId.Hide();
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
            if (MessageBox.Show("Do you want to save this product?", "SAVE", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                con.Open();
                cmd = new SqlCommand($"insert into user_tb (username,password,uname,ulastname,phone) values ('{userNameTb.Text}','{userPasswordTb.Text}','{userFullNameTb.Text}','{userLastName.Text}','{userPhoneTb.Text}')", con);
                cmd.ExecuteNonQuery();
                con.Close();

            }
            else
            {
                MessageBox.Show("You canceled savinig", "Cancel", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to update this product?", "UPDATE", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                con.Open();
                cmd = new SqlCommand($"update user_tb set username = '{userNameTb.Text}',password ='{passwordTb.Text}',uname ='{userFullNameTb.Text}' ,ulastname ='{userLastName.Text}',phone ='{userPhoneTb.Text}' where uid ='{userId.Text}'", con);
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

            if (MessageBox.Show("Do you want to delete this product?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                con.Open();
                cmd = new SqlCommand($"delete user_tb where uid = {userId.Text}", con);
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
