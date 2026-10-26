using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace text_stredniky
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //cesta k vstupnimu souboru
            string vstupniSoubor = @"C:\Users\L20240054\Desktop\studenti.txt";

            //test existence souboru
            if (File.Exists(vstupniSoubor))
            {
                //soubor existuje -> budeme cist
                Console.WriteLine("Soubor nalezen");
                //otevreme cteci proud
                using (StreamReader sr = new StreamReader(vstupniSoubor))
                {
                    //pomocny string pro raqdek
                    string radek;
                    //cteme po radcich az do konce souboru
                    while ((radek = sr.ReadLine()) != null)
                    {
                        //vypiseme radek na konzoli
                        Console.WriteLine(radek);
                        //budeme cist radek do prvniho ; protoze tam je prijmeni
                        string prijmeni = "";
                        int i = 0;
                        //cteme radek po znacich az do stredniku
                        while (radek[i] != ';')
                        {
                            //pismenka prilepujeme do prijmeni
                            prijmeni += radek[i];
                            //posunu se na dalsi
                            i++;
                        }
                        Console.WriteLine("Vytazene prijmeni: " + prijmeni);

                    }
                }
            }
            else
            {
                //soubor neexistuje
                Console.WriteLine("Soubor neexistuje.");
            }
        }
    }
}
