using System;
using System.Reflection;
namespace Activitats;
public class E30
{
    static void main()
    {
        const string PreguntaNom = "Digam el nom dels integrants del grup: ", PreguntaNum = "Quants integrants componen el grup?";
        int integrants=0;
        string[] StIntegrants = new string[integrants];
        do
        {
            Console.WriteLine(PreguntaNum);
            integrants = Convert.ToInt32(Console.ReadLine());

        } while (integrants < 2 || integrants > 15);
        Console.WriteLine(PreguntaNom);
        for (int i = 0; i<integrants; i++)
        {
            StIntegrants[i] = Console.ReadLine();
        }

    }
}
