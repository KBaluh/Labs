using System;

namespace InternetAccessCalculation
{
    class ClientTypeReader : AbstrInstance
    {
        public ClientType ClientType { get; set; }

        public override void Idle()
        {
            Console.Write("Виберiть тип клiенту (1 - Новий, 2 - Постiйний, 3 - VIP): ");
            string typeStr = Console.ReadLine();
            ClientType clientType;
            if (Enum.TryParse(typeStr, out clientType))
            {
                ClientType = clientType;
                SetDone();
            }
        }
    }
}
