using System;

namespace InternetAccessCalculation
{
    class WStationNumber : AbstrInstance
    {
        int maxWStation = 100;
        int minWStation = 10;

        private bool onceMore;

        private int numberOfWStation = 0;

        public int NumberOfWStation
        {
            set
            {
                if (value < minWStation || value > maxWStation)
                {
                    onceMore = true;
                }
                else
                {
                    onceMore = false;
                    numberOfWStation = value;
                }
            }
            get
            {
                return numberOfWStation;
            }
        }

        protected override void Idle()
        {
            Console.Write("Введiть кiлькiсть рабочих станцiй вiд {0} до {1}: ", minWStation, maxWStation);
            string strNumberOfWStation = Console.ReadLine();
            int result;
            if (int.TryParse(strNumberOfWStation, out result))
            {
                NumberOfWStation = result;
                if (!onceMore)
                    SetDone();
            }
        }
    }
}
