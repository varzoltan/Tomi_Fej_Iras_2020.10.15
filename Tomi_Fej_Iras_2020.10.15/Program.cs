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
            int szamol = 0;
            if(kiserlet[0]+kiserlet[1]+kiserlet[2] == "FFI")
            {
                szamol++;
            }
            if (kiserlet[kiserlet.Length-3] + kiserlet[kiserlet.Length-2] + kiserlet[kiserlet.Length-1] == "IFF")
            {
                szamol++;
            }
            for (int i =0;i<n;i++)
            {
                string dobtunk = kiserlet[i] + kiserlet[i + 1] + kiserlet[i + 2] + kiserlet[i + 3];
                if (dobtunk == "IFFI")
                {
                    szamol++;
                }
            }
            Console.WriteLine("5. feladat\nA kisérlet során {0} alkalommal dobtak pontosan két fejet egymás után.",szamol);

            //6.feladat
            int max = 0;
            int maxh = 0;
            for (int i = 0;i<n;i++)
            {
                if (kiserlet[i] == "F")
                {
                    int db = 1;
                    int j = i + 1;
                    while (kiserlet[j] == "F")
                    {
                        db++;
                        j++;
                    }
                    if (max<db)
                    {
                        max = db;
                        maxh = i+1;
                    }
                    i = j;
                }
            }
            Console.WriteLine("6. feladat\nA leghoszabb tisztafej sorozat {0} tagból áll, kezdete a(z) {1}. dobás", max, maxh);

            //7. feladat
            //1000 elemű tömb létrehozása
            string[] dobasok = new string[1000];
            int FFFF = 0;
            int FFFI = 0;
            for (int i = 0;i<dobasok.Length;i++)
            {
                string dob4 = Dobas() + Dobas() + Dobas() + Dobas();
                if (dob4 == "FFFF")
                {
                    FFFF++;
                }
                if (dob4 == "FFFI")
                {
                    FFFI++;
                }
                dobasok[i] = dob4;
            }
            StreamWriter ir = new StreamWriter(@"C:\Users\Rendszergazda\Downloads\dobasok.txt");
            ir.WriteLine("FFFF: " + FFFF + ", " + "FFFI: " + FFFI);
            for(int i = 0; i < dobasok.Length; i++)
            {
                ir.Write(dobasok[i]+" ");
            }
            ir.Close();
            Console.ReadKey();
        }

        //Függvény készítése a dobáshoz!
        static string Dobas()
        {
            Random veletlen = new Random();
            if (veletlen.Next(1,3) == 1)
            {
                return "F";
            }
            else
            {
                return "I";
            }
        }
    }
}
