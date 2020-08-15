using DemoDI.Cases;
using Microsoft.AspNetCore.Mvc;

namespace DemoDI.Controllers
{
    public class FromServicesController : Controller
    {
        public void Index([FromServices] IClientServices clientServices)
        {
            clientServices.AddClient(new Client());
        }
    }
}
