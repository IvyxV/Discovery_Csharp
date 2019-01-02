ing System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Renseignez le mois pour en connaître la saison  : ");
            String month = Console.ReadLine();

            switch (month)
            {
                case "janvier":
                    Console.WriteLine("C'est l'hiver !");
                    break;  // pour arrêter l'execution
                case "février":
                    Console.WriteLine("C'est l'hiver !");
                    break;
                case "mars":
                    Console.WriteLine("C'est le printemps !");
                    break;
                case "avril":
                    Console.WriteLine("C'est le printemps !");
                    break;
                case "mai":
                    Console.WriteLine("C'est le printemps !");
                    break;
                case "juin":
                    Console.WriteLine("C'est l'été !");
                    break;
                case "juillet":
                    Console.WriteLine("C'est l'été !");
                    break;
                case "aout":
                    Console.WriteLine("C'est l'été !");
                    break;
                case "septembre":
                    Console.WriteLine("C'est l'automne !");
                    break;
                case "octobre":
                    Console.WriteLine("C'est l'automne !");
                    break;
                case "novembre":
                    Console.WriteLine("C'est l'automne !");
                    break;
                case "décembre":
                    Console.WriteLine("C'est l'hiver !");
                    break;
                default: // si aucun des cas ne correspond, on execute le default.
                    Console.WriteLine("Le mois renseigné n'existe pas.");
                    break;
            }
        }
    }
}