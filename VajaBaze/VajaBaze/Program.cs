using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VajaBaze
{
    class Program
    {
        static void Main(string[] args)
        {
            BazaZaVajeEntities context = new BazaZaVajeEntities();
            //vsi dobavitelji
            Console.WriteLine("VSI DOBAVITELJI");
            var x1 = from a in context.DOBAVITELJ
                     select a;
            //var x1 = context.DOBAVITELJ.Select(e => e); //isto
            foreach(var y in x1)
            {
                Console.WriteLine(y.D_IME + " " + y.D_KONTAKT);
            }
            Console.ReadLine();
            Console.Clear();

            //a.izberi P_OPIS, P_ZALOGA, P_MIN, P_CENA iz tabele PRODUKT, kjer je P_DATUM manjši od
            //20.jan. 2004
            Console.WriteLine("NALOGA A");
            DateTime datum = DateTime.Parse("20.1.2004");
            var x2 = from a in context.PRODUKT
                     where a.P_DATUM < datum
                     select new { Opis = a.P_OPIS, Zaloga = a.P_ZALOGA, MinZaloga = a.P_MIN, Cena = a.P_CENA };
            foreach(var y in x2)
            {
                Console.WriteLine(y.Opis + " " + y.Cena);
            }
            Console.ReadLine();
            Console.Clear();

            //b.izberi P_OPIS, P_ZALOGA, P_DATUM in današnjidatum + 365 naj se imenuje ZAPADLOST iz
            //tabele PRODUKT
            Console.WriteLine("NALOGA B");
            DateTime danes = DateTime.Now;
            danes = danes.AddDays(365);
            var x3 = from a in context.PRODUKT
                     select new { Opis = a.P_OPIS, Zaloga = a.P_ZALOGA, MinZaloga = a.P_MIN,
                         Cena = a.P_CENA, Zapadlost = danes };
            foreach (var y in x3)
            {
                Console.WriteLine(y.Opis + " " + y.Zapadlost);
            }
            Console.ReadLine();
            Console.Clear();

            //c.izberi P_OPIS, P_ZALOGA, P_MIN, P_CENA iz tabele PRODUKT, kjer je P_CENA manjša od 50 in
            //je P_DATUM večji kot 15.jan. 2004
            Console.WriteLine("NALOGA C");
            DateTime datum1 = DateTime.Parse("15.1.2004");
            var x4 = from a in context.PRODUKT
                     where a.P_CENA < 50 && a.P_DATUM > datum1
                     select new {Opis = a.P_OPIS, Zaloga = a.P_ZALOGA, MinZaloga = a.P_MIN,
                         Cena = a.P_CENA, Datum = a.P_DATUM  };
            foreach (var y in x4)
            {
                Console.WriteLine(y.Cena + " " + y.Datum);
            }
            Console.ReadLine();
            Console.Clear();

            //d.izberi vse atribute iz tabele DOBAVITELJ katerih ime se začne s Smith
            Console.WriteLine("NALOGA D");
            var x5 = from a in context.DOBAVITELJ
                     where a.D_KONTAKT.StartsWith("Smith")
                     select a;
            foreach(var y in x5)
            {
                Console.WriteLine(y.D_KONTAKT);
            }
            Console.ReadLine();
            Console.Clear();

            //e.izberi vse dobavitelje, kjer je zaloga v produktu manjša od dvakratnika minimalne zaloge


            //f.izberi D_KODA od dobaviteljev, ki so nam že dobavili katerega izmed produktov.Vsak
            //dobavitelj naj bo v rešitvi samo enkrat
            Console.WriteLine("NALOGA F");
            var x7 = (from a in context.PRODUKT
                     select a.D_KODA).Distinct();
            foreach (var y in x7)
            {
                Console.WriteLine(y);
            }
            Console.ReadLine();
            Console.Clear();

            //g.izberi kodo in ime dobavitelja, ki nam še niso ničesar dobavili(njihova koda se ne pojavlja v
            //tabeli PRODUKT)
            Console.WriteLine("NALOGA G");
            var x8 = context.DOBAVITELJ.Where(e => !x7.Any(p => p == e.D_KODA));
            foreach (var y in x8)
            {
                Console.WriteLine(y.D_KODA);
            }
            Console.ReadLine();
            Console.Clear();

            //h.izpiši vsoto vseh stanj pri kupcih(KUP_STANJE) (2089, 28)
            Console.WriteLine("NALOGA H");
            var x9 = context.KUPEC.Sum(e => e.KUP_STANJE);
            //var x9 = (from a in context.KUPEC
            //          select a.KUP_STANJE).SUM();
            Console.WriteLine(x9);
            Console.ReadLine();
            Console.Clear();

            //i.izračunaj celotno vrednost blaga na zalogi(15.084,52€)


            //j.izpiši število različnih produktov posameznega dobavitelja po posameznem dobavitelju iz
            //tabele produkt(rešitev ima 6 vrstic, če izključimo dobavitelja null) 

            Console.ReadLine();
        }
    }
}
