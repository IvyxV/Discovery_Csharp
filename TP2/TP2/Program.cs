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
            Random nb_alea = new Random();//Initialise le nb aléatoire
            bool nbOK = false;
            int nb = nb_alea.Next(1, 51);//Demande à l'ordinateur de faire un random entre 1 et 51.
            int nb_user;
            int nb_try = 0;

            Console.WriteLine("Bienvenue dans le jeu : Touver le nombre entre 1 et 50\nMerci de saisir un nombre");
            while (nbOK != true)//Vérif nombre
            {
                if (int.TryParse(Console.ReadLine(), out nb_user))//Lecture de la saisie user
                {
                    if (nb == nb_user)//User à trouver nb
                    {
                        nb_try++;
                        Console.WriteLine("Félicitation, vous avez touvé le bon nombre en " + nb_try + "tentatives");
                        nbOK = true;
                    }
                    else if (nb_user > 50 || nb_user < 1)//Mauvaise saisie user
                    {
                        Console.WriteLine("Merci de saisir un nombre entre 1 et 50");
                    }
                    else if (nb_user < nb)//User à trouver nb trop petit
                    {
                        nb_try++;
                        Console.WriteLine("Trop petit, saisir un nouveau");
                    }
                    else//User à trouver nb trop grand
                    {
                        nb_try++;
                        Console.WriteLine("Trop grand, saisir un nouveau");
                    }
                }
                else
                {
                    Console.WriteLine("Merci de faire une saisie valide");
                }
            }
        }
    }
}
