namespace InternetAccessCalculation
{
    class AccessCost
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
        
        public void Calc()
        {
            //калькуляцiя заходу
            CostOfAccess = (costOfPowerPerWStation + costOfInternetPerWStation) * numberOfWStation;
        }        
    }
}
