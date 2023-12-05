using System;
namespace Project
{
    public class Ex10
    {
        public static void Main()
        {
            int min = 0, max = 201, num;
            int[] mem = new int[10];
            Random rand = new Random();

            for (int i = 0; i < mem.Length; i++) 
            {
                mem[i] = rand.Next(201);
            }
            num = Convert.ToInt32(Console.ReadLine());
            Contains (num, mem);
            for (int i = 0;i < mem.Length; i++) 
            {
                Console.WriteLine(mem[i]);
            }
        }
        public static void Contains(int num, int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == num) Console.WriteLine("Trobat");
            }
        }
      

    }
}
