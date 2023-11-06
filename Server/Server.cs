using Server.Models;
using System.Net;
using System.Net.Sockets;
using System.Text;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace Server
{
    internal class Server
    {
        TcpListener server;
        List<TcpClient> clients = new List<TcpClient>();
        Action<string, string> _messageHandler;
        Action<string> _newClientHandler;

        public Server()
        {
            // create context for ensuring DB
            using var context = new ChatDbContextFactory().CreateDbContext(Array.Empty<string>());

            server = new TcpListener(IPAddress.Any, 12345);
            server.Start(10);
            _ = WaitForConnection();
        }

        public void SubscribeToMessages(Action<string, string> handler)
        {
            _messageHandler = handler;
        }

        public void SubscribeToNewClient(Action<string> handler)
        {
            _newClientHandler = handler;
        }

        private async Task WaitForConnection()
        {
            while (true)
            {
                TcpClient client = await server.AcceptTcpClientAsync();
                clients.Add(client);

                _newClientHandler(client.Client.RemoteEndPoint.ToString());

                _ = RecieveMessage(client);
            }
        }

        private async Task RecieveMessage(TcpClient client)
        {
            try
            {
                using var stream = new StreamReader(client.GetStream(), new UTF8Encoding(false), leaveOpen: true);
                while (client.Connected)
                {
                    var msg = await stream.ReadLineAsync();
                    if (string.IsNullOrEmpty(msg))
                        break;

                    _messageHandler(client.Client.RemoteEndPoint.ToString(), msg);

                    HandleMessage(msg, client);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void HandleMessage(string msg, TcpClient client)
        {
            using (var context = new ChatDbContextFactory().CreateDbContext(Array.Empty<string>()))
            {
                var msgType = msg.Split('|')[0];
                switch (msgType)
                {
                    case "registration":
                        var logn = msg.Split('|')[1];
                        var pas = msg.Split('|')[2];

                       

                        var userrgist = context.Users
                            .Where(x => x.LoginUser == logn)
                            .FirstOrDefault();

                        using (var stream = new StreamWriter(client.GetStream(), new UTF8Encoding(false), leaveOpen: true))
                        {

                            if (userrgist == null)
                            {
                                var userRole = context.Roles.First(r => r.RoleName == "User");
                                var newUser = new User
                                {
                                    LoginPaasword = new LoginPassword
                                    {
                                        Login = logn,
                                        Password = pas,
                                    },
                                    RoleId = userRole.Id,
                                };
                                context.Users.Add(newUser);
                                context.SaveChanges();
                                stream.WriteLine("Successfully registered");
                            }
                            else
                            {
                                stream.WriteLine("Check data or this log already exist");
                            }
                        }
                            break;
                    case "login":
                        var login = msg.Split('|')[1];
                        var password = msg.Split('|')[2];

                        var user = context.Users.Include(u => u.Role)
                            .Where(x => x.LoginPaasword.Login == login && x.LoginPaasword.Password == password)
                            .FirstOrDefault();

                        using (var stream = new StreamWriter(client.GetStream(), new UTF8Encoding(false), leaveOpen: true))
                        {
                            if (user == null)
                            {
                                // send "auth failed"
                                stream.WriteLine("Auth failed!");
                            }
                            else
                            {
                                // send "auth success"
                                if (user.Role.RoleName == "Admin")
                                {
                                    stream.WriteLine("Enter as admin");
                                }
                                else if (user.Role.RoleName == "User")
                                {
                                    stream.WriteLine("Enter as user");
                                }
                            }
                            stream.Flush();
                        }
                      
                        break;
                    case "message":

                        break;
                }
            }                
        }


        public void Stop()
        {
            server.Stop();
        }

    }
}
