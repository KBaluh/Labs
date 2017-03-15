using System;

namespace InternetAccessCalculation
{
    class OrderModule : AbstrInstance
    {
        public Order order;

        public OrderModule()
        {
            order = new Order();
        }

        public override void Idle()
        {
            Console.WriteLine("Створення замовлення...");
            Console.Write("Введiть назву заходу: ");
            string name = Console.ReadLine();
            if (string.IsNullOrEmpty(name))
            {
                return;
            }

            //введення числа робочих станцiй
            WStationNumber wStation = new WStationNumber();
            wStation.Run();

            order.Name = name;
            order.StationNumber = wStation.NumberOfWStation;

            SetDone();
        }
    }
}
