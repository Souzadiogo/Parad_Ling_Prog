using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex03a
{
    class Program
    {
        static void absoluto(int[] x)
        {
            x = new int[10];

            int i;
            for (i = 0; i < 10; i++)
            {
                if (x[i] < 0)
                {
                    x[i] = -(x[i]);
                }
                Console.Write(x[i]);

            }
        }

        static void Main(string[] args)
        {
            vet = new int[10];
            int i;

            for (i = 0; i < 10; i++)
            {
                Console.Write("\nValor absoluto [%d]:", i);
                int.Parse(Console.ReadLine());


            }

            absoluto(vet);
        }
    }
}
