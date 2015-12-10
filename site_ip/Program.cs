using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace site_ip
{
    class Program
    {
        static void Main(string[] args)
        {
            IPHostEntry adresWWW = Dns.GetHostEntry("www.google.com");
            IPAddress adresIP = adresWWW.AddressList[0];

            Console.WriteLine(adresIP.ToString());

            Console.ReadKey();
        }
    }
}
