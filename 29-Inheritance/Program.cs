using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Chef chef = new Chef();
            Console.WriteLine("Chef:");
            chef.MakeChicken();
            //This will call the MakeSpecialDish method in the Chef class
            //even though they are the same method name, the ItalianChef class has a different implementation of the method
            //this was made capable because in the Chef class, the MakeSpecialDish method was declared as virtual
            chef.MakeSpecialDish();

            Console.WriteLine("----------------------");

            Console.WriteLine("Italian Chef:");

            ItalianChef italianChef = new ItalianChef();

            italianChef.MakeChicken();

            italianChef.MakePasta();
            
            //This will call the MakeSpecialDish method in the ItalianChef class
            italianChef.MakeSpecialDish();

            Console.ReadLine();
        }
    }
}

