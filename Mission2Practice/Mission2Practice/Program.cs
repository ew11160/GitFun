// same as our imports
using System;

// name of our whole solution
namespace Mission2Practice
{
    class Program
    {
        // same for all programs
        static void Main(string[] args)
        {
            // set up an array with values
            string[] cars = { "Volvo", "BMW", "Ford", "Mini Cooper" };
            // change the value of place 2 in the array
            cars[2] = "Mazda";
            //Console.WriteLine(cars[2]); // length cars.length

            Random r = new Random(); // declaration & instantiation

            Console.WriteLine(r.Next(10)+2);

            // create new dice
            int[] dice = new int[6];
            // declare counter variable; condition for how long we'll do it; increment
            for (int i = 0; i < 6; i++) // i++ : same as i = i + 1
            {
                dice[i] = i+1;
            }
            for (int i=0; i<6; i++)
            {
                Console.WriteLine(dice[i]);
            }

            int rolls = 10;

            for (int i=0; i<rolls; i++)
            {
                Console.WriteLine("Continued in Mission2Assignment");
            }


            int[] blah = new int[6];
            for (int i=0; i<6, i++)
            {
                blah[i] = 0;
            }
            for (int i = 0, i<100; i++)
            {
                int roll = r.Next(6);
                blah[roll]++; // this is going to the array, finding the spot that correlates
                              // with the roll and adding 1 to that value
                              // (summing the total number of times we rolled that number)
            }
        }
    }
}