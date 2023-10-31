using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Test_Server;

namespace Client
{
    public partial class Client_Window : Form
    {
        TcpClient tcpClient;
        StreamReader reader;

        Clients_Info clients_info;

        List<Clients_Info> connectClients;

        public Client_Window()
        {
            InitializeComponent();
            clients_info = new Clients_Info();
            AddClients();

        }

        private void Client_Window_Load(object sender, EventArgs e)
        {
            try
            {
                tcpClient = new TcpClient();
                tcpClient.Connect(new IPEndPoint(IPAddress.Loopback, 12345));
                if (tcpClient.Connected)
                {
                    lblShowConnect.Text = "ON";
                }
                else
                {
                    lblShowConnect.Text = "OFF";
                }

                reader = new StreamReader(tcpClient.GetStream(), Encoding.UTF8);
                _ = ReceiveMessagesAsync();

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private async Task ReceiveMessagesAsync()
        {
            try
            {
                while (true)
                {
                    var message = await reader.ReadLineAsync();
                    if (string.IsNullOrEmpty(message))
                        continue;

                    AppendTextToRichTextBox(rtbWrite_Show_Message, message);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error receiving message: {ex.Message}");
            }
        }

        private void btnSend_Client_Click(object sender, EventArgs e)
        {
            string selectedClientName = lbUsersShow.SelectedItem as string;
            var selectClient = connectClients.FirstOrDefault(c => c.ClientName == selectedClientName);
            if (selectClient != null)
            {
                var message = rtbWrite_Show_Message.Text;
                if(string.IsNullOrEmpty(message))
                {
                    var sw = new StreamWriter(tcpClient.GetStream(), Encoding.UTF8);
                    sw.Write($"{rtbWrite_Show_Message.Text}\n");
                    sw.Flush();
                }
                else
                {
                    var sw1 = new StreamWriter(tcpClient.GetStream(), Encoding.UTF8);
                    sw1.Write($"{rtbWrite_Show_Message.Text}\n");
                    sw1.Flush();
                }
            }

            //rtbWrite_Show_Message.Clear();
            //rtbWrite_Show_Message.Focus();
        }

        private void AppendTextToRichTextBox(RichTextBox richTextBox, string text)
        {
            if (richTextBox.InvokeRequired)
            {
                richTextBox.Invoke(new Action(() => richTextBox.AppendText(text + Environment.NewLine)));
            }
            else
            {
                richTextBox.AppendText(text + Environment.NewLine);
            }
        }

        private void AddClients()
        {
            clients_info.AddClient(tcpClient, "Client1");
            clients_info.AddClient(tcpClient, "Client2");
            clients_info.AddClient(tcpClient, "Client3");
            clients_info.AddClient(tcpClient, "Client4");
            clients_info.AddClient(tcpClient, "Client5");

            lbUsersShow.Items.Clear();

            connectClients = clients_info.connectedClients;

            foreach (var clientInfo in connectClients)
            {
                lbUsersShow.Items.Add(clientInfo.ClientName!);
            }

        }
    }
}
