using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Process process = new Process();
            //ProcessStartInfo startInfo = new ProcessStartInfo();
            ////startInfo.WindowStyle = ProcessWindowStyle.Hidden;
            //startInfo.FileName = "cmd.exe";
            //startInfo.Arguments = @"/K cd C:\Users\Alisha_Das\Documents\visual studio 2015\Projects\ConsoleApplication1";
            //startInfo.Arguments = @"git init";
            //process.StartInfo = startInfo;
            ////Process.Start("CMD.exe", @"/K cd C:\Users\Alisha_Das\Documents\visual studio 2015\Projects\ConsoleApplication1 / git init");
            ////Process.Start("CMD.exe", @"/K git init");
            //process.Start();
            Process p = new Process();
            ProcessStartInfo info = new ProcessStartInfo();
            info.FileName = "cmd.exe";
            info.RedirectStandardInput = true;
            info.UseShellExecute = false;

            p.StartInfo = info;
            p.Start();

            using (StreamWriter sw = p.StandardInput)
            {
                if (sw.BaseStream.CanWrite)
                {
                    sw.WriteLine(@"cd C:\Users\Alisha_Das\Documents\visual studio 2015\Projects\ConsoleApplication1");
                    sw.WriteLine(@"git init");
                    sw.WriteLine(@"git add .");
                    sw.WriteLine("git commit -m \"First Commint\"");
                    sw.WriteLine(@"git remote add origin1234 https://github.com/alishadas17/asd.git");
                    sw.WriteLine(@"git push -u origin1234 master");

                }
            }
        }
    }
}
