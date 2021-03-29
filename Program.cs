using System;
using System.Collections.Generic;
using System.Security.Cryptography;

namespace Week4
{
    class Program
    {
        static void Main(string[] args)
        {
            string userWantsToContinue;
            Console.WriteLine("Welcome to the Grand Circus Casino");
            do
            {
                Console.WriteLine("How many sides should each die have?");
                int diceSides = Int32.Parse(Console.ReadLine());

                int roll1 = DiceRoll(diceSides);
                int roll2 = DiceRoll(diceSides);

                string result = RollResults(roll1, roll2);
                Console.WriteLine(result);

                Console.WriteLine("Would you like to roll again?");
                userWantsToContinue = Console.ReadLine().ToLower();
                while (userWantsToContinue != "y" && userWantsToContinue != "n")
                {
                    Console.WriteLine("Invalid input! Please use y or n");
                    userWantsToContinue = Console.ReadLine();
                }
            } while (userWantsToContinue == "y");
        }

        static string RollResults(int die1, int die2)
        {
            string result;
            if (die1 == 1 && die2 == 1)
            {
                result = "Snake Eyes: Two 1s\nCraps: A total of 2, 3, 12";
                return result;
            }
            else if ((die1 == 1  && die2 == 2) || ((die1 == 2 && die2 == 1)))
            {
                result = "Ace Duece: A 1 and 2";
                return result;
            }
            else if (die1 == 6 && die2 == 6)
            {
                result = "Box Cars: Two 6s";
                return result;
            }
            else if ((die1 + die2 == 7) || (die1 + die2 == 11))
            {
                result = "Win: A total of 7 or 11";
                return result;
            }
            else if ((die1 + die2 == 3) || (die1 + die2 == 12))
            {
                result = "Craps: A total of 2, 3, or 12";
                return result;
            }
            else
            {
                result = $"You rolled a {die1}  and a {die2}";
                return result;
            }
        }
        static int DiceRoll(int diceSides)
        {
            int roll = getRandom.Next(1, diceSides + 1);

            return roll;
        }
        static readonly Random getRandom = new Random();
    }
}
