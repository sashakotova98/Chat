using Server.Models;
using System.Net;
using System.Net.Sockets;
using System.Text;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Server
{
    internal class Server
    {
        TcpListener server;
        List<OnlineClient> clients = new List<OnlineClient>();
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
                var newClient = new OnlineClient
                {
                    TcpClient = client,
                    Name = "",
                };
                clients.Add(newClient);
                _newClientHandler(newClient.TcpClient.Client.RemoteEndPoint.ToString());

                _ = RecieveMessage(newClient);
            }
        }

        private async Task RecieveMessage(OnlineClient client)
        {
            try
            {
                using var stream = new StreamReader(client.TcpClient.GetStream(), new UTF8Encoding(false), leaveOpen: true);
                while (client.TcpClient.Connected)
                {
                    var msg = await stream.ReadLineAsync();
                    if (string.IsNullOrEmpty(msg))
                        break;

                    _messageHandler(client.TcpClient.Client.RemoteEndPoint.ToString(), msg);

                    HandleMessage(msg, client);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void HandleMessage(string msg, OnlineClient client)
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

                        using (var stream = new StreamWriter(client.TcpClient.GetStream(), new UTF8Encoding(false), leaveOpen: true))
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

                        using (var stream = new StreamWriter(client.TcpClient.GetStream(), new UTF8Encoding(false), leaveOpen: true))
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
                                stream.Flush();

                                var onlineClient = clients.Where(c => c.TcpClient == client.TcpClient).Single();
                                onlineClient.Name = login;
                                SendUdpateOnlineClients();

                            }
                            stream.Flush();
                        }
                      
                        break;
                    case "message":
                        //var sender = context.Users.Where(x => x.LoginUser == client.Name).Single();

                        //if (!sender.BannedTo.HasValue || sender.BannedTo < DateTime.UtcNow)
                        //{
                            try
                            {
                                var text = msg.Split('|')[1];
                                var recipient = msg.Split('|')[2];

                                var receiverUser = context.Users.FirstOrDefault(u => u.LoginUser == recipient);
                                var senderLogin = client.Name;
                                var senderUser = context.Users.FirstOrDefault(u => u.LoginUser == senderLogin);

                                if (receiverUser != null && senderUser != null)
                                {
                                    var newMsg = new Models.Message
                                    {
                                        Text = text,
                                        SendDate = DateTime.Now,
                                        IsDelivered = true,
                                        SenderUserId = senderUser.Id,
                                        ReciverUserId = receiverUser.Id,
                                        ChatId = null
                                    };

                                    context.Messages.Add(newMsg);
                                    context.SaveChanges();
                                }

                                var recipientClient = clients.FirstOrDefault(c => c.Name == recipient);
                                if (recipientClient != null)
                                {
                                    using (var stream = new StreamWriter(recipientClient.TcpClient.GetStream(), new UTF8Encoding(false), leaveOpen: true))
                                    {
                                        stream.WriteLine($"message|{text}|{senderLogin}");
                                        stream.Flush();
                                    }
                                }
                            }

                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message);
                            }
                        //}
                        break;

                    case "delete-user":
                        var delClient = msg.Split('|')[1];
                        var onlineClientToRemove = clients.FirstOrDefault(c => c.Name == delClient);
                        if (onlineClientToRemove != null)
                        {
                            clients.Remove(onlineClientToRemove);
                            
                        }

                        var userToDelete = context.Users.Include(u => u.LoginPaasword).FirstOrDefault(u => u.LoginUser == delClient);
                        if (userToDelete != null)
                        {
                            var messagesToDelete = context.Messages.Where(m => m.SenderUserId == userToDelete.Id || m.ReciverUserId == userToDelete.Id).ToList();
                            context.Messages.RemoveRange(messagesToDelete);
                            var loginPasswordToDelete = context.Logins_Passwords.FirstOrDefault(lp => lp.Login == userToDelete.LoginUser);
                            if (loginPasswordToDelete != null)
                            {
                                context.Logins_Passwords.Remove(loginPasswordToDelete);
                            }
                            context.Users.Remove(userToDelete);
                            context.SaveChanges();
                        }
                        
                            SendUdpateOnlineClients();
                        break;
                    //case "ban":
                        //var banClient = msg.Split('|')[1];

                        //var userToBan = context.Users.FirstOrDefault(u => u.LoginUser == banClient);
                        //if (userToBan != null)
                        //{
                        //    userToBan.BannedTo = DateTime.Now + TimeSpan.FromSeconds(20);
                        //    context.SaveChanges();
                        //}
                        //using (var stream = new StreamWriter(client.TcpClient.GetStream(), new UTF8Encoding(false), leaveOpen: true))
                        //{
                        //    stream.WriteLine($"message|{text}|{senderLogin}");
                        //    stream.Flush();
                        //}



                        //break;


                }
            }                
        }

        private void SendUdpateOnlineClients()
        {
            foreach (var c in clients.Where(x => x.TcpClient.Connected))
            {
                var clientNames = clients.Select(x => x.Name);
                var clientsToStr = string.Join(",", clientNames);

                try
                {
                    using (var writer = new StreamWriter(c.TcpClient.GetStream(), new UTF8Encoding(false), leaveOpen: true))
                    {
                        writer.WriteLine($"update-clients|{clientsToStr}");
                        writer.Flush();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
             
            }
        }


        public void Stop()
        {
            server.Stop();
        }
    }
}
