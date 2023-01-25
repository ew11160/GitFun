// program for mission 2, needed somewhere to store while I fix bugs

using System;

namespace Mission2Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();

            Console.WriteLine("Welcome to the dice throwing simulator!");
            Console.WriteLine("How many dice rolls would you like to simulate? ");
            // get the number of rolls
            int intRolls = Convert.ToInt32(Console.ReadLine());
            // create an array to hold values from 2-12 (possible combination rolled)
            int[] aCount = new int[11];

            for (int i = 0; i < intRolls; i++)
            {
                // calculate dice rolls
                int dice1 = r.Next(1, 7);
                int dice2 = r.Next(1, 7);
                int total = dice1 + dice2;

                // now put those results in the array
                if (total == 2)
                {
                    aCount[0]++;
                }
                if (total == 3)
                {
                    aCount[1]++;
                }
                if (total == 4)
                {
                    aCount[2]++;
                }
                if (total == 5)
                {
                    aCount[3]++;
                }
                if (total == 6)
                {
                    aCount[4]++;
                }
                if (total == 7)
                {
                    aCount[5]++;
                }
                if (total == 8)
                {
                    aCount[6]++;
                }
                if (total == 9)
                {
                    aCount[7]++;
                }
                if (total == 10)
                {
                    aCount[8]++;
                }
                if (total == 11)
                {
                    aCount[9]++;
                }
                if (total == 12)
                {
                    aCount[10]++;
                }
            } // end for loop that rolls totals
            // calculate asterisks by creating a new array to store the asterisks string
            // delete string[] aAsterisks = new string[11];

            // loop through the length of the asterisks array to find each total asterisks
            // currently they are not populating
            for (int i = 0; i < aCount.Length; i++)
            {
                // also need to solve for the amount of asterisks
                // (not based on count of them, but the percentage...)
                double perAsterisks = (aCount[i] / intRolls) * 100;
                Math.Round(perAsterisks);

                Console.WriteLine(aCount[i] + 2 + ": ");// delete + aCount[0] + aAsterisks[0]);

                for (int ii = 0; i < perAsterisks; i++)
                {
                    Console.WriteLine("*");
                }
                Console.WriteLine("\n");
                // string asterisks = "";
                // i am trying to continually concat on an asterisk for the value in the aCount[i]
                //int c = 0;
                //while (c < perAsterisks)
                //{
                //    asterisks += "*";
                //}
                //aAsterisks[i] = asterisks;
            }

            // print results
            Console.WriteLine("DICE ROLLING SIMULATION RESULTS");
            Console.WriteLine("Each '*' represents 1% of the total number of rolls.");
            Console.WriteLine("Total number of rolls = " + intRolls);
            /*Console.WriteLine("2: " + aCount[0] + aAsterisks[0]);
            Console.WriteLine("3: " + aCount[1] + aAsterisks[1]);
            Console.WriteLine("4: " + aCount[2] + aAsterisks[2]);
            Console.WriteLine("5: " + aCount[3] + aAsterisks[3]);
            Console.WriteLine("6: " + aCount[4] + aAsterisks[4]);
            Console.WriteLine("7: " + aCount[5] + aAsterisks[5]);
            Console.WriteLine("8: " + aCount[6] + aAsterisks[6]);
            Console.WriteLine("9: " + aCount[7] + aAsterisks[7]);
            Console.WriteLine("10: " + aCount[8] + aAsterisks[8]);
            Console.WriteLine("11: " + aCount[9] + aAsterisks[9]);
            Console.WriteLine("12: " + aCount[10] + aAsterisks[10]);*/
            Console.WriteLine("Thank you for using the dice throwing simulator. Goodbye!");
        }
    }
}
