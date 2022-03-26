using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraficaTestuale
{
    internal class Enemy
    {
        public int id { get; set; }
        public string Name { get; set; }
        public int HealthPoints { get; set; }
        public int Damage { get; set; }
        public int Loot { get; set; }
        public int Difesa { get; set; }

        public void Attack() { }
        public void Heal() { }
    }

}
