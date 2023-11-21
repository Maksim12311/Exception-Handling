using System;

namespace ExceptionHandling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BasicExceptionHandling();
            MultipleExceptionTypes();
            FinalyBlockUsage();
            CustomExceptionClass();
            ExceptionPropagation();
            UsingThrowAndCatch();
        }

        static void BasicExceptionHandling()
        {
            Console.Write("Enter a number: ");
            // TODO:
            // Convert the input to an integer using int.Parse().
            // Use a try-catch block to handle FormatException if the user enters a non-numeric value.
            try
            {
                string s = Console.ReadLine();
                int i = int.Parse(s);
                Console.WriteLine("Your input is correct");
            }
            catch (FormatException)
            {
                Console.WriteLine("Error occured.Please enter a valid number.");
            }

            // Display an error message in case of an exception.
            // Output the input if correct

        }

        static void MultipleExceptionTypes()
        {
            Console.Write("Enter a number: ");
            // TODO:
            // Implement BasicExceptionHandling code with following modification
            // Include a catch block for OverflowException to handle cases where the number is too large or small for an int.
            // Display appropriate error messages for different exceptions.
            try
            {
                string s = Console.ReadLine();
                int i = int.Parse(s);
                Console.WriteLine("Your input is correct");
            }
            catch (FormatException)
            {
                Console.WriteLine("Error occured.Please enter a valid number.");
            }
            catch (OverflowException)
            {
                Console.WriteLine("the number is too large or small for an int");
            }


        }

        static void FinalyBlockUsage()
        {
            Console.Write("Enter a number: ");
            // TODO:
            // Implement BasicExceptionHandling code with following modification
            // Add a finally block to the program.
            // Use the finally block to display a message whether an exception was caught or not.
            try
            {
                string s = Console.ReadLine();
                int i = int.Parse(s);
                Console.WriteLine("Your input is correct");
            }
            finally { Console.WriteLine("Finally block executed, whether an exception was caught or not"); }


        }



        // Class for custom exception type
        class NegativeNumberException : ApplicationException
        {
            public NegativeNumberException(string message) : base(message) { }
        }

        static void CustomExceptionClass()
        {
            Console.Write("Enter a number: ");
            // TODO:
            // Implement BasicExceptionHandling code with following modification
            // Modify your number input program to throw NegativeNumberException if the user enters a negative number.
            // Handle this exception in a separate catch block and display an appropriate message.
            try
            {
                Console.Write("Enter a number: ");
                int userInput = int.Parse(Console.ReadLine());

                // Check if the entered number is negative
                if (userInput < 0)
                {
                    throw new NegativeNumberException("Negative numbers are not allowed.");
                }

                Console.WriteLine($"You entered: {userInput}");

                // Additional logic can be added here for non-negative numbers
            }
            catch (NegativeNumberException e)
            {
                Console.WriteLine($"Exception: {e.Message}");
                // Additional handling for NegativeNumberException
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
                // Additional handling for invalid input format
            }
            catch (Exception e)
            {
                Console.WriteLine($"An error occurred: {e.Message}");
                // Additional handling for other exceptions
            }
        }

        static void ExceptionPropagation()
        {
            Console.Write("Enter a number: ");
            // TODO:
            // Implement BasicExceptionHandling code with following modification
            // Write a function CheckNumber that takes an integer and throws ArgumentOutOfRangeException if the number is greater than 100.
            // In this function, call CheckNumber inside a try block and handle the exception.
            try
            {
                string s = Console.ReadLine();
                int i = int.Parse(s);
                Console.WriteLine("Your input is correct");
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.ToString());
            }
            catch (ArgumentOutOfRangeException ea)
            {
                Console.WriteLine(ea.ToString());
            }
            catch (OverflowException f)
            {
                Console.WriteLine(f.ToString());
            }
        }

        // NOTE: You can implement the CheckNumber here
        public static void CheckNumber(int number)
        {
            if (number > 100)
            {
                throw new ArgumentOutOfRangeException(" The input is greater than 100");
            }
        }
        static void UsingThrowAndCatch()
        {
            Console.Write("Enter a number: ");
            // TODO:
            // Implement BasicExceptionHandling code with following modification
            // Write a function CheckNumberWithLogging that takes an integer and throws ArgumentOutOfRangeException if the number is greater than 100.
            // Modify the CheckNumberWithLogging function to log the exception message before throwing it.
            // In this function, catch the exception in the main program and display the logged message.
            try
            {
                int input = int.Parse(Console.ReadLine());
                CheckNumberWithLogging(input);
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }
        }


        // NOTE: You can implement the CheckNumberWithLogging here
        static void CheckNumberWithLogging(int input)
        {
            if (input > 100)
            {
                Console.WriteLine("Logged message - entered number should not be greater than 100");
                throw new ArgumentOutOfRangeException("Entered number should not be greater than 100");
            }
        }
    }
}

