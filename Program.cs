// Namespaces organize your code and prevent naming conflicts with other libraries
namespace Roshambo;

//This brings in core system functionality
using System;

// The main container class for our console application
public class Program
{
    // The Main method is the exact starting point (entry point) where the computer
    // begins executing your program. 'args' is an array that stores any words or values
    // passed to the program when running it from the terminal
    static void Main(string[] args)
    {
        //This uses a "Ternary Operator" (condition ? if_true : if_false) as a shorthand
        // for an if-else statement. It checks if a first argument was typed in the terminal
        // if yes, it saves it; if not, it defaults to "Rock".
        var user = args.Length > 0 ? args[0] : "Rock";

        // Does the same check for a second argument in the terminal. //
        // If missing, it defaults to "Rock".
        var computer = args.Length > 1 ? args[1] : "Rock";

        // Calls our custom 'DecideWinner' method passing the two choices,
        // and prints the returned result to the screen.
        Console.WriteLine(DecideWinner(user, computer));
    }

    // A custom method that accepts two text inputs (strings) and outputs
    // a single text result (string). 'public static' allows us to call this method
    // directly from inside our Main method
    public static string DecideWinner(string user, string computer)
    {
        // Rule 1: if both chose the exact same item, its immediately a draw
        if (user == computer) return "Draw";

        // Rule 2: check all combinations where the user beats the computer
        // '&&' means BOTH conditions must be true. '||' means EITHER group can be true.
        if ((user == "Rock" && computer == "Scissors") ||
            (user == "Paper" && computer == "Rock") ||
            (user == "Scissors" && computer == "Paper"))
        {
            return "Win"; // if any of the winning pairs matched, exit the method and return "Win".
        }

        // Rule 3: Catch-all fallback. If it wasn't a tie, and the user didnt win, they must have lost.
        return "Lose";
    }
}
