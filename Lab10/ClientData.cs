using System.Collections.Generic;
using System.Linq;

namespace InternetAccessCalculation
{
    class ClientData
    {
        #region Singleton
        private static ClientData instance;

        private ClientData()
        {
            clients = new List<Client>
            {
                new Client { FirstName = "ЧП Пупкiн", ClientType = ClientType.New },
                new Client { FirstName = "ООО Велика Компанiя", ClientType = ClientType.Regular },
                new Client { FirstName = "Просто команiя", ClientType = ClientType.VIP },
                new Client { FirstName = "Автопром", ClientType = ClientType.VIP }
            };
        }

        public static ClientData Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ClientData();
                }
                return instance;
            }
        }
        #endregion

        private List<Client> clients;

        public List<Client> GetAll()
        {
            return clients;
        }

        public List<Client> OrderByName()
        {
            return clients.OrderBy(x => x.FirstName).ToList();
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
