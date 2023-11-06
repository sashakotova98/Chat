using System.Net.Sockets;
using System.Net;
using System.Text;

namespace Client
{
    public partial class Enter_Window : Form
    {
        public Enter_Window()
        {
            InitializeComponent();
            Client.Instance.SubscribeToNewMsg(OnNewMessageReceived);
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            string login = tbLogin.Text;
            string password = tbPassword.Text;

            if (string.IsNullOrEmpty(login) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Будь ласка, введіть логін та пароль.");
                return;
            }

            Client.Instance.SendMessege("login", login, password);

            tbLogin.Clear();
            tbPassword.Clear();
        }



        private async Task OnNewMessageReceived(string message)
        {
            switch (message)
            {
                case "Auth failed!":
                    this.Invoke(new Action(() =>
                        {
                            tbMsg.Text = message;
                        }));
                    break;
                case "Enter as admin":
                    this.Invoke(new Action(() =>
                    {
                        tbMsg.Text = message;
                    }));
                    await Task.Delay(1000);

                    this.Invoke(new Action(() =>
                    {
                        this.Hide();
                        Admin_Window adminForm = new Admin_Window();
                        adminForm.Show();
                    }));                        
                        
                    break;
                case "Enter as user":
                    this.Invoke(new Action(() =>
                    {
                        tbMsg.Text = message;
                    }));
                    await Task.Delay(1000);

                    this.Invoke(new Action(() =>
                    {
                        this.Hide();
                        Client_Window clientForm = new Client_Window();
                        clientForm.Show();
                    }));
                    break;
            
            }
           
        }
    }
}
