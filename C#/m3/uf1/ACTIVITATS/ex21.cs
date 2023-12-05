using System.Drawing;

class Project
{
    static void Main()
    {
        int size=20, valor=0;
        bool comprobar = false;
        int[] nums = new int[size];
        const string escriu ="Escriu un numero entre 0 i 10", cercar = "Quin valor vols cercar?", cercat = "El valor es troba entre els numeros introduits", noCercat = "El valor NO es troba entre els numeros introduits", torna = "Els valors han de estar entre 0 i 10.";

        for (int i = 0; i < size; i++) 
        {
            Console.WriteLine(escriu);
            nums[i] = Convert.ToInt32(Console.ReadLine());
            while (nums[i] > 10 || nums[i] < 0)
            {
                Console.WriteLine(torna);
                nums[i] = Convert.ToInt32(Console.ReadLine());
            }
        }
        Console.WriteLine(cercar);
            valor = Convert.ToInt32(Console.ReadLine());
        for (int i = size-1; i > 0 && !comprobar; i--) 
        {
            if (nums[i] == valor)
            {
                comprobar = true;
                Console.WriteLine(cercat);
            }
        }
        if (!comprobar) Console.WriteLine(noCercat);
    }
}