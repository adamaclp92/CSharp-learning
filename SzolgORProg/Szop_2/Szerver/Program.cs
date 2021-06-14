using System;
using System.Net;
using System.Net.Sockets;
using System.IO;
using System.Configuration;
using System.Reflection;




namespace Szerver
{
    class Program
    { 
        static void Main(string[] args)
        {
            //Testing
            IPAddress ia = IPAddress.Parse("127.0.0.1");
            IPEndPoint ie = new IPEndPoint(ia, 8000);
            Console.WriteLine("Socket Test");
            Socket test = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            Console.WriteLine("AddressFamily: {0}", test.AddressFamily);
            Console.WriteLine("SocketType: {0}", test.SocketType);
            Console.WriteLine("ProtocolType: {0}", test.ProtocolType);
            Console.WriteLine("-----------------------------------------");

            //Blocking 
            Console.WriteLine("Blocking: {0}", test.Blocking);

            test.Blocking = false;
            Console.WriteLine("new Blocking: {0}", test.Blocking);
            Console.WriteLine("Connected: {0}", test.Connected);

            test.Close();

            //Server datas
            string hostName = Dns.GetHostName();
            Console.WriteLine("Local hostname: {0}", hostName);
            IPHostEntry myServer = Dns.GetHostEntry(hostName);
            Console.WriteLine("IP Address: {0}", myServer.AddressList[2].ToString());

            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("Waiting for connections....");


            //Listener
            TcpListener tcpListener = new TcpListener(IPAddress.Parse("127.0.0.1"), 10);
            tcpListener.Start();
            Socket socketForClient = tcpListener.AcceptSocket();


            if (socketForClient.Connected)
            {
                //Connected client -data
                IPEndPoint newclient = (IPEndPoint)socketForClient.RemoteEndPoint;
                Console.WriteLine("Client connected with {0} at port {1}", newclient.Address, newclient.Port);

                //Streams
                NetworkStream networkStream = new NetworkStream(socketForClient);
                StreamWriter streamWriter =
                new StreamWriter(networkStream);
                StreamReader streamReader =
                new StreamReader(networkStream);
                //Send message to client
                string outString = " > I'm " + hostName + "msg: Hello Client!!!";
                streamWriter.WriteLine(outString);
                streamWriter.Flush();
                //Read message form client
                string inString = streamReader.ReadLine();
                Console.WriteLine(inString);
                //Close streams
                streamReader.Close();
                networkStream.Close();
                streamWriter.Close();
            }

            socketForClient.Close();
            Console.WriteLine("Exiting...");
            Console.ReadKey();
        }

        
    }
}
