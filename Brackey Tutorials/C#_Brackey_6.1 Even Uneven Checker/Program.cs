using System;

namespace Brackey_6._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int result = Multiply(7, 9);
           
            Console.WriteLine("The result is " + result);

            if (result % 2 == 0)
            {
                Console.WriteLine(result + " is an even number!");
            } 
            else 
            {
                Console.WriteLine(result + " is an uneven number!");
            }
            
            // Wait before closing
            Console.ReadKey();
        }

        static int Multiply (int num01, int num02)
        {
            int result = num01 *num02;
            return result;           
            
        }
    }
}
