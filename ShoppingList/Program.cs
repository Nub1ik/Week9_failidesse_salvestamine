using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ShoppingList
{
    class Program
    {
        static void Main(string[] args)
        {
            string rootDirectory = @"/Users/.../Projects/Progemine1";
            Console.WriteLine("Enter your shopinglist name:");
            string newDirectory = Console.ReadLine();
            Console.WriteLine("Enter your shoping list file name");
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
