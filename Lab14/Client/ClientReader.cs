using System;
using DataReaders;

namespace InternetAccessCalculation
{
    class ClientReader : AbstrInstance
    {
        private Client client;
        private ConsoleReader reader;
        private ClientTypeReader clientTypeR;

        public ClientReader()
        {
            reader = new ConsoleReader();
            clientTypeR = new ClientTypeReader();
        }

        public override void Idle()
        {
            Console.WriteLine("Введеня iнформацiї про клiєнта...");

            client = new Client();
            client.FirstName = reader.ReadStr("Iмя: ");
            client.LastName = reader.ReadStr("Фамiлiя: ");
            client.Birthday = reader.ReadDate("День народження: ");
            string phone = reader.RegStr(@"^\d{3}-\d{2}-\d{2}$", "Введiть номер телефону: ", "Номер повинен бути формату 111-22-33");
            client.PhoneNumber = Convert.ToInt32(phone);
            clientTypeR.Run();
            client.ClientType = clientTypeR.ClientType;

            ClientData.Instance.Add(client);
            Console.WriteLine("...");

            SetDone();
        }
    }
}
