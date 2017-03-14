using System;

namespace InternetAccessCalculation
{
    class ModuleControl
    {
        public ModuleControl()
        {
            //введення вартостi пiдключення живлення на одну робочу станцiю
            PowerCost powerCost = new PowerCost();
            InstanceRunner powerCostInst = new InstanceRunner(powerCost);
            powerCostInst.Run();

            //введення вартостi пiдключення iнтернету на одну робочу станцiю
            InternetCost internetCost = new InternetCost();
            InstanceRunner internetCostInst = new InstanceRunner(internetCost);
            internetCostInst.Run();

            //введення числа робочих станцiй
            WStationNumber wStation = new WStationNumber();
            InstanceRunner wStationInst = new InstanceRunner(wStation);
            wStationInst.Run();

            //калькуляцiя заходу
            AccessCost accessCost = new AccessCost(powerCost.СostOfPowerPerWStation, internetCost.СostOfInternetPerWStation, wStation.NumberOfWStation);
            InstanceRunner accessCostInst = new InstanceRunner(accessCost);
            accessCostInst.Run();

            Console.WriteLine("Загальна вартiсть заходу: {0}", accessCost.CostOfAccess);
        }
    }
}
