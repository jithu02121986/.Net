using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsAsyncApp.Services;

namespace WinFormsAsyncApp
{
    public partial class WelcomeForm : Form
    {
        private PrintServices _PrintServices;
        public WelcomeForm()
        {
            _PrintServices = new PrintServices();
            InitializeComponent();
        }

        private void button1_handler_Click(object sender, EventArgs e)
        {
            MessageBox.Show("button1_handler_Click-1");
            _PrintServices.Print();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _PrintServices.Print();
        }

        private void PrintViaThreadController(object sender, EventArgs e)
        {

        }
    }
}
