using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    public class Worker : Person
    {
        public DateTime StartDate { get; set; }
        public string Register { get; set; }
    }

    public class Process
    {
        public void Execution()
        {
            var worker = new Worker()
            {
                Name = "Flabio",
                DateOfBorn = Convert.ToDateTime("1994/01/01"),
                StartDate = DateTime.Now,
                Register = "0123456789"
            };
        }
            
    }
}
