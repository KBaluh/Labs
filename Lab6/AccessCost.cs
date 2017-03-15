namespace InternetAccessCalculation
{
    class AccessCost : AbstrInstance
    {
        public decimal CostOfAccess { get; set; }

        private decimal costOfPowerPerWStation;
        private decimal costOfInternetPerWStation;
        private int numberOfWStation;
        private ClientType clientType;

        public AccessCost(decimal costOfPowerPerWStation, decimal costOfInternetPerWStation, int numberOfWStation, ClientType clientType)
        {
            this.costOfPowerPerWStation = costOfPowerPerWStation;
            this.costOfInternetPerWStation = costOfInternetPerWStation;
            this.numberOfWStation = numberOfWStation;
            this.clientType = clientType;
        }

        public override void Idle()
        {
            decimal discount = 0;
            switch (clientType)
            {
                case ClientType.New:
                    discount = 0.5M;
                    break;
                case ClientType.Regular:
                    discount = 0.10M;
                    break;
                case ClientType.VIP:
                    discount = 0.15M;
                    break;
            }

            //калькуляцiя заходу
            var value = (costOfPowerPerWStation + costOfInternetPerWStation) * numberOfWStation;
            CostOfAccess = value - value * discount;
            SetDone();
        }
    }
}
