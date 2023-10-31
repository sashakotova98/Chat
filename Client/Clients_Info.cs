using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Test_Server
{
    public class Clients_Info
    {
        public TcpClient? TcpClient { get; set; }
        public string? ClientName { get; set; }

        public List<Clients_Info> connectedClients = new List<Clients_Info>();

        public void AddClient(TcpClient tcpClient, string? clientName)
        {
            var clientInfo = new Clients_Info { TcpClient = tcpClient, ClientName = clientName };
            connectedClients.Add(clientInfo);
        }
    }
}
