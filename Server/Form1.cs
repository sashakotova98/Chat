namespace Server;

public partial class Form1 : Form
{
    private Server server;

    public Form1()
    {
        InitializeComponent();
        server = new Server();
        server.SubscribeToMessages(HandleMessage);
        server.SubscribeToNewClient(HandleNewClient);
    }

    private void HandleMessage(string newCLientEndpoint, string message)
    {
        lbMessage.Invoke(() =>
        {
            lbMessage.Items.Add($"{newCLientEndpoint}: {message}");
        });
    }

    private void HandleNewClient(string newCLientEndpoint)
    {
        lbMessage.Invoke(() =>
        {
            lbMessage.Items.Add($"Входящее подключение: {newCLientEndpoint}");
            lbContacts.Items.Add(newCLientEndpoint);
        });
    }

    private void Form1_FormClosing(object sender, FormClosingEventArgs e)
    {
        server.Stop();
    }
}
