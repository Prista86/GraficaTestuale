using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraficaTestuale
{
    class Player
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

        public double DannoArrotondato { get; set; }


       

        double danno;
        
        


        public void Attack(Enemy[] enemies,int idMostro) {
            danno = (this.Attacco / enemies[idMostro].Difesa) *this.DannoArma;
            this.DannoArrotondato = (int)Math.Round(danno);
            enemies[idMostro].PuntiVita -= this.DannoArrotondato;
        }
        public void DefenseStance()
        {

        }
        public void MagicAttack (Enemy[] enemies, int IdMostro)
        {
            danno = (this.AttaccoM / enemies[0].Difesa) * this.DannoMagico;
            this.DannoArrotondato = (int)Math.Round(danno);
            enemies[IdMostro].PuntiVita -=this.DannoArrotondato;
        }
        public void Heal() {
            this.PuntiVita +=60;
            this.Pozioni--;

        }
       

        public void VediEquip()
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("Al momento sei equipaggiato con:");            
            Console.WriteLine("Arma: " + this.Arma);
            Console.WriteLine("Armatura: " + this.Armatura);
            Console.WriteLine("Scudo: " + this.Scudo);
            Console.WriteLine("Magia: " + this.Magia);
            Console.WriteLine("Pozioni: " + this.Pozioni);
            Console.WriteLine();
            Console.WriteLine("Le tue statistiche:");
            Console.WriteLine("Punti Vita: " + this.PuntiVita);
            Console.WriteLine("Danno Arma: " + this.DannoArma);
            Console.WriteLine("Danno Magico: " + this.DannoMagico);
            Console.WriteLine("Attacco: " + this.Attacco);
            Console.WriteLine("Attacco magico: " + this.AttaccoM);
            Console.WriteLine("Difesa: " + this.Difesa);
            Console.WriteLine("Hai nel borsello: " + this.Oro + " monete d'oro");
            Console.WriteLine("'Invio'");
            Console.ReadKey();
        }

    }
}
