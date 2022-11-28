using System;

namespace Casting_livingston_stephen
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a whole number"); //Asks the user to enter a number

            int myFavNum = Convert.ToInt32(Console.ReadLine()); //Converts string input to a integer

            Console.WriteLine("Your favorite number is " + myFavNum); //Tells the user what number was typed.

            Console.WriteLine("Do you like video games? (Please enter 'true' or 'false')"); //Asks the user a true or flase question
            bool isTrue = Convert.ToBoolean(Console.ReadLine()); //Converts answer to true or false

            Console.WriteLine($"It is {isTrue} that I like video games!"); //Tells the user that the answer is true
        }

    }
}
