using System;

namespace GettersAndSetters
{
    class Program
    {
        static void Main()
        {
            //Here we are creating a new object of the Movie class
            Movie avengers = new Movie("The Avengers", "Joss Whedon", "PG-13");
            //You can notice that the rating for the movie Shrek is not one of the following: "G", "PG", "PG-13", "R", "NR"
            //When you run this in the terminal, it will follow the rules we set in the Movie class
            Movie shrek = new Movie("Shrek", "Adam Adamson", "Dog");

            Console.WriteLine(avengers.Rating); //PG-13
            Console.WriteLine(shrek.Rating); //NR
        }
    }
}
