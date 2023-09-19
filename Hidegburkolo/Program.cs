using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hidegburkolo
{
    internal class Program
    {
        private static double szelesseg;
        private static double hosszusag;
        private static double magassag;
        private const double csomagcsempe = 1.44;
        static void Main(string[] args)
        {
            adatok(szelesseg,hosszusag,magassag);
            Console.ReadKey();
        }

        private static void adatok(double sz,double h,double m)
        {
            Console.WriteLine("Hello hidegburkoló!\nEz a program segít egy szoba csempemennyiségének kiszámításában.(méter)");
            Console.WriteLine("Add meg a szoba szélességét: ");
            sz = double.Parse(Console.ReadLine()); 
            Console.WriteLine("Add meg a szoba hosszúságát: ");
            h = double.Parse(Console.ReadLine()); 
            Console.WriteLine("És add meg a szoba magasságát is: ");
            m = double.Parse(Console.ReadLine());
            Szamolas(sz,h,m);
        }

        private static void Szamolas(double sz1, double h1, double m1)
        {
            double afal;
            double bfal;
            double teljes;
            double alapterulet;
            alapterulet = (sz1 * h1);
            afal = (sz1 * m1) * 2;
            bfal = (h1 * m1) * 2;
            teljes = (afal + bfal + alapterulet)*1.1;
            Console.WriteLine("A szügséges csempecsomagok száma: " +  Math.Ceiling(teljes/csomagcsempe));
            
            

        }

    }
}
