using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;


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
            player.HealthPoints = 10;
            player.Damamage = 10;
            player.Gold = 10;
            player.Armatura = "Sacco di patate";
            player.Arma = "Spada arruginita spezzata e storta";
            player.Difesa = 10;
            int ToccaA = 0;
            string scelta = "S";

            string[] EnemyName = new string[3];
            int[] EnemyHealtPoints = new int[3];
            int[] EnemyDamage = new int[3];
            int[] EnemyLoot = new int[3];
            for (int i = 0; i < 3; i++)
            {
                Enemy enemy = new Enemy();
                enemy.Name = "Enemy" + i;
                EnemyName[i] = enemy.Name;
                enemy.HealthPoints = 10;
                EnemyHealtPoints[i] = enemy.HealthPoints;
                enemy.Damamage = 5;
                EnemyDamage[i] = enemy.Damamage;
                enemy.Loot = 10;
                EnemyLoot[i] = enemy.Loot;
            }
            Console.WriteLine("Benvenuto nel mio primo gdr testuale!");
            Console.WriteLine("Quale è il tuo Nome coraggioso eroe?!!!");
            player.Name = Console.ReadLine();

            Console.WriteLine("Ottimo " + player.Name + " !!! Indubbiamente sarai destinato a grandiosi atti eroici!!!");
            Console.ReadKey();
            Console.WriteLine("Oh!! Sei appena stato convocato dal Re Maccio per una nuova avventura!!");
            Console.WriteLine("Vuoi andare? 'digita S o N'");
            //scelta = Console.ReadLine();
            if (scelta == "S")                                                                                        //convocazione di Re Maccio
            {
                Console.WriteLine("Bene non sei un coniglio!");
                Console.WriteLine(" Dopo averlo atteso 2 ore");
                //for (int i = 0; i < 2; i++)
                //{
                //    Thread.Sleep(500);
                //    Console.Write(".");
                //}
                Console.WriteLine("'Questa attesa serve per immergerti ancora di più nella storia...'");
                Console.ReadKey();
                Console.WriteLine("...in breve il Re ha notato che questa mattina non si è presentata a colazione la sua figlia principessina!!!");
                Console.WriteLine("Lui è convinto chesia stato il drago a rapirla e ti chiede se hai voglia di andare a recuperarla nella sua tana.");
                Console.WriteLine("Ti andrebbe?");
                //scelta = Console.ReadLine();
                if (scelta == "S")                                                                                               // Andare a salvare la principessa?
                {
                    Console.WriteLine("Bene sei coraggioso!!! Ora però è ora di cena quindi andate a mangiare!!! Partirai domani mattina dopo una bella dormita! Tanto la grotta dista solo mezzoretta di strada!");
                    Console.ReadKey();
                    Console.WriteLine("'Cena time...'");
                    Console.ReadKey();
                    Console.WriteLine("..zZz..' Dormita time'");
                    Console.ReadKey();
                    Console.WriteLine("Ottimo sei riposato e rifocillato con una ottima colazione vegana a base di pane e acqua!!! Sei proprio pronto per partire!");
                    Console.WriteLine("Prima di partire vuoi per caso passare dal negozio ad acquistare qualcosa per il viaggio?");
                    //scelta = Console.ReadLine();
                    if (scelta == "S")                                                                                       //Negozio??
                    {
                        Console.WriteLine("Mi dispiace è chiuso. 'No non è vero non ho ancora avuto voglia di programmare pure il negozio. Ti terrai i tuoi vestiti da straccione, il tuo scudo bucato e la tua spada storta. ;)'");
                        Console.ReadKey();
                    }
                    else
                    {
                        Console.WriteLine("Grande sei fortissimo già cosi come sei!'No non è vero, non sei assolutamente preparato per nulla, neanhe per andare a fare la spesa al conad'");
                        Console.ReadKey();
                    }
                    Console.WriteLine();
                    Console.WriteLine("Grandioso!!! Stai per intraprendere la tua prima avventura!! quindi è giusto vedere come sei 'messo'");
                    player.VediEquip();
                    Console.ReadKey();
                    Console.WriteLine("Ora puoi veramente partire verso la tana del drago che puoi già vedere in lontananza in cima alla collina!");
                    Console.ReadKey();
                    Console.WriteLine("Oh nooo!! mentre passeggi per il sentiero appena uscito dal villaggio incontri un tizio poco promettente incappucciato e leggermente gobbo... ");
                    Console.WriteLine("Attenzione è un bandito e ti vuole derubare!!!' che cosa poi? non lo sa che sei uno straccione -.-'? '");
                    Console.WriteLine("Hai capito che ti vuole attaccare ma è ancora lontano... vuoi attaccarlo per primo?");
                    //scelta = Console.ReadLine();
                    if (scelta == "S")
                    {
                        ToccaA = 0;
                    }
                    else
                    {
                        ToccaA = 1;
                    }

                    while (EnemyHealtPoints[0] >= 0)
                    {
                        if (ToccaA == 0)
                        {
                            Console.WriteLine(@" _______________________________________________________________________________________________________________");
                            Console.WriteLine(@"|                                                                                                               |");
                            Console.WriteLine(@"|         ------------                                           _____                                          |");
                            Console.WriteLine(@"|        | Giocatore1 |                                      .-,;='';_),-.                                      |");
                            Console.WriteLine(@"|        | PV: " + player.HealthPoints + @"     |                                       \_\(),()/_/                                       |  ");
                            Console.WriteLine(@"|        | Atk: " + player.Damamage + @"    |                                         (,___,)                                         |  ");
                            Console.WriteLine(@"|        | Def: " + player.Difesa + @"    |                                        ,-/`~`\-,___                                     |");
                            Console.WriteLine(@"|         ------------                                        / /).:.('--._)                                    |");
                            Console.WriteLine(@"|                                                            {_[ (_,_)                                          |");
                            Console.WriteLine(@"|              .=.,                                              | Y |                                          |");
                            Console.WriteLine(@"|             ;c =\                                             /  |  \                                         |");
                            Console.WriteLine(@"|          __ | _ /                                                                                             |");
                            Console.WriteLine(@"|        .'-'-._ /-'-._                                    ------------                                         |");
                            Console.WriteLine(@"|       / ..           \                                  | Giocatore1 |                                        |");
                            Console.WriteLine(@"|      / ' _   	   )   \                                  | PV: " + player.HealthPoints + @"     |                                        |");
                            Console.WriteLine(@"|     (  / \--   --/'._  )                                | Atk: " + player.Damamage + @"    |                                        |");
                            Console.WriteLine(@"|      \-;_/\__;__/ _/ _/                                 | Def: " + player.Difesa + @"    |                                        |");
                            Console.WriteLine(@"|       '._}|==o==\{_\/                                    ------------                                         |");
                            Console.WriteLine(@"|        /  /-._.--\ \_                                                                                         |");
                            Console.WriteLine(@"|       // /   /|   \ \ \                                                                                       |");
                            Console.WriteLine(@"|      / | |   | \;  |  \ \                                                                                     |");
                            Console.WriteLine(@"|     / /  | :/   \: \   \_\                                                                                    |");
                            Console.WriteLine(@"|    /  |  /.'|   /: |    \ \                                                                                   |");
                            Console.WriteLine(@"|    |  |  |--| . |--|     \_\                                                                                  |");
                            Console.WriteLine(@"|   / _ /   \ | : | /___--._) \                                                                                 |");
                            Console.WriteLine(@"|  |_(---'-| >-'-| |       '-'                                                                                  |");
                            Console.WriteLine(@"|           /_ /  \_\                                                                                           |");


                            Console.WriteLine(@" _______________________________________________________________________________________________________________");
                            Console.ReadKey();

                            ToccaA = 1;
                        }
                        else if (ToccaA == 1)
                        {


                            ToccaA = 0;
                        }
                    }




































                }
                else                                                                           // No salvare la principessa
                {
                    Console.WriteLine("Ok ci sta che tu sia un po' pigrotto..");
                    Console.WriteLine("Però il Re Maccio è un po dispiaciuto, quindi ti butta nel pozzo di prima.");
                    Console.WriteLine("SEI MORTO");
                    Console.ReadKey();
                    System.Environment.Exit(0);
                }

            }
            else                                                                                   // No convocazione da Re Maccio
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
