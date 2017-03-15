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

            decimal amount = 0;

            ClientData data = new ClientData();
            var clients = data.GetAll();
            foreach (var client in clients)
            {
                //калькуляцiя заходу
                AccessCost accessCost = new AccessCost(powerCost.СostOfPowerPerWStation, internetCost.СostOfInternetPerWStation, wStation.NumberOfWStation, client.ClientType);
                accessCost.Run();
                amount += accessCost.CostOfAccess;
            }

            Console.WriteLine("Загальна вартiсть заходу: {0}", amount);
        }
    }
}
