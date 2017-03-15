namespace InternetAccessCalculation
{
    class Client
    {
        public string Name { get; set; }

        public ClientType ClientType { get; set; }

        public override string ToString()
        {
            return string.Format("Клiєнт: {0}, Тип: {1}", Name, ClientType);
        }
    }
}
