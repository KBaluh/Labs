using NumberWStationDoWhile; //подключение пространства имен NumberWStationDoWhile для доступа к его именам 

namespace InternetAccessCalculation
{
    class ModulControl
    {
        public ModulControl()
        {
            //введення вартостi пiдключення живлення на одну робочу станцiю
            PowerCost powerCost = new PowerCost();
            powerCost.Run();

            //введення вартостi пiдключення iнтернету на одну робочу станцiю
            InternetCost internetCost = new InternetCost();
            internetCost.Run();

            //введення числа робочих станцiй
            WStationNumberDoWhile wStationNumberDoWhile = new WStationNumberDoWhile();
            wStationNumberDoWhile.Run();

            //калькуляцiя заходу
            AccessCost accessCost = new AccessCost(powerCost.СostOfPowerPerWStation, internetCost.СostOfInternetPerWStation, wStationNumberDoWhile.NumberOfWStation);
            accessCost.Run();

            //виведення результату (передача об'єкту)
            ShowAccessCost showAccessCost = new ShowAccessCost(accessCost);
            showAccessCost.Run();
        }
    }
}
