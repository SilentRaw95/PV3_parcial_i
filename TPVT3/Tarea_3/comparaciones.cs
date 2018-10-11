using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_3
{
    class comparaciones
    {
        public void showComparations()
        {
            Console.WriteLine("------------------------- CLASE 2 -------------------------");
            int a = 12;
            int b = 5;

            Console.WriteLine("Variables int");
            Console.WriteLine("a: " + a);
            Console.WriteLine("b: " + b);
            Console.WriteLine("a + b = " + (a + b));
            Console.WriteLine("a - b = " + (a - b));
            Console.WriteLine("a * b = " + (a * b));
            Console.WriteLine("a / b = " + (a / b));
            Console.WriteLine("");

            float c = 16;
            float d = 5;

            Console.WriteLine("Variables float");
            Console.WriteLine("c: " + c);
            Console.WriteLine("d: " + d);
            Console.WriteLine("c + d = " + (c + d));
            Console.WriteLine("c - d = " + (c - d));
            Console.WriteLine("c * d = " + (c * d));
            Console.WriteLine("c / d = " + (c / d));
            Console.WriteLine("");

            float e = 70;
            float f = 30;

            Console.WriteLine("Variables double");
            Console.WriteLine("e: " + e);
            Console.WriteLine("f: " + f);
            Console.WriteLine("e + f = " + (e + f));
            Console.WriteLine("e - f = " + (e - f));
            Console.WriteLine("e * f = " + (e * f));
            Console.WriteLine("e / f = " + (e / f));
            Console.WriteLine("");

            byte g = 100;
            byte h = 35;

            Console.WriteLine("Variables double");
            Console.WriteLine("g: " + g);
            Console.WriteLine("h: " + h);
            Console.WriteLine("g + h = " + (g + h));
            Console.WriteLine("g - h = " + (g - h));
            Console.WriteLine("g * h = " + (g * h));
            Console.WriteLine("g / h = " + (g / h));
            Console.WriteLine("");

            Console.WriteLine("Comparativas");
            Console.WriteLine("g + h > 100: " + ((g + h) > 100));
            Console.WriteLine("g + h <= 100: " + ((g + h) <= 150));
            Console.WriteLine("e / f >= 5: " + ((e / f) >= 5));
            Console.WriteLine("c + d == 20 " + ((c + d) == 20));
            Console.WriteLine("a + b != 18 " + ((a + b) != 18));
        }
    }
}
