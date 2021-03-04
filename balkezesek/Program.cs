using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;

namespace balkezesek
{
    class Program
    {
        static List<Jatekos> jatekosok;
        static int evszam;
        static void Main(string[] args)
        {
            Beolvas();
            Kiir();
            Feladat3();
            Feladat4();
            Feladat5();
            Feladat6();

            Console.ReadKey();
        }

        private static void Feladat6()
        {
            Console.Write("6. feladat: ");

            double osszSuly = 0;
            int darabszam = 0;
            foreach (var jatekos in jatekosok)
            {
                if (jatekos.Elso.Year < evszam && jatekos.Utolso.Year > evszam)
                {
                    osszSuly += jatekos.Suly;
                    darabszam++;
                }
            }

            double atlagSuly = osszSuly / darabszam;
            Console.WriteLine(Math.Round(atlagSuly, 2) + " font");
        }

        private static void Feladat5()
        {
            Console.WriteLine("5. feladat: ");
            Console.Write("Kérek egy 1990 és 1999 közötti évszámot!:");
            evszam = int.Parse(Console.ReadLine());
            

            while (evszam < 1990 || evszam > 1999)
            {
                Console.Write("Hibás adat, kérek egy 1990 és 1999 közötti évszámot!: ");
                evszam = int.Parse(Console.ReadLine());
            }
        }

        private static void Feladat4()
        {
            Console.WriteLine("4. feladat: ");

            foreach (var jatekos in jatekosok)
            {
                if (jatekos.Utolso.Year == 1999 && jatekos.Utolso.Month == 10)
                {
                    Console.WriteLine(jatekos);
                }
            }
        }

        private static void Feladat3()
        {
            Console.WriteLine("3. feladat: " + jatekosok.Count);
        }

        private static void Kiir()
        {
            foreach (var jatekos in jatekosok)
            {
                Debug.WriteLine(jatekos);
            }
        }

        private static void Beolvas()
        {
            jatekosok = new List<Jatekos>();
            using (StreamReader sr = new StreamReader("balkezesek.csv"))
            {
                sr.ReadLine();
                while (!sr.EndOfStream)
                {
                    string[] sor = sr.ReadLine().Split(';');
                    string nev = sor[0];
                    DateTime elso = DateTime.Parse(sor[1]);
                    DateTime utolso = DateTime.Parse(sor[2]);
                    int suly = int.Parse(sor[3]);
                    int magassag = int.Parse(sor[4]);

                    Jatekos jatekos = new Jatekos(nev, elso, utolso, suly, magassag);
                    jatekosok.Add(jatekos);
                }
            }

        }
    }
}
