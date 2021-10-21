using System;
using System.IO;

namespace DeleteFolderAndFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"G:\";
            string[] patharr = { };

            //if (Directory.Exists(path))
            //{
            //    Directory.Delete(path, true);
            //    Console.WriteLine("Delete Success");
            //}

            DirectoryInfo directory = new DirectoryInfo(path);

            var allFils = directory.EnumerateFiles();
            var dir = directory.EnumerateDirectories();

            //foreach (FileInfo file in allFils)
            //{
            //    Console.WriteLine(file.Name);
                
            //    //file.Delete();
            //    //Console.WriteLine("Delete File Success");
            //}

            foreach (DirectoryInfo d in dir)
            {
               
                //Console.WriteLine(d.FullName);
                //d.Delete();
                //Console.WriteLine("\nDelete Success");
            }
        }
    }
}
