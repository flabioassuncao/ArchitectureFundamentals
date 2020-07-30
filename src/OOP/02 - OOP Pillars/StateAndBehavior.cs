using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    public class Person
    {
        public string Name { get; set; }
        public DateTime DateOfBorn { get; set; }

        public int CalculateAge()
        {
            var actualDate = DateTime.Now;
            var age = actualDate.Year - DateOfBorn.Year;

            if (actualDate < DateOfBorn.AddYears(age)) age--;

            return age;
        }
    }
}
