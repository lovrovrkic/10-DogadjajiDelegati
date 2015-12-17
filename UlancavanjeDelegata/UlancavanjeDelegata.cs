using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Vsite.CSharp
{
    class Program
    {
        delegate void IspišiPoruku(string poruka);

        // dvije metode koje možemo pridružiti delegatu
        private static void IspišiNaKonzolu(string poruka)
        {
            Console.WriteLine(poruka);
        }

        private static void IspišiUFajl(string poruka)
        {
            using (StreamWriter writer = new StreamWriter(new FileStream("poruke.txt", FileMode.Append, FileAccess.Write)))
                writer.WriteLine(poruka);
        }

        static void Main(string[] args)
        {
            IspišiPoruku ip = IspišiUFajl;

            ip("Dobar dan");

            // Nadovežite u delegatsku listu metodu IspišiNaKonzolu. Pokrenite program i usporedite prikaz na konzoli sa sadržajem datoteke "poruke.txt"

            ip += IspišiNaKonzolu;

            ip("Bok");

            Console.ReadLine();
        }
    }
}
