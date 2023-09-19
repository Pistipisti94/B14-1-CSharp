using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Macska : Emlosok
    {
        public Macska(string neve, double suly, string nem) : base(neve,"szisza", 4, suly, nem, "miaú")
        {
        }
    }
}
