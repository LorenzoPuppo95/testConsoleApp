using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

//modifica esercizio 3 per prendere come argomenti un file e la parola da contare nel testo dentro al file
//se ti do il file e basta conta quante parole, quanti caratteri, quante vocali, quante consonanti ha
//rifai il csv to json fatto in javascript

namespace testConsoleApp
{
    internal class Esercizio1Casa
    {
        public void CountInFile(string filePath, string? wordToCount = null)
        {
            try
            {
                string text = File.ReadAllText(filePath);
                string[] words = text.Split(new char[] { ' ', '?', '!', ',', ':', ';', '"', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);

                if (string.IsNullOrEmpty(wordToCount))
                {
                    int totalWords = words.Length;
                    int totalCharacters = text.Length;
                    int totalVowels = text.Count(c => "aeiouAEIOU".Contains(c));
                    int totalConsonants = text.Count(c => char.IsLetter(c) && !"aeiouAEIOU".Contains(c));

                    Console.WriteLine($"Il file contiene:");
                    Console.WriteLine($"- {totalWords} parole");
                    Console.WriteLine($"- {totalCharacters} caratteri");
                    Console.WriteLine($"- {totalVowels} vocali");
                    Console.WriteLine($"- {totalConsonants} consonanti");
                }
                else
                {
                    int count = words.Count(word => word.Equals(wordToCount, StringComparison.OrdinalIgnoreCase));
                    Console.WriteLine($"La parola '{wordToCount}' appare {(count == 1 ? "una" : count)} volt{(count == 1 ? "a" : "e")} nel testo.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Errore: {ex.Message}");
            }
        }
    }
}
