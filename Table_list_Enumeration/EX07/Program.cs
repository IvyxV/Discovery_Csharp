using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX07
{
    class Program
    {
        enum Week
        {
            Lundi,
            Mardi,
            Mercredi,
            Jeudi,
            Vendredi,
            Samedi,
            Dimanche
        }
        static void Main(String[] args)
        {
            String[] week = Enum.GetNames(typeof(Week));//Permet d'entré les valeurs d'un enum dans un tableau.
            foreach (String day in week)// Afficher Toutes les valeurs du tableau.
                Console.WriteLine(day);
            Console.WriteLine(week[4]);
        }
    }
}
