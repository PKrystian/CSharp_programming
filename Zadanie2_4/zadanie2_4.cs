using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace ProgramowanieObiektoweZadania2_4
{
    internal class ProgramowanieObiektoweZadania2_4
    {
        static void Main(string[] args)
        {

            Console.Write("Podaj wartosc: ");
            string x = Console.ReadLine()!;
            uint binary = Convert.ToUInt32(x);

            int shift_amount = 10;

            Console.WriteLine(Convert.ToString(binary, toBase: 2).PadLeft(8, '0'));

            for (int i = 0; i < shift_amount; i++)
            {
                uint temp = binary << 1;

                if (temp > 255)
                {
                    binary -= 0b_10000000;
                    binary = binary << 1;
                    binary += 0b_00000001;

                    Console.WriteLine(Convert.ToString(binary, toBase: 2).PadLeft(8, '0'));
                }
                else
                {
                    binary = binary << 1;
                    Console.WriteLine(Convert.ToString(binary, toBase: 2).PadLeft(8, '0'));
                }
            }
        }
    }
}
