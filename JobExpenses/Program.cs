using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace JobExpenses
{
    class Program
    {
        static void Main(string[] args)
        {
            string n = Console.ReadLine();

            int nInt = Convert.ToInt32(n);

            if (0 <= nInt && nInt <= 20000) {

                string s = Console.ReadLine();

                string[] ss = s.Split(" ");

                int[] ssInt = Array.ConvertAll(ss, i => int.Parse(i));

                for (int j = 0; j < ssInt.Length; j++)
                { 
                    if (-50000 <= ssInt[j] && ssInt[j] <= 500000 && ssInt[j] != 0) 
                    {
                        if (nInt == ssInt.Length)
                        {
                            Array.Sort(ssInt);

                            int[] negativeNumbers = ssInt.Where(i => i < 0).ToArray();

                            bool containsNegative = ssInt.Any(i => i < 0);

                            if (containsNegative)
                            {
                                Console.WriteLine(0 - negativeNumbers.Sum());
                            }
                            else
                            {
                                Console.WriteLine(0);
                            }
                            break;
                        }
                    }
                }
            }
        }
    }
}
