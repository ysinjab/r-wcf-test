using System;
using System.Collections.Generic;

namespace Utils
{
    public static class StringHelper
    {
        public static string ReverseWords(string sentence)
        {
            string[] words = sentence.Split(' ');
            List<string> reversedWord = new List<string>();
            foreach (var word in words)
            {
                char[] charArrayWord = word.ToCharArray();
                Array.Reverse(charArrayWord);
                reversedWord.Add(new String(charArrayWord));
            }

            return string.Join(" ", reversedWord);
        }
    }
}
