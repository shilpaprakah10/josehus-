using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace josephus
{
    class josephus
    {
        static int saved(int no_of_people, int skips)
        {
            int i, prev = 0;
            for (i = 2; i<= no_of_people; i++)
            {
                prev=(prev + skips) % i;
            }
            return prev + 1;
        }
        static void Main(string[] args)
        {
            int no_of_people, skips;
            Console.WriteLine("Enter the number");
            no_of_people = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the skips");
            skips = int.Parse(Console.ReadLine());
            Console.WriteLine("Position saved " + saved(no_of_people, skips));
            Console.ReadKey();
        }
    }
}
