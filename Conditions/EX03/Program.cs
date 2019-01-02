using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX03
{
    class Program
    {
        static void Main(string[] args)
        {
            int age;
            String sexe = Console.ReadLine();
            int.TryParse(Console.ReadLine(), out age);
            if (sexe == "Homme")
                Console.WriteLine("Vous êtes un homme ");
            else
                Console.WriteLine("Vous êtes une femme ");
            majmin(age);
        }

        private static void majmin(int age)
        {
            if (age >= 18)
                Console.WriteLine("et vous êtes majeur.");
            else
                Console.WriteLine("et vous êtes mineur.");
        }
    }
}