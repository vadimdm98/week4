using System;

namespace ControlFlow
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your favoritr color");
            string userInput = Console.ReadLine().ToLower();

            if(userInput == "red")
            {
                Console.WriteLine("You are so romantic.");
            }
            else if(userInput == "blue")
            {
                Console.WriteLine("You are a workaholic.");
            }
            else if(userInput == "green")
            {
                Console.WriteLine("You care about the enviroment.");
            }
            else
            {
                Console.WriteLine($"You are {userInput} unicorn.");
            }
            Console.WriteLine("Have a nice day.");

        }
    }
}
