using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadFolder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("\n  Path : ");
            string path = Console.ReadLine();
            DirectoryInfo directoryInfo = new DirectoryInfo(path);

            Console.WriteLine("\n\n  Directories : ");
            DirectoryInfo[] directoryInfos = directoryInfo.GetDirectories();
            for (int i = 0; i < directoryInfos.Length; i++)
                Console.WriteLine(directoryInfos[i].Name);

            Console.WriteLine("\n\n  Files : ");
            FileInfo[] fileInfos = directoryInfo.GetFiles();
            for (int i = 0; i < fileInfos.Length; i++)
                Console.WriteLine(fileInfos[i].Name);

            Console.Write("\n\n  File to start : ");
            string file = Console.ReadLine();
            Process.Start(path + @"\" + file);
        }
    }
}
