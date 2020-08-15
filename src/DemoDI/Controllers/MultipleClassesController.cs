using System;
using DemoDI.Cases;
using Microsoft.AspNetCore.Mvc;

namespace DemoDI.Controllers
{
    public class MultipleClassesController : Controller
    {
        private readonly Func<string, IService> _serviceAcessor;

        public MultipleClassesController(Func<string, IService> serviceAcessor)
        {
            _serviceAcessor = serviceAcessor;
        }

        public string Index()
        {
            return _serviceAcessor("A").Return();
            //return _serviceAcessor("B").Return();
            //return _serviceAcessor("C").Return();
        }
    }
}
