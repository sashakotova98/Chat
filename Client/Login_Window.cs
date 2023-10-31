using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class Login_Window : Form
    {
        public Login_Window()
        {
            InitializeComponent();
        }

        private void btn_Enter_Login_Click(object sender, EventArgs e)
        {
            var client_window = new Client_Window();
            client_window.Show();
        }

        private void btn_Register_Login_Click(object sender, EventArgs e)
        {
            var register_window = new Register_Window();
            register_window.Show();
        }
    }
}
