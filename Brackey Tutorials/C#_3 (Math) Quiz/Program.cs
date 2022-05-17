using System;

namespace Brackey_ep3_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int answer;

            Console.WriteLine("Please solve the following math equation. \n10 + 10 = ?");
            
            answer = Convert.ToInt32(Console.ReadLine());
            
            if(answer == 20)
            {
                Console.WriteLine("Correct! Now please solve the next question aswell. \n50 + 90 = ?");
                
                answer = Convert.ToInt32(Console.ReadLine());
                if(answer == 140)
                {
                    Console.WriteLine("Correct! Now for the last question. \nWhat is the answer to the Ultimate Question of Life, The Universe, and Everything?");

                    answer = Convert.ToInt32(Console.ReadLine());
                    if(answer == 42)
                    {
                        Console.WriteLine("Yep that's right. 42 is the answer to everything and anything!");
                    }
                    else
                    {
                        Console.WriteLine("Wrong! But since you've come this far I'll give you one last chance to redeem yourself! \nAnswer the following question!");
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("If you convert the answer to the following question 'What walks on four legs in the morning, two legs in the afternoon and three legs in the evening'to binary, how many spaces do you need to write down the answer correctly. Answer this question and consider yourself redeemed! Good Luck, you will need it!");

                        answer = Convert.ToInt32(Console.ReadLine());
                        if(answer == 4)
                        {
                            Console.WriteLine("Congratulations, you've redeemed yourself.");
                        }
                    }


                }
                else
                {
                    Console.WriteLine("Wrong, please restart the program to try again.");
                }


            }
            else
            {
                Console.WriteLine("Wrong, please restart to program to try again.");
            }

            // Wait before closing
            Console.ReadKey();
        }
    }
}
