using System;

namespace Exception_Handling
{
    class Program
    {
        static void Main()
        {
            //This is a simple program that takes two numbers and divides them
            //It uses exception handling to catch errors otherwise known as a try-catch block
            try
            {
                //Here we are asking the user to enter two numbers
                Console.Write("Enter a number: ");
                int num1 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter another number: ");
                int num2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(num1 / num2);
            }
            //You can have multiple catch blocks to catch different types of exceptions
            //This will catch a divide by zero exception
            //Test this by entering 0 as the second number in the program
            catch (DivideByZeroException e)
            {
                Console.WriteLine("Cannot divide by zero");
                //restart the program
                Main();
            }
            //This will catch a format exception
            //Test this by entering a letter instead of a number
            catch (FormatException e)
            {
                Console.WriteLine("Please enter a number");
                //restart the program
                Main();
            }
            //This will catch any other exception
            //This is the most general exception and should be used as a last resort
            //Test this by entering 3029183948573282910139438576218910039483129 as the second number
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
