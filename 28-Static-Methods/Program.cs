using System;

namespace StaticMethods
{
    class Program
    {
        static void Main()
        {   
            //Here we are using the Math class to call the sqrt method
            //We can do this because the sqrt method is static and a built-in method in the Math class
            Console.WriteLine(Math.Sqrt(144)); //12

            //Here we are using the SayHi method from the UsefulTools static class
            UsefulTools.SayHi("Mike"); //Hello Mike

            Console.ReadLine();
        }
    }
}
