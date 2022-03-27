using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraficaTestuale
{
    internal class Enemy
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public double PuntiVita { get; set; }
        public double DannoArma { get; set; }
        public double Loot { get; set; }
        public double Difesa { get; set; }
        public double Attacco  { get; set; }
        public int Pozioni { get; set; }

        public void Attack(Player player) {
            double danno;
            int arrotondo;
            danno = (this.Attacco / player.Difesa) * this.DannoArma;
            arrotondo = (int)Math.Round(danno);
            player.PuntiVita -=arrotondo;
        }
        public void Heal() {
            this.PuntiVita +=40;
            this.Pozioni--;
        }
    }

}
