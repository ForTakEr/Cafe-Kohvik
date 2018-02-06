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
            Kohvid = new List<Ostetud>
            {
                new Espresso(),
                new Latte(),
                new Cappucino(),
                new Must_kohv()
            };
        }

        public void Toit()
        {
            Toidud = new List<Ostetud>()
            {
                new Kook(),
                new Salat(),
                new Praad()
            };
        }

        public Kohvik()
        {
            Kohv();
            Toit();

            klient = new Klient();
        }

        public void RahaOlemas()
        {
            while (true)
            {
                double Olemas;

                Console.Clear();

                Console.WriteLine("Kui palju teil raha kaasas on?");

                try
                {
                    Olemas = int.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Võimalik on ainult arve sisestada");
                    Console.WriteLine();
                    continue;
                }

                klient.Raha = Olemas;

                Console.Clear();

                return;
            }
        }

        public void Tellimus(List<Ostetud> OstetudList)
        {
            while (true)
            {
                int Sisend;
                int k;

                for (k = 0; k < OstetudList.Count; k++)
                {
                    OstetudList[k].OstuNimekiri(k);
                }
                Console.WriteLine((k + 1) + ". Tagasi");
                Console.WriteLine();
                klient.Money();

                try
                {
                    Sisend = int.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Peate valima numbri");
                    continue;
                }

                Console.Clear();

                if (Sisend == (k +1))
                {
                    return;
                }

                if (Sisend > 0 && Sisend <= OstetudList.Count +1)
                {
                    Ostetud hetkeTellimus = OstetudList[Sisend - 1];

                    if (klient.Raha < hetkeTellimus.Hind)
                    {
                        Console.WriteLine("Teil ei ole piisavalt raha, et seda tellida");
                    }
                    else
                    {
                        hetkeTellimus.Ost(klient);
                    }
                }

                else
                {
                    Console.WriteLine("Sellist numbrit pole");
                }
                Console.WriteLine();
            }
        }

        public void Käima()
        {
            RahaOlemas();

            while (true)
            {
                Console.WriteLine("1. Telli kohvi\n" +
                    "2. Telli toitu\n" +
                    "3. Tellitud asjad\n" +
                    "4. Lahkumine");
                Console.WriteLine();
                klient.Money();

                string cmd = Console.ReadLine();

                Console.Clear();

                switch (cmd)
                {
                    case "1":
                        Tellimus(Kohvid);
                        break;
                    case "2":
                        Tellimus(Toidud);
                        break;
                    case "3":
                        klient.OstetudAsjadeList();
                        break;
                    case "4":
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Käsklus puudub");
                        Console.WriteLine();
                        break;
                }
            }
        }

    }
}
