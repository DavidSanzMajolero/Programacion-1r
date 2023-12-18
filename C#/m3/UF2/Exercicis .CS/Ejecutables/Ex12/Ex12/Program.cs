using System;
namespace Exercicis
{
    public class Ex12
    {
        public static void Main()
        {
            Console.Write("Introdueix el numero de litres consumits: ");
            double litres = Convert.ToInt32(Console.ReadLine());
            double resultat = Precio(litres);
            Console.WriteLine($"El preu és {resultat} euros");
        }
        public static double Precio(double litres)
        {
            double mem = 6;
            double preu = 0;

            if (litres < 50)  return mem;

            else if (litres > 50 && litres < 200 )
            {
                litres -= 50;
                preu = litres * 0.1;
                return preu + mem;
            }

            else
            {
                litres -= 200;
                mem += 15;
                preu = litres * 0.3;                
                return preu+mem;
            }
        }
    }
}

