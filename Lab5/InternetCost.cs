using System;

namespace InternetAccessCalculation
{
    class InternetCost : AbstrInstance
    {
        public decimal СostOfInternetPerWStation {set; get;}//властивість

        private decimal maxCost = 1000;
        private decimal minCost = 1;
        private StrCheckDecimal strCheckDecimal;

        protected override void Init()
        {
            strCheckDecimal = new StrCheckDecimal();
        }

        protected override void Idle()
        {
            Console.Write("Введiть вартiсть пiдключення iнтернету на одну робочу станцiю вiд {0} до {1}: ", minCost, maxCost);
            string strCostOfInternetPerWStation = Console.ReadLine();
            strCostOfInternetPerWStation = strCheckDecimal.CheckStrDecimal(strCostOfInternetPerWStation, maxCost);
            СostOfInternetPerWStation = Convert.ToDecimal(strCostOfInternetPerWStation);
            if (СostOfInternetPerWStation >= minCost && СostOfInternetPerWStation <= maxCost)
                SetDone();
        }
        
        protected override void CleanUp()
        {
            Console.WriteLine("Выход");
        }    
    }
}
