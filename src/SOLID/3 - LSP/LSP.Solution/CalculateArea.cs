using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.LSP.Solution
{
    public class CalculateArea
    {

        private static void GetParallelogramArea(Parallelogram rec)
        {
            Console.Clear();
            Console.WriteLine("");
            Console.WriteLine();
            Console.WriteLine(rec.Height + " + " + rec.Width);
            Console.WriteLine();
            Console.WriteLine(rec.Area);
            Console.ReadKey();
        }

        public static void Calculate()
        {
            var squa = new Square(5, 5);
            var rec = new Rectangle(10, 5);

            GetParallelogramArea(squa);
            GetParallelogramArea(rec);
        }
    }
}
