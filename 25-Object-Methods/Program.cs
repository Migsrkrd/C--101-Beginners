using System;

namespace ObjectMethods
{
    class Program
    {
        static void Main()
        {
            Student student1 = new Student("Jim", "Business", 2.8);
            Student student2 = new Student("Pam", "Art", 3.6);

            //Just like how we can use the class to create objects, we can also use the class to call methods on those objects
            //This is how we call the HasHonors method on the student1 and student2 objects
            Console.WriteLine(student1.HasHonors());
            Console.WriteLine(student2.HasHonors());
        }
    }
}
