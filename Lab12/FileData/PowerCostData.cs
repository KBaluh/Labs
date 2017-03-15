using FileData;
using System;
using System.IO;

namespace InternetAccessCalculation
{
    class PowerCostData : DataManager
    {
        private PowerCost powerCost;

        public PowerCostData(PowerCost powerCost)
            : base("PowerCostData.txt")
        {
            this.powerCost = powerCost;
        }

        protected override void OnWrite(BinaryWriter bw)
        {
            string str = "СostOfPowerPerWStation";
            decimal num = powerCost.СostOfPowerPerWStation;
            bw.Write(str);
            bw.Write(num);
        }

        protected override void OnRead(BinaryReader br)
        {
            string readString = br.ReadString();
            decimal readDecimal = br.ReadDecimal();
            Console.WriteLine(readString + " = " + readDecimal);
            if (readString == "СostOfPowerPerWStation")
            {
                powerCost.СostOfPowerPerWStation = readDecimal;
            }
        }
    }
}
