using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.ISP.Violation
{
    public class RegisterClient : IRegister
    {
        public void Save()
        {
            // logic to save on cliente table
        }

        public void SendEmail()
        {
            // logic to send
        }

        public void Validate()
        {
            // logic to validate
        }
    }
}
