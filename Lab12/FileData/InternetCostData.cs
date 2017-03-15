using FileData;
using System;
using System.IO;

namespace InternetAccessCalculation
{
    class InternetCostData : DataManager
    {
        private InternetCost internetCost;

        public InternetCostData(InternetCost internetCost)
            : base("InternetCostData.txt")
        {
            this.internetCost = internetCost;
        }

        protected override void OnWrite(BinaryWriter bw)
        {
            string str = "СostOfInternetPerWStation";
            decimal num = internetCost.СostOfInternetPerWStation;
            bw.Write(str);
            bw.Write(num);
        }

        protected override void OnRead(BinaryReader br)
        {
            string readString = br.ReadString();
            decimal readDecimal = br.ReadDecimal();
            Console.WriteLine(readString + " = " + readDecimal);
            if (readString == "СostOfInternetPerWStation")
            {
                internetCost.СostOfInternetPerWStation = readDecimal;
            }
        }
    }
}
