using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_3
{
    class Struct1
    {
        public void imprimir()
        {
            Console.WriteLine("------------------------- STRUCT 1 -------------------------");
            //Entero con signo
            sbyte e_sbyte = 45;
            short e_short = 67;
            int e_int = 78;
            long e_long = -99;

            //Entero sin signo
            byte e_byte = 65;
            ushort e_ushort = 56;
            uint e_uint = 34;
            ulong e_ulong = 61;

            //Punto flotante
            float e_float = 11;
            double e_double = 14.721212;

            //Caracteres
            char e_char = 's';
            string e_string = "prueba";

            //Decimal
            decimal e_decimal = 12;

            //mostrar valores
            Console.WriteLine("--------- Entero con signo ---------");
            Console.WriteLine("sbyte: " + e_sbyte);
            Console.WriteLine("short: " + e_short);
            Console.WriteLine("int: " + e_int);
            Console.WriteLine("long: " + e_long);

            Console.WriteLine("--------- Entero sin signo ---------");
            Console.WriteLine("byte: " + e_byte);
            Console.WriteLine("ushort: " + e_ushort);
            Console.WriteLine("uint: " + e_uint);
            Console.WriteLine("ulong: " + e_long);

            Console.WriteLine("--------- Punto flotante ---------");
            Console.WriteLine("float: " + e_float);
            Console.WriteLine("double: " + e_double);

            Console.WriteLine("--------- Caracteres ---------");
            Console.WriteLine("char: " + e_char);
            Console.WriteLine("string: " + e_string);

            Console.WriteLine("--------- Decimal ---------");
            Console.WriteLine("decimal: " + e_decimal);

            //casteos
            Console.WriteLine("\n\n------------- Casteos -----------------");
            Console.WriteLine("Hice casteos solo con algunos tipo de dato");

            double cast_1 = (double)e_int;
            Console.WriteLine("int a double: " + cast_1);

            double cast_2 = (double)e_int + 0.131249;
            Console.WriteLine("int a double mas suma: " + cast_2);

            String cast_3 = e_float.ToString();
            Console.WriteLine("float a string: " + cast_3);

            double cast_4 = (byte)e_sbyte;
            Console.WriteLine("sbyte a byte: " + cast_4);

            double cast_5 = (long)e_long;
            Console.WriteLine("ulong a long: " + cast_5);

            String cast_6 = e_char.ToString();
            Console.WriteLine("char a string: " + cast_6);
        }
    }
}
