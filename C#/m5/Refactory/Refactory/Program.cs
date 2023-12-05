using System;
namespace Refactoring
{
    public class FirstRefactoringExercise
    {
        public static void Main(string[] args)
        {
            int quantity;
            const string Msg = "Indica quants valors vols introduir:";
            Console.WriteLine(Msg);
            quantity = Convert.ToInt32(Console.ReadLine());
            int[] numbers = new int[quantity];
            Console.WriteLine(Calc(numbers));
           
        }
        public static string Calc(int[] numbers)
        {
            int input, errors = 0, answer = 1;
            const string MsgRang = "Introdueix un valor entre el 5 i el 150 (inclosos). Tens 3 intents com a màxim", MsgError = "El valor introduït no és vàlid.", MsgMax = "Has superat el total d'intents.";
            for (int i = 0; i < numbers.Length; i++)
            {
                if (errors < 3)
                {
                    Console.WriteLine(MsgRang);
                    input = Convert.ToInt32(Console.ReadLine());
                    if (input < 5 || input > 150)
                    {
                        Console.WriteLine(MsgError);
                        errors++;
                        i--;
                    }
                    else numbers[i] = input;
                } 
            }
            if (errors == 3) return MsgMax; 
            else
            {
                for (int i = 0; i < numbers.Length; i++) answer *= numbers[i];
                string MsgFin = $"El numero és {answer}";
                return MsgFin;
            }
        }
    }
}