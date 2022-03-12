using System;

namespace VideoGameManager.View
{
    public class EntryValidation
    {
        public string ValidString(string userInput)
        {
            string output = "";

            while (output == "")
            {
                Console.WriteLine(userInput);
                output = Console.ReadLine().Trim();

                if (output == "")
                {
                    Console.WriteLine("Invalid. Please try again.");
                }
            }

            return output;
        }

        public int ValidInt(string userInput, int min, int max)
        {
            string outputString;
            int output;

            while (true)
            {
                Console.WriteLine(userInput);
                outputString = Console.ReadLine();

                if (int.TryParse(outputString, out output))
                {
                    if (output >= min && output <= max)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("\nThat number was not between {0} and {1}.", min, max);
                        Console.WriteLine("Please try again.");
                        Console.WriteLine();
                    }
                }
                else
                {
                    Console.WriteLine("\nThat was not a valid selection.");
                    Console.WriteLine("Please try again.");
                    Console.WriteLine();
                }
            }

            return output;
        }
    }
}
