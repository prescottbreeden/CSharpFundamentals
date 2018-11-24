using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpFundamentals
{
    class BasicStringBuilder
    {
        public static void Run()
        {
            //StringBuilder builder = new StringBuilder("Hello World");
            StringBuilder builder = new StringBuilder();
            builder
                .Append('-', 10)
                .AppendLine()
                .Append("Header")
                .AppendLine()
                .Append('-', 10)
                .Replace('-', '+')
                .Remove(0, 10)
                .Insert(0, new string('-', 10));

            Console.WriteLine(builder);
            Console.WriteLine("First char: " + builder[0]);

        }
    }
}
