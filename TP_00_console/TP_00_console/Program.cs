using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_00_console
{
    class Program
    {
        static void Main(string[] args)
        {
            int var1;
            int var2;
            int var3;
            Console.WriteLine("saisir un entier");
            var1 = int.Parse(Console.ReadLine());
            Console.WriteLine("saisir un entier");
            var2 = int.Parse(Console.ReadLine());
            Console.WriteLine("saisir un entier");
            var3 = int.Parse(Console.ReadLine());
            if (var1>var2)
            { var2 = var1;
            }
            else
            {
                var1 = var3;
            }
            if (var2 > var3)
            {
                var1 = var2;
                var3 = var1;
            }
            else
            {
                var2 = var3;
                var1 = var2;
            }
            Console.WriteLine(var1 + "--" + var2 + "--" + var3 );


            Console.ReadLine();
        }
    }
}
