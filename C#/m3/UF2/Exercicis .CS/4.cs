using System;
namespace Project
{
    public class Ex4
    {
        public static void Main()
        {
            int decition;
            string text;
            bool Choose = false;
            Console.WriteLine("Escriu el text");
            text = Console.ReadLine();
            Console.WriteLine("Escriu '0' per Mayuscula i '1' per Minuscula");
            do
            {
                decition = Convert.ToInt32(Console.ReadLine());

            } while (decition != 0 && decition != 1);

            if (decition == 0) Choose = false;
            else if (decition == 1) Choose = true;
            
            if (!Choose) Console.WriteLine(Maysc(text));
            else Console.WriteLine(Minsc(text));
            
        }
        public static string Maysc(string ToMaysc)
        {
            ToMaysc = ToMaysc.ToUpper();
            return ToMaysc;
        }
        public static string Minsc(string ToMinsc)
        {
            ToMinsc = ToMinsc.ToLower();
            return ToMinsc;
        }
    }
}
