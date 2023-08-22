using System;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Collections.Generic;
using Client.Commands;


namespace Client
{
    internal class Program
    {
        private static Socket s;
        private static CommandHandler ch;

        public static void Main(string[] args)
        {
            ch = new CommandHandler();

            s = new Socket(AddressFamily.InterNetworkV6, SocketType.Dgram, ProtocolType.Udp);
            s.SetSocketOption(SocketOptionLevel.IPv6, SocketOptionName.IPv6Only, false);
            s.Bind(new IPEndPoint(IPAddress.IPv6Any, 14518));

            Task t = Task.Factory.StartNew(listen);


            Console.ReadKey();

        }

        public static void listen()
        {
            IPEndPoint ipep = new IPEndPoint(IPAddress.IPv6Any, 0);
            EndPoint ep = ipep as EndPoint;
            Byte[] data = new Byte[65535];
            s.ReceiveFrom(data, ref ep);
            List<Byte> bytes = new List<Byte>(data);
            bytes.RemoveAll(b => b == 0);
            Console.WriteLine(ch.runCommand(Encoding.ASCII.GetString(bytes.ToArray())));
            listen();
        }

    }
}