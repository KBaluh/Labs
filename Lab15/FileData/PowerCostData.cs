using FileData;
using System;
using System.IO;
using System.Threading.Tasks;

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

        protected override async Task OnWrite(BinaryWriter bw)
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
