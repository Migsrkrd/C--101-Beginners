using System;

namespace LearnCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----------------");
            Console.WriteLine("For loop for 5 iterations: 0, 1, 2, 3, 4");
            //A for loop is a more concise way to write a while loop
            //The for loop has three parts: the initialization, the condition, and the increment
            //The initialization is the starting point of the loop
            //The condition is the condition that must be true for the loop to continue
            //The increment is what happens after each iteration of the loop
            for (int i = 0; i < 5; i++) {
                Console.WriteLine(i);
            }

            Console.WriteLine("-----------------");
            Console.WriteLine("For Loop for Array of Names: John, Paul, George, Ringo");

            string[] namesArray = {"John", "Paul", "George", "Ringo"};
            
            //Call the method in the main method to print the names
            PrintNameArray(namesArray);
            Console.WriteLine("-----------------");
        }

        //We can use a for loop to iterate through an array
        //Create a method that takes an array of strings and prints each string
        static void PrintNameArray(string[] names){
            //We can use the length property of the array to determine how many times to loop
            for (int i = 0; i < names.Length; i++) {
                //We can use i to access each element of the array
                Console.WriteLine(names[i]);
            }
        }
    }
}
