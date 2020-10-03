using System;

namespace Planetaris
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] n = Array.ConvertAll(Console.ReadLine().Split(' '), i => Convert.ToInt32(i));

            int[] a = Array.ConvertAll(Console.ReadLine().Split(' '), i => Convert.ToInt32(i));

            int nFirst = n[0];

            int nSecond = n[1];

            Array.Sort(a);

            int count = 0;

            if (nFirst == a.Length)
            {
                for (int i = 0; i < a.Length; i++)
                {
                    if (a[i] < nSecond)
                    {
                        nSecond = nSecond - a[i] - 1;

                        count += 1;
                    }
                    else
                    {
                        break;
                    }
                }

                Console.WriteLine(count);
            }
        }
    }
}
