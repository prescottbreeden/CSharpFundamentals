using System;

namespace CSharpFundamentals
{
    class BasicArrays
    {
        public static void Run()
        {
            int[] numbers = new int[] { 3, 7, 9, 2, 14, 6 };
            // Length
            Console.WriteLine("Length: " + numbers.Length);

            // IndexOf()
            int index = Array.IndexOf(numbers, 9);
            Console.WriteLine(index);

            // Clear()
            Array.Clear(numbers, 0, 2);
            Console.WriteLine("Effect of Clear()");
            foreach (int num in numbers)
                Console.WriteLine(num);

            // Copy()
            int[] another = new int[3];
            Array.Copy(numbers, another, 3);

            Console.WriteLine("Effect of Copy()");
            foreach (int num in another)
                Console.WriteLine(num);

            // Sort()
            Array.Sort(numbers);
            Console.WriteLine("Effect of Sort()");
            foreach (int num in numbers)
                Console.WriteLine(num);
            
            // Reverse()
            Array.Reverse(numbers);
            Console.WriteLine("Effect of Reverse()");
            foreach (int num in numbers)
                Console.WriteLine(num);
        }
    }
}
