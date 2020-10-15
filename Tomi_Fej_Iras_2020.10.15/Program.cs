using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tomi_Fej_Iras_2020._10._15
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.feladat
            Random fejIras = new Random();
            //Ha 1 = I; 2 = F
            int veletlen = fejIras.Next(1,2);
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

        }
    }
}
