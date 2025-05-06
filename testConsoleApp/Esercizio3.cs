using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//conta il numero di volte che una parola appare in un testo

namespace testConsoleApp
{
    internal class Esercizio3
    {
        public void countWords(string[] args)
        {
            string text = args[0];
            string wordToCount = args[1];
            int count = 0;
            string[] words = text.Split(new char[] { ' ', '.', ',', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);
            foreach (string word in words)
            {
                if (word.Equals(wordToCount, StringComparison.OrdinalIgnoreCase))
                {
                    count++;
                }
            }
            Console.WriteLine($"La parola '{wordToCount}' appare {count} volte nel testo.");
        }

    }
}
