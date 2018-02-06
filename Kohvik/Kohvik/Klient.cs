using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kohvik
{
    class Klient
    {
        public double Raha = 10.0;
        public List<Ostetud> OstetudAsjad = new List<Ostetud>();

        public void Money()
        {
            Console.WriteLine("Teil on: " + Raha + "€");
        }

        public void OstetudAsjadeList()
        {
            if (OstetudAsjad.Count == 0)
            {
                Console.WriteLine("Te pole veel midagi tellinud");
                Console.WriteLine();
                return;
            }

            Console.WriteLine("Teil on tellitud järgmised: ");
            Console.WriteLine();

            foreach (Ostetud ost in OstetudAsjad)
            {
                Console.WriteLine(ost.Nimi);
            }
            Console.WriteLine();
        }
    }
}
