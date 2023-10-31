using System.Net;
using System.Net.Sockets;
using System.Text;

namespace Test_Server
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            TcpListener tcpListener = null!;
            List<TcpClient> connectedClients = new List<TcpClient>();

            try
            {
                tcpListener = new TcpListener(IPAddress.Any, 12345);
                tcpListener.Start(10);
                Console.WriteLine("Server is working!");

                while (true)
                {
                    var client = await tcpListener.AcceptTcpClientAsync();
                    connectedClients.Add(client);
                    _ = HandleClientAsync(client, connectedClients);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                tcpListener?.Stop();
            }


            //async Task WaitForConnectionAsync()
            //{
            //    while (true)
            //    {
            //        var client = await tcpListener.AcceptTcpClientAsync();
            //        _ = HandleClientAsync(client);
            //    }
            //}

            async Task HandleClientAsync(TcpClient client, List<TcpClient> connectedClients)
            {
                try
                {
                    var sr = new StreamReader(client.GetStream(), Encoding.UTF8);
                    while (true)
                    {
                        var msg = await sr.ReadLineAsync();

                        if (msg?.ToLower().StartsWith("exit") ?? false)
                            break;

                        Console.WriteLine($"{client.Client.RemoteEndPoint} => {msg}");

                        foreach (var otherClient in connectedClients)
                        {
                            if (otherClient != client)
                            {
                                var sw = new StreamWriter(otherClient.GetStream(), Encoding.UTF8);
                                sw.WriteLine($"{client.Client.RemoteEndPoint} => {msg}");
                                sw.Flush();
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error handling client: {ex.Message}");
                }
                finally
                {
                    client.Close();
                }
            }
        }
    }
}