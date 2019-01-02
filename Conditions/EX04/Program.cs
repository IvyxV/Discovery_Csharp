using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX04
{
    class Program
    {
        static void Main(string[] args)
        {
            String login = "LECANARD";
            String password = "1234";
            Console.WriteLine("Saisir votre identifiant : ");
            string log = Console.ReadLine();
            Console.WriteLine("Saisir votre Mot de passe : ");
            string mdp = Console.ReadLine();
            if (login == log && password == mdp)
                Console.WriteLine("Bienvenue à la Manu Amiens.");
            else
                Console.WriteLine("Mauvais identifiant ou mauvais mot de passe.");
        }
    }
}