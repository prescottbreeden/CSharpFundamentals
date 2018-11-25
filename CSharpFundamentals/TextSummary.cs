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
            PrintBlogSummary(blog);
            PrintBlogSummary(blog, 40);
        }

        public static void PrintBlogSummary(string blog, int len=20)
        {
            Console.WriteLine(BlogUtility.SummarizeBlog(blog, len));
        }

    }
}

