using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberGuesser
{
    class Program
    {
        static void Main(string[] args)
        {
            GetAppInfo();

            GetName();

            while (true)
            {
                // int correctNumber = 7;

                Random random = new Random();

                int correctNumber = random.Next(1, 10);

                int guess = 0;

                Console.WriteLine("Guess a Number (1-10)");

                while (guess != correctNumber)
                {
                    string input = Console.ReadLine();

                    if (!int.TryParse(input, out guess))
                    {
                        PrintColorMessage(ConsoleColor.Red, "Not Number");

                        continue;
                    }

                    guess = Int32.Parse(input);

                    if (guess != correctNumber)
                    {
                        PrintColorMessage(ConsoleColor.Red, "Wrong");
                    }
                    else
                    {
                        PrintColorMessage(ConsoleColor.Yellow, "Correct");

                        Console.WriteLine("Play Again? [Y or N]");

                        string answer = Console.ReadLine().ToUpper();

                        if (answer == "Y")
                        {
                            continue;
                        }
                        else if (answer == "N")
                        {
                            return;
                        }
                        else
                        {
                            return;
                        }
                    }
                }

            }
        
        }

        static void GetAppInfo()
        {
            string appName = "Number Guesser";
            string appVersion = "1.0.0";
            string appAuthor = "Hafiz";
            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);

            Console.ResetColor();
        }

        static void GetName()
        {
            Console.WriteLine("Your Name?");

            string inputName = Console.ReadLine();
             
            Console.WriteLine("Hello {0}, let's play", inputName);
        }

        static void PrintColorMessage(ConsoleColor color, string message)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(message);
            Console.ResetColor();
        }


    }
}
