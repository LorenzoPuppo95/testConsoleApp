using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//saluta utente,
//estrai e salva un numero random tra 0 e 10,
// consiglia se il numero inserito è piu basso o piu alto del numero estratto,
//fai inserire un numero tra 1 e 10,
//se è giusto hai vinto, se è sbagliato riprova
//aggiungi un contatore per i tentativi

namespace testConsoleApp
{
    internal class Esercizio2
    {
        public void GuessTheNumber()
        {
            Console.WriteLine("Ciao, benvenuto nel gioco del numero segreto!");
            Random random = new Random();
            int secretNumber = random.Next(1, 1000001);
            int userGuess = 0;
            int attempts = 0;
            Console.WriteLine("Ho scelto un numero tra 1 e 1000000, prova a indovinarlo!");
            while (userGuess != secretNumber)
            {
                Console.Write("Inserisci un numero tra 1 e 1000000: ");
                string input = Console.ReadLine();
                if (int.TryParse(input, out userGuess) && userGuess >= 0 && userGuess <= 1000000)
                {
                    attempts++;
                    if (userGuess < secretNumber)
                    {
                        Console.WriteLine("Troppo basso! Riprova.");
                    }
                    else if (userGuess > secretNumber)
                    {
                        Console.WriteLine("Troppo alto! Riprova.");
                    }
                    else
                    {
                        Console.WriteLine($"Complimenti! Hai indovinato il numero segreto ({secretNumber}) in {attempts} tentativi.");
                    }
                }
                else
                {
                    Console.WriteLine("Input non valido. Inserisci un numero tra 1 e 1000000.");
                }
            }
        }

    }
}