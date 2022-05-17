using System;

namespace Brackey_5_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many students are in your class? ");
                        
            int amount = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Would you kindly tell me their names?");

            string[] students = new string[amount];
            
            for (int i = 0; i < students.Length; i++)
            {
                students[i] = Console.ReadLine();
            }

            Console.WriteLine("-----------------\nHere they are alphabetically:" );

            Array.Sort(students);

            for (int i = 0; i < students.Length; i++)
            {
                Console.WriteLine(students[i]);
            }

            // Wait before closing
            Console.ReadKey();
        }
    }
}
