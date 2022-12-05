using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramowanieObiektoweZadania1
{
    internal class ProgramowanieObiektoweZadania1
    {
        static void Main(string[] args)
        {
            Console.Write("Podaj swoje imie: ");
            string? a = Console.ReadLine()!;
            Console.Write("Podaj swoje nazwisko: ");
            string? v = Console.ReadLine()!;
            Console.Write("Podaj swoj wiek: ");
            string? b = Console.ReadLine()!;
            Console.WriteLine("Użytkownik " + a + " " + v + " ma " + b + " lat");
        }
    }
}
