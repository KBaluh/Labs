﻿using System;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            AccessCalculation calculation = new AccessCalculation();
            calculation.Run();

            //затримка
            Console.ReadKey();
        }
    }
}
