using System;

namespace Classes_and_Objects
{
    class Program
    {
        static void Main()
        {
            //Here we are creating two new objects of type Book

            //This is how we create a new object of type Book, following the template we defined in the Book class
            Book book1 = new Book();
            book1.title = "Harry Potter";
            book1.author = "JK Rowling";
            book1.pages = 400;

            //Here we are doing it again for a second book
            Book book2 = new Book();
            book2.title = "Lord of the Rings";
            book2.author = "Tolkein";
            book2.pages = 700;

            //Here we are printing out the attributes of the two objects we created
            Console.WriteLine("The first book is " + book1.title + " by " + book1.author + " and has " + book1.pages + " pages.");
            Console.WriteLine("The second book is " + book2.title + " by " + book2.author + " and has " + book2.pages + " pages.");

            //Try removing one of the attributes from the Book class and see what happens when you try to run the program
        }
    }
}
