using System;

namespace LearnCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isMale = true;
            bool isTall = true;
            // this checks if the booleans are true or false
            if (isMale && isTall)
            {
                // if both are true
                Console.WriteLine("You are a tall male");
            }
            // if the first condition is true and the second is false
            else if (isMale && !isTall)
            {
                Console.WriteLine("You are a short male");
            }
            // if the first condition is false and the second is true
            else if (!isMale && isTall)
            {
                Console.WriteLine("You are not a male but are tall");
            }
            //otherwise
            else
            {
                Console.WriteLine("You are not a male and not tall");
            }
        }
    }
}
