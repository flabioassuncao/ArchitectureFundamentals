using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.SRP.Solution
{
    public class Client
    {
        public int ClientId { get; set; } 
        public string Name { get; set; }
        public Email Email { get; set; }
        public CPF CPF { get; set; }
        public DateTime RegisterDate { get; set; }

        public bool Valid()
        {
            return Email.Valid() && CPF.Valid();
        }
    }
}
