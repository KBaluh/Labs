using System;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            DecimalReader decReader = new DecimalReader();
            //введення вартостi пiдключення живлення на одну робочу станцiю
            //Console.Write("Введiть вартiсть пiдключення живлення на одну робочу станцiю: ");
            //string strCostOfPowerPerWStation = Console.ReadLine();
            //decimal costOfPowerPerWStation = Convert.ToDecimal(strCostOfPowerPerWStation);
            decimal costOfPowerPerWStation = decReader.Read("Введiть вартiсть пiдключення живлення на одну робочу станцiю: ");

            //введення вартостi пiдключення iнтернету на одну робочу станцiю
            //Console.Write("Введiть вартiсть пiдключення iнтернету на одну робочу станцiю: ");
            //string strCostOfInternetPerWStation = Console.ReadLine();
            //decimal costOfInternetPerWStation = Convert.ToDecimal(strCostOfInternetPerWStation);
            decimal costOfInternetPerWStation = decReader.Read("Введiть вартiсть пiдключення iнтернету на одну робочу станцiю: ");

            //введення числа робочих станцiй
            //Console.Write("Введiть число робочих станцiй: ");
            //string strNumberOfWStation = Console.ReadLine();
            //decimal numberOfWStation = Convert.ToDecimal(strNumberOfWStation);
            decimal numberOfWStation = decReader.Read("Введiть число робочих станцiй: ");

            //калькуляцiя заходу
            decimal costOfAccess = (costOfInternetPerWStation + costOfPowerPerWStation) * numberOfWStation;

            //виведення результату
            Console.WriteLine("Загальна вартiсть заходу: {0}", costOfAccess);

            //затримка
            Console.ReadKey();
        }
    }
}
