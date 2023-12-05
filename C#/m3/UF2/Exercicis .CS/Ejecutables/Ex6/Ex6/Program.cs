using System;
namespace Project
{
    public class Ex6
    {
        public static void Main()
        {
            int num = Convert.ToInt32(Console.ReadLine());
            Comprobation(num);
        }
        public static void Comprobation(int num)
        {
            num = Math.Abs(num);
            Console.WriteLine(num);
        }
    }
}
