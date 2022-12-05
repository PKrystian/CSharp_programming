using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ProgramowanieObiektoweZadania2_5
{
    internal class ProgramowanieObiektoweZadania2_5
    {
        enum Country
        {
            Afganistan=93,
            Bułgaria=359,
            Chile=56,
            Chiny=86,
            Chorwacja=385,
        }

        static void Main(string[] args)
        {

            Console.WriteLine("Jakiego numeru kierunkowego kraju szukasz?: ");
            string looking2 = System.Console.ReadLine()!;
            Country looking = (Country)Convert.ToInt32(looking2);
            System.Console.WriteLine(looking);
        }
    }
}