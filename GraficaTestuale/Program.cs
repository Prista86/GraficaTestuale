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
                        - int PuntiVita (HP)
                        - int DannoArma
                        - int Oro
                    - metodi:
                        - Attack() per attaccare i nemici
                        - Heal() per guarirsi di una certa quantità di HP
                - classe Enemy con:
                    - properties:
                        - string Name
                        - int PuntiVita (HP)
                        - int DannoArma
                        - int Loot
                    - metodi:
                        - Attack() per attaccare il giocatore
                        - opzionale: Heal() per guarirsi di una certa quantità di HP
            - simulare delle battaglie tra l'oggetto di tipo Player
            e vari oggetti di tipo Enemy
            - quando il giocatore o un nemico viene colpito, perde una
            quantità di HP pari al DannoArma dell'attaccante, e quando i suoi
            HP arrivano a 0 muore
            - quando un nemico muore, lascia una ricompensa al giocatore
            pari al suo Loot, che viene aggiunto al Oro del giocatore
            - opzionali:
                - implementare eventuali altre interazioni tra Player e Enemy
                quali fuga dalla battaglia, incantesimi, diversi tipi di armi,
                armature
                - dopo ogni battaglia dare la possibilità al Player di comprare
                nuove armi o aumentare le proprie statistiche
                - decidere le condizioni finali di vittoria, quali un tot di
                Oro da raggiungere, un tot di nemici da uccidere, uno specifico
                nemico da uccidere
         */

namespace GraficaTestuale
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string Scelta = "S";
            int ToccaA = 0;
            int idMostro = 0;

            string AzioneEnemySpiegaz = "";


            Player player = new Player();
            player.Nome = "Luca";
            player.PuntiVita = 100;
            player.Attacco = 100;
            player.AttaccoM = 0;
            player.Difesa = 70;
            player.DannoArma = 15;
            player.DannoMagico = 0;
            player.Oro = 1;
            player.Arma = "Spada brutta";
            player.Armatura = "Sacco di patate puzzolente";
            player.Scudo = "";
            player.Magia = "Non conosci nulla";
            player.Pozioni = 3;




            Enemy[] enemies = new Enemy[3];

            for (int i = 0; i < 3; i++)
            {
                Enemy enemy = new Enemy();
                enemy.id = i;
                enemy.Nome = "Enemy" + i;
                enemy.PuntiVita = 200;
                enemy.Attacco = 100;
                enemy.Difesa = 70;
                enemy.DannoArma = 5;
                enemy.Loot = 10;

                enemies[i] = enemy;
            }

            Console.WriteLine("Benvenuto nel mio primo gdr testuale!");
            //Console.WriteLine("Quale è il tuo Nome coraggioso eroe?!!!");
            //player.Name = Console.ReadLine();

            Console.WriteLine("Ottimo " + player.Nome + " !!! Indubbiamente sarai destinato a grandiosi atti eroici!!!");
            //Console.ReadKey();
            Console.WriteLine("Oh!! Sei appena stato convocato dal Re Maccio per una nuova avventura!!");
            Console.WriteLine("Vuoi andare? 'digita S o N'");
            Scelta = "S";
            //Scelta = Console.ReadLine();
            if (Scelta == "S")                                                                                        //convocazione di Re Maccio
            {
                Console.WriteLine("Bene non sei un coniglio!");
                Console.WriteLine(" Dopo averlo atteso 2 ore");
                //for (int i = 0; i < 2; i++)
                //{
                //    Thread.Sleep(500);
                //    Console.Write(".");
                //}
                Console.WriteLine("'Questa attesa serve per immergerti ancora di più nella storia...'");
                //Console.ReadKey();
                Console.WriteLine("...in breve il Re ha notato che questa mattina non si è presentata a colazione la sua figlia principessina!!!");
                Console.WriteLine("Lui è convinto chesia stato il drago a rapirla e ti chiede se hai voglia di andare a recuperarla nella sua tana.");
                Console.WriteLine("Ti andrebbe?");
                Scelta = "S";
                //Scelta = Console.ReadLine();
                if (Scelta == "S")                                                                                               // Andare a salvare la principessa?
                {
                    Console.WriteLine("Bene sei coraggioso!!! Ora però è ora di cena quindi andate a mangiare!!! Partirai domani mattina dopo una bella dormita! Tanto la grotta dista solo mezzoretta di strada!");
                    //Console.ReadKey();
                    Console.WriteLine("'Cena time...'");
                    //Console.ReadKey();
                    Console.WriteLine("..zZz..' Dormita time'");
                    //Console.ReadKey();
                    Console.WriteLine("Ottimo sei riposato e rifocillato con una ottima colazione vegana a base di pane e acqua!!! Sei proprio pronto per partire!");
                    //Console.WriteLine("Prima di partire vuoi per caso passare dal negozio ad acquistare qualcosa per il viaggio?");

                    //Scelta = "S";
                    //Scelta = Console.ReadLine();
                    //if (Scelta == "S")                                                                                       //Negozio??
                    //{
                    //    Negozio(player);
                    //}
                    //else
                    //{
                    //    Console.WriteLine("Grande sei fortissimo già cosi come sei!'No non è vero, non sei assolutamente preparato per nulla, neanche per andare a fare la spesa al conad'");
                    //    Console.ReadKey();
                    //}
                    //Console.WriteLine();
                    //Console.WriteLine("Grandioso!!! Stai per intraprendere la tua prima avventura!! quindi è giusto vedere 'come sei messo'");
                    //player.VediEquip();

                    Console.WriteLine("Ora puoi veramente partire verso la tana del drago che puoi già vedere in lontananza in cima alla collina!");
                    //Console.ReadKey();
                    Console.WriteLine("Oh nooo!! mentre passeggi per il sentiero appena uscito dal villaggio incontri un tizio poco promettente incappucciato e leggermente gobbo... ");
                    Console.WriteLine("Attenzione è un bandito e ti vuole derubare!!!' che cosa poi? non lo sa che sei uno straccione -.-'? '");
                    Console.WriteLine("Hai capito che ti vuole attaccare ma è ancora lontano... vuoi attaccarlo per primo?");
                    Scelta = "S";
                    //Scelta = Console.ReadLine();
                    if (Scelta == "S")
                    {
                        ToccaA = 0;
                    }
                    else
                    {
                        ToccaA = 1;
                    }

                    idMostro = 0;
                    Combattimento(enemies, player, idMostro, ToccaA, AzioneEnemySpiegaz);
                    Console.WriteLine("Bravo è stata dura ma sei riuscito a salvare la pellaccia!!! ");
                    Console.WriteLine("Ora che sei pieno di Cash$ vuoi tornare in negozio e prepararti come si deve???");
                    Scelta = "S";
                    //Scelta = Console.ReadLine();
                    if (Scelta == "S")
                    {
                        Negozio(player);
                        player.VediEquip();
                    }
                    else
                    {
                        Console.WriteLine("Va bene ma potresti, forse , trovare qualche difficoltà in più...");
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
        static void GrigliaCombattimentoTurnoGiocatore(Enemy[] enemies, Player player, int idMostro)
        {
            Console.WriteLine(@" ______________________________________________________________________________________");
            Console.WriteLine(@"|                                                                                      |");
            Console.WriteLine(@"|            ------------                                           _____              |");
            Console.WriteLine(@"|           | Giocatore1 |                                      .-,;='';_),-.          |");
            Console.WriteLine(@"|           | PV: " + player.PuntiVita + @"     |                                       \_\(),()/_/           |  ");
            Console.WriteLine(@"|           | Atk: " + player.Attacco + @"     |                                         (,___,)             |  ");
            Console.WriteLine(@"|           | Def: " + player.Difesa + @"    |                                        ,-/`~`\-,___         |");
            Console.WriteLine(@"|            ------------                                        / /).:.('--._)        |");
            Console.WriteLine(@"|                                                               {_[ (_,_)              |");
            Console.WriteLine(@"|                 .=.,                                              | Y |              |");
            Console.WriteLine(@"|                ;c =\                                             /  |  \             |");
            Console.WriteLine(@"|             __ | _ /                                                                 |");
            Console.WriteLine(@"|           .'-'-._ /-'-._                                      ------------           |");
            Console.WriteLine(@"|          / ..           \                                    |   Bandito  |          |");
            Console.WriteLine(@"|         / ' _        )   \                                   | PV: " + enemies[idMostro].PuntiVita + @"     |          |");
            Console.WriteLine(@"|        (  / \--   --/'._  )                                  | Atk: " + enemies[idMostro].DannoArma + @"     |          |");
            Console.WriteLine(@"|         \-;_/\__;__/ _/ _/                                   | Def: " + enemies[idMostro].Difesa + @"     |          |");
            Console.WriteLine(@"|          '._}|==o==\{_\/                                      ------------           |");
            Console.WriteLine(@"|           /  /-._.--\ \_                 ____________________________________________|");
            Console.WriteLine(@"|          // /   /|   \ \ \              |                                            |");
            Console.WriteLine(@"|         / | |   | \;  |  \ \            | TOCCA A TE!!                               | ");
            Console.WriteLine(@"|        / /  | :/   \: \   \_\           |                                            |");
            Console.WriteLine(@"|       /  |  /.'|   /: |    \ \          | 1. Attacca    2. Difenditi                 |");
            Console.WriteLine(@"|       |  |  |--| . |--|     \_\         | 3. Curati     4. Lancia incantesimo        |");
            Console.WriteLine(@"|      / _ /   \ | : | /___--._) \        | 5. Scappa come il coniglio che sei         |");
            Console.WriteLine(@"|     |_(---'-| >-'-| |       '-'         |                                            |");
            Console.WriteLine(@"|              /_ /  \_\                  |                                            |");
            Console.WriteLine(@"|_________________________________________|____________________________________________|");
            //Console.ReadKey();
        }
        static void GrigliaCombattimentoTurnoEnemy(Enemy[] enemies, Player player, int idMostro, string AzioneEnemy)
        {
            Console.WriteLine(@" ______________________________________________________________________________________");
            Console.WriteLine(@"|                                                                                      |");
            Console.WriteLine(@"|            ------------                                           _____              |");
            Console.WriteLine(@"|           | Giocatore1 |                                      .-,;='';_),-.          |");
            Console.WriteLine(@"|           | PV: " + player.PuntiVita + @"      |                                       \_\(),()/_/           |  ");
            Console.WriteLine(@"|           | Atk: " + player.Attacco + @"     |                                         (,___,)             |  ");
            Console.WriteLine(@"|           | Def: " + player.Difesa + @"    |                                        ,-/`~`\-,___         |");
            Console.WriteLine(@"|            ------------                                        / /).:.('--._)        |");
            Console.WriteLine(@"|                                                               {_[ (_,_)              |");
            Console.WriteLine(@"|                 .=.,                                              | Y |              |");
            Console.WriteLine(@"|                ;c =\                                             /  |  \             |");
            Console.WriteLine(@"|             __ | _ /                                                                 |");
            Console.WriteLine(@"|           .'-'-._ /-'-._                                      ------------           |");
            Console.WriteLine(@"|          / ..           \                                    |   Bandito  |          |");
            Console.WriteLine(@"|         / ' _        )   \                                   | PV: " + enemies[idMostro].PuntiVita + @"      |          |");
            Console.WriteLine(@"|        (  / \--   --/'._  )                                  | Atk: " + enemies[idMostro].Attacco + @"     |          |");
            Console.WriteLine(@"|         \-;_/\__;__/ _/ _/                                   | Def: " + enemies[idMostro].Difesa + @"     |          |");
            Console.WriteLine(@"|          '._}|==o==\{_\/                                      ------------           |");
            Console.WriteLine(@"|           /  /-._.--\ \_                                                             |");
            Console.WriteLine(@"|          // /   /|   \ \ \               ____________________________________________|");
            Console.WriteLine(@"|         / | |   | \;  |  \ \            |                                            |");
            Console.WriteLine(@"|        / /  | :/   \: \   \_\           |  TOCCA AL NEMICO!!                         |");
            Console.WriteLine(@"|       /  |  /.'|   /: |    \ \          |                                            |");
            Console.WriteLine($@"|       |  |  |--| . |--|     \_\         |  Il nemico decide di: {AzioneEnemy}            |");
            Console.WriteLine(@"|      / _ /   \ | : | /___--._) \        |                                            |");
            Console.WriteLine(@"|     |_(---'-| >-'-| |       '-'         |                                            |");
            Console.WriteLine(@"|              /_ /  \_\                  |                                            |");
            Console.WriteLine(@"|_________________________________________|____________________________________________|");
            //Console.ReadKey();
        }
        static void Combattimento(Enemy[] enemies, Player player, int idMostro, int ToccaA, string AzioneEnemySpiegaz)
        {
            //enemies[idMostro].PuntiVita = 0;
            double danno = 0;
            int arrotondo=0;
            //double dannoMagico = 0;
            string playerDifesa = "";

            string AzionePlayer = "";
            string AzioneEnemy = "";
            while (enemies[0].PuntiVita > 0)
            {
                danno = 0;
                arrotondo = 0;
                if (ToccaA == 0)
                {
                    if (playerDifesa == "braccia")
                    {
                        player.Difesa = player.Difesa / 1.9;
                        playerDifesa = "";
                    }
                    else if (playerDifesa == "scudo")
                    {
                        player.Difesa = player.Difesa / 1.5;
                        playerDifesa = "";
                    }
                    Console.Clear();
                    GrigliaCombattimentoTurnoGiocatore(enemies, player, idMostro);
                    Console.WriteLine(@"|                                                                                      |");
                    Console.WriteLine(@"|                                                                                      |");
                    Console.WriteLine(@"|                                                                                      |");
                    Console.WriteLine(@"|______________________________________________________________________________________|");
                    Console.SetCursorPosition(3, 29);
                    Console.WriteLine("Digita l'azione da compiere: ");
                    Console.SetCursorPosition(32, 29);
                    AzionePlayer = Console.ReadLine();

                    if (AzionePlayer == "1")
                    {
                        danno = (player.Attacco / enemies[idMostro].Difesa) * player.DannoArma;
                        arrotondo = (int)Math.Round(danno);
                        enemies[idMostro].PuntiVita = enemies[0].PuntiVita - arrotondo;
                        
                        
                        
                        Console.SetCursorPosition(3, 29);
                        Console.WriteLine($"Attacchi {enemies[idMostro].Nome} e lo colpisci con {player.Arma} facendogli {arrotondo} Danni. ");
                        ToccaA = 1;
                        Console.SetCursorPosition(70, 29);
                        Console.ReadKey();


                    }
                    else if (AzionePlayer == "2")
                    {
                        if (player.Scudo == "")
                        {
                            Console.SetCursorPosition(3, 29);
                            Console.WriteLine($"Decidi di non attaccare ma di proteggerti con le braccia,");
                            Console.SetCursorPosition(3, 30);
                            Console.WriteLine($"diminuendo i danni del prossimo attacco.");
                            player.Difesa = player.Difesa * 1.9;
                            playerDifesa = "braccia";
                            Console.SetCursorPosition(43, 30);
                            Console.ReadKey();
                        }
                        else if (player.Scudo == "Scudo a Torre")
                        {
                            Console.SetCursorPosition(3, 29);
                            Console.WriteLine($"Decidi di non attaccare ma di proteggerti nascondendoti dietro lo scudo a Torre,diminuendo i danni del prossimo attacco");
                            player.Difesa = player.Difesa * 1.5;
                            playerDifesa = "scudo";
                        }
                        ToccaA = 1;
                    }
                    else if (AzionePlayer == "3")
                    {
                        if (player.Pozioni > 0)
                        {
                            player.PuntiVita = player.PuntiVita + 20;
                            player.Pozioni--;
                            ToccaA = 1;
                        }
                        else
                        {
                            Console.SetCursorPosition(3, 29);
                            Console.WriteLine("Non hai pozioni con cui curarti.");
                            Console.ReadKey();
                        }

                    }
                    else if (AzionePlayer == "4")
                    {
                        if (player.Magia == "Non conosci nulla")
                        {
                            Console.SetCursorPosition(3, 29);
                            Console.WriteLine("Ti credi spiritoso? Già tanto che hai una spada rotta sei ignorante come una capra e parli a mala pena la tua lingua");
                            Console.ReadKey();
                            ToccaA = 0;
                        }
                        else
                        {
                            Console.SetCursorPosition(3, 29);
                            Console.WriteLine("Blateri cose strane, lanci una palla di fuoco e gli fai un male cane");
                            
                            danno = (player.AttaccoM / enemies[idMostro].Difesa) * player.DannoMagico;
                            arrotondo = (int)Math.Round(danno);
                            enemies[0].PuntiVita = enemies[0].PuntiVita-arrotondo;
                        }
                    }
                    else if (AzionePlayer == "5")
                    {
                        Console.WriteLine("Bravo sei saggio, cosi porti a casa la pellaccia!");
                        break;
                    }
                    Console.SetCursorPosition(3, 29);
                    Console.WriteLine("Ora tocca al tuo nemico.                                            ");
                    Console.SetCursorPosition(3, 30);
                    Console.WriteLine("                                                                   ");
                    Console.SetCursorPosition(27, 29);
                    Console.ReadKey();
                }
                else if (ToccaA == 1)
                {
                    Console.Clear();
                    if (enemies[0].PuntiVita < 30)
                    {
                        if (enemies[idMostro].Pozioni > 0)
                        {
                            AzioneEnemy = "Curarsi";
                            AzioneEnemySpiegaz = "Il nemico sta prendendo schiaffi quindi decide di curarsi";
                            enemies[0].PuntiVita = enemies[0].PuntiVita + 20;
                        }

                    }
                    else
                    {
                        danno = (enemies[idMostro].Attacco / player.Difesa) * enemies[idMostro].DannoArma;
                        arrotondo = (int)Math.Round(danno);
                        player.PuntiVita = player.PuntiVita -arrotondo;
                        AzioneEnemy = "Attaccare";
                        //Console.SetCursorPosition(3, 29);
                        AzioneEnemySpiegaz = $"Il Nemico ti attacca e ti ferisce. Perdi {arrotondo} PV.";
                        
                    }


                    GrigliaCombattimentoTurnoEnemy(enemies, player, idMostro, AzioneEnemy);                    
                    Console.WriteLine(@"|                                                                                      |");
                    Console.WriteLine(@"|  " + AzioneEnemySpiegaz + "                                     |");
                    Console.WriteLine(@"|                                                                                      |");
                    Console.WriteLine(@"|______________________________________________________________________________________|");
                    Console.SetCursorPosition(50, 29);
                    Console.ReadKey();
                    ToccaA = 0;
                }
            }



            if (AzionePlayer == "1")
            {
                Console.Clear();
                Console.WriteLine("Bravo hai ucciso per la prima volta una persona.");
                Console.WriteLine("Frughi nelle sue tasche e trovi 150 monete d'oro");
                Console.ReadKey();
            }
            else if (AzionePlayer == "5")
            {
                Console.Clear();
                Console.WriteLine("Sei riuscito per un pelo a scappare, solo perchè era leggermente gobbo...");
                Console.ReadKey();
            }
        }
        static void Negozio(Player player)
        {
            string Scelta = "";
            int SceltaNum = 0;
            Console.WriteLine("Appena entrato il simpatico negoziante ti chiede se vuoi acquistare qualcosa!!");
            Console.WriteLine("Vuoi vedere la merce che vende?");
            Scelta = "S";
            //Scelta = Console.ReadLine();
            Console.ReadKey();

            if (Scelta == "S")
            {
                do
                {
                    Console.Clear();
                    Console.WriteLine("                                             Monete D'oro Disponibili:" + player.Oro);
                    Console.WriteLine("");
                    Console.WriteLine("-Spade-                           -Armature-                          -Scudi-");
                    Console.WriteLine("1.Frostmourne      :50 Mo         3.Sacco di patate pulito  :50 Mo    6.Scudo a torre :50 Mo");
                    Console.WriteLine("2.Ammazzadraghi    :50 Mo         4.Armatura di Pegasus     :50 Mo");
                    Console.WriteLine("");
                    Console.WriteLine("-Pozioni-                         -Incantesimi-");
                    Console.WriteLine("5. Cura 50  hp     :50 Mo         8.Palla di fuoco          :50 Mo");
                    Console.WriteLine("                                  7.Magia sali di livello   :50 Mo");
                    Console.WriteLine("Di quale oggetto vuoi le infomrazioni? (digita 9 per uscire dal negozio");

                    Scelta = Console.ReadLine();
                    SceltaNum = int.Parse(Scelta);

                    switch (SceltaNum)
                    {
                        case 1:
                            Console.WriteLine("Spada fortissima di wow, atk + 50");

                            Console.WriteLine("Vuoi acquistarla?");
                            Scelta = Console.ReadLine();
                            if (Scelta == "S")
                            {
                                if (player.Arma == "Frostmourne")
                                {
                                    Console.WriteLine("La hai già in possesso...");
                                    Console.ReadKey();
                                }
                                else
                                {
                                    if (player.Oro > 50)
                                    {
                                        player.Arma = "Frostmourne";
                                        player.DannoArma = 20;
                                        player.Attacco = 120;
                                        player.Oro = player.Oro - 50;
                                        player.VediEquip();
                                    }
                                    else
                                    {
                                        Console.WriteLine("Non hai abbastanza soldi, vai a picchiare qualcuno");
                                        Console.ReadKey();
                                    }
                                }

                            }
                            continue;
                        case 2:
                            Console.WriteLine("Spada di Gatsu (prioprio la sua non è una replica), atk + 500");

                            Console.WriteLine("Vuoi acquistarla?");
                            Scelta = Console.ReadLine();
                            if (Scelta == "S")
                            {
                                if (player.Arma == "Ammazzadraghi")
                                {
                                    Console.WriteLine("Non te ne fai niente di due, non si usurano in questo gioco.");
                                    Console.ReadKey();
                                }
                                else
                                {
                                    if (player.Oro > 50)
                                    {
                                        player.Arma = "Ammazzadraghi";
                                        player.DannoArma = 25;
                                        player.Attacco = 140;
                                        player.Oro = player.Oro - 50;
                                        player.VediEquip();
                                    }
                                    else
                                    {
                                        Console.WriteLine("Non hai abbastanza soldi, vai a picchiare qualcuno");
                                        Console.ReadKey();
                                    }
                                }

                            }
                            continue;
                        case 3:
                            Console.WriteLine("Stesso tuo modello ma non puzza, def + 10");
                            Console.WriteLine("Vuoi acquistarla?");
                            Scelta = Console.ReadLine();
                            if (Scelta == "S")
                            {
                                if (player.Armatura == "Sacco di Patate pulito e stirato")
                                {
                                    Console.WriteLine("Lo hai già.. cerca di acquistare la pegasus");
                                    Console.ReadKey();
                                }
                                else
                                {
                                    if (player.Oro > 50)
                                    {
                                        player.Armatura = "Sacco di Patate pulito e stirato";
                                        player.Difesa = 70;
                                        player.Oro = player.Oro - 50;
                                        player.VediEquip();
                                    }
                                    else
                                    {
                                        Console.WriteLine("Non hai abbastanza soldi, vai a picchiare qualcuno");
                                        Console.ReadKey();
                                    }
                                }
                            }
                            continue;
                        case 4:
                            Console.WriteLine("Con questa sembri un pirla ma ti protegge bene, def+100");
                            Console.WriteLine("Vuoi acquistarla?");
                            Scelta = Console.ReadLine();
                            if (Scelta == "S")
                            {
                                if (player.Armatura == "Armatura di Pegasus")
                                {
                                    Console.WriteLine("Lo hai già.. punta sulle armi se vuoi diventare più forte");
                                    Console.ReadKey();
                                }
                                else
                                {
                                    if (player.Oro > 50)
                                    {
                                        player.Armatura = "Armatura di Pegasus";
                                        player.Difesa = 100;
                                        player.Oro = player.Oro - 50;
                                        player.VediEquip();
                                    }
                                    else
                                    {
                                        Console.WriteLine("Non hai abbastanza soldi, vai a picchiare qualcuno");
                                        Console.ReadKey();
                                    }
                                }
                            }
                            continue;
                        case 5:
                            Console.WriteLine("Ti cura di 50 hp , da usare in combattimento");
                            Console.WriteLine("Vuoi acquistarla?");
                            Scelta = Console.ReadLine();
                            if (Scelta == "S")
                            {
                                if (player.Oro > 50)
                                {
                                    player.Pozioni++;
                                    player.Oro = -50;
                                    player.VediEquip();
                                }
                                else
                                {
                                    Console.WriteLine("Non hai abbastanza soldi, vai a picchiare qualcuno");
                                    Console.ReadKey();
                                }
                            }
                            continue;
                        case 6:
                            Console.WriteLine("Scudo a Torre, aumenta la tua difesa");
                            Console.WriteLine("Vuoi acquistarla?");
                            Scelta = Console.ReadLine();
                            if (Scelta == "S")
                            {
                                if (player.Armatura == "Scudo a Torre")
                                {
                                    Console.WriteLine("Lo hai già.. punta sulle armi se vuoi diventare più forte");
                                    Console.ReadKey();
                                }
                                else
                                {
                                    if (player.Oro > 50)
                                    {
                                        player.Scudo = "Scudo a Torre";
                                        player.Difesa = player.Difesa + 40;
                                        player.Oro = -50;
                                        player.VediEquip();
                                    }
                                    else
                                    {
                                        Console.WriteLine("Non hai abbastanza soldi, vai a picchiare qualcuno");
                                        Console.ReadKey();
                                    }
                                }
                            }
                            continue;
                        case 7:
                            Console.WriteLine("Leggendo questa pergamenta diventi intelligente e spari palle di fuoco da 500 danni");
                            Console.WriteLine("Vuoi acquistarla?");
                            Scelta = Console.ReadLine();
                            if (Scelta == "S")
                            {
                                if (player.Armatura == "Palla di Fuoco")
                                {
                                    Console.WriteLine("Lo hai già.. punta sulle armi se vuoi diventare più forte");
                                    Console.ReadKey();
                                }
                                else
                                {
                                    if (player.Oro > 50)
                                    {
                                        player.Magia = "Palla di Fuoco";
                                        player.AttaccoM = 200;
                                        player.DannoMagico = 50;
                                        player.Oro = player.Oro - 50;
                                        player.VediEquip();
                                    }
                                    else
                                    {
                                        Console.WriteLine("Non hai abbastanza soldi, vai a picchiare qualcuno");
                                        Console.ReadKey();
                                    }
                                }
                            }
                            continue;
                        case 8:
                            Console.WriteLine("Con questa magia diventi più furbo, aumenti le tue statistiche");
                            Console.WriteLine("Vuoi acquistarla?");
                            Scelta = Console.ReadLine();
                            if (Scelta == "S")
                            {
                                if (player.Oro > 1000)
                                {
                                    player.PuntiVita = player.PuntiVita + 100;
                                    player.Attacco = player.Attacco + 80;
                                    player.Difesa = player.Difesa + 60;
                                    player.DannoArma = player.DannoArma + 25;
                                    player.DannoMagico = player.DannoMagico + 50;
                                    player.Oro = player.Oro - 1000;
                                    player.VediEquip();
                                }
                                else
                                {
                                    Console.WriteLine("Non hai abbastanza soldi, vai a picchiare qualcuno");
                                    Console.ReadKey();
                                }
                            }
                            continue;
                    }

                } while (SceltaNum < 9);










            }
            else
            {
                Console.WriteLine("Allora esci.");
            }


        }
    }
}
