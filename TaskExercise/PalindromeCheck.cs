using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskExercise
{
    class PalindromeCheck
    {
        string check;

        public void DisplayWelcome()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("|*********************************|");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(" Welcome to The Palindrome Checker");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("|*********************************|\n");
            Console.ResetColor();
            CheckWord();        
        }
        public void CheckWord()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Enter a word, phase, or number \n");
            check = Console.ReadLine().ToLower();
            if (check.Equals(""))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Hey!!!You forgot to enter a word, phase, or number");
                Console.ResetColor();
                CheckWord();
            }
            else
            {

            }
            Console.ResetColor();
            GetPaliodrome(check);
            DisplayAgain();
        }

        public bool GetPaliodrome(string check)
        {
            char[] word = check.ToCharArray();
            Array.Reverse(word);
            string returnWord = new string(word);
            if (check == returnWord)
            {

                Console.WriteLine("\nThe word: ({0}) is a Palindrome \n", check);
                return false;
            }
            else
            {
                Console.WriteLine("\nThe word: {0} is not a Palindrome", check);
                return true;
            }

        }
        public void DisplayAgain()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Play again? Y | N");
            string yes = Console.ReadLine().ToLower();
            Console.ResetColor();
            if(yes == "y" )
            {
                Console.Clear();
                DisplayWelcome();
                CheckWord();
            }
            else if(yes =="n")
            {
                Console.WriteLine("\nThanks for playing");
                Console.ReadKey();
                Environment.Exit(0);
            }
            else
            {
                Console.WriteLine("\nPlease choose a valid option");
                DisplayAgain();
            }
        }

    }
}
