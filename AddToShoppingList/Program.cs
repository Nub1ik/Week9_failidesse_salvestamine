using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace AddToShoppingList
{
    class Program
    {
        static void Main(string[] args)
        {
            string fileLocation = @"/Users/.../Projects/Progemine1/shopinglist";
            string fileName = @"/myShopingList.txt";

            string[] arrayFromFile = File.ReadAllLines($"{fileLocation}{fileName}");
            List<string> myShopingList = arrayFromFile.ToList<string>();

            bool loopActive = true;

            while (loopActive)
            {
                Console.WriteLine("Would you like to add your shopinglist? Y/N:");
                char userInput = Convert.ToChar(Console.ReadLine().ToLower());

                if (userInput == 'y')
                {
                    Console.WriteLine("Add to your list:");
                    string userWish = Console.ReadLine();
                    myShopingList.Add(userWish);
                }
                else
                {
                    loopActive = false;
                    Console.WriteLine("Take care!");
                }

                Console.Clear();

                foreach (string SList in myShopingList)
                {
                    Console.WriteLine($"You need to buy {SList}");
                }

                File.WriteAllLines($"{fileLocation}{fileName}", myShopingList);
            }
        }
    }
}
