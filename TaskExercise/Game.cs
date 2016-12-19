using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskExercise
{
    public class Game
    {
        PalindromeCheck palindrome;
        TriangleMarker triangle;
        public Game()
        {
            palindrome = new PalindromeCheck();
            triangle = new TriangleMarker();
        }
        public void DisplayOption()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Do you want to play Palindrome or make Triangle \n");
            Console.WriteLine("\n[1] Palindrome \n[2] Triangle \n[3] Quit");
            string option = Console.ReadLine().ToLower();
            Console.ResetColor();
            if (option == "1")
            {
                Console.Clear();
                palindrome.DisplayWelcome();
                DisplayAgain();
            }
            else if (option == "2")
            {
                Console.Clear();
                triangle.DisplayWelcome();
                DisplayAgain();
            }
            else if (option == "3")
            {
                Console.WriteLine("Thanks for playing");
                Console.ReadKey();
                Environment.Exit(0);
            }

            else
            {
                Console.WriteLine("Please choose a valid choice");
                DisplayOption();
            }
        }
        public void DisplayAgain()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("[1]Game Menu \n[2]Quit");
            string yes = Console.ReadLine().ToLower();
            Console.ResetColor();
            if (yes == "1")
            {
                Console.Clear();
                DisplayOption();
            }
            else if (yes == "2")
            {
                Console.WriteLine("Thanks for playing");
                Console.ReadKey();
                Environment.Exit(0);
            }
            else
            {
                Console.WriteLine("Please choose a valid option");
                DisplayAgain();
            }
        }

    }
}
