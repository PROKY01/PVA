using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Threading;

namespace test1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string cestaKSouboru = "c:\\Users\\L20240054\\Desktop\\test1.txt";
            string cestaKVystupnimuSouboru = "c:\\Users\\L20240054\\Desktop\\vystupni.txt";
            int minCislo = Int32.MaxValue;
            int pocetRadku = 0;
            int pocetLichychRadku = 0;
            int pomocnaKPrumeru = 0;
            int prumer = 0;
            int mincisloPocet = 0;
            int pocetNizsichCisel = 0;
            if (File.Exists(cestaKSouboru))
            {
                Console.WriteLine("Soubor nalezen");
                using (StreamReader sr = File.OpenText(cestaKSouboru))
                {
                    string radek;
                    while ((radek = sr.ReadLine()) != null)
                    {
                        pocetRadku++;
                        if (pocetRadku % 2 == 1)
                        {
                            pocetLichychRadku++;
                            int cislo = Int32.Parse(radek);
                            Console.WriteLine(cislo);
                            pomocnaKPrumeru += cislo;
                            if (cislo < minCislo)
                            {
                                minCislo = cislo;
                            }
                        }
                        
                    }
                    sr.Close();
                    prumer = pomocnaKPrumeru / pocetLichychRadku;
                    Console.WriteLine("Nejmenší číslo v souboru je: " + minCislo);
                    Console.WriteLine(pocetRadku);
                    Console.WriteLine(pocetLichychRadku);
                    Console.WriteLine("Aritmetický průměr lichých řádků je: " + prumer);
                }
                using (StreamReader sr = File.OpenText(cestaKSouboru))
                {
                    string radek;
                    while ((radek = sr.ReadLine()) != null)
                    {
                        int cislo = Int32.Parse(radek);
                        if (minCislo == cislo)
                        {
                            mincisloPocet++;
                        }
                        if (cislo < prumer)
                        {
                            pocetNizsichCisel++;
                        }
                    }
                    sr.Close();
                    Console.WriteLine("Počet výskytů nejmenšího čísla v souboru je: " + mincisloPocet);
                    Console.WriteLine("Pocet cisel mensich nez prumer je: " + pocetNizsichCisel);
                }
            }
            else
            {
                Console.WriteLine("Soubor nenalezen");
            }
            using (StreamWriter sw = File.CreateText(cestaKVystupnimuSouboru))
            {
                sw.WriteLine("Nejmensi cislo v lichych radcich: " + minCislo);
                sw.WriteLine("Aritmeticky prumer lichych radku: " + prumer);
                sw.WriteLine("Pocet vyskytu minimalnich cisel: " + mincisloPocet);
                sw.WriteLine("Pocet cisel nizsich nez prumer: " + pocetNizsichCisel);
                sw.Close();
            }
        }
    }
}
