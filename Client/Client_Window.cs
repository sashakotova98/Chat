using System.Net;
using System.Net.Sockets;
using System.Text;

namespace Client
{
    public partial class Client_Window : Form
    {
        public Client_Window()
        {
            InitializeComponent();
            Client.Instance.SubscribeToUpdate(UpdateList);
            Client.Instance.SubscribeToReceivingMessages(UpdateListMesseges);
            this.Visible = false;
        }

        private async void btnSend_Click(object sender, EventArgs e)
        {
            var msg = tbMessage.Text;

            if (lbContacts.SelectedItem == null)
            {
                MessageBox.Show("Пожалуйста, выберите пользователя из списка.");
                return;
            }
            if (string.IsNullOrWhiteSpace(msg))
            {
                MessageBox.Show("Введите сообщение для отправки.");
                return;
            }
            var recipient = lbContacts.SelectedItem.ToString();
            Client.Instance.SendMessegeToClients(msg, recipient);

            lbContacts.Invoke(() =>
            {
                lbContacts.Items.Add($"client -> {recipient}: {msg}");
            });


            tbMessage.Clear();
        }

        private void UpdateList(List<string> clients)
        {
            Task.Run(async () =>
            {
                while (true)
                {
                    if (!this.IsHandleCreated)
                    {
                        await Task.Delay(10);
                    }
                    else
                    {
                        lbContacts.Invoke(() =>
                        {
                            lbContacts.Items.Clear();
                            foreach (string client in clients.Where(c => c != Client.Instance.LoggedInAs))
                            {
                                lbContacts.Items.Add(client);
                            }
                        });
                        break;
                    }
                }
            });
        }

        private void UpdateListMesseges(string message)
        {

            Task.Run(async () =>
            {
                while (true)
                {
                    if (!this.IsHandleCreated)
                    {
                        await Task.Delay(10);
                    }
                    else
                    {
                        lbMessage.Invoke(() =>
                        {
                            lbMessage.Items.Add(message);
                        });
                        break;
                    }
                }
            });
        }


    }
}