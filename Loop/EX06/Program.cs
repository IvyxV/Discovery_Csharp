using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX06
{
    class Program
    {
        static void Main(string[] args)
        {
            String[] week = new String[] { "Janvier", "Février", "Mars", "Avril", "Mai", "Juin", "Juillet", "Aout", "Septembre", "Octobre", "Novembre", "Décembre" };
            foreach (String i in week)
                Console.WriteLine(i);
        }
    }
}
