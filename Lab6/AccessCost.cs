namespace InternetAccessCalculation
{
    class AccessCost : InterfaceInstance
    {
        private bool isDone;

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

        public void Idle()
        {
            //калькуляцiя заходу
            CostOfAccess = (costOfPowerPerWStation + costOfInternetPerWStation) * numberOfWStation;
            SetDone();
        }

        public void Init()
        {
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
