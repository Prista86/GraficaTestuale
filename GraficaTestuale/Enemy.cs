using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraficaTestuale
{
    class Enemy
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public double PuntiVita { get; set; }
        public double DannoArma { get; set; }
        public int Loot { get; set; }
        public double Difesa { get; set; }
        public double Attacco { get; set; }
        public int Pozioni { get; set; }
        public int DannoArrotondato { get; set; }

        public void Attack(Player player)
        {
            double danno;
            danno = (this.Attacco / player.Difesa) * this.DannoArma;
            this.DannoArrotondato = (int)Math.Round(danno);
            player.PuntiVita -= this.DannoArrotondato;
        }
        public void Heal()
        {
            this.PuntiVita += 25;
            this.Pozioni--;
        }
    }
}
