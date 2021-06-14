using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using szop4kliens;
using ServiceReference1;
using System.Net;

namespace szop4kliens
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceReference1.
           we webservice = new WebService1SoapChannel(); //használjuk, mint objektum
            string srt =
            Console.WriteLine(srt);
            Console.WriteLine(webservice.anotherSimpleMethod(4, 3));
        }
    }
}
