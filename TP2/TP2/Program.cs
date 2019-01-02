using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random nb_alea = new Random();
            bool nbOK = false;
            int nb = nb_alea.Next(1, 50), nb_user;

            Console.WriteLine("Touver le nombre entre 1 et 50");
            int.TryParse(Console.ReadLine(), out nb_user);
            Console.WriteLine("Saisir un nombre");
            while (nbOK != true)//Vérif nombre
            {
                
                if (nb == nb_user)
                {
                    Console.WriteLine("Félicitation, vous avez touvé le bon nombre");
                    nbOK = true;
                }
                else if (nb_user < nb)
                {
                    Console.WriteLine("Trop petit, saisir un nouveau");
                    int.TryParse(Console.ReadLine(), out nb_user);
                }
                else
                {
                    Console.WriteLine("Trop grand, saisir un nouveau");
                    int.TryParse(Console.ReadLine(), out nb_user);
                }
            }
        }
    }
}
