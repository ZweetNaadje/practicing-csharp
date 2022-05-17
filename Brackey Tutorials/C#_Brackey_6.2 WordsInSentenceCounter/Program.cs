using System;

namespace Brackey_6_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tell me something, anything really...:");

            string sentence = Console.ReadLine();
            int wordCount = wordCounter(sentence);

            Console.WriteLine("There are "+ wordCount +" words in that sentence.");

            Console.ReadKey();
        }

        static int wordCounter (string sentence)
        {
            int wordCount = sentence.Split(' ').Length;
            return wordCount;
        }
    }
}
