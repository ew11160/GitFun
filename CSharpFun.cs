using System;

// Name of Program (to keep everything together)
namespace CSharpFun
{
    // class = organizational unit
    public class Program
    {
        // Start statement (public (outside classes can access), void (return types)
        public static void Main(string[] args)
        {
            PrintStuff ps = new PrintStuff("EN"); //Declaration & Instantiation
            PrintStuff ps2 = new PrintStuff("PT"); // different variable
            string ?userName = "";

            Console.Write("Please enter your name: ");
            userName = Console.ReadLine();

            ps.PrintName(userName);
            ps2.PrintName(userName);
        }
    }
}
// creating a variable, but determine the type of data to be stored
// declare datatype, then name the variable, blank is better than a null, instantiate
// the ? in front tells the program the value can be null