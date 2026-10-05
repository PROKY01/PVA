using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace soubory_kopirovani
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //cesta k vstupnímu souboru
            string vstupniSoubor = @"C:\Users\L20240054\Desktop\PVA\pokus.txt";

            //kontrola, zda soubor existuje
            if (File.Exists(vstupniSoubor))
            {
                //soubor nalezen
                //cesta k výstupnímu souboru
                string vystupniSoubor = @"C:\Users\L20240054\Desktop\PVA\pokus_kopie.txt";
                //promenna na pocitani zkopirovanych radku
                int pocetRadku = 0;

                //otevreme cteci proud
                using (StreamReader sr = File.OpenText(vstupniSoubor))
                {
                    //otevreme zapisovaci proud
                    using (StreamWriter sw = File.CreateText(vystupniSoubor))
                    {
                        //textovy retecec pro nacteni celeho radku
                        string radek;
                        while ((radek = sr.ReadLine()) != null)
                        {
                            //nacetli jsme jeden radek
                            pocetRadku++;
                            //zapiseme radek do vystupniho souboru
                            sw.WriteLine(radek);
                        }
                        //cely vstup je precten
                        //uzavreme vstupni proud
                        sw.Close();
                    }
                    sr.Close();
                }
                //ohlasime pocet zkopirovanych radku
                Console.WriteLine("Bylo zkopírováno " + pocetRadku + " radku.");
            }
            else
            {
                //soubor nenalezen
                Console.WriteLine("Soubor nebyl nalezen.");
            }
        }
    }
}
