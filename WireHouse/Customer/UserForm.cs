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
    public partial class UserForm : Form
    {
        string path = @"Data Source=DESKTOP-SM0C90P\SQLEXPRESS;Initial Catalog=ProductDB;Integrated Security=True";
        SqlCommand cmd;
        SqlConnection con;
        SqlDataReader dataReader;
        public UserForm()
        {
            InitializeComponent();
            con = new SqlConnection(path);
            getUsers();
        }
        public void getUsers()
        {
            dataGridViewUsers.Rows.Clear();
            con.Open();
            cmd = new SqlCommand($"select * from user_tb", con);
            dataReader = cmd.ExecuteReader();
            while (dataReader.Read())
            {
                dataGridViewUsers.Rows.Add(dataReader[0].ToString(), dataReader[1].ToString(), dataReader[2].ToString(), dataReader[3].ToString(), dataReader[4].ToString(), dataReader[5].ToString());
            }
            dataReader.Close();
            con.Close();
        }

        private void dataGridViewCategory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewUsers.Columns[e.ColumnIndex].Name == "Update")
            {
                addUserForm addUser = new addUserForm();
                addUser.userId.Text = dataGridViewUsers.Rows[e.RowIndex].Cells[0].Value.ToString();
                addUser.userNameTb.Text = dataGridViewUsers.Rows[e.RowIndex].Cells[1].Value.ToString();
                addUser.userPasswordTb.Text = dataGridViewUsers.Rows[e.RowIndex].Cells[2].Value.ToString();
                addUser.userFullNameTb.Text = dataGridViewUsers.Rows[e.RowIndex].Cells[3].Value.ToString();
                addUser.userLastName.Text = dataGridViewUsers.Rows[e.RowIndex].Cells[4].Value.ToString();
                addUser.userPhoneTb.Text = dataGridViewUsers.Rows[e.RowIndex].Cells[5].Value.ToString();

                addUser.saveBtn.Enabled = false;
                addUser.deleteBtn.Enabled = false;
                addUser.ShowDialog();
            }
            else if (dataGridViewUsers.Columns[e.ColumnIndex].Name == "Delete")
            {
                addUserForm addUser = new addUserForm();
                addUser.userId.Text = dataGridViewUsers.Rows[e.RowIndex].Cells[0].Value.ToString();
                addUser.userNameTb.Text = dataGridViewUsers.Rows[e.RowIndex].Cells[1].Value.ToString();
                addUser.userPasswordTb.Text = dataGridViewUsers.Rows[e.RowIndex].Cells[2].Value.ToString();
                addUser.userFullNameTb.Text = dataGridViewUsers.Rows[e.RowIndex].Cells[3].Value.ToString();
                addUser.userLastName.Text = dataGridViewUsers.Rows[e.RowIndex].Cells[4].Value.ToString();
                addUser.userPhoneTb.Text = dataGridViewUsers.Rows[e.RowIndex].Cells[5].Value.ToString();

                addUser.saveBtn.Enabled = false;
                addUser.updateBtn.Enabled = false;
                addUser.ShowDialog();
            }
        }

        private void addPb_Click(object sender, EventArgs e)
        {
            addUserForm addUser = new addUserForm();
            addUser.Show();
            addUser.updateBtn.Enabled = false;
            addUser.deleteBtn.Enabled = false;
        }

        private void UserForm_Load(object sender, EventArgs e)
        {

        }
    }
}

