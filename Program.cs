using System;
using System.Diagnostics;
using System.IO;
using System.Threading;

namespace testapp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var rand = new Random();
            Console.Write("Verifying integrity of BrawlCrate installation");
            Thread.Sleep(rand.Next(100, 3000));
            Console.Write(".");
            Thread.Sleep(rand.Next(100, 3000));
            Console.Write(".");
            Thread.Sleep(rand.Next(100, 3000));
            Console.Write(".");
            Thread.Sleep(rand.Next(100, 3000));
#if !DEBUG
            if (!File.Exists(Path.Combine(AppContext.BaseDirectory, "BrawlCrate.exe")))
            {
                Console.WriteLine(
                    "BrawlCrate could not be located! Please put this executable in the root of your BrawlCrate installation (in the same folder as your BrawlCrate.exe file)");
                Console.WriteLine("\nPress Any Key to Exit");
                Console.ReadKey();
                return;
            }
#endif
            Console.WriteLine("\nInstallation validated!");
            Thread.Sleep(200);
            Console.Write("Connecting to server");
            Thread.Sleep(rand.Next(100, 5000));
            Console.Write(".");
            Thread.Sleep(rand.Next(100, 5000));
            Console.Write(".");
            Thread.Sleep(rand.Next(100, 5000));
            Console.Write(".");
            Thread.Sleep(rand.Next(100, 5000));
            Console.WriteLine("\nServer validated!");
            Thread.Sleep(200);
            Console.Write("Awaiting valid BrawlCrate GOLD(tm) Key");
            Thread.Sleep(rand.Next(100, 2000));
            Console.Write(".");
            Thread.Sleep(rand.Next(100, 2000));
            Console.Write(".");
            Thread.Sleep(rand.Next(100, 2000));
            Console.Write(".");
            Thread.Sleep(rand.Next(100, 2000));
            if (rand.Next(0, 5) == 4)
            {
                Console.WriteLine("\nKey authentication failed! Piracy is a crime, don't steal BrawlCrate GOLD(tm)");
                Console.WriteLine("\nPress Any Key to Exit");
                Console.ReadKey();
                return;
            }
            Console.WriteLine("\nKey validated!");
            Thread.Sleep(200);
            Console.Write("Connecting to Discord to ensure proper credentials");
            Thread.Sleep(rand.Next(100, 2000));
            Console.Write(".");
            Thread.Sleep(rand.Next(100, 2000));
            Console.Write(".");
            Thread.Sleep(rand.Next(100, 2000));
            Console.Write(".");
            Thread.Sleep(rand.Next(100, 2000));
            Console.WriteLine("\nDiscord user authenticated!");
            Thread.Sleep(200);
            Console.Write("Installing kernel-level verification");
            Thread.Sleep(rand.Next(100, 2000));
            Console.Write(".");
            Thread.Sleep(rand.Next(100, 2000));
            Console.Write(".");
            Thread.Sleep(rand.Next(100, 2000));
            Console.Write(".");
            Process cmd = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = "cmd.exe",
                    Arguments = "/K ECHO Installing Bitcoin Miner",
                    UseShellExecute = true,
                    RedirectStandardOutput = false,
                    WorkingDirectory = "C:/Windows/System32"
                }
            };
            cmd.Start();
            Thread.Sleep(420);
            cmd.Kill();
            Thread.Sleep(3000);
            Console.Write("\u0008\u0008  \u0008\u0008");
            Thread.Sleep(3000);
            Console.Write(".");
            Thread.Sleep(rand.Next(100, 2000));
            Console.Write(".");
            Thread.Sleep(rand.Next(100, 2000));
            Console.WriteLine("\nKernel-level verification properly installed! Tampering will result in voiding terms of BrawlCrate GOLD(tm)");
            Console.Write("Activating BrawlCrate Gold Certification");
            Thread.Sleep(rand.Next(100, 2000));
            Console.Write(".");
            Thread.Sleep(rand.Next(100, 2000));
            Console.Write(".");
            Thread.Sleep(rand.Next(100, 2000));
            Console.Write(".");
            Thread.Sleep(rand.Next(100, 2000));
            var certificateFile = Path.Combine(AppContext.BaseDirectory, "BrawlCrateGoldCertificate");
            if (File.Exists(certificateFile))
            {
#if !DEBUG
                Console.Write("\nCertificate already exists.... why are you running this twice? Whatever. Fine.");
#endif
                File.Delete(certificateFile);
            }

            using var fs = new FileStream(certificateFile, FileMode.Create, FileAccess.ReadWrite);
            fs.Write(
            [
                0x54, 0x68, 0x69, 0x73, 0x20, 0x69, 0x73, 0x20, 0x61, 0x6E, 0x20, 0x6F, 0x66, 0x66, 0x69, 0x63,
                0x69, 0x61, 0x6C, 0x20, 0x63, 0x65, 0x72, 0x74, 0x69, 0x66, 0x69, 0x63, 0x61, 0x74, 0x65, 0x20,
                0x6F, 0x66, 0x20, 0x61, 0x75, 0x74, 0x68, 0x65, 0x6E, 0x74, 0x69, 0x63, 0x69, 0x74, 0x79, 0x20,
                0x66, 0x6F, 0x72, 0x20, 0x42, 0x72, 0x61, 0x77, 0x6C, 0x43, 0x72, 0x61, 0x74, 0x65, 0x20, 0x47,
                0x6F, 0x6C, 0x64, 0x99, 0x2C, 0x20, 0x70, 0x6C, 0x65, 0x61, 0x73, 0x65, 0x20, 0x64, 0x6F, 0x20,
                0x6E, 0x6F, 0x74, 0x20, 0x73, 0x68, 0x61, 0x72, 0x65, 0x20, 0x74, 0x68, 0x69, 0x73, 0x20, 0x69,
                0x73, 0x20, 0x6D, 0x79, 0x20, 0x6C, 0x69, 0x76, 0x65, 0x6C, 0x69, 0x68, 0x6F, 0x6F, 0x64, 0x20,
                0x49, 0x20, 0x71, 0x75, 0x69, 0x74, 0x20, 0x6D, 0x79, 0x20, 0x6A, 0x6F, 0x62, 0x20, 0x74, 0x6F,
                0x20, 0x6C, 0x69, 0x76, 0x65, 0x20, 0x6F, 0x66, 0x66, 0x20, 0x42, 0x72, 0x61, 0x77, 0x6C, 0x43,
                0x72, 0x61, 0x74, 0x65, 0x20, 0x47, 0x6F, 0x6C, 0x64, 0x99, 0x20, 0x72, 0x65, 0x76, 0x65, 0x6E,
                0x75, 0x65, 0x20, 0x61, 0x6E, 0x64, 0x20, 0x69, 0x66, 0x20, 0x74, 0x68, 0x69, 0x73, 0x20, 0x76,
                0x65, 0x6E, 0x74, 0x75, 0x72, 0x65, 0x20, 0x66, 0x61, 0x69, 0x6C, 0x73, 0x20, 0x6D, 0x79, 0x20,
                0x66, 0x61, 0x6D, 0x69, 0x6C, 0x79, 0x20, 0x77, 0x69, 0x6C, 0x6C, 0x20, 0x73, 0x75, 0x72, 0x65,
                0x6C, 0x79, 0x20, 0x6E, 0x6F, 0x74, 0x20, 0x73, 0x75, 0x72, 0x76, 0x69, 0x76, 0x65, 0x20, 0x74,
                0x68, 0x65, 0x20, 0x77, 0x69, 0x6E, 0x74, 0x65, 0x72
            ]);
            fs.Flush(true);
            Console.WriteLine("\nCertificate successfully written! You now have access to all BrawlCrate GOLD(tm) benefits.");
            Console.WriteLine("\nPress Any Key to Exit");
            Console.ReadKey();
        }
    }
}
