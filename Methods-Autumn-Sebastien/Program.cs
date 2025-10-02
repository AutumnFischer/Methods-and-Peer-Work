/**
 * Code written by Autumn Fischer and Sebastien Guillotin
 * Assignment for IGME.201.01 - Interac Des & Alg Prob Sol III
 * Due October 12, 2025
**/
namespace Methods_Autumn_Sebastien
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int autumnFavoriteNumber;
            int sebastienFavoriteNumber;

            //initialize
            autumnFavoriteNumber = 13;
            sebastienFavoriteNumber = 67;

            /// <summary>
            ///     A funtion that takes two integers as parameters and returns their difference
            /// </summary>
            /// <param name="num1">the first number</param>
            /// <param name="num2">the second number</param>
            /// <returns>returns the two parameters subtracted</returns>
            int Subtract(int num1, int num2)
            {
                int result = num1 - num2;
                return result;
            }

            //start the real stuff
            Console.WriteLine("Autumn's favorite number is " + autumnFavoriteNumber + "!");
            Console.WriteLine("Sebastien's favorite number is " + sebastienFavoriteNumber + " :(");
            //add sebastien's print here

            //call the Add function here
            int sum = Add(autumnFavoriteNumber, sebastienFavoriteNumber);
            Console.WriteLine("The sum of our favorite numbers is: " + sum + "!");

            int difference = Subtract(sebastienFavoriteNumber, autumnFavoriteNumber);
            Console.WriteLine("The difference between our favorite numbers is: " + difference + "! :D");
        }

        /// <summary>
        ///     A funtion that takes two integers as parameters and returns their sum
        /// </summary>
        /// <param name="num1">the first number</param>
        /// <param name="num2">the second number</param>
        /// <returns>returns the two parameters added together</returns>
        static int Add(int num1, int num2)
            { 
                int result = num1 + num2;
                return result;
        }
    }
}
