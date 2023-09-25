using System;
using System.Collections.Generic;
using System.Security.Cryptography;

namespace CollectionsMasterConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO: Follow the steps provided in the comments under each region.
            //Make the console formatted to display each section well
            //Utlilize the method stubs at the bottom for the methods you must create ⬇⬇⬇

            int[] myArray = new int[50];
            Populater(myArray);
            Console.WriteLine("Original Array:");
            NumberPrinter(myArray);

            ThreeKiller(myArray);
            Console.WriteLine("\nArray after ThreeKiller:");
            NumberPrinter(myArray);

            List<int> myList = new List<int>(myArray);
            OddKiller(myList);
            Console.WriteLine("\nList after OddKiller:");
            NumberPrinter(myList);

            Console.WriteLine("\nEnter a number to search in the List:");
            if (int.TryParse(Console.ReadLine(), out int searchNumber))
            {
                NumberChecker(myList, searchNumber);
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }
        }
        private static void ThreeKiller(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 3 == 0)
                {
                    numbers[i] = 0;
                }
            }
        }
        private static void OddKiller(List<int> numberList)
        {
            numberList.RemoveAll(n => n % 2 != 0);
        }

        private static void NumberChecker(List<int> numberList, int searchNumber)
        {
            if (numberList.Contains(searchNumber))
            {
                Console.WriteLine($"The List contains the number {searchNumber}.");
            }
            else
            {
                Console.WriteLine($"The List does not contain the number {searchNumber}.");
            }
        }
        private static void Populater(List<int> numberList)
        {
            Random rng = new Random();
            for (int i = 0; i < 50; i++)
            {
                int randomNumber = rng.Next(51);
                numberList.Add(randomNumber);
            }
        }
        private static void Populater(int[] numbers)
        {
            for (int i = 0; i <= 49; i++)
            {


                Random rng = new Random();
                int randomNumber = rng.Next(51);
                numbers[i] = randomNumber;
                /*Console.WriteLine($"Random number between 0 and 50 is; {randomNumber}")*/
            }

        }

        private static void ReverseArray(int[] array)
        {
            Array.Reverse(array);
        }

        /// <summary>
        /// Generic print method will iterate over any collection that implements IEnumerable<T>
        /// </summary>
        /// <typeparam name="T"> Must conform to IEnumerable</typeparam>
        /// <param name="collection"></param>
        private static void NumberPrinter<T>(T collection) where T : IEnumerable<int>
        {
            //STAY OUT DO NOT MODIFY!!
            foreach (var item in collection)
            {
                Console.WriteLine(item);
            }
        }
    }
}
