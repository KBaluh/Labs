using System;

namespace InternetAccessCalculation
{
    class InternetCost : InterfaceInstance
    {
        private decimal maxCost = 1000;
        private decimal minCost = 1;

        private bool onceMore;
        private bool isDone;

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

        public void Init()
        {
        }

        public void Idle()
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

        public void CleanUp()
        {
        }

        public bool Done()
        {
            return isDone;
        }

        private void SetDone()
        {
            isDone = true;
        }
    }
}
