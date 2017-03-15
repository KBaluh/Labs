using System;

namespace InternetAccessCalculation
{
    class ModuleControl
    {
        public ModuleControl()
        {
            //введення вартостi пiдключення живлення на одну робочу станцiю
            PowerCost powerCost = new PowerCost();
            powerCost.Run();

            //введення вартостi пiдключення iнтернету на одну робочу станцiю
            InternetCost internetCost = new InternetCost();
            internetCost.Run();

            //введення числа робочих станцiй
            WStationNumber wStation = new WStationNumber();
            wStation.Run();

            ClientTypeReader clientType = new ClientTypeReader();
            clientType.Run();

            //калькуляцiя заходу
            AccessCost accessCost = new AccessCost(powerCost.СostOfPowerPerWStation, internetCost.СostOfInternetPerWStation, wStation.NumberOfWStation, clientType.ClientType);
            accessCost.Run();

            Console.WriteLine("Загальна вартiсть заходу: {0}", accessCost.CostOfAccess);
        }
    }
}
