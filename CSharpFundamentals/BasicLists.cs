using System;
using System.Collections.Generic;

namespace CSharpFundamentals
{
    class BasicLists
    {
        public static void Run()
        {
            List<int> numbers = new List<int>() { 1, 2, 3, 4 };
            numbers.Add(1);
            numbers.AddRange(new int[3] { 5, 6, 7 });
            foreach (int num in numbers)
                Console.WriteLine(num);

            Console.WriteLine("\nIndex of 1: " + numbers.IndexOf(1));
            Console.WriteLine("Last Index of 1: " + numbers.LastIndexOf(1));

            Console.WriteLine("Count: " + numbers.Count);

            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] == 1)
                    numbers.Remove(numbers[i]);
            }
            foreach (int num in numbers)
                Console.WriteLine(num);

            numbers.Clear();
            Console.WriteLine("\nCount: " + numbers.Count);
        }

        public static void Ex1()
        {
            List<string> friends = new List<string>();
            string response;
            do
            {
                Console.WriteLine("Enter a name: ");
                response = Console.ReadLine();
                friends.Add(response);
            } while (response != "");
            foreach (string friend in friends)
                Console.WriteLine(friend);
        }

        public static void Ex2()
        {
            string response;
            Console.WriteLine("Enter your name: ");
            response = Console.ReadLine();
            string backwards = "";
            for (int i = response.Length - 1; i >= 0; i--)
                backwards += response[i];

            Console.WriteLine(backwards);
        }

        public static void Ex3()
        {
            string response;
            int count = 0;
            List<int> numbers = new List<int>();
            Console.WriteLine("Please enter 5 numbers: ");
            do
            {
                Console.WriteLine("Enter a unique number: ");
                response = Console.ReadLine();
                int num = Int32.Parse(response);
                if (response == "")
                    continue;
                if (numbers.IndexOf(num) == -1)
                    numbers.Add(num);
                else
                {
                    Console.WriteLine("Numbers must be unique, that number has already been added");
                    continue;
                }
                count++;
            } while (count < 5);
            Console.WriteLine("Loop finished");
            foreach (int num in numbers)
                Console.WriteLine(num);

        }
    }
}
