using System;
namespace Activitats;
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce la base y luego la altura del cuadrado: ");
            int Numbase = Convert.ToInt16(Console.ReadLine());
            int altura = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("El area es: " + Area(Numbase, altura, false));
            Console.WriteLine("Introduce el radio del circulo: ");
            double radi = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("El area es: " + Area(radi));
        }
        static double Area (int Base, int Altura, bool isPentagon)
        {      
            if(isPentagon)
            {
                return (Base * Altura) / 2;
            }
            return Base * Altura;
        }
        static double Area (double Radi)
        {
            return 3.14 * (Radi * 2);
        }
    }
