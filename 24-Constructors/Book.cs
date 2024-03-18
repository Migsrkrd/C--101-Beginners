using System;

//Here we are creating a new class called Book for the purpose of creating objects of type Book

namespace Constructors
{
    class Book
    {
        //Again here we are creating the attributes of the class Book
        public string title;
        public string author;
        public int pages;

        //This is the constructor for the class Book
        //Here we can define the attributes of the class when we create a new object of type Book
        public Book(string aTitle, string aAuthor, int aPages){
            title = aTitle;
            author = aAuthor;
            pages = aPages;
            
        }
    }
}