using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pravokutni_trokut
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 3;
            int y = 4;
            int z = 5;

            if (x > 0 && y > 0 && z > 0)
            {
                if (x * x + y * y == z * z)
                {
                    Console.WriteLine("Vrijednosti predstavljaju pravokutni trokut.");
                }
                else
                {
                    Console.WriteLine("Vrijednosti ne predstavljaju pravokutni trokut.");
                }
            }
            else
            {
                Console.WriteLine("Svi iznosi moraju biti veći od 0.");
            }
            Console.ReadKey();
        }
    }
}
