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
    public partial class CategoryForm : Form
    {
        string path = @"Data Source=DESKTOP-SM0C90P\SQLEXPRESS;Initial Catalog=ProductDB;Integrated Security=True";
        SqlCommand cmd;
        SqlConnection con;
        SqlDataReader dataReader;
        public CategoryForm()
        {
            con = new SqlConnection(path);
            InitializeComponent();
            getCategoty();
        }

        private void addPb_Click(object sender, EventArgs e)
        {
            AddCategory ac = new AddCategory();
            ac.deleteBtn.Enabled = false;
            ac.updateBtn.Enabled = false;
            ac.ShowDialog();

        }
        public void getCategoty()
        {
            dataGridViewCategory.Rows.Clear();
            con.Open();
            cmd = new SqlCommand($"select * from category_tb", con);
            dataReader = cmd.ExecuteReader();
            while (dataReader.Read())
            {
                dataGridViewCategory.Rows.Add(dataReader[0].ToString(), dataReader[1].ToString());
            }
            dataReader.Close();
            con.Close();
        }
        private void dataGridViewCategory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewCategory.Columns[e.ColumnIndex].Name == "Update")
            {
                AddCategory addCategory = new AddCategory();
                addCategory.idValueTb.Text = dataGridViewCategory.Rows[e.RowIndex].Cells[0].Value.ToString();
                addCategory.categoryTb.Text = dataGridViewCategory.Rows[e.RowIndex].Cells[1].Value.ToString();

                addCategory.saveBtn.Enabled = false;
                addCategory.deleteBtn.Enabled = false;
                addCategory.ShowDialog();
            }
            else if (dataGridViewCategory.Columns[e.ColumnIndex].Name == "Delete")
            {
                AddCategory addCategory = new AddCategory();
                addCategory.idValueTb.Text = dataGridViewCategory.Rows[e.RowIndex].Cells[0].Value.ToString();
                addCategory.categoryTb.Text = dataGridViewCategory.Rows[e.RowIndex].Cells[1].Value.ToString();

                addCategory.saveBtn.Enabled = false;
                addCategory.updateBtn.Enabled = false;
                addCategory.ShowDialog();
            }
        }
    }
}
