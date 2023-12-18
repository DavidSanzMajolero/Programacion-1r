using System;
namespace Exercicis
{
    public class Ex16   
    {
        public static void Main()
        {
            Console.WriteLine("Cuantos numeros quieres introducir?");
            int n, count = 5;
            do
            {
                n = Convert.ToInt32(Console.ReadLine());
                count--;
            } while ((n < 10 || n>100) && count > 0);
            if (count > 0) 
            {
                int[] array = new int[n];
                for (int i = 0; i < array.Length; i++)
                {
                    Console.Write("Introduce un numero: ");
                    array[i] = Convert.ToInt32(Console.ReadLine());
                }
                Console.WriteLine("El resultado es: " + ArraySum(array));
            }
            else Console.WriteLine("Has superado el numero de intentos");
        }
        public static int ArraySum(int[] array)
        {
            int result = 0;
            for (int i = 0; i < array.Length; i++)
            {
                result += array[i];
            }
            return result;
        }
    }
}