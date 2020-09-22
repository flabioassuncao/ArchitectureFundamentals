using System;
using System.Collections.Generic;

namespace DesignPatterns.Facade.Domain
{
    public class Request
    {
        public Guid Id { get; set; }
        public decimal Amount { get; set; }
        public List<Product> Products { get; set; }
    }
}
