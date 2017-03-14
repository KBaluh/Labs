using System;
using DataReaders;

namespace Lab2
{
    public class AccessCalculation
    {
        public void Run()
        {
            DecimalReader decReader = new DecimalReader();
            IntReader intReader = new IntReader();

            decimal costOfPowerPerWStation = decReader.ReadRange("Введiть вартiсть пiдключення живлення на одну робочу станцiю вiд {0} до {1}: ", 10, 10000);
            decimal costOfInternetPerWStation = decReader.ReadRange("Введiть вартiсть пiдключення iнтернету на одну робочу станцiю вiд {0} до {1}: ", 10, 10000);
            decimal numberOfWStation = intReader.ReadRange("Введiть число робочих станцiй вiд {0} до {1}: ", 1, 100);

            //калькуляцiя заходу
            decimal costOfAccess = (costOfInternetPerWStation + costOfPowerPerWStation) * numberOfWStation;

            //виведення результату
            Console.WriteLine("Загальна вартiсть заходу: {0}", costOfAccess);
        }
    }
}