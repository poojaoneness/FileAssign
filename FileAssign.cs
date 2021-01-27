using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsInputOutput
{
    class FileAssign

    {
        //private const string V = "C:\\Sample.txt";

        //   [STAThread]
        static void Main(string[] args)
        {
            FileStream fs = null;
            StreamWriter sw = null;
            
            try
            {
                fs = new FileStream(@"E:\Sample2.txt", FileMode.Create, FileAccess.Write);
               
               // BinaryReader w = new BinaryReader(fs);
                sw = new StreamWriter(fs);
                Console.WriteLine("Enter the string:");
                String str = Console.ReadLine(); 
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            finally
            {
                // Console.WriteLine("Executing finally block.");
                sw.Flush();
                sw.Close();
                fs.Close();
             
               // Console.WriteLine();
            }
            Console.ReadLine();
        }


        static void ReadData()
        {
            using (StreamReader reader = new StreamReader(new FileStream(@"E:\Sample2.txt", FileMode.Open)))
            {
                String line;
                Console.WriteLine("\nUser Given Data:");
                //Continue to read until you reach end of file
                while ((line = reader.ReadLine()) != null)
                {
                    //write the lie to console window
                    Console.WriteLine(line);
                }
               
            }
        }
    }
}