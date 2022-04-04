using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CompanyFullProject
{
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
        }
        Form aForm = null;
        private void OpenForm(Form form)
        {
            if (aForm != null)
                aForm.Close();
            aForm = form;
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            mainPagePanel.Controls.Add(form);
            form.Show();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            OpenForm(new Product());
        }

        private void categoryPb_Click(object sender, EventArgs e)
        {
            OpenForm(new CategoryForm());
        }

        private void customerPb_Click(object sender, EventArgs e)
        {
            OpenForm(new Customers());
        }

        private void usersPb_Click(object sender, EventArgs e)
        {
            OpenForm(new UserForm());
        }

        private void ordersPb_Click(object sender, EventArgs e)
        {
            OpenForm(new OrderForm());
        }
    }
}
