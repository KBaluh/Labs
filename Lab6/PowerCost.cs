﻿using System;

namespace InternetAccessCalculation
{
    public class PowerCost : InterfaceInstance
    {
        bool onceMore = true;
        bool isDone = false;

        decimal maxCost = 100M;
        decimal minCost = 1M;

        private decimal costOfPowerPerWStation;//поле

        public decimal СostOfPowerPerWStation //властивість
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
                    costOfPowerPerWStation = value;
                }
            }
            get
            {
                return costOfPowerPerWStation;
            }
        }

        public void Init()
        {
        }

        public void Idle()
        {
            Console.Write("Введiть вартiсть пiдключення живлення на одну робочу станцiю вiд {0} до {1}: ", minCost, maxCost);
            string strCostOfPowerPerWStation = Console.ReadLine();
            decimal result;
            if (decimal.TryParse(strCostOfPowerPerWStation, out result))
            {
                СostOfPowerPerWStation = result;
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
