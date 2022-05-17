using System;

namespace Brackeys__ep4_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Random numGen = new Random();

            int roll1 = 0;
            int roll2 = 1;
            int attempts = 0;

            Console.WriteLine("Press enter to roll the dice.");

            while(roll1 != roll2)
            {
                Console.ReadKey();
                
                roll1 = numGen.Next(1, 7);
                roll2 = numGen.Next(1, 7);
                Console.WriteLine("\nRoll 1: " + roll1); 
                Console.WriteLine("Roll 2: " + roll2);
                attempts++;
            }

            Console.WriteLine("It took you " + attempts + " attempts to roll the same number.");





            // Wait before closing
            Console.ReadKey();
        }

        
    }
}
