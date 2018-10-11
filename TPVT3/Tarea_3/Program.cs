using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Variables clase1 = new Variables();
            comparaciones clase2 = new comparaciones();

            Struct1 estrct1 = new Struct1();
            Struct2 estrct2 = new Struct2();

            Console.Write("----- Por Clase -----");
            clase1.showVariables();
            clase2.showComparations();

            Console.Write("----- Por struct -----");
            estrct1.imprimir();
            estrct2.imprimir();


            string despacito = Console.ReadLine();
        }
    }
}
