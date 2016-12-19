using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskExercise
{
    public class TriangleMarker
    {
        public void DisplayWelcome()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("|************************************|");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("| Welcome to the Triangel Maker Game |");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("|************************************|");
            Console.ResetColor();
            triangleOption();           
        }       

        public void triangleOption()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\nDo you want to make Regular-Triangle or Reverse-Triangle");
            Console.WriteLine("[1] Regular-Triangle \n[2] Reverse-Triangle");
            string option = Console.ReadLine().ToLower();
            Console.ResetColor();
            if (option == "1")
            {
                Console.WriteLine("\nPlease enter a number");
                string number = Console.ReadLine().ToLower();
                int newNumber = Convert.ToInt32(number);
                DisplayTriangle(newNumber);
            }
            else if (option =="2")
            {
                Console.WriteLine("\nPlease enter a number");
                string number = Console.ReadLine().ToLower();
                int newNumber = Convert.ToInt32(number);
                DisplayReverseTriangle(newNumber);
            }
            else
            {
                Console.WriteLine("\nPlease enter a valid option");
                Console.Clear();
                triangleOption();
            }
        }
        public void DisplayTriangle(int newNumber)
        {
            int a;
            int b;
            int c;
            for (a = 1; a <= newNumber; a++)
            {             
                for (b = 1; b <= newNumber-a; b++)
                {
                }
                for (c = 1; c <= a; c++)
                {
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.Write("  *");
                    Console.ResetColor();                          
                }
                    Console.WriteLine("");
            }
        }

        public void DisplayReverseTriangle(int newNumber)
        {
            int a;
            int b;
            int c;
            for (a = 1; a <= newNumber; a++)
            {
                for (b = 1; b <= newNumber - a; b++)
                {
                }
                for (c = 1; c <= b; c++)
                {
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.Write("  *");
                    Console.ResetColor();
                }
                Console.WriteLine("");
            }
        }
    }
}
