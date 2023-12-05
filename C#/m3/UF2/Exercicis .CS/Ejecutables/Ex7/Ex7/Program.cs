using System;
namespace Project
{
    public class Ex7
    {
        public static void Main()
        {
            double num = Convert.ToInt32(Console.ReadLine());
            double baseNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Power(num,baseNum));
        }
        public static double Power(double numBase, double numExp)
        {
            numBase = Math.Pow(numBase,numExp);
            return numBase;
        }
    }
}
