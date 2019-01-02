using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX05
{
    class Program
    {
        static void Main(String[] args)
        {
            List<int> numbers = new List<int>();
            for (int number = 2; number < 7; number++)
                numbers.Add(number);
            numbers.Insert(0,1);
            numbers.Insert(6,7);
            foreach (int i in numbers)
                Console.WriteLine(i);
        }
    }
}
