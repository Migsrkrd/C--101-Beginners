using System;

namespace StaticClasses
{
    class Song
    {
        public string title;
        public string artist;
        public int duration;

        //Here we create a static variable to keep track of the number of songs created.
        //Static variables are shared across all instances of a class. Meaning that if we create 10 Song objects, they will all share the same songCount variable.
        //Below we initialize songCount to 0.
        public static int songCount = 0;

        public Song(string aTitle, string aArtist, int aDuration)
        {
            title = aTitle;
            artist = aArtist;
            duration = aDuration;
            //Here we increment songCount by 1 each time a new Song object is created.
            songCount++;
        }

        //Here we create a method to get the songCount. We use public instead of static because we want to be able to call this method on each object, not just the class itself.
        public int getSongCount()
        {
            return songCount;
        }
    }
}