using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace diearatorLog
{
    class Program
    {
        public static gui1 guiform = new gui1();
        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                
                Console.WriteLine("Diearator Failure. Arguments required...");
            }
            if (args.Length > 0)
            {

                if (args[0] == "scan")
                {
                    Diearator.Scan();
                }
            }

            if (args.Length > 0)
            {
                if (args[0] == "activate")
                {
                    Diearator.DieActiv();
                }
            }
            if (args.Length > 0)


                if (args[0] == "denyhost")
                {
                    Diearator.denyhost(true);
                    
                }
            if (args.Length == 2)


                if (args[0] == "deny")
                {
                    Diearator.denyIp(args[1]);
                    
                }
            //Graphical user interface command
            if (args.Length > 0)
                if (args[0] == "gui") {
                    Diearator.DieActiv();
                    Console.WriteLine("Generating Form...");
                    
                    guiform.ShowDialog();
                    Console.WriteLine("Press any key to close...");
                    Console.ReadKey();
                }

            if (args.Length > 0)



                if (args[0] == "AMIDIBOSS")
                {
                    ami.amidiboss();
                    
                }
            if (args.Length > 0)


                if (args[0] == "ihavenofriends...")
                {
                    ami.hellodarkness();
                    
                }





        }
        
        

    }
}
