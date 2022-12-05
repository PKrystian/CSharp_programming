using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramowanieObiektoweZadania2_3
{
    internal class ProgramowanieObiektoweZadania2_3
    {
        static void Main(string[] args)
        {
            string x;
            Console.Write("Podaj liczbe (max 255): ");
            x = Console.ReadLine()!;
            uint n = Convert.ToUInt32(x);
            for (int i = 0; i < 9-n; i++)
            {
                uint y = n << 0+i;
                string binary = Convert.ToString(y, 2).PadLeft(8, '0');
                Console.WriteLine(binary);
            }
        }
    }
}
