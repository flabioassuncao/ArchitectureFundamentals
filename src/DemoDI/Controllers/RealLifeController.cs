using DemoDI.Cases;
using Microsoft.AspNetCore.Mvc;

namespace DemoDI.Controllers
{
    public class RealLifeController : Controller
    {
        private readonly IClientServices _clientServices;

        public RealLifeController(IClientServices clientServices)
        {
            _clientServices = clientServices;
        }

        //public IActionResult Index()
        //{
        //    return View();
        //}

        public void Index()
        {
            _clientServices.AddClient(new Client());
        }
    }
}
