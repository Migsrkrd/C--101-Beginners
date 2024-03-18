using System;

namespace GettersAndSetters
{
    class Movie
    {
        public string title;
        public string director;
        //We can use a private access modifier to make sure that the rating can only be set from within the class
        private string rating;

        public Movie(string aTitle, string aDirector, string aRating)
        {
            title = aTitle;
            director = aDirector;
            Rating = aRating;
        }

        //We can use properties to control the access to the rating
        public string Rating{
            //get is used to return the value of the rating
            get {return rating;}
            //set is used to set the value of the rating by using conditions
            set {
                //If the value is one of the following, then set the rating to the value
                if(value == "G" || value == "PG" || value == "PG-13" || value == "R" || value == "NR")
                {
                    rating = value;
                }
                //If the value is not one of the following, then set the rating to NR
                else
                {
                    rating = "NR";
                }
            }
        }
    }
}