using SOLID.DIP.Solution.Interfaces;

namespace SOLID.DIP.Solution
{
    public class ClientService : IClientService
    {
        private readonly IClientRepository _clientRepository;
        private readonly IEmailService _emailService;

        public ClientService(IClientRepository clientRepository, IEmailService emailService)
        {
            _clientRepository = clientRepository;
            _emailService = emailService;
        }

        public string AddClient(Client client)
        {
            if (!client.Valid())
                return "invalid data";

            _clientRepository.AddClient(client);

            _emailService.Send("company@company.com", client.Email.EmailAddress, "Welcome.", "Congrats! You are registered.");

            return "successfully registered client";
        }
    }
}
