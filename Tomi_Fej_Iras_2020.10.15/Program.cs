using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace Tomi_Fej_Iras_2020._10._15
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.feladat
            Random fejIras = new Random();
            //Ha 1 = I; 2 = F
            int veletlen = fejIras.Next(1,3);
            Console.WriteLine("1. feladat");
            if (veletlen == 1)
            {
                Console.WriteLine($"A pénzfeldobás eredménye: I");
            }
            else
            {
                Console.WriteLine($"A pénzfeldobás eredménye: F");
            }

            //2.feladat
            Console.Write("2.Feladat:\nKérem adja meg a tippjét (\"I\" vagy \"F\"): ");
            string tip = Console.ReadLine();
            veletlen = fejIras.Next(1, 3);
            if (veletlen == 1 && tip == "I")
            {
                Console.WriteLine("Ön eltalálta.");
            }
            else if (veletlen == 2 && tip == "F")
            {
                Console.WriteLine("Ön eltalálta.");
            }
            else
            {
                Console.WriteLine("Ön nem találta el.");
            }

            //Beolvasás vektorba. A vektor az egy egydimenziós tömb.
            string[] kiserlet = new string[1000000];
            StreamReader olvas = new StreamReader(@"C:\Users\Rendszergazda\Downloads\kiserlet.txt");
            int n = 0;
            while (!olvas.EndOfStream)
            {
                string sor = olvas.ReadLine();
                kiserlet[n] = sor;
                n++;
            }
            olvas.Close();
            Console.WriteLine("3.Feladat\nA kísérlet {0} dobásból állt",n);
            
            //4.Feladat
            int fej = 0;
            for (int i=0;i<n;i++)
            {
                if (kiserlet[i] == "F")
                {
                    fej++;
                }
                        
            }
            Console.WriteLine("4.Feladat\nA kísérlet során a fej gyakorisága {0} volt.",(fej*100.0 / n).ToString("0.00"));

            //5.Feladat
            for (int i =0;i<n;i++)
            {
                
            }
            Console.ReadKey();
        }
    }
}
