using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaPremiereApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 42, b = 36;

            Console.WriteLine("Exercice 01 :\nVal a : " + a + "\nVal b : " + b + "\nVal a + b : " + (a + b) + "\n");
            ex02();
            ex03();
            ex04();
            ex05();
            ex06();
            ex07();
            ex08();
        }

       

        static void ex02()
        {
            int x = 1;
            int y = 2;
            int z = 3;
            int result = (x + y) * z;

            Console.WriteLine("Exercice 02 :\nVal x : " + x + "\nVal y : " + y + "\nVal z : " + z + "\nLe résultat (x + y) * z = " + result + "\n");
        }

        private static void ex03()
        {
            int a;
            int b;

            Console.WriteLine("Exercice 03 :\nSaisir valeur A : \n");
            int.TryParse(Console.ReadLine(), out a);
            Console.WriteLine("Saisir valeur B : \n");
            int.TryParse(Console.ReadLine(), out b);
            a = a + 33;
            b++;
            a = a / b;
            Console.WriteLine("Le résultat est : " + a + "\n");
        }
        private static void ex04()
        {
            string V = "Vincent";
            string M = "Monsieur";
            int a = 1;
            Console.WriteLine("Exercice 04 :\nBonjour " + M + " " + V + ", vous êtes venu nous rendre visite " + a + " fois\n");
        }
        private static void ex05()
        {
            Console.WriteLine("Exercice 05 :\nSaisir votre prénom : \n");
            string P = Console.ReadLine();
            Console.WriteLine("Saisir votre nom : \n");
            string N = Console.ReadLine();
            Console.WriteLine("Bonjour " + N + " " + P + ", nous sommes le "+ DateTime.Now + ", comment allez-vous?\n");
        }

        private static void ex06()
        {
            int A;

            Console.WriteLine("Exercice 06 :\nSaisir votre nom : ");
            string N = Console.ReadLine();
            Console.WriteLine("\nSaisir votre prénom : ");
            string P = Console.ReadLine();
            Console.WriteLine("\nSaisir votre année de naissance : ");
            int.TryParse(Console.ReadLine(), out A);
            Console.WriteLine("\nFiches de renseignement\n" + N + "\n" + P + "\n" + (DateTime.Now.Year - A) +"\n");

        }

        private static void ex07()
        {
            double BC, CA;

            Console.WriteLine("Exercie 07\nsaisir la longueur BC : ");
            double.TryParse(Console.ReadLine(), out BC);
            Console.WriteLine("\nsaisir la longueur CA : ");
            double.TryParse(Console.ReadLine(), out CA);
            Console.WriteLine("\nLa longueur de AB est de : " + Math.Sqrt(Math.Pow(BC,2) + (Math.Pow(CA,2))));
        }

        private static void ex08()
        {
            int R;

            Console.WriteLine("Exercice 08\nSaisir le rayon du cercle : ");
            int.TryParse(Console.ReadLine(), out R);
            Console.WriteLine("\n" + " Le prérimetre du cercle est de " + Math.PI * R * 2 + "La surface du cercle est de " + Math.PI * R * R);
        }
    }
}