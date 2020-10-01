using System;

namespace PrimaryArithmetic
{
    class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {

                string s = Console.ReadLine();

                string[] ss = s.Split(' ');

                string n1 = ss[0];

                string n2 = ss[1];

                int first = Convert.ToInt32(n1);

                int second = Convert.ToInt32(n2);

                if (n1 == "0" && n2 == "0")
                {
                    break;
                }

                int carries = 0;

                int carry = 0;

                while (first != 0 && second != 0)
                {
                    int sum = carry + first % 10 + second % 10;

                    if (sum >= 10)
                    {
                        carries++;
                    }

                    carry = sum / 10;

                    first /= 10;

                    second /= 10;
                }

                if (carries == 0)
                {
                    Console.WriteLine("No carry operation.");
                }
                else if (carries == 1)
                {
                    Console.WriteLine("1 carry operation.");
                }
                else
                {
                    Console.WriteLine(carries + " carry operations.");
                }
            }
            
        }
    }
}
