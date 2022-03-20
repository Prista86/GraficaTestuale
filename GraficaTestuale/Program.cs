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
        }
    }
}
