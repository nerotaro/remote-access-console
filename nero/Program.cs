using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using console;

namespace nero
{
    internal class Program
    {

        public static void Main(string[] args)
        {
            Console.WriteLine("Control Panel");

            sendCmd:
            sendCmd(Console.ReadLine());
            goto sendCmd;
        }
        public static void sendCmd(string cmd)
        {
            Socket s = new Socket(AddressFamily.InterNetworkV6, SocketType.Dgram, ProtocolType.Udp);
            s.SetSocketOption(SocketOptionLevel.IPv6, SocketOptionName.IPv6Only, false);
            IPEndPoint ipep = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 14518);
            Byte[] data = Encoding.UTF8.GetBytes(cmd.obfuscate());
            s.SendTo(data,ipep);
        }
        
    }
}