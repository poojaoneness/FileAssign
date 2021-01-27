using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace ConsInputOutput
{
    class Class1
    {
        static void Main(string[] args)
        {
            var startFolder = @"C:\DotNetProgram\ClassSessionCoverTopic-\ConsInputOutput";
            Directory dir = new Directory(startFolder);
            var fileList = dir.GetFiles("*.*", SearchOption.AllDirectories);
            var FileQuery = from file in fileList
                            where file.Extension == ".txt";
                             Ordered Query file.Name
                             select file;
            Console.WriteLine("All file name with txt Extension");
            foreach (var v in FileQuery)
            {
                Console.WriteLine(v.FullName + ":" v.Extension);
            }
            Console.ReadLine();
            }

        

    }
}
