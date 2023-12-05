using System;
namespace Activitats;
public class E31
{
    static void Main()
    {
        int mes = 1, count = 0;
        double aux = 0, mitjana = 0, cercar;
        bool BoolCercar = false;
        double[] arrayPluges = new double[] { 15.5, 10, 3.2, 1.25, 1.75, 12, 5.15, 6.75, 15, 9.25, 10.75, 20.75 };
        const string StMes = "Mes ", StMitjana = "La mitjana és: ";
        for (int i = 0; i < arrayPluges.Length - 1; i++)
        {
            for (int j = i + 1; j < arrayPluges.Length; j++)
            {
                if (arrayPluges[i] < arrayPluges[j])
                {
                    aux = arrayPluges[i];
                    arrayPluges[i] = arrayPluges[j];
                    arrayPluges[j] = aux;
                }
            }
        }
        for (int i = 0; i < arrayPluges.Length; i++)
        {
            Console.WriteLine(StMes + mes + ": " + arrayPluges[i]);
            mitjana += arrayPluges[i];
            mes++;
            if (arrayPluges[i]>5 && arrayPluges[i]<18) count++;
        }
        mitjana = mitjana / 12;
        Console.WriteLine(StMitjana + mitjana);
        Console.WriteLine($"Hi ha {count} mesos amb mitjanes de pluges entre 5 i 18 litres");
        Console.WriteLine("Quin valor vols cercar?");
        cercar = Convert.ToDouble(Console.ReadLine());
        for (int i = 0; i<arrayPluges.Length && !BoolCercar; i++)
        {
            if (arrayPluges[i]  == cercar) 
            {
                Console.WriteLine($"El valor {cercar} s'ha trobat");
                BoolCercar = true;
            }
        }
        if (BoolCercar == false) Console.WriteLine($"El valor {cercar} no s'ha trobat");
    }
}

