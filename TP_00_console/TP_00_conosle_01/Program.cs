using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_00_console_01
{
    class Program
    {
        static void Main(string[] args)
        {
            int nb1;
            int nb2;
            Console.WriteLine("saisir un entier");
            nb1 = int.Parse(Console.ReadLine());
            Console.WriteLine("saisir un entier");
            nb2 = int.Parse(Console.ReadLine());
            if(nb1 > nb2)
            { Console.WriteLine(nb1 + " est plus grand que "+ nb2); }
            else if (nb1 < nb2)
            { Console.WriteLine(nb2 + " est plus grand que " + nb1); } 
            Console.WriteLine("--------------------");
            Console.WriteLine(Math.Max(nb1,nb2) + " est plus grand que " + Math.Min(nb1,nb2));
            Console.WriteLine("--------------------");
            if (nb2 > nb1)
            { Console.WriteLine(nb1 + " est plus petit que " + nb2); }
            else if (nb2 < nb1)
            { Console.WriteLine(nb2 + " est plus petit que " + nb1); }
            Console.WriteLine("--------------------");
            Console.WriteLine(Math.Min(nb1, nb2) + " est plus petit que " + Math.Max(nb1, nb2));
            Console.WriteLine("--------------------");


            Console.ReadLine();
        }
    }
}
