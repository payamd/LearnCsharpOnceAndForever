using System;
using System.Collections.Generic;

namespace LearnCsharpOneTimeAndForever
{
    internal class Text
    {
        public static string ReverseName (string name) {

            var array = new char[name.Length];
            for (var i = name.Length; i > 0; i--)
                array[name.Length - i] = name[i - 1];
            return new string(array);
        }




        public static string SummerizeText(string text, int maxlenght=25) {

            if (text.Length < maxlenght)
                return text;

            var words = text.Trim().Split(' ');
            var totalCharacters = 0;
            var summaryWords = new List<string>();
            foreach (var word in words)
            {
                summaryWords.Add(word);
                totalCharacters += word.Length + 1;
                if (totalCharacters >= maxlenght)
                    break;
            }
            var summary = string.Join(" ", summaryWords) + "...";
            return summary;
        }


    }
}