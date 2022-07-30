using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

/*  Esercizio cattivo per sadomasochisti ]:-)
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
                nemico da uccidere  */

namespace GraficaTestuale
{
    class Program
    {
        static void Main(string[] args)
        {
            int width = 130;
            int height = 35;
            Console.SetWindowSize(width, height);
            string Scelta;
            //string Risposta = "";
            int ToccaA = 0;
            int idMostro;
            double potMostro = 1;
            string AzioneEnemySpiegaz = "";

            Player player = new Player();
            player.Nome = "";
            player.PuntiVita = 150;
            player.Attacco = 100;
            //player.AttaccoM = 0;
            player.Difesa = 80;
            player.DannoArma = 15;
            player.DannoMagico = 0;
            player.Oro = 0;
            player.Arma = "Spada brutta";
            player.Armatura = "Sacco di patate puzzolente";
            player.Scudo = "Non hai uno scudo";
            player.Magia = "Non conosci nulla";
            player.Pozioni = 3;
            player.DannoArrotondato = 0;

            Enemy[] enemies = new Enemy[3];

            for (int i = 0; i < 3; i++)
            {
                Enemy enemy = new Enemy();
                enemy.Id = i;
                enemy.Nome = "Enemy" + i;
                enemy.PuntiVita = 150 * potMostro;
                enemy.Attacco = 100 * potMostro;
                enemy.Difesa = 100 * potMostro;
                enemy.DannoArma = 15 * potMostro;
                enemy.Loot = 350 + (i * 10);
                enemy.Pozioni = 1 + (i * 2);
                potMostro *= 1.3;
                enemies[i] = enemy;
            }

            Console.WriteLine("Benvenuto nel mio primo gdr testuale!");
            Console.WriteLine("Quale è il tuo Nome coraggioso eroe?!!!");
            player.Nome = "Luca";
            player.Nome = Console.ReadLine();
            Console.WriteLine("Ottimo " + player.Nome + " !!! Indubbiamente sarai destinato a grandiosi atti eroici!!! 'Invio'");
            Console.ReadKey();
            Console.WriteLine("Oh!! Sei appena stato convocato dal Re Maccio per una nuova avventura!!");
            Console.WriteLine("Vuoi andare?");
            Scelta = "";
            Scelta = SioNo(Scelta);
            if (Scelta == "S")                                                                                        //convocazione di Re Maccio
            {
                Console.WriteLine("Bene " + player.Nome + " non sei un coniglio!");
                Console.WriteLine("Dopo averlo atteso 2 ore");
                for (int i = 0; i < 8; i++)
                {
                    Thread.Sleep(700);
                    Console.Write(".");
                }
                Console.WriteLine("'Questa attesa serve per immergerti ancora di più nella storia...' 'Invio'");
                Console.ReadKey();
                Console.Clear();
                Console.WriteLine("...in breve il Re ha notato che questa mattina non si è presentata a colazione la sua figlia principessina!!!");
                Console.WriteLine("Lui è convinto che sia stato il drago a rapirla e ti chiede se hai voglia di andare a recuperarla nella sua tana.");
                Console.WriteLine("Ti andrebbe " + player.Nome + " ?");
                Scelta = "";
                Scelta = SioNo(Scelta);
                if (Scelta == "S")                                                                                               // Andare a salvare la principessa?
                {
                    Console.WriteLine("Bene " + player.Nome + " sei coraggioso!!! Ora però è ora di cena quindi andate a mangiare!!!");
                    Console.WriteLine("Partirai domani mattina dopo una bella dormita!");
                    Console.WriteLine("Tanto la grotta dista solo mezzoretta di strada! 'Invio'");
                    Console.ReadKey();
                    Console.Clear();
                    Console.WriteLine("'Cena time...' 'Invio'");
                    Console.ReadKey();
                    Console.Clear();
                    Console.WriteLine("..zZz..' Dormita time' 'Invio'");
                    Console.ReadKey();
                    Console.WriteLine("Ottimo " + player.Nome + " sei riposato e rifocillato con una ottima colazione vegana a base di pane e acqua!!!");
                    Console.WriteLine("Sei proprio pronto per partire!");
                    Console.WriteLine("Prima di partire vuoi per caso passare dal negozio ad acquistare qualcosa per il viaggio?");
                    Scelta = "";
                    Scelta = SioNo(Scelta);
                    if (Scelta == "S")                                                                                       //Negozio
                    {
                        Negozio(player);
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Grande " + player.Nome + " sei fortissimo già cosi come sei!!!");
                        Console.WriteLine("'...No non è vero, non sei assolutamente preparato per nulla, neanche per andare a fare la spesa al conad'");
                        Console.WriteLine("Quindi vediamo un attimo come sei messo. 'Invio'");
                        Console.ReadKey();
                        player.VediEquip();
                    }
                    Console.Clear();
                    Console.WriteLine();
                    Console.WriteLine("Grandioso !!! " + player.Nome + " stai per intraprendere la tua prima avventura!!");
                    Console.WriteLine("Ora puoi veramente partire verso la tana del drago che puoi già vedere in lontananza in cima alla collina! 'Invio'");
                    Console.ReadKey();
                    Console.Clear();
                    idMostro = 0;
                    enemies[idMostro].Nome = "Bandito";
                    while (enemies[idMostro].PuntiVita > 1)
                    {
                        Console.Clear();
                        Console.WriteLine("Oh nooo!! " + player.Nome + " mentre passeggi per il sentiero appena uscito dal villaggio incontri un tizio");
                        Console.WriteLine("poco promettente incappucciato e leggermente gobbo... ");
                        Console.WriteLine("Attenzione è un bandito e ti vuole derubare!!!' che cosa poi? non lo sa che sei uno straccione -.-?'");
                        Console.WriteLine();
                        Console.WriteLine("Hai capito che ti vuole attaccare ma è ancora lontano... vuoi attaccarlo per primo?");
                        Scelta = "";
                        Scelta = SioNo(Scelta);
                        if (Scelta == "S")
                        {
                            ToccaA = 0;
                        }
                        else
                        {
                            ToccaA = 1;
                        }
                        Combattimento(enemies, player, idMostro, ToccaA, AzioneEnemySpiegaz);
                    }
                    Console.Clear();
                    Console.WriteLine("Bravo " + player.Nome + " è stata dura ma sei riuscito a salvare la pellaccia!!! ");
                    Console.WriteLine("Vuoi tornare in negozio e prepararti come si deve???");
                    Scelta = "";
                    Scelta = SioNo(Scelta);
                    if (Scelta == "S")
                    {
                        Negozio(player);
                        player.VediEquip();
                    }
                    else
                    {
                        Console.WriteLine("Va bene " + player.Nome + " ma potresti, forse , trovare qualche difficoltà in più...");
                    }
                    Console.Clear();
                    Console.WriteLine("Ottimo " + player.Nome + " hai affontato il tuo primo combattimento e ora sei pronto per salvare la principessa!!");
                    Console.WriteLine("Procedi per il sentieri di prima e pian piano arrivi ad una grotta molto grande, subito leggi un cartello con scritto;");
                    Console.WriteLine("ATTENZIONE NON ENTRARE, FORSE DRAGO!");
                    Console.WriteLine("Ma tu sei coraggioso ed entri se no il Re Maccio ti ammazza comunque. 'Invio");
                    Console.ReadKey();
                    idMostro = 1;
                    enemies[idMostro].PuntiVita += 160;
                    enemies[idMostro].Nome = "FraBand";
                    player.PuntiVita = 150;
                    while (enemies[idMostro].PuntiVita > 1)
                    {
                        Console.Clear();
                        Console.WriteLine("Appena entri vedi che c'è un bruttissimno ceffo...");
                        Console.WriteLine("Ti urla correndoti incontro dicendoti:");
                        Console.WriteLine("'" + player.Nome + " tu hai ammazzato mio fratello e ora lo forse vendicherò!!!' 'Invio'");
                        Console.ReadKey();
                        Combattimento(enemies, player, idMostro, ToccaA, AzioneEnemySpiegaz);

                    }
                    Console.Clear();
                    Console.WriteLine("Bravo " + player.Nome + " è stata dura ma sei riuscito a salvare la pellaccia!!! ");
                    Console.WriteLine("Ora che hai qualche soldino in più vuoi prendere qualcosa per non prenderti gli schiaffi dal Drago??");
                    Scelta = "";
                    Scelta = SioNo(Scelta);
                    if (Scelta == "S")
                    {
                        Negozio(player);
                        player.VediEquip();
                    }
                    else
                    {
                        Console.WriteLine("Va bene " + player.Nome + " ma potresti, forse , trovare qualche difficoltà in più... 'Invio'");
                        Console.ReadKey();
                    }
                    Console.Clear();
                    Console.WriteLine("Molto bene " + player.Nome + " , sei riuscito a salvarti pure questa volta..");
                    Console.WriteLine("Continui ad addentrarti nella grotta e in lontananza senti una voce di ragazza che chiede aiuto");
                    Console.WriteLine("'AIUTOOOO AIUTOOOOO IL DRAGO NON MI FA USCIREEE MI TIENE PRIGIONIERA QUII SALVATEMI!!!'");
                    Console.WriteLine("Tu non puoi che accorrere in suo aiuto!!!!");
                    Console.WriteLine("La caverna pian piano che avanzi si fa sempre pià stretta fino a diventare un cunicolo in cui stai a malapena in piedi.");
                    Console.WriteLine("Ad un certo punto sei obbligato a girare a destra e subito dopo entri in una gigatesca cavità ");
                    Console.WriteLine("scavata nella roccia chissà quanti millenni fa!!!");
                    Console.WriteLine("Dentro trovi la principessa in una gabbia e a fianco un grandissimo drago che ha tutta l'aria di essere molto affamato!!!");
                    Console.WriteLine("Si gira verso di te ( il drago ) e ti dice:");
                    Console.WriteLine("' bene " + player.Nome + " , avevo fame e ora ti mangio' e inizia a correrti in contro!!!");
                    Console.WriteLine("...Sei obbligato a combattere non puoi scappare");
                    Console.ReadKey();
                    idMostro = 2;
                    player.PuntiVita = 150;
                    enemies[idMostro].PuntiVita += 200;
                    enemies[idMostro].Nome = "Drago  ";
                    Combattimento(enemies, player, idMostro, ToccaA, AzioneEnemySpiegaz);
                    Console.Clear();
                    Console.WriteLine("Bravissimo " + player.Nome + " !! Hai ammazzato il drago! Ora puoi salvare la principessa!!");
                    Console.WriteLine("Dopo due orette buone a cercare di aprire la gabbia riesci finalmente nell'intento!");
                    Console.WriteLine("La principessa ti ringrazia e scappa via con te dalla grotta");
                    Console.WriteLine("Arrivati al paese correte dal Re che è felicissimo nel veder tornata la sua amata figlia");
                    Console.WriteLine("Il re ti ringrazia tanto e ti regala altre 5 mo 'Invio'");
                    Console.ReadKey();
                    player.Oro += 5;
                    Console.Clear();
                    Console.SetCursorPosition(56, 15);
                    Console.WriteLine("Bravo hai vinto.");
                    Console.ReadKey();
                    System.Environment.Exit(0);
                }
                //FINE STORIA
                //FINE STORIA
                //FINE STORIA

                else                                                                           // No salvare la principessa
                {
                    Console.WriteLine("Ok ci sta che tu sia un po' pigrotto..");
                    Console.WriteLine("Però il Re Maccio è un po dispiaciuto, quindi ti butta nel pozzo di prima.");
                    Console.ReadKey();
                    Console.Clear();
                    Console.SetCursorPosition(56, 15);
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
                Console.WriteLine("Ti rompi l'osso del collo.");
                Console.ReadKey();
                Console.Clear();
                Console.SetCursorPosition(56, 15);
                Console.WriteLine("SEI MORTO");
                Console.ReadKey();
                System.Environment.Exit(0);
            }
        }
        static void GrigliaCombattimentoTurnoGiocatore(Enemy[] enemies, Player player, int idMostro)
        {
            Console.WriteLine(@" ______________________________________________________________________________________");
            Console.WriteLine(@"|                                                                                      |");
            Console.WriteLine(@"|            ------------                                           _____              |");
            Console.WriteLine(@"|           | Giocatore1 |                                      .-,;='';=),-.          |");
            Console.WriteLine(@"|           | PV: " + player.PuntiVita + @"    |                                       \_\(),()/_/           |  ");
            Console.WriteLine(@"|           | Atk: " + player.Attacco + @"   |                                         (,___,)             |  ");
            Console.WriteLine(@"|           | Def: " + player.Difesa + @"    |                                        ,-/`~`\-,___         |");
            Console.WriteLine(@"|            ------------                                        / /).:.('--._)        |");
            Console.WriteLine(@"|                                                               {_[ (_,_)              |");
            Console.WriteLine(@"|                 .=.,                                              | Y |              |");
            Console.WriteLine(@"|                ;c =\                                             /  |  \             |");
            Console.WriteLine(@"|             __ | _ /                                                                 |");
            Console.WriteLine(@"|           .'-'-._ /-'-._                                      ------------           |");
            Console.WriteLine(@"|          / ..           \                                    |   " + enemies[idMostro].Nome + "  |          |");
            Console.WriteLine(@"|         / ' _        )   \                                   | PV: " + enemies[idMostro].PuntiVita + @"    |          |");
            Console.WriteLine(@"|        (  / \--   --/'._  )                                  | Atk: " + enemies[idMostro].Attacco + @"   |          |");
            Console.WriteLine(@"|         \-;_/\__;__/ _/ _/                                   | Def: " + enemies[idMostro].Difesa + @"   |          |");
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
        static void GrigliaCombattimentoTurnoEnemy(Enemy[] enemies, Player player, int idMostro)
        {
            Console.WriteLine(@" ______________________________________________________________________________________");
            Console.WriteLine(@"|                                                                                      |");
            Console.WriteLine(@"|            ------------                                           _____              |");
            Console.WriteLine(@"|           | Giocatore1 |                                      .-,;='';_),-.          |");
            Console.WriteLine(@"|           | PV: " + player.PuntiVita + @"    |                                       \_\(),()/_/           |  ");
            Console.WriteLine(@"|           | Atk: " + player.Attacco + @"   |                                         (,___,)             |  ");
            Console.WriteLine(@"|           | Def: " + player.Difesa + @"    |                                        ,-/`~`\-,___         |");
            Console.WriteLine(@"|            ------------                                        / /).:.('--._)        |");
            Console.WriteLine(@"|                                                               {_[ (_,_)              |");
            Console.WriteLine(@"|                 .=.,                                              | Y |              |");
            Console.WriteLine(@"|                ;c =\                                             /  |  \             |");
            Console.WriteLine(@"|             __ | _ /                                                                 |");
            Console.WriteLine(@"|           .'-'-._ /-'-._                                      ------------           |");
            Console.WriteLine(@"|          / ..           \                                    |   " + enemies[idMostro].Nome + "  |          |");
            Console.WriteLine(@"|         / ' _        )   \                                   | PV: " + enemies[idMostro].PuntiVita + @"    |          |");
            Console.WriteLine(@"|        (  / \--   --/'._  )                                  | Atk: " + enemies[idMostro].Attacco + @"   |          |");
            Console.WriteLine(@"|         \-;_/\__;__/ _/ _/                                   | Def: " + enemies[idMostro].Difesa + @"   |          |");
            Console.WriteLine(@"|          '._}|==o==\{_\/                                      ------------           |");
            Console.WriteLine(@"|           /  /-._.--\ \_                                                             |");
            Console.WriteLine(@"|          // /   /|   \ \ \               ____________________________________________|");
            Console.WriteLine(@"|         / | |   | \;  |  \ \            |                                            |");
            Console.WriteLine(@"|        / /  | :/   \: \   \_\           |  TOCCA AL NEMICO!!                         |");
            Console.WriteLine(@"|       /  |  /.'|   /: |    \ \          |                                            |");
            Console.WriteLine(@"|       |  |  |--| . |--|     \_\         |                                            |");
            Console.WriteLine(@"|      / _ /   \ | : | /___--._) \        |                                            |");
            Console.WriteLine(@"|     |_(---'-| >-'-| |       '-'         |                                            |");
            Console.WriteLine(@"|              /_ /  \_\                  |                                            |");
            Console.WriteLine(@"|_________________________________________|____________________________________________|");
            //Console.ReadKey();
        }
        static void Combattimento(Enemy[] enemies, Player player, int idMostro, int ToccaA, string AzioneEnemySpiegaz)
        {
            string playerDifesa = "";
            string Scelta;
            string AzionePlayer = "";
            string AzioneEnemy = "";
            while (enemies[idMostro].PuntiVita > 0)
            {
                if (ToccaA == 0)
                {
                    if (playerDifesa == "braccia")
                    {
                        player.Difesa /= 1.8;
                        playerDifesa = "";
                    }
                    else if (playerDifesa == "scudo")
                    {
                        player.Difesa /= 2.5;
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
                        player.Attack(enemies, idMostro);
                        Console.SetCursorPosition(3, 29);
                        Console.WriteLine($"Attacchi {enemies[idMostro].Nome} e lo colpisci con {player.Arma} facendogli {player.DannoArrotondato} Danni. ");
                        ToccaA = 1;
                        Console.SetCursorPosition(70, 29);
                        Console.ReadKey();
                    }
                    else if (AzionePlayer == "2")
                    {
                        if (player.Scudo == "Non hai uno scudo")
                        {
                            Console.SetCursorPosition(3, 29);
                            Console.WriteLine($"Decidi di non attaccare ma di proteggerti con le braccia,");
                            Console.SetCursorPosition(3, 30);
                            Console.WriteLine($"diminuendo i danni del prossimo attacco.");
                            player.Difesa *= 1.8;

                            playerDifesa = "braccia";
                            Console.SetCursorPosition(43, 30);
                            Console.ReadKey();
                        }
                        else if (player.Scudo == "Scudo a Torre")
                        {
                            Console.SetCursorPosition(3, 29);
                            Console.WriteLine($"Decidi di non attaccare ma di proteggerti nascondendoti dietro lo scudo a Torre,diminuendo i danni del prossimo attacco");
                            player.Difesa *= 2.5;
                            playerDifesa = "scudo";
                        }
                        ToccaA = 1;
                    }
                    else if (AzionePlayer == "3")
                    {
                        if (player.Pozioni > 0)
                        {
                            player.Heal();
                            Console.SetCursorPosition(3, 29);
                            Console.WriteLine($"Ti bevi la pozione, fa schifo ma ti senti meglio.");
                            Console.SetCursorPosition(3, 30);
                            Console.WriteLine($"Te ne rimangono {player.Pozioni}.");
                            Console.SetCursorPosition(21, 30);
                            Console.ReadKey();
                            ToccaA = 1;
                        }
                        else
                        {
                            Console.SetCursorPosition(3, 29);
                            Console.WriteLine("Non hai pozioni con cui curarti. Ma perdi comunque il turno. 'Invio'");
                            Console.SetCursorPosition(35, 29);
                            Console.ReadKey();
                        }
                    }
                    else if (AzionePlayer == "4")
                    {
                        if (player.Magia == "Non conosci nulla")
                        {
                            Console.SetCursorPosition(3, 29);
                            Console.WriteLine($"Ti credi spiritoso? Già tanto che hai una spada rotta sei ignorante");
                            Console.SetCursorPosition(3, 30);
                            Console.WriteLine($"come una capra e parli a mala pena la tua lingua. 'Invio'");
                            Console.SetCursorPosition(55, 30);
                            Console.ReadKey();
                            ToccaA = 0;
                        }
                        else
                        {
                            Console.SetCursorPosition(3, 29);
                            Console.WriteLine("Blateri cose strane, lanci una palla di fuoco e gli fai un male cane");
                            Console.SetCursorPosition(3, 30);
                            player.MagicAttack(enemies, idMostro);
                            Console.WriteLine($"Attacchi {enemies[idMostro].Nome} e lo colpisci con {player.Magia} facendogli {player.DannoArrotondato} Danni. ");
                            Console.ReadKey();
                        }
                    }
                    else if (AzionePlayer == "5")
                    {
                        if (enemies[idMostro].Nome == "Drago")
                        {
                            Console.SetCursorPosition(3, 29);
                            Console.WriteLine($"Mi dispiace ma stai combattendo contro un drago..");
                            Console.SetCursorPosition(3, 30);
                            Console.WriteLine($"..e dai draghi non si scappa. 'Invio'");
                            Console.ReadKey();
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("Bravo sei saggio, cosi porti a casa la pellaccia!");
                            Console.WriteLine("Sei riuscito a scappare per un pelo... vuoi passare dal negozio e darti una sistemata? 'S/N'");
                            Scelta = Console.ReadLine();
                            if (Scelta == "S")
                            {
                                Negozio(player);
                                player.VediEquip();
                            }
                            else
                            {
                                Console.WriteLine("Va bene ma potresti, forse , non farcela di nuovo... 'Invio'");
                                Console.ReadKey();

                            }
                            break;
                        }
                    }
                    if (AzionePlayer != "1" && AzionePlayer != "2" && AzionePlayer != "3" && AzionePlayer != "4" && AzionePlayer != "5")
                    {
                        Console.WriteLine("Devi inserire un numero da 1 a 5");
                        Console.ReadKey();
                        ToccaA = 0;
                    }
                    else
                    {
                        Console.SetCursorPosition(3, 29);
                        Console.WriteLine("Ora tocca al tuo nemico.                                                     ");
                        Console.SetCursorPosition(3, 30);
                        Console.WriteLine("                                                                             ");
                        Console.SetCursorPosition(27, 29);
                        Console.ReadKey();
                        ToccaA = 1;
                    }
                }
                else if (ToccaA == 1)                                //Attacco del mostro
                {
                    Console.Clear();
                    GrigliaCombattimentoTurnoEnemy(enemies, player, idMostro);
                    if (enemies[idMostro].Pozioni > 0)
                    {
                        if (enemies[idMostro].PuntiVita < 30)
                        {
                            AzioneEnemy = "Curarsi";
                            AzioneEnemySpiegaz = "Il nemico sta prendendo schiaffi quindi si beve una pozione";
                            enemies[idMostro].Heal();
                        }
                        else
                        {
                            enemies[idMostro].Attack(player);

                            AzioneEnemy = "Attaccare";
                            AzioneEnemySpiegaz = $"Il Nemico ti attacca e ti ferisce. Perdi {enemies[idMostro].DannoArrotondato} PV.";
                            if (player.PuntiVita < 1)
                            {
                                if (player.PuntiVita < 1)
                                {
                                    Console.Clear();
                                    Console.SetCursorPosition(25, 9);
                                    Console.WriteLine("Vieni ammazzato con una semplicità imbarazzante.");
                                    Console.ReadKey();
                                    Console.Clear();
                                    Console.SetCursorPosition(56, 15);
                                    Console.WriteLine("SEI MORTO");
                                    Console.ReadKey();
                                    Environment.Exit(0);
                                }
                            }
                        }
                    }
                    else
                    {
                        enemies[idMostro].Attack(player);
                        AzioneEnemy = "Attaccare";
                        AzioneEnemySpiegaz = $"Il Nemico ti attacca e ti ferisce. Perdi {enemies[idMostro].DannoArrotondato} PV.";
                        if (player.PuntiVita < 1)
                        {
                            Console.Clear();
                            Console.SetCursorPosition(25, 9);
                            Console.WriteLine("Cavoli c'é l'avevi quasi fatta ma sei troppo scarso comunque.");
                            Console.ReadKey();
                            Console.Clear();
                            Console.SetCursorPosition(56, 15);
                            Console.WriteLine("SEI MORTO");
                            Console.ReadKey();
                            Environment.Exit(0);
                        }
                    }
                    Console.WriteLine(@"|                                                                                      |");
                    Console.WriteLine(@"|  Il nemico decide di: " + AzioneEnemy + "                                                      |");
                    Console.WriteLine(@"|                                                                                      |");
                    Console.WriteLine(@"|  " + AzioneEnemySpiegaz + "                                     |");
                    Console.WriteLine(@"|______________________________________________________________________________________|");
                    Console.SetCursorPosition(50, 31);
                    Console.ReadKey();
                    ToccaA = 0;
                }
            }
            if (AzionePlayer == "1" || AzionePlayer == "4")
            {
                Console.Clear();
                Console.WriteLine("Hai eliminato il " + enemies[idMostro].Nome + ".");
                if (idMostro == 1)
                {
                    enemies[idMostro].Loot += 300;
                }
                else if (idMostro == 0)
                {
                    enemies[idMostro].Loot += 100;
                }
                Console.WriteLine("Frughi nelle sue tasche e trovi " + enemies[idMostro].Loot + "monete d'oro");
                player.Oro += enemies[idMostro].Loot;
                Console.ReadKey();
            }
        }
        static void Negozio(Player player)
        {
            string Scelta;
            int SceltaNum;
            Console.WriteLine("Appena entrato il simpatico negoziante ti chiede se vuoi acquistare qualcosa!!");
            Console.WriteLine("Vuoi vedere la merce che vende?");
            Scelta = "";
            Scelta = SioNo(Scelta);
            if (Scelta == "S")
            {
                do
                {
                    Console.Clear();
                    Console.WriteLine();
                    Console.WriteLine(" Monete D'oro Disponibili:" + player.Oro);
                    Console.WriteLine("");
                    Console.WriteLine("");
                    Console.WriteLine(" -Spade-                               -Armature-                                  -Scudi-");
                    Console.WriteLine("");
                    Console.WriteLine(" 1.Frostmourne      :100 Mo            3.Sacco di patate pulito  :50 Mo            6.Scudo a torre :200 Mo");
                    Console.WriteLine("");
                    Console.WriteLine(" 2.Ammazzadraghi    :200 Mo            4.Armatura di Pegasus     :200 Mo");
                    Console.WriteLine("");
                    Console.WriteLine("");
                    Console.WriteLine("");
                    Console.WriteLine("");
                    Console.WriteLine(" -Pozioni-                             -Incantesimi-");
                    Console.WriteLine("");
                    Console.WriteLine(" 5.Cura             :50 Mo             7.Palla di fuoco          :70 Mo");
                    Console.WriteLine("");
                    Console.WriteLine("                                       8.Magia sali di livello   :1000 Mo          9.Visiona Equipaggiamento");
                    Console.WriteLine("");
                    Console.WriteLine("");
                    Console.WriteLine("");
                    Console.WriteLine(" Di quale oggetto vuoi le infomrazioni? 'digita 11 per uscire dal negozio'");
                    Console.WriteLine("");
                    Console.SetCursorPosition(3, 26);
                    Scelta = Console.ReadLine();
                    bool n = int.TryParse(Scelta, out SceltaNum);
                    switch (SceltaNum)
                    {
                        case 1:
                            Console.WriteLine("Spada fortissima di WoW, atk + 50");
                            Console.WriteLine("Vuoi acquistarla?");
                            Scelta = "";
                            Scelta = SioNo(Scelta);
                            if (Scelta == "S")
                            {
                                if (player.Arma == "Frostmourne")
                                {
                                    Console.WriteLine("La hai già in possesso... 'Invio'");
                                    Console.ReadKey();
                                }
                                else
                                {
                                    if (player.Oro > 50)
                                    {
                                        player.Arma = "Frostmourne";
                                        player.DannoArma = 20;
                                        player.Attacco = 150;
                                        player.Oro -= 100;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Non hai abbastanza soldi, spiace... 'Invio'");
                                        Console.ReadKey();
                                    }
                                }

                            }
                            continue;
                        case 2:
                            Console.WriteLine("Spada di Gatsu (prioprio la sua non è una replica), atk + 90'");
                            Console.WriteLine("Vuoi acquistarla?");
                            Scelta = "";
                            Scelta = SioNo(Scelta);
                            if (Scelta == "S")
                            {
                                if (player.Arma == "Ammazzadraghi")
                                {
                                    Console.WriteLine("Non te ne fai niente di due, non si usurano in questo gioco. 'Invio'");
                                    Console.ReadKey();
                                }
                                else
                                {
                                    if (player.Oro > 199)
                                    {
                                        player.Arma = "Ammazzadraghi";
                                        player.DannoArma = 25;
                                        player.Attacco = 190;
                                        player.Oro -= 200;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Non hai abbastanza soldi, spiace... 'Invio'");
                                        Console.ReadKey();
                                    }
                                }
                            }
                            continue;
                        case 3:
                            Console.WriteLine("Stesso tuo modello ma non puzza, def + 20");
                            Console.WriteLine("Vuoi acquistarla?");
                            Scelta = "";
                            Scelta = SioNo(Scelta);
                            if (Scelta == "S")
                            {
                                if (player.Armatura == "Sacco di Patate pulito e stirato")
                                {
                                    Console.WriteLine("Lo hai già.. cerca di acquistare la pegasus 'Invio'");
                                    Console.ReadKey();
                                }
                                else
                                {
                                    if (player.Oro > 49)
                                    {
                                        player.Armatura = "Sacco di Patate pulito e stirato";
                                        player.Difesa = 100;
                                        player.Oro -= 50;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Non hai abbastanza soldi, spiace... 'Invio'");
                                        Console.ReadKey();
                                    }
                                }
                            }
                            continue;
                        case 4:
                            Console.WriteLine("Con questa sembri un pirla ma ti protegge bene, def+40");
                            Console.WriteLine("Vuoi acquistarla?");
                            Scelta = "";
                            Scelta = SioNo(Scelta);
                            if (Scelta == "S")
                            {
                                if (player.Armatura == "Armatura di Pegasus")
                                {
                                    Console.WriteLine("Lo hai già.. punta sulle armi se vuoi diventare più forte 'Invio'");
                                    Console.ReadKey();
                                }
                                else
                                {
                                    if (player.Oro > 199)
                                    {
                                        player.Armatura = "Armatura di Pegasus";
                                        player.Difesa = 140;
                                        player.Oro -= 200;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Non hai abbastanza soldi, spiace... 'Invio'");
                                        Console.ReadKey();
                                    }
                                }
                            }
                            continue;
                        case 5:
                            Console.WriteLine("Ti cura di 40 hp , da usare in combattimento");
                            Console.WriteLine("Vuoi acquistarla?");
                            Scelta = "";
                            Scelta = SioNo(Scelta);
                            if (Scelta == "S")
                            {
                                if (player.Oro > 49)
                                {
                                    player.Pozioni++;
                                    player.Oro -= 50;
                                }
                                else
                                {
                                    Console.WriteLine("Non hai abbastanza soldi, spiace... 'Invio'");
                                    Console.ReadKey();
                                }
                            }
                            continue;
                        case 6:
                            Console.WriteLine("Scudo a Torre, aumenta la tua difesa");
                            Console.WriteLine("Vuoi acquistarla?");
                            Scelta = "";
                            Scelta = SioNo(Scelta);
                            if (Scelta == "S")
                            {
                                if (player.Scudo == "Scudo a Torre")
                                {
                                    Console.WriteLine("Lo hai già.. punta sulle armature se vuoi difenderti meglio 'Invio'");
                                    Console.ReadKey();
                                }
                                else
                                {
                                    if (player.Oro > 99)
                                    {
                                        player.Scudo = "Scudo a Torre";
                                        player.Difesa += 50;
                                        player.Oro -= 100;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Non hai abbastanza soldi, spiace... 'Invio'");
                                        Console.ReadKey();
                                    }
                                }
                            }
                            continue;
                        case 7:
                            Console.WriteLine("Leggendo questa pergamenta diventi intelligente e spari palle di fuoco potentissime");
                            Console.WriteLine("Vuoi acquistarla?");
                            Scelta = "";
                            Scelta = SioNo(Scelta);
                            if (Scelta == "S")
                            {
                                if (player.Magia == "Palla di Fuoco")
                                {
                                    Console.WriteLine("Lo hai già.. punta sulle armi se vuoi diventare più forte 'Invio'");
                                    Console.ReadKey();
                                }
                                else
                                {
                                    if (player.Oro > 69)
                                    {
                                        player.Magia = "Palla di Fuoco";
                                        //player.AttaccoM = 110;
                                        player.DannoMagico = 27;
                                        player.Oro -= 70;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Non hai abbastanza soldi, spiace... 'Invio'");
                                        Console.ReadKey();
                                    }
                                }
                            }
                            continue;
                        case 8:
                            Console.WriteLine("Con questa magia diventi più furbo, aumenti le tue statistiche");
                            Console.WriteLine("Vuoi acquistarla?");
                            Scelta = "";
                            Scelta = SioNo(Scelta);
                            if (Scelta == "S")
                            {
                                if (player.Arma == "Ammazzadraghi" && player.Armatura == "Armatura di Pegasus" && player.Scudo == "Scudo a Torre" && player.Magia == "Palla di Fuoco")
                                {
                                    if (player.Oro > 999)
                                    {
                                        player.PuntiVita += 200;
                                        player.Attacco += 80;
                                        player.Difesa += 60;
                                        player.DannoArma += 25;
                                        player.DannoMagico += 50;
                                        player.Oro -= 1000;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Non hai abbastanza soldi, spiace... 'Invio'");
                                        Console.ReadKey();
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Non hai abbastanza esperienza per padroneggiare questo potere...");
                                    Console.WriteLine("'Torna quando sarai equipaggiato come si deve' 'Invio'");
                                    Console.ReadKey();
                                }
                            }
                            continue;
                        case 9:
                            player.VediEquip();
                            continue;
                        case 10:
                            player.Oro += 500;
                            continue;
                        case 11:
                            SceltaNum = 101;
                            Console.WriteLine("Il commerciante ti saluta!");
                            Console.ReadKey();

                            break;
                        default:
                            Console.WriteLine("Devi inserire un numero da 1 a 11");
                            Console.ReadKey();
                            continue;
                    }

                } while (SceltaNum < 100);
            }
            else
            {
                Console.WriteLine("Esci dal negozio.");
                Console.WriteLine("Vediamo un attimo come sei messo. 'Invio'");
                Console.ReadKey();
                player.VediEquip();
            }
        }
        static string SioNo(string Scelta)
        {
            int i = 1;
            while (i > 0)
            {
                if (Scelta == "S" || Scelta == "N")
                {
                    i = 0;
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("'Digita S o N'");
                    Scelta = Console.ReadLine();
                }
            }
            return Scelta;
        }
    }
}
