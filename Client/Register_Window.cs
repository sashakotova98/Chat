using System.Text;

namespace Client
{
    public partial class Register_Window : Form
    {

        public Register_Window()
        {
            InitializeComponent();
            Client.Instance.SubscribeNewRegistReceived(OnNewMessageReceived);
        }

        private void bntRegistration_Click(object sender, EventArgs e)
        {
            string login = tbLogin.Text;
            string password = tbPassword.Text;

            if (string.IsNullOrEmpty(login) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Будь ласка, введіть логін та пароль.");
                return;
            }

            Client.Instance.SendMessege("registration", login, password);

            tbLogin.Clear();
            tbPassword.Clear();
        }

        private async Task OnNewMessageReceived(string message)
        {
            switch (message)
            {
                case "Check data or this log already exist":
                    this.Invoke(new Action(() =>
                    {
                        tbMsg.Text = message;
                    }));
                    break;
                case "Successfully registered":
                    this.Invoke(new Action(() =>
                    {
                        tbMsg.Text = message;
                    }));
                    await Task.Delay(1000);
                    this.Invoke(new Action(() =>
                    {
                        this.Hide();
                    }));
                    break;

                   
            }


        }
    }



}
