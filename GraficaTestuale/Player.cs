using System;
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
        public int MagicDamage { get; set; }
        public int Gold { get; set; }
        public string Armatura { get; set; }
        public string Arma { get; set; }
        public string Magia { get; set; }
        public int Difesa { get; set; }
        public int Potion { get; set; }
        public int HighPotion { get; set; }


        public void Attack() { }
        public void Heal() { }

        public void VediEquip()
        {
            Console.WriteLine("Al momento sei equipaggiato con:");
            Console.WriteLine("Armatura: " + this.Armatura);
            Console.WriteLine("Arma: " + this.Arma);
            Console.WriteLine("Magia: " + this.Magia);
            Console.WriteLine("Pozioni: " + this.Potion);
            Console.WriteLine("MegaPozioni"+this.HighPotion);
            Console.WriteLine();
            Console.WriteLine("Come statistiche sei cosi messo:");
            Console.WriteLine("PV: " + this.HealthPoints);
            Console.WriteLine("Atk: " + this.Damage);
            Console.WriteLine("Magic Atk: " + this.MagicDamage);
            Console.WriteLine("Def:" + this.Difesa);
            Console.WriteLine("Hai nel borsello: " + this.Gold + " monete d'oro");
            Console.ReadKey();
        }

    }
}
