using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.SRP.Solution
{
    public class Email
    {
        public string EmailAddress { get; set; }

        public bool Valid()
        {
            return EmailAddress.Contains("@");
        }
    }
}
