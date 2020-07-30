using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    // definition class
    public class Home
    {
        public int Size { get; set; }
        public int Floors { get; set; }
        public decimal Cost { get; set; }
    }

    public class HomeObject
    {
        public HomeObject()
        {
            // definition object
            var home = new Home
            {
                Size = 100,
                Floors = 2,
                Cost = 3000.45m
            };
        }
    }
}
