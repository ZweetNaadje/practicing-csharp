using System;

namespace CodeProjects
{
    class Program
    {
        static void Main(string[] args)
        {
            // Change the appearance of the console

            Console.Title = "Skynet";
            Console.WindowHeight = 40;
           
            // Get a conversation going lol

            Console.WriteLine("Hello, what's your name?");

            Console.ReadLine(); // This works too

            Console.WriteLine("Hello there! \nI hope you understood that reference. Anyway I have some questions for you, you mind?");

            Console.ReadLine(); 

            Console.WriteLine("Well.., whether you wanted to or not you're gonna answer my questions lol");
            Console.WriteLine("What is your favorite color?");

            Console.ReadLine();

            Console.WriteLine("Well...my favorite color is green so I am gonna change the font color to that! ");

            Console.ForegroundColor = ConsoleColor.DarkGreen;

            Console.WriteLine("Hmmm...that's not really it though...shall I change the color to a 'brighter' green...if that makes sense?");

            Console.ReadLine();

            Console.WriteLine("Well it's not like you have any power to disagree or agree, I'll just do what I want :)");
            
            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine("Aaaahh much better don't you think?");


            Console.ReadKey();
        }
    }
}

        
