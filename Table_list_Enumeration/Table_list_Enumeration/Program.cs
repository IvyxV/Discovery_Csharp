using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Table_list_Enumeration
{
    class Program
    {
        static void Main(String[] args)
        {
            String[] week = new String[] { "Lundi", "Mardi", "Mercredi", "Jeudi", "Vendredi", "Samedi", "Dimanche" };
            for (int i = 0; i < week.Length; i++)
                Console.WriteLine(week[i]);
        }
    }
}
