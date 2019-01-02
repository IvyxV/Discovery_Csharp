using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX02
{
    class Program
    {
        static void Main(string[] args)
        {
            int age;
            int.TryParse(Console.ReadLine(), out age);
            if (age >= 18)
                Console.WriteLine("Vous avez " + age + " ans, vous êtes donc majeur.");
            else
                Console.WriteLine("Vous avez " + age + " ans, vous êtes donc mineur.");
        }
    }
}
