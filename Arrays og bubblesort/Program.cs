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

            for (int i = 0; i <= tal.Length - 2; i++)
            {
                for (int j = 0; j <= tal.Length - 2; j++)
                {
                    if (tal[j] > tal[j + 1])
                    {
                        temp = tal[j + 1];
                        tal[j + 1] = tal[j];
                        tal[j] = temp;
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


