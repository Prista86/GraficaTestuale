﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraficaTestuale
{
    internal class Player
    {
        public string Name { get; set; }
        public int HealthPoints { get; set; }
        public int Damage { get; set; }
        public int Gold { get; set; }
        public string Armatura { get; set; }
        public string Arma { get; set; }
        public int Difesa { get; set; }


        public void Attack() { }
        public void Heal () { }

        public void VediEquip()
        {
            Console.WriteLine("Al momento sei equipaggiato con:");
            Console.WriteLine("Armatura: " + this.Armatura);
            Console.WriteLine("Arma: " + this.Arma);
            Console.WriteLine("Come statistiche sei cosi messo:");
            Console.WriteLine("PV: "+this.HealthPoints);
            Console.WriteLine("Atk: "+ this.Damage);
            Console.WriteLine("Def:" + this.Difesa);
            Console.WriteLine("Hai nel borsello: " + this.Gold + " monete d'oro");
        }

    }
}
