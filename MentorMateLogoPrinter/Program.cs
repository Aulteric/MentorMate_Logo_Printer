using System;

namespace MentorMate_Logo_Printer
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            int validatedInput = ValidateInputs(input);

            for (int i = 0; i < (validatedInput + 1) / 2; i++) // used for the upper part of the logo printing
            {
                PrintDash(validatedInput - i);
                PrintStars(validatedInput + i * 2);
                PrintDash(validatedInput - i * 2);
                PrintStars(validatedInput + i * 2);
                PrintDash((validatedInput - i) * 2);
                PrintStars(validatedInput + i * 2);
                PrintDash(validatedInput - i * 2);
                PrintStars(validatedInput + i * 2);
                PrintDash(validatedInput - i);

                Console.WriteLine();//used to separate the lines
            }
            int secondCounter = 1;
            for (int i = (validatedInput + 1) / 2; i <= validatedInput; i++)
            {
                PrintDash(validatedInput - i);
                PrintStars(validatedInput);
                PrintDash(secondCounter);
                PrintStars((validatedInput * 2) - secondCounter);
                PrintDash(secondCounter);
                PrintStars(validatedInput);
                PrintDash((validatedInput - i) * 2);
                PrintStars(validatedInput);
                PrintDash(secondCounter);
                PrintStars((validatedInput * 2) - secondCounter);
                PrintDash(secondCounter);
                PrintStars(validatedInput);
                PrintDash(validatedInput - i);


                secondCounter += 2;
                Console.WriteLine();
            }
        }

        private static void PrintStars(int count)
        {
            Console.Write(new string('*', count));
        }
        private static void PrintDash(int count)
        {
            if (count > 0)
            {
                Console.Write(new string('-', count));
            }
        }

        private static int ValidateInputs(string input) //This method is used to validate if the input is an integer and if it fits the requirements given by the assignment
        {
            int parsedInput;

            while (true)
            {
                if (int.TryParse(input, out int result)) // First validation if its an integer
                {
                    parsedInput = int.Parse(input);

                    if (parsedInput < 2 || parsedInput > 10000 || parsedInput % 2 == 0) // Second validation if it fits the given requirements
                    {
                        Console.WriteLine("This input does not match the requirements given by the assignment, please use the correct input: ");
                        input = Console.ReadLine();
                        continue;
                    }

                    return parsedInput;
                }
                else
                {
                    Console.WriteLine("This input is not a valid integer, please try again: ");
                    input = Console.ReadLine();
                }
            }
        }
    }
}
