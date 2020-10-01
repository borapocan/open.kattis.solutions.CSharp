using System;

public class Trik
{
    public static void Main(string[] args)
    {
        int position = 1;

        string moves = Console.ReadLine();

        for (int i = 0; i < moves.Length; i++)
        {
            switch (moves[i])
            {
                case 'A':

                    if (position == 1)
                    {
                        position = 2;
                    }
                    else if (position == 2)
                    {
                        position = 1;
                    }
                    break;

                case 'B':

                    if (position == 2)
                    {
                        position = 3;
                    }
                    else if (position == 3)
                    {
                        position = 2;
                    }
                    break;

                case 'C':

                    if (position == 1)
                    {
                        position = 3;
                    }
                    else if (position == 3)
                    {
                        position = 1;
                    }
                    break;
            }
        }
        Console.WriteLine(position);
    }
}
