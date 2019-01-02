using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP
{
    class Program
    {
        static void Main(string[] args)
        {
            float weight = 0, height = 0, IMC = 0;
            bool weightOK = false, heightOK = false;

            while (weightOK != true)//Vérif poids possible.
            {
                if (weight <= 0 || weight > 700)
                {
                    Console.WriteLine("Merci de saisir votre poids en Kg");
                    float.TryParse(Console.ReadLine(), out weight);
                }
                else
                {
                    weightOK = true;
                }
            }
            while (heightOK != true)//Vérif Taile possible
            {
                if (height <= 0 || height > 3)
                {
                    Console.WriteLine("Merci de saisir votre taille en mètre");
                    float.TryParse(Console.ReadLine(), out height);
                }
                else
                {
                    heightOK = true;
                }
            }
            IMC = weight / (height * height);//Calcul IMC
            if (IMC < 500)//Vérif IMC possible
            {
                Console.WriteLine("Votre indice de masse corporelle est de " + IMC + ".");
            }
            else
            {
                Console.WriteLine("Votre indice de masse corporelle est supérieur à 500.");
            }

            if (IMC < 16.5)//Toutes les conditions suivantes servent à donner les interprétations de l'IMC de l'utilisateur.
            {
                Console.WriteLine("Dénutrition");
            }
            else if (IMC >= 16.5 && IMC < 18.5)
            {
                Console.WriteLine("Maigreur");
            }
            else if (IMC >= 18.5 && IMC < 25)
            {
                Console.WriteLine("Corpulence normale");
            }
            else if (IMC >= 25 && IMC < 30)
            {
                Console.WriteLine("Surpoids");
            }
            else if (IMC >= 30 && IMC < 35)
            {
                Console.WriteLine("Obésité modérée");
            }
            else if (IMC >= 35 && IMC < 40)
            {
                Console.WriteLine("Obésité sévère");
            }
            else
            {
                Console.WriteLine("Obésité morbide ou massive");
            }
        }
    }
}