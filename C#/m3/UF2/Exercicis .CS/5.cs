using System;
namespace Project
{
    public class Ex5
    {
        public static void Main()
        {
            int num = Convert.ToInt32(Console.ReadLine());
            Comprobation(num);
        }
        public static void Comprobation(int num)
        {
            if (num < 0) Console.WriteLine("Nombre negatiu");
            else Console.WriteLine("Nombre positiu");
            if (num < 100) Console.WriteLine("Més petit que 100");
            else Console.WriteLine("Major que 100");
        }
    }
}
