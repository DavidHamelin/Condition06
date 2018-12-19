using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Condition06
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bonjour, veuillez renseigner un mois (s'il vous plaît) : ");
            string userMonth = Console.ReadLine();

            /* une boucle if - else if - else avec opérateurs logiques OU "||"
            est également possible voire plus simple à écrire... */

            // Différents cas :
            switch (userMonth)
            {
                case "Septembre":
                case "Octobre":
                case "Novembre":
                    Console.WriteLine("La saison du mois saisie est l'Automne !");
                    break;
                case "Décembre":
                case "Janvier":
                case "Février":
                    Console.WriteLine("La saison du mois saisie est l'Hiver !");
                    break;
                case "Mars":
                case "Avril":
                case "Mai":
                    Console.WriteLine("La saison du mois saisie est le Printemps !");
                    break;
                case "Juin":
                case "Juillet":
                case "Aout":
                case "Août":
                    Console.WriteLine("La saison du mois saisie est l'Eté !");
                    break;
                default: // Permet d'afficher un message si l'utilisateur n'entre pas correctement un mois
                    Console.WriteLine("Je n'ai pas compris... Vérifier votre orthographe ! Essayez d'écrire le mois avec une Majuscule et n'oubliez pas les accents !");
                    break;
               /* On aurait pu également prendre en compte un mois écrit sans majuscule au début en ajoutant des cas sans maj
               exemple : case "mars": */
            }
        }
    }
}
