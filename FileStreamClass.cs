using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsInputOutput
{
    class FileStreamClass
    {
        static void WriteToFile()
        {
            //try
            //{

            //}
            //catch () { }
            //finally
            //{

            //}
        }

        static void Main()
        {
    FileStream fs = new FileStream(@"e:\file1.txt", FileMode.Create, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);
            sw.WriteLine("We are writing in file1.txt using stream swriter");
            sw.WriteLine("Streamwriter is used to write stream data");
            sw.Close();
            fs.Close();

            using (FileStream fs1 = new FileStream(@"e:\file2.txt", FileMode.Create, FileAccess.ReadWrite))
            {
                using(StreamWriter sw1 = new StreamWriter(fs1))
                {
                    sw1.WriteLine("New contents in new file");
                }
            }
            Console.WriteLine("Please check the contents of file2.txt");

  using (FileStream fsr= new FileStream(@"e:\file2.txt", FileMode.Open))
            {
                using (StreamReader sr = new StreamReader(fsr))
                {
                    Console.WriteLine("Reading contents of file2.txt :" + sr.ReadToEnd());
                }

                using (StreamWriter ss = new StreamWriter(@"E:\file3.txt"))
                {
                    ss.WriteLine("Writing contents into file3 only using StreamWriter class............ ");
                }
                Console.ReadLine();
            }
        }
    }
}
