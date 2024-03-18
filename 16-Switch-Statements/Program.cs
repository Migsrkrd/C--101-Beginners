using System;

namespace LearnCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //calling the GetDay method and passing in 3 as the argument
            Console.WriteLine(GetDay(3)); //output: Wednesday
        }

        static string GetDay(int dayNum) {
            //establish a variable to hold the day name
            string dayName;
            //use a switch statement to determine the day name
            switch (dayNum) {
                //if the day number is 0
                case 0:
                    //set the day name to Sunday
                    dayName = "Sunday";
                    //break out of the switch statement
                    break;
                //if the day number is 1, set the day name to Monday.
                case 1:
                    //set the day name to Monday
                    dayName = "Monday";
                    //break out of the switch statement
                    break;
                case 2:
                    dayName = "Tuesday";
                    break;
                case 3:
                    dayName = "Wednesday";
                    break;
                case 4:
                    dayName = "Thursday";
                    break;
                case 5:
                    dayName = "Friday";
                    break;
                case 6:
                    dayName = "Saturday";
                    break;
                default:
                    dayName = "Invalid Day Number";
                    break;
            }
            //return the day name
            return dayName;
        }

    }
}
