using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramowanieObiektoweZadania2_2
{
    internal class ProgramowanieObiektoweZadania2_2
    {
        static void Main(string[] args)
        {
            string x;
            Console.Write("Podaj liczbe (max 255): ");
            x = Console.ReadLine()!;
            int n = Convert.ToInt32(x);
            string binary = Convert.ToString(n, 2);

            Console.WriteLine(binary);

        }
    }
}
