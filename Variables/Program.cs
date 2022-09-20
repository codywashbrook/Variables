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

            Console.WriteLine("Variables");
            Console.WriteLine("");

            Console.WriteLine("Integers");
            int score; //declaration that score is intiger// int = whole number
            score = 0; //initilization == init, "score" to be 0
            int enemyPoints;
            enemyPoints = 100;
            Console.WriteLine("Enemy Points: " + enemyPoints);
            score = score + enemyPoints; // when enemy killed score is +100
            Console.WriteLine("Score: " + score); //display score

            Console.WriteLine();

            Console.WriteLine("Floats");
            // floating points == floats are numbers w/ decimals
            float lapTime; //declaration
            lapTime = 0.0f; // f = floating point
            Console.WriteLine(lapTime);
            lapTime = 34.67f;
            Console.WriteLine(lapTime);

            Console.WriteLine();

            //string = text
            Console.WriteLine("Strings");

            string title; // declaration
            title = "Cody Washbrook";
            Console.WriteLine(title);
            title = "Wody Cashbrook";
            Console.WriteLine(title);

            Console.ReadKey(true);



        }
    }
}
