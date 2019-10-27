using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fizzbuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesite do kojeg broja zelite da idete: ?");
            int brojac = int.Parse(Console.ReadLine());
            for(int i =0; i<= brojac; i++)
            {
                if (i % 3 == 0 && i % 5 == 0 && i != 0)
                {
                    Console.WriteLine("Fiiz-Buzz");
                }
                else if (i % 5 == 0 && i!=0)
                    Console.WriteLine("Buzzz");
                else if (i % 3 == 0 && i!=0)
                    Console.WriteLine("Fizz");
                else
                    Console.WriteLine(i);
            }
            Console.ReadKey();
        } 
    }
}
