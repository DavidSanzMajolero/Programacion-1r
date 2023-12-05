using System;
namespace Exercicis
{
    class Ex2
    {
        public static void Main()
        {
            int numBase, numExp;
            numBase = Convert.ToInt32(Console.ReadLine());
            numExp = Convert.ToInt32(Console.ReadLine());
            Exponent(numBase, numExp);
        }
        public static void Exponent(int numberOne, int numberTwo)
        {
            int mem = 0;
            mem = numberOne;
            if (numberTwo == 0) Console.WriteLine("1");
            else 
            {
                for (int i = 0; i < numberTwo - 1; i++)
                {
                    numberOne *= mem;
                }
                Console.WriteLine(numberOne);
            }
        }
    }
}
