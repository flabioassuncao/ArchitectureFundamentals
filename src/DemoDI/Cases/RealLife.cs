using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoDI.Cases
{
    public class Client
    {
        public int ClientId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Cpf { get; set; }
        public DateTime RegisterDate { get; set; }
    }

    public interface IClientRepository
    {
        void AddClient(Client client);
    }

    public class ClientRepository : IClientRepository
    {
        public void AddClient(Client client)
         {
            // just do things
        }
    }

    public interface IClientServices
    {
        void AddClient(Client client);
    }

    public class ClientServices : IClientServices
    {
        private readonly IClientRepository _clientRepository;
        public ClientServices(IClientRepository clientRepository)
        {
            _clientRepository = clientRepository;
        }

        public void AddClient(Client client)
        {
            _clientRepository.AddClient(client);
        }
    }
}
