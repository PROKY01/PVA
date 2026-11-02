using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vyhledavani
{
    internal class Program
    {
        //naivni vyhledavani - funkce
        public static bool Naivni(int[] pole, int hledany)
        {
            //predpokladam ze nenajdu
            bool nalezeno = false;
            //projdu cele pole
            for (int i = 0; i < pole.Length; i++)
            {
                //kaydeho prvku se zeptam jestli je hledany
                if (pole[i] == hledany)
                {
                    nalezeno = true;
                    break;
                }
            }
            return nalezeno;
        }

        static void Main(string[] args)
        {
            //zde vytvorime pole
            int[] pole = new int[10];

            //nahodny generator
            Random rd = new Random();

            //projdeme pole, naplnime hodnotami a vypiseme je
            for (int i = 0; i < pole.Length; i++)
            {
                //nahodna hodnota
                pole[i] = rd.Next(pole.Length);
                //vypis
                Console.Write(pole[i] + ", ");
            }
            //odetrujeme vypis
            Console.WriteLine();

            //testujeme vyhledavani
            int hledany = 5;
            if(Naivni(pole, hledany) == true)
            {
                Console.WriteLine("Cislo: " + hledany + " nalezeno");
            }
            else
            {
                Console.WriteLine("Cislo: " + hledany + " nenalezeno");
            }
        }
    }
}
