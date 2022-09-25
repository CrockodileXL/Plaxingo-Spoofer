using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Plaxingo_Spoofer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Plaxingo-Spoofer... Pls Use Arguments to Spoof your PC");
            Thread.Sleep(1500);
            Console.Clear();
            if (args[0].StartsWith("-spoof_disk"))
            {
                Thread.Sleep(3000);
                Console.WriteLine("Spoofing Disks...");
                Spoofer disk_spoof = new Spoofer();
                disk_spoof.SpoofDisks();
                Console.WriteLine("Spoofing Disks is Complete!!!");
                Thread.Sleep(3500);
                Environment.Exit(122);
            }
            if (args[1].StartsWith("-spoof_guid"))
            {
                Thread.Sleep(1500);
                Console.WriteLine("Spoofing GUID...");
                Spoofer spoof_guid = new Spoofer();
                spoof_guid.SpoofGUIDs();
                Console.WriteLine("Spoofing GUID is Complete!!!");
                Thread.Sleep(3500);
                Environment.Exit(143);
            }
            if (args[2].StartsWith("-spoof_macaddress"))
            {
                Thread.Sleep(15000);
                Console.WriteLine("Spoofing MAC Address");
                Spoofer mac_spoof = new Spoofer();
                mac_spoof.SpoofMAC();
                Console.WriteLine("Spoofing MAC is Complete!!!");
                Thread.Sleep(1400);
                Environment.Exit(1224);
            }
        }
    }
}
