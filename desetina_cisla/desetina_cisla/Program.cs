using System;
using System.IO;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        // Příklad hodnot; nahraďte vlastním kódem/ proměnnými
        int minCislo = 1;
        int pocetRadku = 10;
        int pocetLichychRadku = 5;
        int prumer = 2;
        int mincisloPocet = 3;

        string vystupniSoubor = @"c:\Users\L20240054\Desktop\vystup.txt";

        try
        {
            // Přepsat (overwrite) existující soubor
            using (var sw = new StreamWriter(vystupniSoubor, false, Encoding.UTF8))
            {
                sw.WriteLine("Nejmenší číslo v souboru: {0}", minCislo);
                sw.WriteLine("Počet řádků: {0}", pocetRadku);
                sw.WriteLine("Počet lichých řádků: {0}", pocetLichychRadku);
                sw.WriteLine("Aritmetický průměr lichých řádků: {0}", prumer);
                sw.WriteLine("Počet výskytů minima: {0}", mincisloPocet);
            }

            Console.WriteLine("Výstup zapsán do: " + vystupniSoubor);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Chyba při zápisu: " + ex.Message);
        }
    }
}