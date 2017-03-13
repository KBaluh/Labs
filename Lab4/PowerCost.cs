using System;

namespace InternetAccessCalculation
{
    public class PowerCost : AbstrInstance
    {
        bool onceMore = true;

        decimal maxCost = 100M;
        decimal minCost = 1M;

        private decimal costOfPowerPerWStation;//поле

        public decimal СostOfPowerPerWStation //властивість
        {
            set
            {
                if (value < minCost || value > maxCost)
                    onceMore = true;
                else
                {
                    onceMore = false;
                    costOfPowerPerWStation = value;
                }
            }
            get
            {
                return costOfPowerPerWStation;
            }
        }
        
        StrCheckDecimal strCheckDecimal;

        protected override void Init()
        {
            strCheckDecimal = new StrCheckDecimal();
        }
        
        protected override void Idle()
        {
            Console.Write("Введiть вартiсть пiдключення живлення на одну робочу станцiю вiд {0} до {1}: ", minCost, maxCost);
            string strCostOfPowerPerWStation = Console.ReadLine();
            strCostOfPowerPerWStation = strCheckDecimal.CheckStrDecimal(strCostOfPowerPerWStation, maxCost);
            СostOfPowerPerWStation = Convert.ToDecimal(strCostOfPowerPerWStation);
            if (!onceMore)
                SetDone();
        }

        protected override void CleanUp()
        {
            Console.WriteLine("Выход");
        }    
    }
}
