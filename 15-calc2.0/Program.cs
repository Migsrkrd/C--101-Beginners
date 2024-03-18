using System;

namespace LearnCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //asking for user input for first number
            Console.Write("Enter a number: ");
            //storing the user input in a variable
            double num1 = Convert.ToDouble(Console.ReadLine());

            //asking for user input for operator
            Console.Write("Enter Operator: ");
            //storing the user input in a variable
            string op = Console.ReadLine();

            //asking for user input for second number
            Console.Write("Enter a number: ");
            //storing the user input in a variable
            double num2 = Convert.ToDouble(Console.ReadLine());
            
            //checking the operator and performing the operation
            if (op == "+")
            {
                Console.WriteLine(num1 + num2);
            }
            else if (op == "-")
            {
                Console.WriteLine(num1 - num2);
            }
            else if (op == "/")
            {
                Console.WriteLine(num1 / num2);
            }
            else if (op == "*")
            {
                Console.WriteLine(num1 * num2);
            }
            else
            {
                Console.WriteLine("Invalid Operator");
            }

            Console.ReadLine();
        }

    }
}
