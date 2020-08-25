using System;

namespace IfElsePractice
{
    class Program
    {
        static void Main(string[] args)
        {
            var r = new Random();
            var favNumber = r.Next(1, 1000);
            Console.WriteLine("Give me a number between 1 and 1000");
            int userInput;

            do
            {
                userInput = int.Parse(Console.ReadLine());

                if (userInput < favNumber)
                {
                    Console.WriteLine("Thats too low");
                }
                else if (userInput > favNumber)
                {
                    Console.WriteLine("Thats too high");
                }
                else
                {
                    Console.WriteLine("Nevermind");
                }

            } while (userInput != favNumber);
                    
               
         
        }
    }
}
