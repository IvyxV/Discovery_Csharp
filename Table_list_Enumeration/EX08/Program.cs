using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX08
{
    class Program
    {
        enum Week
        {
            Lundi = 1,
            Mardi,
            Mercredi,
            Jeudi,
            Vendredi,
            Samedi,
            Dimanche
        }
        static void Main(string[] args)
        {
            String[] week = Enum.GetNames(typeof(Week));//Permet d'entré les valeurs d'un enum dans un tableau.
            Console.WriteLine(Enum.GetName(typeof(Week), 4));//Permet d'afficher la valeur 4 de l'enum.
        }
    }
}
