using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpFundamentals
{
    class BasicDebugging
    {
        public static void Run()
        {
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6 };
            List<int> smallests = GetSmallests(numbers, 3);

            foreach (int number in smallests)
                Console.WriteLine(number);
        }
        public static List<int> GetSmallests(List<int> list, int count)
        {
            if (list == null)
                throw new ArgumentNullException("list", "List of numbers cannot be null.");

            if (count > list.Count || count <= 0)
                throw new ArgumentOutOfRangeException("count", "Count should be between 1 and the number of elements in the list.");

            List<int> smallests = new List<int>();
            List<int> buffer = new List<int>(list);
            while (smallests.Count < count)
            {
                int min = GetSmallest(buffer);
                smallests.Add(min);
                buffer.Remove(min);
            }

            return smallests;
        }

        public static int GetSmallest(List<int> list)
        {
            int min = list[0];
            for (var i = 1; i < list.Count; i++)
            {
                if (list[i] < min)
                    min = list[i];
            }
            return min;
        }
    }
}
