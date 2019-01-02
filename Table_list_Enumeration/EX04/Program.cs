using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX04
{
    class Program
    {
        static void Main(String[] args)
        {
            String[] shopping = new String[] { "Carottes", "Oignons", "Pomme de terre", "Salade", "Tomate" };
            foreach (string i in shopping)
                Console.WriteLine(i);
        }
    }
}
