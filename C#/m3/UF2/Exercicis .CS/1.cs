﻿using System;

namespace Project 
{
    public class Ex1 
    {       
        public static void Main()
        {
            const string Msg = "Introdueix un valor natural";
            int num;
            Console.WriteLine(Msg);
            num = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(Ex1.IsPositive(num));
        }
        public static bool IsPositive(int num)
        {
            return num > 0;
        }
    }
}