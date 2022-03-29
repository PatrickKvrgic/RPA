﻿using System;
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
            var x1 = from a in context.DOBAVITELJ
                     select a;
            //var x1 = context.DOBAVITELJ.Select(e => e); //isto
            foreach(var y in x1)
            {
                Console.WriteLine(y.D_IME + " " + y.D_KONTAKT);
            }
            Console.ReadLine();
        }
    }
}
