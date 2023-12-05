using System;
namespace Project
{
    public class Ex11
    {
        public static void Main()
        {
            int num = Convert.ToInt32(Console.ReadLine());
            int numTwo = Factorial(num);
            Console.WriteLine(numTwo);
        }
        public static int Factorial(int num)
        {
            int mem = num;
            for (int i = num - 1; i > 0; i--)
            {
                mem *= i;
            }
            return mem;
        }


    }
}
