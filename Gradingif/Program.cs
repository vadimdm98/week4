using System;

namespace Gradingif
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your exam resoult:");
            char userInput = Convert.ToChar(Console.ReadLine().ToUpper());

            if(userInput == 'A')
            {
                Console.WriteLine("Outstading!");
            }
            if (userInput == 'B')
            {
                Console.WriteLine("Superior!");
            }
            if (userInput == 'C')
            {
                Console.WriteLine("Good!");
            }
            if (userInput == 'D')
            {
                Console.WriteLine("Statisfactory!");
            }
            if (userInput == 'E')
            {
                Console.WriteLine("Low Pass!");
            }
            if (userInput == 'F')
            {
                Console.WriteLine("Failure :(");
            }
        }
    }
}
