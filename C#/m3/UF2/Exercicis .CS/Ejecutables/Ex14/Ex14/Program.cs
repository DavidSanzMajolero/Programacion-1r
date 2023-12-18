using System;

namespace Exercicis
{
    public class Ex14
    {
        public static void Main()
        {
            Console.WriteLine("Introdueix un numero: ");
            int num = Convert.ToInt32(Console.ReadLine());
            Digits(num);
        }

        public static void Digits(int num)
        {
            int digits = 0;
            int originalNum = num;

            while (num > 0)
            {
                num /= 10;
                digits++;
            }

            Console.WriteLine($"El nombre té {digits} dígits.");

            int sumaParells = 0;
            int sumaSenars = 0;


            for (int i = 0; i < digits; i++)
            {
                int digit = originalNum % 10;
                originalNum /= 10;

                if (digit % 2 == 0)
                {
                    sumaParells += digit;
                }
                else
                {
                    sumaSenars += digit;
                }
            }

            Console.WriteLine($"La suma dels dígits parells és: {sumaParells}");
            Console.WriteLine($"La suma dels dígits senars és: {sumaSenars}");
        }
    }
}
