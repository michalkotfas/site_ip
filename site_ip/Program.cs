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
            Console.WriteLine("Witaj w programie znajdujacym adres IP podanej witryny\n");
            Console.WriteLine("Wpisz adres strony:\n");
            var adres = Console.ReadLine();
            IPHostEntry adresWWW = Dns.GetHostEntry(adres);
            IPAddress adresIP = adresWWW.AddressList[0];
            Console.WriteLine("\n");
            Console.WriteLine("Adres IP witryny "+adres+" to: "+adresIP.ToString());
            Console.ReadKey();
        }
    }
}
