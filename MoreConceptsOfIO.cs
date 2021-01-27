using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsInputOutput
{
    class MoreConceptsOfIO
    {
        static void Main()
        {
            //FileStream fs = new FileStream(@"abc.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            //StreamWriter sw = new StreamWriter(fs);
            //sw.WriteLine("Hello Everyone");
            //fs.Seek(0, SeekOrigin.Begin);
            //StreamReader sr = new StreamReader(fs);
            //Console.WriteLine(sr.ReadToEnd());
            //sr.Close();
            //sw.Close();
            //fs.Close();

            string data = "We are understanding the static class File";
            File.WriteAllText("static.txt", data);
            Console.WriteLine("Contents of the file :" + File.ReadAllText("static.txt"));
            File.AppendAllText("static.txt", "New content appended in static file");

        }
    }
}
