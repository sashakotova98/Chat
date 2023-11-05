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
        }

        private async void btnSend_Click(object sender, EventArgs e)
        {
           

            //NetworkStream stream = Tcp.Client.GetStream();
            //byte[] data = Encoding.UTF8.GetBytes("message|" + textBox1.Text + "\n");
            //await stream.WriteAsync(data, 0, data.Length);

            //await stream.FlushAsync();
            //textBox1.Clear();
        }
    }
}