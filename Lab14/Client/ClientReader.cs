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
            clientTypeR.Run();
            client.ClientType = clientTypeR.ClientType;

            ClientData.Instance.Add(client);
            Console.WriteLine("...");

            SetDone();
        }
    }
}
