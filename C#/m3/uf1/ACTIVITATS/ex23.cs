using System.Drawing;

class Project
{
    static void Main()
    {
        int size = 20, comprobar;
        int[] nums = new int[size];
        const string escriu ="Escriu un numero entre 0 i 10", torna = "Els valors han de estar entre 0 i 10.";

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

            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] > nums[j])
                    {
                        int aux = nums[i];
                        nums[i] = nums[j];
                        nums[j] = aux;
                    }
                }
            }
            Console.WriteLine("Escriu '0' per ascendents, '1' per descendent");
            comprobar = Convert.ToInt32(Console.ReadLine());
            while (comprobar != 0 && comprobar !=1) 
            {
                Console.WriteLine("El numero a de ser 0 o 1");
                comprobar = Convert.ToInt32(Console.ReadLine());

            }
            if (comprobar == 0)
            {
                for (int i = 0; i <= 19; i++)
                {
                    Console.Write(nums[i] + " ");
                }
            }
            else
            {
                for ( int i = 19; i >= 0; i--)
                {
                Console.Write(nums[i] + " ");
                }
            }
    }
}
