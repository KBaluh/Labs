using System;
using FileData;
using System.IO;

namespace InternetAccessCalculation
{
    class WStationData : DataManager
    {
        private WStationNumber station;

        public WStationData(WStationNumber station)
            : base("WStationData.txt")
        {
            this.station = station;
        }

        protected override void OnWrite(BinaryWriter bw)
        {
            string str = "NumberOfWStation";
            int num = station.NumberOfWStation;
            bw.Write(str);
            bw.Write(num);
        }

        protected override void OnRead(BinaryReader br)
        {
            string readString = br.ReadString();
            int readInt = br.ReadInt32();
            Console.WriteLine(readString + " = " + readInt);
            if (readString == "NumberOfWStation")
            {
                station.NumberOfWStation = readInt;
            }
        }
    }
}
