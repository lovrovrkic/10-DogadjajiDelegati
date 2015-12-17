using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Vsite.CSharp
{
    // primjer poziva delegata preko GetInvocationList

    class Program
    {
        delegate double Funkcija(double x);

        static void IspišiFunkciju(Funkcija fja, double x1, double x2, int n)
        {
            Console.WriteLine("Ispis funkcije {0}:", fja.Method);
            Console.WriteLine("{0} {1}", "x", "y");
            for (int i = 0; i < n; ++i)
            {
                double x = x1 + (x2 - x1) / (n - 1) * i;
                Console.WriteLine("{0} {1}", x, fja(x));
            }
        }

        static void IspišiFunkcijeZasebno(Funkcija fja, double x1, double x2, int n)
        {
            // TODO: Pomoću metode GetInvocationList dohvatiti sve delegatske funkcije zasebno i za svaku ispisati vrijednosti u traženom intervalu
            foreach (Funkcija f in fja.GetInvocationList())
            {
                Console.WriteLine("Ispis funkcije {0}:", f.Method);
                Console.WriteLine("{0} {1}", "x", "y");
                for (int i = 0; i < n; ++i)
                {
                    double x = x1 + (x2 - x1) / (n - 1) * i;
                    Console.WriteLine("{0} {1}", x, f(x));
                }
            }
        
        
        }

        static void Main(string[] args)
        {
            Funkcija f = Math.Cos;
            f += Math.Sin;

            Console.WriteLine("*** IspišiFunkciju ***");
            IspišiFunkciju(f, 0, Math.PI, 10);

            Console.WriteLine("*** IspišiFunkcijeZasebno ***");
            IspišiFunkcijeZasebno(f, 0, Math.PI, 10);

            Console.ReadLine();
        }
    }
}
