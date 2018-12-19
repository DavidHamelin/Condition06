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
            est également possible voire plus simple à écrire */

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

                default:
                    Console.WriteLine("Je n'ai pas compris... Essayez d'écrire le mois avec une Majuscule !");
                    break;
            }
        }
    }
}
