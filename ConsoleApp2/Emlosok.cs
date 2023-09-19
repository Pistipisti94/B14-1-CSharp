using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Emlosok
    {
        public string neve;
        public string faj;
        public int labakszama;
        public double suly;
        public string nem;
        string hang;

        public String getHangotAd() {
            return hang;
        }
        public void setHangotAd(string hang)
        {
            this.hang = hang;
        }
        public String halad()
        {
            return "előre";
        }
        public override string ToString()
        {
            return this.neve;
        }

        public Emlosok(string neve, string faj, int labakszama, double suly, string nem, string hang)
        {
            this.neve = neve;
            this.faj = faj;
            this.labakszama = labakszama;
            this.suly = suly;
            this.nem = nem;
            this.hang = hang;
        }
    }
}
