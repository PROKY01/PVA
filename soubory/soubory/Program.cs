using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace soubory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //cesta k souboru
            //@ pred stringem zajistuje ze se to bere jako cesta
            string cestaKVstupnimuSouboru = @"C:\Users\L20240054\Desktop\PVA\pokus.txt";

            //test existence souboru
            if(File.Exists(cestaKVstupnimuSouboru))
            {
                Console.WriteLine("Soubor existuje.");

                //cesta k vystupnimu souboru
                string cestaKVystupnimuSouboru = @"C:\Users\L20240054\Desktop\PVA\kopie.txt";

                //vytvorime cteci proud pro cteni vstupniho souboru
                using (StreamReader sr = File.OpenText(cestaKVstupnimuSouboru))
                {
                    //potrubuju cislo kam budu ukladt kody prectenych znaku
                    int cislo;

                    //vytvorime zapisovaci proud do vystupniho souboru, puvodni prepise
                    //using (StreamWriter sw = File.CreateText(cestaKVystupnimuSouboru))

                    using (StreamWriter sw = File.AppendText(cestaKVystupnimuSouboru))
                    {
                        //cteme az do konce vstupni soubor znak po znaku 
                        while ((cislo = sr.Read()) != -1)
                        {
                            //z cisleneho vytvorime jednoznakovy string
                            string znak = Char.ConvertFromUtf32(cislo);
                            //tento znak  / string zapisu
                            sw.Write(znak);
                            //kontrolni vypis do konzole - nefunguji specialni pismena arabstina, cinsky, korejstina, japonstina, atd.
                            Console.Write(znak);
                        }
                        //uzavreme zapisovaci proud
                        sw.Close();
                    }
                    //uzavreme cteci proud
                    sr.Close();
                }
            }
            else
            {
                Console.WriteLine("Soubor neexistuje.");
            }



            Console.ReadKey();
        }
    }
}
