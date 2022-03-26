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
        public string Nome { get; set; }
        public double PuntiVita { get; set; }
        public int DannoArma { get; set; }
        public int Loot { get; set; }
        public double Difesa { get; set; }
        public int Attacco  { get; set; }
        public int Pozioni { get; set; }

        public void Attack() { }
        public void Heal() { }
    }

}
