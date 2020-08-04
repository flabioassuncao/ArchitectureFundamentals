﻿namespace SOLID.DIP.Solution
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
