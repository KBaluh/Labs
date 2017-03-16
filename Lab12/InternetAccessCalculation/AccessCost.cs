namespace InternetAccessCalculation
{
    class AccessCost : AbstrInstance
    {
        public decimal CostOfAccess { get; set; }

        private PowerCost power;
        private InternetCost internet;
        private Order order;
        private ClientData clientData;

        public AccessCost(PowerCost power, InternetCost internet, Order order)
        {
            this.power = power;
            this.internet = internet;
            this.order = order;
            clientData = ClientData.Instance;
        }

        public override void Idle()
        {
            decimal amount = 0;

            var clients = clientData.GetAll();
            foreach (Client client in clients)
            {
                var discount = GetClientDiscount(client.ClientType);

                //калькуляцiя заходу
                var value = (power.СostOfPowerPerWStation + internet.СostOfInternetPerWStation) * order.StationNumber * discount;
                amount = value;
            }

            CostOfAccess = amount;

            SetDone();
        }

        private decimal GetClientDiscount(ClientType type)
        {
            decimal discount = 0;
            switch (type)
            {
                case ClientType.New:
                    discount = 0.95M;
                    break;
                case ClientType.Regular:
                    discount = 0.90M;
                    break;
                case ClientType.VIP:
                    discount = 0.85M;
                    break;
            }
            return discount;
        }
    }
}
