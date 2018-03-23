using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;

namespace Server
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Socket server = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            IPEndPoint ipe = new IPEndPoint(IPAddress.Any, 995);
            server.Bind(ipe);
            EndPoint ep = ipe;
            Random rd = new Random();
            
            while (true)
            {
                byte[] receiveData = new byte[1024];
                server.ReceiveFrom(receiveData, ref ep);
                int clientResult = Convert.ToInt32(Encoding.ASCII.GetString(receiveData));
                string serverResult = rd.Next(0, 3).ToString();
                byte[] sendData = Encoding.ASCII.GetBytes(serverResult);
                if (serverResult == "0")
                    Console.WriteLine("-- Keo");
                else if (serverResult == "1")
                    Console.WriteLine("-- bao");
                else
                    Console.WriteLine("-- bua");
                server.SendTo(sendData, ep);
            }
                 
        }
        
    }
    
}
