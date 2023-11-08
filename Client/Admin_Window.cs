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
            Client.Instance.SubscribeToUpdate(UpdateList);
            Client.Instance.SubscribeToReceivingMessagesToAdmin(UpdateListMesseges);
            this.Visible = false;

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
                        lbUsersShow.Invoke(() =>
                        {
                            lbUsersShow.Items.Clear();
                            foreach (string client in clients.Where(c => c != Client.Instance.LoggedInAs))
                            {
                                lbUsersShow.Items.Add(client);
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
                        lbMessages.Invoke(() =>
                        {
                            lbMessages.Items.Add(message);
                            lbMessages.ForeColor = Color.Blue;

                        });
                        break;
                    }
                }
            });
        }



        private void btnSend_Click(object sender, EventArgs e)
        {
            var msg = tbMessage.Text;

            if (lbUsersShow.SelectedItem == null)
            {
                MessageBox.Show("Пожалуйста, выберите пользователя из списка.");
                return;
            }
            if (string.IsNullOrWhiteSpace(msg))
            {
                MessageBox.Show("Введите сообщение для отправки.");
                return;
            }
            var recipient = lbUsersShow.SelectedItem.ToString();
            Client.Instance.SendMessegeToClients(msg, recipient);

            lbMessages.Invoke(() =>
            {
                lbMessages.Items.Add($"admin -> {recipient}: {msg}");
                lbMessages.ForeColor = Color.Red;
                
            });


            tbMessage.Clear();

        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            var selectItem = lbUsersShow.SelectedItem.ToString();
            Client.Instance.SendMessegeToDelete(selectItem);
           

        }

        private void btnBanUser_Click(object sender, EventArgs e)
        {
            var selectedItem = lbUsersShow.SelectedItem;
            if (selectedItem == null)
            {
                MessageBox.Show("Please select a user to ban.");
                return;
            }
            var selectItemString = selectedItem.ToString();

            Client.Instance.SendBanClient(selectItemString);
        }
    }
}
