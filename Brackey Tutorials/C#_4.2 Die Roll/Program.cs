using System;

namespace Brackey_ep4_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random numGen = new Random();

            int roll = 0;
            int attempts = 0;

            Console.WriteLine("Press enter to roll the die.");

            while(roll != 6)
            {   Console.ReadKey();
            
                roll = numGen.Next(1, 7);
                Console.WriteLine("You rolled: " + roll);
                attempts++;
            }

            Console.WriteLine("It took you " + attempts + " attempts to roll a six.");
            

            // Wait before closing
            Console.ReadKey();
        }
    }       
}