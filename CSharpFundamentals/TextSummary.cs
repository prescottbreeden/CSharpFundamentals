using System;
using System.Collections.Generic;

namespace CSharpFundamentals
{
    class TextSummary
    {
        public static void Run()
        {
            Console.WriteLine("Let's summarize some textseses...");
            string blog = "This is going to be a really really really really really long text...";

            string shortSummary = BlogUtility.SummarizeBlog(blog);
            Console.WriteLine(shortSummary);

            string longSummary = BlogUtility.SummarizeBlog(blog, 40);
            Console.WriteLine(longSummary);
        }

    }
}

