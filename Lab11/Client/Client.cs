using System;

namespace InternetAccessCalculation
{
    class Client
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime Birthday { get; set; }

        public int PhoneNumber { get; set; }

        public ClientType ClientType { get; set; }

        public override string ToString()
        {
            return string.Format("Клiєнт: {0} {1}, День народження: {2}, Тип: {3}", LastName, FirstName, Birthday.ToShortDateString(), ClientType);
        }
    }
}
