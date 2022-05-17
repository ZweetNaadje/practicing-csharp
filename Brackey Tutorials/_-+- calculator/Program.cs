using System;

namespace testc_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter a number: ");
            double answer = Convert.ToDouble(Console.ReadLine());
            
            Console.WriteLine("");

            Console.Write("Please enter a second number: ");
            double answer2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("What do you want to do with these numbers?");
            Console.WriteLine("-------------------------");
           
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Multiply? Press m");
                
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Divide? Press d" );
            
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("Add up to eachother? Press p");
                
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Subtract from eachother? Press a");
               
            string answer3 = (Console.ReadLine());

            if(answer3 == "m")
            {
                double result = answer * answer2;
                Console.WriteLine(result);
            }

            if(answer3 == "d")
            {
                double result = answer / answer2;
                Console.WriteLine(result);
            }

            if(answer3 == "p")
            {
                double result = answer + answer2;
                Console.WriteLine(result);
            }

            if(answer3 == "a")
                {
                double result = answer - answer2;
                Console.WriteLine(result);
                }

            // Wait before closing
            Console.ReadKey();
        }
    }
}
