using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.ISP.Violation
{
    public class RegisterProduct : IRegister
    {
        public void Save()
        {
            // logic to save on product table
        }

        public void SendEmail()
        {
            // product does not has email
            throw new NotImplementedException("");
        }

        public void Validate()
        {
            // logic to validate
        }
    }
}
