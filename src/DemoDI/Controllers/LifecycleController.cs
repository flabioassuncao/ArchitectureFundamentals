using System;
using DemoDI.Cases;
using Microsoft.AspNetCore.Mvc;

namespace DemoDI.Controllers
{
    public class LifecycleController : Controller
    {
        public OperationService OperacaoService { get; }
        public OperationService OperacaoService2 { get; }

        public LifecycleController(OperationService operacaoService, OperationService operacaoService2)
        {
            OperacaoService = operacaoService;
            OperacaoService2 = operacaoService2;
        }

        public string Index()
        {
            return
                "First instace: " + Environment.NewLine +
                OperacaoService.Transient.OperationId + Environment.NewLine +
                OperacaoService.Scoped.OperationId + Environment.NewLine +
                OperacaoService.Singleton.OperationId + Environment.NewLine +
                OperacaoService.SingletonInstance.OperationId + Environment.NewLine +

                Environment.NewLine +
                Environment.NewLine +

                "Second instace: " + Environment.NewLine +
                OperacaoService2.Transient.OperationId + Environment.NewLine +
                OperacaoService2.Scoped.OperationId + Environment.NewLine +
                OperacaoService2.Singleton.OperationId + Environment.NewLine +
                OperacaoService2.SingletonInstance.OperationId + Environment.NewLine;
        }
    }
}
