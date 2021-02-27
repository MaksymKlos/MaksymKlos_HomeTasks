using System;

namespace Actions
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("You can enter arbitrary lines. Enter \"end\" to exit.");
            var stringHandler = new StringHandler();
            string input;


            while (true)
            {
                input = Console.ReadLine();
                if (input.ToLower() == "end")
                {
                    stringHandler.GetStrings();
                    break;
                }
                else
                {
                    stringHandler.SetString(input);
                }
            }
        }

    }
}
