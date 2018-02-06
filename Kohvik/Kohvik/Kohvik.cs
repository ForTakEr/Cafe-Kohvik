using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kohvik
{
    class Kohvik
    {
        Klient klient;
        List<Ostetud> Kohvid;
        List<Ostetud> Toidud;

        public void Kohv()
        {
            Kohvid = new List<Ostetud>();

            Kohvid.Add(new Espresso());
            Kohvid.Add(new Latte());
            Kohvid.Add(new Cappucino());
            Kohvid.Add(new Must_kohv());
        }



    }
}
