using System;

namespace Lab1
{
    public class AccessCalculation
    {
        public void Run()
        {
            DecimalReader decReader = new DecimalReader();
            decimal costOfPowerPerWStation = decReader.Read("Введiть вартiсть пiдключення живлення на одну робочу станцiю: ");
            decimal costOfInternetPerWStation = decReader.Read("Введiть вартiсть пiдключення iнтернету на одну робочу станцiю: ");
            decimal numberOfWStation = decReader.Read("Введiть число робочих станцiй: ");

            //калькуляцiя заходу
            decimal costOfAccess = (costOfInternetPerWStation + costOfPowerPerWStation) * numberOfWStation;

            //виведення результату
            Console.WriteLine("Загальна вартiсть заходу: {0}", costOfAccess);
        }
    }
}