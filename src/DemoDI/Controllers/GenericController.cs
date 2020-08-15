using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DemoDI.Cases;
using Microsoft.AspNetCore.Mvc;

namespace DemoDI.Controllers
{
    public class GenericController : Controller
    {
        private readonly IGenericRepository<Client> _clientRepository;

        public GenericController(IGenericRepository<Client> clientRepository)
        {
            _clientRepository = clientRepository;
        }

        public void Index()
        {
            _clientRepository.Add(new Client());
        }
    }
}
