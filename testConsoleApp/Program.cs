using testConsoleApp;

internal class Program
{
    private static void Main(string[] args)
    {
//        bool isActive = true; // Declare and initialize a boolean variable to true

//        char letter = 'A'; // Declare and initialize a character variable with the letter 'A'

//        char letter2 = '\u0041'; // Declare and initialize a character variable using Unicode representation of 'A'

//        int number = 0; // Declare an integer variable and initialize it to 0
        
//        float pi = 3.14f; // Declare and initialize a float variable with the value of pi (approximation)

//        double pi2 = 3.14; // Declare and initialize a double variable with the value of pi (higher precision)

//        decimal price = 3.14m; // Declare and initialize a decimal variable with the value of pi (higher precision for financial calculations)

//        string name = "Pippo"; // Declare and initialize a string variable with the name "Pippo"

//        string greetings = $"Hello {name}!"; // Declare and initialize a string variable with a greeting message with string interpolation

//        string verbatimString = @"This is a verbatim string literal."; // Declare and initialize a verbatim string literal

//        string multilineString = @"This is a
//multiline string
//literal"; // Declare and initialize a multiline string literal

//        var isTrueVar = true; // Implicitly declare a variable with the value true using var

//        var numberVar = 1; // Implicitly declare a variable with the value 1 using var

//        var piVar = 3.14f; // Implicitly declare a variable with the value of pi using var

//        if (true)
//        { // Start an if statement with a condition that is always true
//            Console.WriteLine("This will always be printed."); // Output a message to the console
//        }
//        else if (false)
//        {
//            // Start an else if statement with a condition that is always false
//        }
//        else
//        {
//            // Start an else statement
//        }

//        for (int i = 0; i < 10; i++)
//        { // Start a for loop that iterates from 0 to 9
//            Console.WriteLine(i); // Output the current value of i to the console
//        }

//        foreach (var item in new[] { 1, 2, 3, 4, 5 })
//        { // Start a foreach loop that iterates over an array of integers
//            Console.WriteLine(item); // Output the current item to the console
//        }

//        while (isActive)
//        { // Start a while loop that continues as long as isActive is true
//            Console.WriteLine("This will print until isActive is false."); // Output a message to the console
//            isActive = false; // Set isActive to false to exit the loop
//        }

//        do
//        { // Start a do-while loop that executes at least once
//            Console.WriteLine("This will print at least once."); // Output a message to the console
//        } while (isActive); // Continue the loop as long as isActive is true

//        switch (number)
//        { // Start a switch statement based on the value of number
//            case 0:
//                Console.WriteLine("Number is zero."); // Output a message if number is 0
//                break; // Exit the switch statement
//            case 1:
//                Console.WriteLine("Number is one."); // Output a message if number is 1
//                break; // Exit the switch statement
//            default:
//                Console.WriteLine("Number is something else."); // Output a message for any other value
//                break; // Exit the switch statement
//        }

        //Test(); // Call the Test method to demonstrate functionality

        //var esercizioTest = new EsercizioTest(); // Create an instance of Class1  
        //esercizioTest.WriteStoCazzo(); // Call the WriteStoCazzo method from the Esercizio1 class var
        //EsercizioTest.WriteStiCazzi(); // Call the static WriteStiCazzi method from the Esercizio1 class

        //var fizzBuzz = new Esercizio1(); // Create an instance of Esercizio1
        //fizzBuzz.FizzBuzz(); // Call the FizzBuzz method from the Esercizio1 class

        //var guessNumber = new Esercizio2(); // Create an instance of Esercizio2
        //guessNumber.GuessTheNumber(); // Call the GuessTheNumber method from the Esercizio2 class

        //for (int i=0; i < args.Length; i++)
        //{ // Start a for loop that iterates over the command line arguments
        //    Console.WriteLine(args[i]); // Output each command line argument to the console
        //}

        //var countWords = new Esercizio3(); // Create an instance of Esercizio3
        //countWords.countWords(args); // Call the countWords method from the Esercizio3 class with command line arguments

        var countWordsCasa = new Esercizio1Casa(); // Create an instance of Esercizio1Casa
        countWordsCasa.CountInFile("C:\\Users\\Allievo\\Desktop\\lorenzopuppo-fullstack\\dotnet\\testConsoleApp\\testConsoleApp\\coglione.txt", "coglione"); 

    }
    private static void Test()
    {       
        Console.WriteLine("Puzzi di culo!"); // Output a humorous message to the console
    }
}