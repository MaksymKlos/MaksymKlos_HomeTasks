using System;

namespace Delegate
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("You can enter arbitrary lines. Enter \"end\" to exit.");
            var stringHandler = new StringHandler();
            string input;


            while(true)
            {
                input = Console.ReadLine();
                if (input.ToLower() == "end") break;
                else
                {
                    stringHandler.SetString(input);
                }
            }
            PrintMenu(stringHandler);
        }

        static void PrintMenu(StringHandler stringHandler)
        {
            do
            {
                char input;
                Console.WriteLine("---------------------------------------");
                Console.WriteLine("Please choose one of the followings:");
                Console.WriteLine("Enter '1' to print AlphaNumericCollection");
                Console.WriteLine("Enter '2' to print StringCollection");
                Console.WriteLine("Enter '3' to exit");
                Console.WriteLine("---------------------------------------");
                try
                {
                    input = char.Parse(Console.ReadLine());
                    switch (input)
                    {
                        case '1':
                            stringHandler.GetStrings(input);
                            break;
                        case '2':
                            stringHandler.GetStrings(input);
                            break;
                        case '3':
                            return;
                        default:
                            Console.WriteLine("You entered an invalid value");
                            break;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            } while (true);
        }
    }
}
