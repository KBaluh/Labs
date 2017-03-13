namespace InternetAccessCalculation
{
    class AccessCost : AbstrInstance
    {
        public decimal costOfAccess;

        private decimal costOfPowerPerWStation;
        private decimal costOfInternetPerWStation;
        private int numberOfWStation;

        public AccessCost(decimal costOfPowerPerWStation, decimal costOfInternetPerWStation, int numberOfWStation)
        {
            this.costOfPowerPerWStation = costOfPowerPerWStation;
            this.costOfInternetPerWStation = costOfInternetPerWStation;
            this.numberOfWStation = numberOfWStation;
        }

        protected override void Init()
        {
        }
        
        protected override void Idle()
        {
            //калькуляцiя заходу
            costOfAccess = (costOfPowerPerWStation + costOfInternetPerWStation) * numberOfWStation;
            SetDone();
        }
        
        protected override void CleanUp()
        {
        }            
    }
}
