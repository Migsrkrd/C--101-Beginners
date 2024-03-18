using System;

namespace _2d_Arrays
{
    class Program
    {
        static void Main()
        {
            //To create a 2d Array, you declare the data type, followed by two sets of square brackets with a comma in between. Then name the array and set it equal to a set of curly braces with the values inside.
            //A 2d Array is an array of arrays
            int[,] numberGrid = {
                {1, 2},
                {3, 4},
                {5, 6}
            };

            //To find a value in a 2d Array, you use the name of the array, followed by square brackets with the index of the array you want to access. Then you use another set of square brackets with the index of the value you want to access.
            //This will print 6
            Console.WriteLine(numberGrid[2, 1]);

        }
    }
}
