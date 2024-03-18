using System;

namespace Inheritance
{
    //ItalianChef inherits from Chef
    //you can do so with this notation
    //this means that ItalianChef has all the methods and properties of Chef
    //you typically use inheritance when you want to add some extra functionality to a separate class but also want to keep the original class
    class ItalianChef : Chef
    {
        public void MakePasta()
        {
            Console.WriteLine("The chef makes pasta");
        }

        //This method overrides the MakeSpecialDish method in the Chef class
        //This means that if you call the MakeSpecialDish method on an ItalianChef object, it will call this method instead of the one in the Chef class
        public override void MakeSpecialDish()
        {
            Console.WriteLine("The chef makes chicken parm");
        }
    }
}
