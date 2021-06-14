using System;
using System.Net;
using System.Net.Sockets;
using System.IO;
using System.Configuration.Assemblies;

namespace Szop_2
{
    class Program
    {
        static void Main(string[] args)
        {
           /* IPHostEntry cimek = Dns.GetHostEntry(Dns.GetHostName());

            foreach (IPAddress ip in cimek.AddressList)
                Console.WriteLine("{0}", ip);*/


            IPAddress[] localIP = Dns.GetHostAddresses(Dns.GetHostName());

            foreach (IPAddress address in localIP)
            {
                if (address.AddressFamily == AddressFamily.InterNetwork)
                {
                    Console.WriteLine(address); 
                }
            }
            Console.ReadLine();
        }
    }
}
