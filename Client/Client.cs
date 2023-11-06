﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic.Logging;


namespace Client
{
    internal class Client : IDisposable
    { 
        private TcpClient _tcpClient;
        public Func<string, Task> NewMessageReceived;
        public Func<string, Task> NewRegistReceived;
        public static Client Instance { get; private set; }

        public static Client Init()
        {
            Instance = new Client();
            return Instance;
        }

        private Client()
        {
            try
            {
                _tcpClient = new TcpClient();
                _tcpClient.Connect(IPAddress.Loopback, 12345);
                _ = RecieveMessage();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void SubscribeToNewMsg(Func<string, Task> handler)
        {
            NewMessageReceived = handler;
        }

        public void SubscribeNewRegistReceived(Func<string, Task> handler)
        {
            NewRegistReceived = handler;
        }

     

        public void SendMessege(string action, string log, string pas)
        {
            if (action != "registration" && action != "login")
            {
                throw new ArgumentException("Action must be 'registration' or 'login'.");
            }

            try
            {
                using var stream = new StreamWriter(_tcpClient.GetStream(), new UTF8Encoding(false), leaveOpen: true);
                stream.Write($"{action}|{log}|{pas}\n");
                stream.Flush();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        public async Task RecieveMessage()
        {
            try
            {
                NetworkStream stream = _tcpClient.GetStream();
                using var reader = new StreamReader(stream, new UTF8Encoding(false), leaveOpen: true);
                while (_tcpClient.Connected)
                {
                    var message = await reader.ReadLineAsync();

                    if (string.IsNullOrEmpty(message))
                        break;

                    if (message == "Auth failed!" || message == "Enter as admin" || message == "Enter as user")
                    {
                        await NewMessageReceived(message);
                    }

                    else if (message == "Successfully registered" || message == "Check data or this log already exist")
                    {
                         await NewRegistReceived(message);
                    }

                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void Dispose()
        {
            _tcpClient.Close();
            _tcpClient.Dispose();
        }
    }
}
