using System;
using System.IO;

namespace DirectorsAndFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            string rootpath = @"C:\Users\opilane\Samples";

            //get the full path of all the direcroies at the rootPath
            string[] allDirectories = Directory.GetDirectories(rootpath);
            //ReadArray(allDirectories);

            //get nested directories
            string[] includeNestedDirectories = Directory.GetDirectories(rootpath, "*", SearchOption.AllDirectories);
            ReadArray(includeNestedDirectories);

            //get directory files
            string[] files = Directory.GetFiles(rootpath, "*.*", SearchOption.AllDirectories);
            ReadArray(files);

        }

        public static void ReadArray(string[] array)
        {
            foreach (string line in array)
            {
                Console.WriteLine(line);
            }
        } 
    }
}
