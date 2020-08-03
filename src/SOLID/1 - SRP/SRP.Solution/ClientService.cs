using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.SRP.Solution
{
    public class ClientService
    {
        public string AddClient(Client client)
        {
            if (!client.Valid())
                return "invalid data";

            var repo = new ClientRepository();
            repo.AddClient(client);

            EmailService.Send("company@company.com", client.Email.EmailAddress, "Welcome.", "Congrats! You are registered.");

            return "successfully registered client";
        }
    }
}
