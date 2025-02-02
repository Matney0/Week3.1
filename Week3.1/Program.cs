using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3._1
{
    //Used class random to generate a number between 1 and 6
    //Simulate dice roll
    internal class RandomNumber
    {

        private static void Main(string[] args, bool shouldContinue)

        {
         while (true)

            Console.WriteLine("Welcome to the dice roll simulator, press any button to begin");

            Console.ReadKey();
            //Named the object dice and simulates a dice
            //Generates a random number between 1 and 6
            var dice = new Random();
            int randomNumber = dice.Next(1, 6);
            //Writes the result of the dice roll
            Console.WriteLine("Your first dice roll resulted is " + randomNumber);


            //starts the second dice roll
            Console.WriteLine("And your second dice roll will ensue");

            Console.ReadKey();

            var dice2 = new Random();
            int randomNumber2 = dice2.Next(1, 6);
            //Writes the result of the dice roll
            Console.WriteLine("Your second dice roll resulted is " + randomNumber2);


            //Asks the user if they would like to roll again
            Console.WriteLine("Would you like to roll again? Y/N");
            if (Console.ReadLine().ToUpper() != "Y")
            {
                //ending the loop
                break;
            }
        }
    }
}
