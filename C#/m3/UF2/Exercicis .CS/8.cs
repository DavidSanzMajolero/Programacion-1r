using System;
namespace Project
{
    public class Ex8
    {
        public static void Main()
        {
            int min = 0, max = 256;
            Random rand = new Random();
            for (int i = 0; i < 10; i++) Console.WriteLine(rand.Next(min, max));
        }

    }
}
