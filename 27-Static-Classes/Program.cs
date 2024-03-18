using System;

namespace StaticClasses
{
    class Program
    {
        static void Main()
        {
            //Here we are creating new objects of the Song class
            Song holiday = new Song("Holiday", "Green Day", 200);
            Song kashmir = new Song("Kashmir", "Led Zeppelin", 150);

            //When we run this in the terminal, we will see that songCount is 2
            //We can get this straight from the class itself because songCount is a static variable
            //If it were not static, we would have to create a new Song object and call the getSongCount method on it
            Console.WriteLine(Song.songCount); //2

            //Here we are actually accessing the getSongCount method from the Song class
            //We are able to do this because we made the method public
            Console.WriteLine(holiday.getSongCount()); //2
        }
    }
}
