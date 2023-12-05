using System;
namespace Project
{
    public class Ex2
    {
        public static void Main()
        {
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Absolute(num));
        }
        public static int Absolute(int numAbsolute)
        {
            if (numAbsolute < 0) numAbsolute *= -1;
            return numAbsolute;
        }
    }
}
