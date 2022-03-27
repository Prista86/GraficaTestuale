using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraficaTestuale
{
    internal class Player
    {
        public string Nome { get; set; }
        public double PuntiVita { get; set; }
        public int DannoArma { get; set; }
        public int DannoMagico { get; set; }
        public int Oro{ get; set; }
        public string Armatura { get; set; }
        public string Scudo { get; set; }
        public string Arma { get; set; }
        public string Magia { get; set; }
        public double Difesa { get; set; }
        public double Attacco { get; set; }

        public double AttaccoM { get; set; }
        public int Pozioni { get; set; }

        double danno=0;
        int arrotondo=0;
        int idMostro = 0;
        


        public void Attack(Enemy[] enemies) {
            danno = (this.Attacco / enemies[idMostro].Difesa) *this.DannoArma;
            arrotondo = (int)Math.Round(danno);
            enemies[idMostro].PuntiVita = enemies[idMostro].PuntiVita - arrotondo;
        }
        public void MagicAttack (Enemy[] enemies)
        {
            danno = (this.AttaccoM / enemies[idMostro].Difesa) * this.DannoMagico;
            arrotondo = (int)Math.Round(danno);
            enemies[idMostro].PuntiVita = enemies[idMostro].PuntiVita - arrotondo;
        }
        public void Heal() {
            this.PuntiVita +=20;
            this.Pozioni--;

        }
       

        public void VediEquip()
        {
            Console.WriteLine();
            Console.WriteLine("Al momento sei equipaggiato con:");            
            Console.WriteLine("Arma: " + this.Arma);
            Console.WriteLine("Armatura: " + this.Armatura);
            Console.WriteLine("Scudo: " + this.Scudo);
            Console.WriteLine("Magia: " + this.Magia);
            Console.WriteLine("Pozioni: " + this.Pozioni);
            Console.WriteLine();
            Console.WriteLine("Come statistiche sei cosi messo:");
            Console.WriteLine("Punti Vita: " + this.PuntiVita);
            Console.WriteLine("Danno Arma: " + this.DannoArma);
            Console.WriteLine("Danno Magico: " + this.DannoMagico);
            Console.WriteLine("Attacco:" + this.Attacco);
            Console.WriteLine("Difesa:" + this.Difesa);

            Console.WriteLine("Hai nel borsello: " + this.Oro + " monete d'oro");
            Console.ReadKey();
        }

    }
}
