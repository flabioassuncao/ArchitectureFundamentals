using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.ISP.Violation
{
    public interface IRegister
    {
        void Validate();
        void Save();
        void SendEmail();
    }
}
