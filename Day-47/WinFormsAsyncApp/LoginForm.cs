using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsAsyncApp
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void Login_Click(object sender, EventArgs e)
        {
            string userName = txtuser.Text;
            string password = txtpass.Text;

            if (userName == "admin" && password == "admin")
            {
                MessageBox.Show("Login Successfull");
            }
            else
            {
                MessageBox.Show("Please enter the Valid credentials !");
            }
        }
    }
}
