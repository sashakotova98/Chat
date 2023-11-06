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
    public partial class Admin_Window : Form
    {
        public Admin_Window()
        {
            InitializeComponent();
        }

        private void btnAddNewUser_Click(object sender, EventArgs e)
        {
            using (Register_Window form = new Register_Window())
            {
                if (form.ShowDialog() == DialogResult.OK)
                {

                }
            }
        }

        private void Admin_Window_Load(object sender, EventArgs e)
        {
            //сервер мне посылает сообщение 
        }
    }
}
