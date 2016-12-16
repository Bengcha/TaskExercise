using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskExercise
{
    class TriangleMarker
    {

        public void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the Triangel Maker Game");
            UserInput();
        }
        
        public void UserInput()
        {
            Console.WriteLine("Please enter a number");
            string number = Console.ReadLine().ToLower();
            int newNumber = Convert.ToInt32(number);
            DisplayTriangle(newNumber);
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

                Console.Write("*");
                                     
                }
                Console.WriteLine("");

            }
            Console.ReadLine();
        }

    }
}
