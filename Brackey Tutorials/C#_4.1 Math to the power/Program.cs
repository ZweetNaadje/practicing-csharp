﻿using System;

namespace Brackey_ep4_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many cool numbers do you want: ");
            
            int count = Convert.ToInt32(Console.ReadLine());
            
            for (int i = 1; i <= count; i++) 
            {
                double result = Math.Pow(2, i);
                Console.WriteLine(result);
            }


            // Wait before closing
            Console.ReadKey();
        }
    }
}
