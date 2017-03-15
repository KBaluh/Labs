using System.Collections.Generic;
using System.Linq;

namespace InternetAccessCalculation
{
    class ClientData
    {
        private List<Client> clients;

        public ClientData()
        {
            clients = new List<Client>
            {
                new Client { Name = "ЧП Пупкiн", ClientType = ClientType.New },
                new Client { Name = "ООО Велика Компанiя", ClientType = ClientType.Regular },
                new Client { Name = "Просто команiя", ClientType = ClientType.VIP },
                new Client { Name = "Автопром", ClientType = ClientType.VIP }
            };
        }

        public List<Client> GetAll()
        {
            return clients;
        }

        public List<Client> OrderByName()
        {
            return clients.OrderBy(x => x.Name).ToList();
        }

        public List<Client> GetByType(ClientType type)
        {
            return clients.Where(x => x.ClientType == type).ToList();
        }

        public List<ClientType> GetTypes()
        {
            return clients.Select(x => x.ClientType).Distinct().ToList();
        }
    }
}
