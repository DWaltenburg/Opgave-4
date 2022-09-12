using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] fornavne = { "Ib", "Kim", "Helle", "Jens", "Ove" };
            Console.WriteLine($"Første fornavn: {fornavne[0]}");
            Console.WriteLine($"Sidste fornavn: {fornavne.Last()}");

            foreach (string s in fornavne)
            {
                Console.WriteLine(s);
            }

            string[] efternavne = { "Jensen", "Nielsen", "Larsen" };

            foreach (string s in fornavne)
            {
                foreach (string t in efternavne)
                {
                    Console.WriteLine($"{s} {t}");
                }
            }
            Console.WriteLine("Tre nye efternavne:");
            efternavne[0] = Console.ReadLine();
            efternavne[1] = Console.ReadLine();
            efternavne[2] = Console.ReadLine();

            foreach (string s in fornavne)
            {
                foreach (string t in efternavne)
                {
                    Console.WriteLine($"{s} {t}");
                }
            }
        }
    }
}
