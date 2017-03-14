using System;

namespace InternetAccessCalculation
{
    class InternetCost
    {
        private decimal maxCost = 1000;
        private decimal minCost = 1;

        private bool onceMore;

        private decimal costOfInternetPerWStation;

        public decimal СostOfInternetPerWStation
        {
            set
            {
                if (value < minCost || value > maxCost)
                {
                    onceMore = true;
                }
                else
                {
                    onceMore = false;
                    costOfInternetPerWStation = value;
                }
            }
            get
            {
                return costOfInternetPerWStation;
            }
        }

        public void Run()
        {
            while (!Done())
            {
                Idle();
            }
        }

        private bool isDone;

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
            Console.Write("Введiть вартiсть пiдключення iнтернету на одну робочу станцiю вiд {0} до {1}: ", minCost, maxCost);
            string strCostOfInternetPerWStation = Console.ReadLine();
            decimal result;
            if (decimal.TryParse(strCostOfInternetPerWStation, out result))
            {
                СostOfInternetPerWStation = result;
                if (!onceMore)
                    SetDone();
            }
        }  
    }
}
