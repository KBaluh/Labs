using System;

using InternetAccessCalculation;//подключение пространства имен InternetAccessCalculation для доступа к его именам 
using StringCheck;//подключение пространства имен StringCheck для доступа к его именам 

namespace NumberWStationDoWhile
{
    class WStationNumberDoWhile : AbstrInstance
    {
        int maxWStation = 100;
        int minWStation = 10;
        
        public int numberOfWStation = 0;
        public int NumberOfWStation { set; get; } //властивість

        private StrCheckInt strCheckInt;
        protected override void Init()
        {
            strCheckInt = new StrCheckInt();
        }

        protected override void Idle()
        {
            Console.Write("Введiть кiлькiсть рабочих станцiй вiд {0} до {1}: ", minWStation, maxWStation);
            string strNumberOfWStation = Console.ReadLine();
            strNumberOfWStation = strCheckInt.CheckStrInt(strNumberOfWStation, maxWStation);
            NumberOfWStation = Convert.ToInt32(strNumberOfWStation);
            if (NumberOfWStation >= minWStation && NumberOfWStation <= maxWStation)
                SetDone();
        }
        
        protected override void CleanUp()
        {
            Console.WriteLine("Выход");
        }    
    }
}
