using System;

namespace LearnCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GetMax(10, 30));
        }

        static int GetMax(int num1, int num2)
        {
            int result;
            if (num1 > num2)
            {
                result = num1;
            }
            else
            {
                result = num2;
            }
            return result;
        }
    }
}
