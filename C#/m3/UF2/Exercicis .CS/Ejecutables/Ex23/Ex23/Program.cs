using System;
namespace Activitats;
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce la base y luego la altura del cuadrado(i rectangulo): ");
            double Numbase = Convert.ToInt16(Console.ReadLine());
            double altura = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("El area del cuadrado y del rectangulo es: " + Area(Numbase, altura, false));
            Console.WriteLine("Introduce el radio del circulo: ");
            double radi = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("El area del circulo es: " + Area(radi));
            Console.WriteLine("Introduce la apotema y luego la longitud del pentagono: ");
            Numbase = Convert.ToInt16(Console.ReadLine());
            altura = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("El area del pentagono es: " + Area(Numbase, altura, true));
        }
        static double Area (double Base, double Altura, bool isPentagon)
        {      
            if (isPentagon)
            {
                return (Base * Altura) / 2;
            }
            else
            {
                return Base * Altura;
            }
        }
        static double Area (double Radi)
        {
            return 3.14 * (Radi * 2);
        }
    }

