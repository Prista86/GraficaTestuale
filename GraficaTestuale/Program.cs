using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
         esercizio cattivo per sadomasochisti ]:-)
            - creare un gioco di ruolo tesuale con:
                - classe Player con:
                    - properties:
                        - string Name
                        - int HealthPoints (HP)
                        - int Damage
                        - int Gold
                    - metodi:
                        - Attack() per attaccare i nemici
                        - Heal() per guarirsi di una certa quantità di HP
                - classe Enemy con:
                    - properties:
                        - string Name
                        - int HealthPoints (HP)
                        - int Damage
                        - int Loot
                    - metodi:
                        - Attack() per attaccare il giocatore
                        - opzionale: Heal() per guarirsi di una certa quantità di HP
            - simulare delle battaglie tra l'oggetto di tipo Player
            e vari oggetti di tipo Enemy
            - quando il giocatore o un nemico viene colpito, perde una
            quantità di HP pari al Damage dell'attaccante, e quando i suoi
            HP arrivano a 0 muore
            - quando un nemico muore, lascia una ricompensa al giocatore
            pari al suo Loot, che viene aggiunto al Gold del giocatore
            - opzionali:
                - implementare eventuali altre interazioni tra Player e Enemy
                quali fuga dalla battaglia, incantesimi, diversi tipi di armi,
                armature
                - dopo ogni battaglia dare la possibilità al Player di comprare
                nuove armi o aumentare le proprie statistiche
                - decidere le condizioni finali di vittoria, quali un tot di
                Gold da raggiungere, un tot di nemici da uccidere, uno specifico
                nemico da uccidere
         */

namespace GraficaTestuale
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player();
            player.Name = "Luca";
            player.HealthPotions = 10;
            player.Damamage = 10;
            player.Gold = 100;

            string[] EnemyName = new string[3];
            int [] EnemyHealtP = new int[3];
            int [] EnemyDamage = new int[3];
            int[] EnemyLoot = new int[3];
            for (int i = 0; i < 3; i++)
            {
                Enemy enemy = new Enemy();
                enemy.Name = "Enemy"+i;
                EnemyName[i] = enemy.Name;
                enemy.HealthPotions = 10;
                EnemyHealtP[i] = enemy.HealthPotions;
                enemy.Damamage = 5;
                EnemyDamage[i] = enemy.Damamage;
                enemy.Loot = 10;
                EnemyLoot[i] = enemy.Loot;
            }
            Console.WriteLine("Benvenuto nel mio primo gdr testuale!");
            Console.WriteLine("Quale è il tuo Nome coraggioso eroe?!!!");
            player.Name = Console.ReadLine();

            Console.WriteLine("Ottimo"+player.Name+" !!! Indubbiamente sarai destinato a grandiosi atti eroici!!!");
            Console.ReadKey();
            Console.WriteLine("Oh!! Sei appena stato convocato dal Re Maccio per una nuova avventura!!");
            Console.WriteLine("Vuoi andare? 'digita S o N'");
            string scelta = Console.ReadLine();
            if (scelta == "S")
            {

            }
            else
            {
                Console.WriteLine("Va bene ci sta che tu possa avere paura...");
                Console.WriteLine("Mentra passeggi per il villaggio ti viene sete, decidi di abbeverarti al pozzo.");
                Console.WriteLine("Quando cerchi di spogerti per tirare su il secchio scivoli e preciti giù per il pozzo...");
                Console.WriteLine("SEI MORTO");
                Console.ReadKey();
            }


        }
    }
}
