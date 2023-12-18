using System;
namespace Exercicis
{
    public class Ex13
    {
        public static void Main()
        {
            Console.WriteLine("Introdueix 20 numeros: ");
            NumbersArray();
        }
        public static void NumbersArray() 
        {
            const int n = 20;
            int[] arr = new int[n];

            for (int i = 0; i < arr.Length; i++) arr[i] = Convert.ToInt16(Console.ReadLine());
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 != 0) 
                {
                    Console.Write("\t" + arr[i]);
                }
            }
        }

        
    }
}