using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsInputOutput
{
    class FileSeekMethod
    {
        static void Main()
        {
            int i;
            FileStream fs = new FileStream(@"fileseek.txt", FileMode.OpenOrCreate);
            for(char c='A'; c <= 'Z'; c++)
            {
                fs.WriteByte((byte)c);
            }
            // fs.Seek(0, SeekOrigin.Begin);
            // fs.Seek(5, SeekOrigin.Begin);
            fs.Seek(-5, SeekOrigin.End);
            do
            {
                i = fs.ReadByte();
                Console.Write((char)i);
            } while (i != -1);

        }
    }
}
