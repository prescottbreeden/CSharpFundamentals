using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpFundamentals
{
    class BlogUtility
    {
        public static string SummarizeBlog(string stuff, int maxLength = 20)
        {
            if (stuff.Length < maxLength)
                return stuff;

            string[] words = stuff.Split(' ');
            int totalCharacters = 0;
            List<string> summaryWords = new List<string>();

            foreach (string word in words)
            {
                summaryWords.Add(word);
                totalCharacters += word.Length + 1;
                if (totalCharacters > maxLength)
                    break;
            }

            string allWords = String.Join(" ", summaryWords) + "...";
            return allWords;
        }
    }
}
