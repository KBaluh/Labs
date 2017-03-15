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

        private List<Client> clients = new List<Client>();

        public void Add(Client client)
        {
            clients.Add(client);
        }

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
