using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Magenta;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Variables");
            Console.ResetColor();
            Console.WriteLine("");

            Console.BackgroundColor = ConsoleColor.Blue; 
            Console.ForegroundColor = ConsoleColor.White; //after this line every text will be white on blue background
            Console.WriteLine("Integers");
            Console.ResetColor(); //reset to the default colour
            int score; //declaration that score is intiger// int = whole number
            score = 0; //initilization == init, "score" to be 0
            int enemyPoints;
            enemyPoints = 100;
            Console.WriteLine("Enemy Points: " + enemyPoints);
            score = score + enemyPoints; // when enemy killed score is +100
            Console.WriteLine("Score: " + score); //display score

            Console.WriteLine();

            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Floats");
            Console.ResetColor();
            // floating points == floats are numbers w/ decimals
            float lapTime; //declaration
            lapTime = 0.0f; // f = floating point
            Console.WriteLine(lapTime);
            lapTime = 34.67f;
            Console.WriteLine(lapTime);

            Console.WriteLine();

            //string = text
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Strings");
            Console.ResetColor();

            string title; // declaration
            title = "Cody Washbrook";
            Console.WriteLine(title);
            title = "Wody Cashbrook";
            Console.WriteLine(title);

            Console.ReadKey(true);



        }
    }
}
