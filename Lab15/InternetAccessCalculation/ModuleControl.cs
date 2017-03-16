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

            PowerCostData powerData = new PowerCostData(powerCost);
            powerData.Write();

            //введення вартостi пiдключення iнтернету на одну робочу станцiю
            InternetCost internetCost = new InternetCost();
            internetCost.Run();

            InternetCostData internetData = new InternetCostData(internetCost);
            internetData.Write();

            ClientReader clientReader = new ClientReader();
            clientReader.Run();

            OrderModule orderModule = new OrderModule();
            orderModule.Run();

            AccessCost accessCost = new AccessCost(powerCost, internetCost, orderModule.order);
            accessCost.Run();            

            Console.WriteLine("Загальна вартiсть заходу: {0}", accessCost.CostOfAccess);
        }
    }
}
