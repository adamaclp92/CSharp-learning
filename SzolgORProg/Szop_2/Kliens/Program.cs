using System;
using System;
using System.Net;
using System.Net.Sockets;
using System.IO;
using System.Configuration;
using System.Reflection;


namespace Kliens
{
    class Program
    {
        static void Main(string[] args)
        {
            TcpClient socketForServer;
            try
            {
                socketForServer = new TcpClient("localHost", 10);
            }
            catch
            {
                Console.WriteLine("Failed to connect to server at {0}:999", "localhost");
                Console.WriteLine("<Press Enter>");
                Console.ReadKey();
                return;
            }
            NetworkStream networkStream = socketForServer.GetStream();
            StreamReader streamReader = new StreamReader(networkStream);
            StreamWriter streamWriter = new StreamWriter(networkStream);

            try
            {
                string StringForServer = streamReader.ReadLine();
                Console.WriteLine(StringForServer);
                streamWriter.WriteLine("Hello server!!!");
                streamWriter.Flush();
            }
            catch
            {
                Console.WriteLine("Exception reading from Server");
                Console.WriteLine("<Press Enter>");
                Console.ReadKey();
            }
            Console.WriteLine("Exiting...");
            Console.ReadKey();

            networkStream.Close();
        }
    }
}
