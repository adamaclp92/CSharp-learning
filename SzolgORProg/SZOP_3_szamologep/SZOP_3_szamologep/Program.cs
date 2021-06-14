using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;
using System.Configuration;
using System.Configuration.Assemblies;


namespace SZOP_3_szamologep
{
    class Program
    {
        static void Main(string[] args)
        {
            string portSzam = ConfigurationManager.AppSettings["portszam"];
           
            TcpChannel chan = new TcpChannel(int.Parse(portSzam));
            // HttpChannel http = new HttpChannel ( int .Parse ( port_2 ) ) ; lehetne ez is….
            ChannelServices.RegisterChannel(chan, false);
            RemotingConfiguration.RegisterWellKnownServiceType(typeof(Kalkulator), " Math", WellKnownObjectMode.SingleCall);
            Console.ReadLine();
        }
    }
}
