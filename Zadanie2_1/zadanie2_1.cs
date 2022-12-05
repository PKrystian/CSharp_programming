using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramowanieObiektoweZadania2_1
{
    internal class ProgramowanieObiektoweZadania2_1
    {
        static void Main(string[] args)
        {
            string x;
            Console.Write("Podaj ilosc iteracji pi: ");
            x = Console.ReadLine()!;
            int n = Convert.ToInt32(x);
            double suma_e = 0;
            for (int i = 0; i < n; i++)
            {
                suma_e += (Math.Pow(-1, i) / (2 * i + 1));
            }
            double pi = 4 * suma_e;

            Console.WriteLine(pi);

        }
    }
}
