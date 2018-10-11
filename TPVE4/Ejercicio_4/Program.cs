using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matriz = new int[4, 5]
            {
                {1, 9, 23, 34, 102},
                {2, 8, 67, 56, 23},
                {3, 7, 84, 78, 43},
                {4, 5, 90, 98, 34}
            };

            Console.Write("Resultado: {");
            for (int i = 0; i <= 4; i++)
            {
                if (i % 2 == 0)
                {
                    for (int j = 0; j <= 3; j++)
                    {
                        Console.Write(matriz[j, i] + ", ");
                    }
                }
                else
                {
                    for (int j = 3; j >= 0; j--)
                    {
                        Console.Write(matriz[j, i] + ", ");
                    }
                }

            }
            Console.Write("}");
            string despacito = Console.ReadLine();
        }
    }
}
