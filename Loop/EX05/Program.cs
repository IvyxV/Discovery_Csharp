using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX05
{
    class Program
    {
        static void Main(string[] args)
        {
            String[] week = new String[] { "Lundi", "Mardi", "Mercredi", "Jeudi", "Vendredi", "Samedi", "Dimanche" };
            for (int i = 0; i < 7; i++)
                Console.WriteLine(week[i]);
        }
    }
}
