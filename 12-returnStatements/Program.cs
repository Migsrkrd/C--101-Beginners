using System;

namespace LearnCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //you can call a method from the Main method
            int result = cube(5);
            Console.WriteLine(result);
        }

        //here we use an int as the return type
        //return types are declared before the method name
        //this method takes an int as a parameter and returns its cube
        static int cube(int num)
        {
            return num * num * num;
        }

    }
}
