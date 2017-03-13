using System;
using Lab2.Dut.Readers;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            DecimalReader decReader = new DecimalReader();
            IntReader intReader = new IntReader();

            decimal costOfPowerPerWStation = decReader.Read("Введiть вартiсть пiдключення живлення на одну робочу станцiю: ");
            decimal costOfInternetPerWStation = decReader.Read("Введiть вартiсть пiдключення iнтернету на одну робочу станцiю: ");
            int numberOfWStation = intReader.ReadRange("Введiть число робочих станцiй від {0} До {1}: ", 1, 100);

            //калькуляцiя заходу
            decimal costOfAccess = (costOfInternetPerWStation + costOfPowerPerWStation) * numberOfWStation;

            //виведення результату
            Console.WriteLine("Загальна вартiсть заходу: {0}", costOfAccess);

            //затримка
            Console.ReadKey();
        }
    }
}
