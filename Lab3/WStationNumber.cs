using System;

namespace InternetAccessCalculation
{
    class WStationNumber
    {
        int maxWStation = 100;
        int minWStation = 10;

        private bool onceMore;
        private bool isDone;

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

        public void Run()
        {
            while (!Done())
            {
                Idle();
            }
        }

        protected bool Done()
        {
            return isDone;
        }

        protected void SetDone()
        {
            isDone = true;
        }

        protected void Idle()
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
