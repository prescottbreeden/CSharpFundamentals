using System;

namespace CSharpFundamentals
{
    class BasicStrings
    {
        public static void Run()
        {
            string greeting = "hello... I am a string... ";
            Console.WriteLine("Trim: '{0}'", greeting.Trim());
            Console.WriteLine("Upper: '{0}'", greeting.ToUpper());
            Console.WriteLine("Lower: '{0}'", greeting.ToLower());
            Console.WriteLine(greeting.Replace("hello", "hi"));
            int index = greeting.IndexOf(' ');
            string hello = greeting.Substring(0, index);
            string whoami = greeting.Substring(index + 1);
            Console.WriteLine(hello);
            Console.WriteLine(whoami);

            // or more simply
            string[] split = greeting.Split("...");
            for (int i = 0; i < split.Length; i++)
                split[i] = split[i].Trim();
            Console.WriteLine(split[0]);
            Console.WriteLine(split[1]);

            string test = null;
            if (String.IsNullOrEmpty(test))
                Console.WriteLine("null is Invalid");

            if (string.IsNullOrEmpty(""))
                Console.WriteLine("'' is Invalid");

            if (string.IsNullOrWhiteSpace(" "))
                Console.WriteLine("Whitespace is Invalid");

            string str = "25";
            byte age = Convert.ToByte(str);
            Console.WriteLine(age);

            float price = 29.95f;
            Console.WriteLine(price.ToString("C"));
            Console.WriteLine(price.ToString("C0"));
        }
    }
}
