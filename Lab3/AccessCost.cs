namespace InternetAccessCalculation
{
    class AccessCost : AbstrInstance
    {
        public decimal CostOfAccess { get; set; }

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
            CostOfAccess = (costOfPowerPerWStation + costOfInternetPerWStation) * numberOfWStation;
            SetDone();
        }
        
        protected override void CleanUp()
        {
        }            
    }
}
