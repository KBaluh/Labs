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
            int numberOfWStation = intReader.Read("Введiть число робочих станцiй: ");

            //калькуляцiя заходу
            decimal costOfAccess = (costOfInternetPerWStation + costOfPowerPerWStation) * numberOfWStation;

            //виведення результату
            Console.WriteLine("Загальна вартiсть заходу: {0}", costOfAccess);

            //затримка
            Console.ReadKey();
        }
    }
}
