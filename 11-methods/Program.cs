//This is the boilerplate code for the program.
//using System is here to include the System namespace in the program.
using System;

//The namespace is a container for classes and other namespaces. It should be unique for each program.
namespace LearnCSharp
{
    //The class is a blueprint for objects. It can contain methods, fields, constructors, and other class members.
    class Program
    {
        //The Main method is the entry point for every C# application. It is the method that is called when the program is executed.
        static void Main(string[] args)
        {
            string myName = "John";
            int myAge = 30;
            //you can call a method from the Main method
            MyMethod();

            //comment out the code below to include it in the output
            // MyMethodWithParameters(myName, myAge);
        }

        //you can create methods outside of the Main method to make your code more organized. It will not run unless you call it from the Main method.
        //static means that the method belongs to the class, not an object of the class and can be called without creating an instance of the class.
        //void means that the method does not have a return value.
        //You use a Capital letter to name the method.
        static void MyMethod()
        {
            Console.WriteLine("I just got executed!");
        }

        //you can also create methods with parameters
        //you can pass data to the method by using parameters
        static void MyMethodWithParameters(string name, int age)
        {
            Console.WriteLine(name + " is my friend" + " and he is " + age + " years old.");
        }
    }
}
