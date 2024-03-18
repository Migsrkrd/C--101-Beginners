using System;

namespace Inheritance
{
    class Chef
    {
        public void MakeChicken()
        {
            Console.WriteLine("The chef makes chicken");
        }

        public void MakeSalad()
        {
            Console.WriteLine("The chef makes salad");
        }

        //This method is virtual, which means that it can be overriden by a subclass (In this case, the ItalianChef class)
        public virtual void MakeSpecialDish()
        {
            Console.WriteLine("The chef makes bbq ribs");
        }
    }
}
