using System;
namespace Project
{
    public class Ex9
    {
        public static void Main()
        {
            double num = Convert.ToInt32(Console.ReadLine());
            double numTwo = Convert.ToInt32(Console.ReadLine());
            double numThree = Convert.ToInt32(Console.ReadLine());
            bool validation = Validate(num, numTwo, numThree);
            if (validation) Console.WriteLine("Esta al rang");
            else Console.WriteLine("No esta al rang");

        }
        public static bool Validate(double num, double numTwo, double numThree)
        {
            return (num > numTwo && num < numThree) ? true : false;
        }
    }
}
