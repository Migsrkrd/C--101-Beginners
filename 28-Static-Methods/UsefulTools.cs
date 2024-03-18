using System;

namespace StaticMethods
{
    static class UsefulTools
    {
        //Here we are creating a static method that takes in a string parameter
        //we say public to make it accessible from other classes
        //we say static so that we can call it without creating an object of the UsefulTools class
        //we say void because we are not returning anything
        public static void SayHi (string name)
        {
            Console.WriteLine("Hello " + name);
        }
    }
}