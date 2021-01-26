using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays_og_bubblesort
{
    class Program
    {

        static void Main(string[] args)
        {
            int[] tal = new int[100];
            int[] talRe = tal;
            Random rand = new Random();
            int temp;

            for (int i = 0; i < 100; i++)
            {
                int randNumbers = rand.Next(1, 1000);
                tal[i] = randNumbers;
            }

            for (int j = 0; j <= tal.Length - 2; j++)
            {
                for (int i = 0; i <= tal.Length - 2; i++)
                {
                    if (tal[i] > tal[i + 1])
                    {
                        temp = tal[i + 1];
                        tal[i + 1] = tal[i];
                        tal[i] = temp;
                    }
                }
            }
            Array.Reverse(talRe);
            for (int i = 0; i < talRe.Length; i++)
            {
                Console.WriteLine(talRe[i]);
            }
        }
    }
}


