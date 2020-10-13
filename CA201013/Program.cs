using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA201013
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine(Osztalyoz(654654));
            Console.WriteLine(HonapSzam("waglkkjggf"));

            int[] t = new int[10];
            Feltolt(t, 99);
            //Kiir(t);

            Kiir(PermutacioN(30));

            Console.ReadKey();
        }


        static int[] PermutacioN(int n)
        {
            int[] t = new int[n];

            for (int i = 0; i < t.Length; i++)
            {
                t[i] = i + 1;
            }
            Kever(t);
            return t;
        }

        static void Kever(int[] t)
        {
            for (int i = 0; i < t.Length; i++)
            {
                int x = rnd.Next(t.Length);
                int y = rnd.Next(t.Length);
                int s = t[x];
                t[x] = t[y];
                t[y] = s;
            }
        }

        private static void Kiir(int[] t)
        {
            for (int i = 0; i < t.Length; i++)
            {
                Console.Write($"{t[i]} ");
            }
        }

        static Random rnd = new Random();
        static void Feltolt(int[] t, int max)
        {
            for (int i = 0; i < t.Length; i++)
            {
                t[i] = rnd.Next(1, max + 1);
            }
        }


        static string Osztalyoz(int szam)
        {
            switch(szam)
            {
                case 1: return "elégtelen";
                case 2: return "elégséges";
                case 3: return "közepes";
                case 4: return "jó";
                case 5: return "jeles";
                default: return "nem megfelelő értéket írt be";
            }
        }

        static int HonapSzam(string honapNev)
        {
            switch (honapNev)
            {
                case "január": return 1;
                case "február": return 2;
                default:
                    {
                        Console.WriteLine("hincs ilyen hónap");
                        return -1;
                    }
            }
        }

        static void KerTer(int a, int b)
        {
            Console.WriteLine($"téglalap kerülete: {2 * (a + b)} cm");
            Console.WriteLine($"téglalap területe: {a * b} cm^2");
        }

        static bool HaromszogE(int a, int b, int c)
        {
            return (a + b > c && a + c > b && b + c > a);
        }

        static void KorkerTer(int r)
        {
            Console.WriteLine($"kerület: {2 * r * Math.PI} cm");
            Console.WriteLine($"terület: {Math.Pow(r, 2) * Math.PI} cm^2");
        }


    }
}
