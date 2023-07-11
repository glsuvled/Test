using System;
using System.Net;
using System.Net.Sockets;

namespace NetworkPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            // string Address = Console.ReadLine();
            // IPAddress IP = IPAddress.Parse(Address);
            // Console.WriteLine("ip : {0}", IP.ToString());

            // IPAddress[] IP = Dns.GetHostAddresses("www.glsled.com");
            // foreach (IPAddress HostIP in IP)
            // {
            //     Console.WriteLine("{0}", HostIP);
            // }

            // IPHostEntry HostInfo = Dns.GetHostEntry("www.naver.com");
            // 
            // foreach (IPAddress ip in HostInfo.AddressList)
            // {
            //     Console.WriteLine("{0}", ip);
            // }
            // Console.WriteLine("{0}", HostInfo.HostName);

            // IPAddress IPInfo = IPAddress.Parse("127.0.0.1");
            // int port = 13;
            // IPEndPoint EndPointInfo = new IPEndPoint(IPInfo, port);

            // Console.WriteLine("ip: {0}", EndPointInfo.Address);
            // Console.WriteLine("port: {0}", EndPointInfo.Port);
            // Console.WriteLine(EndPointInfo.ToString());
            // Console.ReadKey();

            IPAddress ip = IPAddress.Parse("127.0.0.1");
            TcpListener tcpListener = new TcpListener(ip, 13);
            Console.WriteLine("{0}", tcpListener.LocalEndpoint.ToString());
            

        }
    }
}
