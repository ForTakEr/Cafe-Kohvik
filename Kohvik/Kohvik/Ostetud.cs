using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kohvik
{
    class Ostetud
    {
        public string Nimi;
        public double Hind;

        public virtual void Ost(Klient klient)
        {
            Console.WriteLine("Te tellisite " + Nimi);
            klient.Raha -= Hind;
            klient.OstetudAsjad.Add(this);
        }

        public void OstuNimekiri(int count)
        {
            Console.WriteLine((count + 1) + ". " + Nimi + " - " + Hind + "€");
        }
    }
}
