using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsInputOutput
{
    class FileAndLing2
    {
        static long GetFileLength(string filename)
        {
            long returnaval;
            try
            {
                FileInfo fi = new FileInfo(filename);
                returnaval = fi.Length;
            }
            catch (FileNotFoundException)
            {
                
                    returnaval = 0;
                } 

                finally
            {

            }
            return returnaval;
            }
        
        static void Main()
        {
            var path = @"C:\DotNetProgram\ClassSessionCoverTopic-\ConsInputOutput";
            var dir = new DirectoryInfo(path);
            var fileList = dir.GetFiles("*.*");
            var query = from file in fileList
                        select GetFileLength(file.FullName);
            var res1 = query.ToArray();//cache the result to avaoid multiple trips to the direcory
            var largestFile = res1.Max();
            var totbytes = res1.Sum();
            Console.WriteLine($"File Lengths :{res1}");
            Console.WriteLine($"Largest File:{largestFile}");
            Console.WriteLine($"Total Bytes:{totbytes}");
        }
    }
}
