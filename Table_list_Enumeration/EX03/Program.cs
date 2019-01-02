using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX03
{
    class Program
    {
        static void Main(String[] args)
        {
            String[] week = new String[] { "Lundi", "Mardi", "Mercredi", "Jeudi", "Jeudi", "Samedi", "Dimanche" };
            {
                foreach (String i in week)
                    Console.WriteLine(i);
                int k = Array.IndexOf(week, "Jeudi");
                week[k + 1] = "Vendredi";
                foreach (String j in week)
                    Console.WriteLine(j);
            }
        }
    }
}