using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Emlosok> emlosoks = new List<Emlosok>();
            emlosoks.Add(new Macska("Cirmi", 4.2,"kandúr"));
            emlosoks.Add(new Kutya("Bodri", 10.2,"kan"));
            emlosoks.Add(new Macska("Szerénke",1.3,""));

            foreach (var item in emlosoks)
            {
                Console.WriteLine($"{item} - {item.faj}");
            }



            Console.ReadKey();

        }
    }
}
