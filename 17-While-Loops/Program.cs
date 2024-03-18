using System;

namespace LearnCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            int index = 1;
            Console.WriteLine("While Loop for numbers:");
            //while loops are used when you don't know how many times you want to loop
            //the loop will continue to run as long as the condition is true
            //in this case, the loop will run as long as index is less than or equal to 5
            while (index <= 5) {
                Console.WriteLine(index);
                index++;
            }
            Console.WriteLine("--------------------");

            //you can also use a while loop to iterate through an array
            string[] friends = {"Jim", "Karen", "Kevin"};
            int i = 0;
            Console.WriteLine("While Loop for friends array:");
            while (i < friends.Length) {
                Console.WriteLine(friends[i]);
                i++;
            }
            Console.WriteLine("--------------------");

            Console.WriteLine("Do-While Loop for numbers:");
            //do-while loops are used when you want to run the loop at least once
            //the loop will continue to run as long as the condition is true
            int j = 6;
            do {
                Console.WriteLine(j);
                j++;
            } while (j <= 5);
        }
    }
}
