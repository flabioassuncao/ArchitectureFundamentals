using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.LSP.Violation
{
    public class CalculateArea
    {

        private static void GetRectangleArea(Rectangle rec)
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
            var squa = new Square()
            {
                Height = 10,
                Width = 5
            };

            GetRectangleArea(squa); 
        }
    }
}
