using System;
using System.IO; //namespace for File IO operations. 

namespace CSarpBasics
{
    internal class Ex21FileIO
    {
        static void Main(string[] args)
        {
            var files = Directory.GetFiles("C:\\Users\\phani\\OneDrive\\Documents\\LTTS Docs");
            foreach (var file in files)
            {
                var selected_file = new FileInfo(file);
                Console.WriteLine($"The Name: {selected_file.Name}, Created on {selected_file.CreationTime}");

            }
            Console.WriteLine("Displaying Directories and its Info");
            var directorys = Directory.GetDirectories("C:\\Users\\phani\\OneDrive\\Documents");
            foreach (var dirPath in directorys)
            {
                var dir = new DirectoryInfo(dirPath);
                Console.WriteLine(dir.Name);
            }

            var newDir = "C:\\TestDir";
            var dirInfo = Directory.CreateDirectory(newDir);
            var parent = dirInfo.Parent;
            foreach (var dir_path in directorys)
            {
                var info = new DirectoryInfo(dir_path);
                foreach (var file in info.GetFiles())
                {
                    Console.WriteLine(file.Name);
                }
            }
        }
    }
}


