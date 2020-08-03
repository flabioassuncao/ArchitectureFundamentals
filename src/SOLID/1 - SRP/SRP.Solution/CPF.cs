using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.SRP.Solution
{
    public class CPF
    {
        public string Number { get; set; }

        public bool Valid()
        {
            return Number.Length == 11;
        }
    }
}
