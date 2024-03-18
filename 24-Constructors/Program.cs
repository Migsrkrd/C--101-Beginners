using System;

namespace Constructors
{
    class Program
    {
        static void Main()
        {
            //Now we can create a new object of type Book and define its attributes all in one line
            Book book1 = new Book("Harry Potter", "JK Rowling", 400);

            //Again here
            Book book2 = new Book("Lord of the Rings", "Tolkein", 700);

            Console.WriteLine("The first book is " + book1.title + " by " + book1.author + " and has " + book1.pages + " pages.");
            
            Console.WriteLine("The second book is " + book2.title + " by " + book2.author + " and has " + book2.pages + " pages.");

            Console.ReadLine();
        }
    }
}