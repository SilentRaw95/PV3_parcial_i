using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variables
            int num1, num2, num3, num4, num5;
            double suma, prom, mayor;

            Console.Write("Ingresa un numero: ");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ingresa otro numero: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ingresa otro numero: ");
            num3 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ingresa otro numero: ");
            num4 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ingresa el ultimo numero: ");
            num5 = Convert.ToInt32(Console.ReadLine());

            //suma
            suma = (double)num1 + (double)num2 + (double)num3 + (double)num4 + (double)num5;
            Console.Write("\nLa suma de los 5 numeros: "+suma);

            //promedio
            prom = suma / 5;
            Console.Write("\nEl promedio de los 5 numeros: " + prom);

            //cual es el mas grande


            if (num1 >= num2 && num1 >= num3 && num1 >= num4 && num1 >= num5)
            {
                Console.Write("\nEl numero mas grande es: " + num1);
            }
            else if (num2 >= num1 && num2 >= num3 && num2 >= num4 && num2 >= num5)
            {
                Console.Write("\nEl numero mas grande es: " + num2);
            }
            else if (num3 >= num1 && num3 >= num2 && num3 >= num4 && num3 >= num5)
            {
                Console.Write("\nEl numero mas grande es: " + num3);
            }
            else if (num4 >= num1 && num4 >= num2 && num4 >= num3 && num4 >= num5)
            {
                Console.Write("\nEl numero mas grande es: " + num4);
            }
            else if (num5 >= num1 && num5 >= num2 && num5 >= num3 && num5 >= num4)
            {
                Console.Write("\nEl numero mas grande es: " + num5);
            }

            String xd = Console.ReadLine();
        }
    }
}
