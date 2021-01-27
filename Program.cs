using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsInputOutput
{
    class Program
    {
        static void Main(string[] args)
        {

            DriveInfo dio = new DriveInfo("C:");
            Console.WriteLine($"Drive Name :{dio.Name}");
            Console.WriteLine($"Volume Label :{dio.VolumeLabel}");
            Console.WriteLine($"Available Free Space:{dio.AvailableFreeSpace}");
            Console.WriteLine($"Tot Free Space : {dio.TotalFreeSpace/1000}");
            Console.WriteLine($"Format :{dio.DriveFormat}");
        var drives=    DriveInfo.GetDrives();
            foreach(var v in drives)
                Console.WriteLine($"All drives in my system : {v.Name}");


            //Directory Info Class

            //DirectoryInfo dirfo = new DirectoryInfo("C:\\windows\\test\\user");
            DirectoryInfo dirfo = new DirectoryInfo(@"C:\wdf");
            if (dirfo.Exists) {
                Console.WriteLine($"Full Name :{dirfo.FullName}");
                Console.WriteLine($"Parent :{dirfo.Parent}");
                Console.WriteLine($"Name{dirfo.Name}");
         var dirinfoarr=    dirfo.GetDirectories();
                Console.WriteLine("All Directories under c:Windows are :");
                foreach (var v in dirinfoarr)
                {
                    Console.Write( v.Name+ ", ");
                    
                }
              var allfiles=  dirfo.GetFiles();
                foreach(var v in allfiles)
                {
                    Console.WriteLine(v.Name + "    "+v.Extension);
                }
            }
            else
            {
                Console.WriteLine(  "Directory Not found..........");
            }

            
            //FileInfo Class

            FileInfo fio = new FileInfo(@"E:\DotNetFreshersBatchJan2021\ConsoleApps\CSharpBasics\CSharpBasics\App.config");
            if (fio.Exists) {
                Console.WriteLine($"FullName: {fio.FullName}");
          
         
           }
            else
            {
                Console.WriteLine("File Does not exisits....");
            }
            Console.ReadLine();
        }
    }
}
