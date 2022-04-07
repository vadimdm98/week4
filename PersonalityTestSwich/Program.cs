using System;

namespace PersonalityTestSwich
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your favoritr color");
            string userInput = Console.ReadLine().ToLower();
            switch (userInput)
            {
                case "red":
                    Console.WriteLine("Tou are so romantic.");
                    break;
                case "blue":
                    Console.WriteLine("You are a workaholic.");
                    break;
                case "green":
                    Console.WriteLine("You care about the environment");
                    break;
                default:
                    Console.WriteLine($"You are a {userInput} unicorn.");
                    break;
            }
            Console.WriteLine("Heve a nice day!");
        }
    }
}
