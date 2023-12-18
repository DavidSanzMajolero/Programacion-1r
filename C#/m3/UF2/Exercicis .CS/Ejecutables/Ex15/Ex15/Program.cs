using System;
namespace Exercicis
{
    public class Ex15
    {
        public static void Main()
        {
            Console.Write("Introdueix un any: ");
            int any = Convert.ToInt32(Console.ReadLine());
            Any(any);

        }
        public static void Any(int any)
        {
            if ((any % 4 == 0 && any % 100 != 0) || (any % 400 == 0))
            {
                Console.WriteLine($"{any} és un any de traspàs.");
            }
            else
            {
                Console.WriteLine($"{any} no és un any de traspàs.");
            }
        }
    }
}