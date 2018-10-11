using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_4
{
    class Program
    {
        public static string ReverseString(string s)
        {
            char[] arr = s.ToCharArray();
            Array.Reverse(arr);
            return new string(arr);
        }

        static void Main(string[] args)
        {
            String word = "";

            while (word.Equals(""))
            {
                Console.WriteLine("Ingrese una palabra: ");
                word = Console.ReadLine();
            }

            String word2 = ReverseString(word);

            if (word.Equals(word2))
            {
                Console.WriteLine("Si es palindromo");
            }
            else
            {
                Console.WriteLine("No es palindromo");
            }

            String xd = Console.ReadLine();
        }
    }
}
