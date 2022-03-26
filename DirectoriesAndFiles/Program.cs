using System;
using System.IO;

namespace DirectoriesAndFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            string rootDirectory = @"/Users/.../Projects/Progemine1";
            Console.WriteLine("Enter directory name:");
            string newDirectory = Console.ReadLine();
            Console.WriteLine("Enter File name");
            string filename = Console.ReadLine();

            if (Directory.Exists($"{rootDirectory}/{newDirectory}") && File.Exists($"{rootDirectory}/{newDirectory}/{filename}"))
            {
                Console.WriteLine($"Directory and file already exists at {rootDirectory}");

            }
            else
            {
                Directory.CreateDirectory($"{rootDirectory}/{newDirectory}");
                File.Create($"{rootDirectory}/{newDirectory}/{filename}");
            }


        }




    }

}
