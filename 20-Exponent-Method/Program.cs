using System;

namespace Exponent_Method
{
    class Program
    {
        static void Main()
        {
            //Call the Power method and pass in 2 and 3 as arguments
            Console.WriteLine(Power(3, 3));
        }
        //Create a method that takes two integers as arguments and returns the value of the first argument raised to the power of the second argument.
        static int Power(int baseNum, int powNum)
        {
            //Create a variable to store the result
            //Set it to 1 because if the power is 0, the result will be 1
            int result = 1;
            
            //Loop through the power number and multiply the base number by itself
            for (int i = 0; i < powNum; i++)
            {
                //Multiply the base number by itself each time the loop runs (powNum times)
                result *= baseNum;
            }

            //Return the result
            return result;
        }
    }
}