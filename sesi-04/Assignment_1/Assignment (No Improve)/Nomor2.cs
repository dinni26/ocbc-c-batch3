using System;

public class Nomor2
{
    public static void Main(string [] args)
    {
        int h;

        Console.Write("Enter the Range = ");
        h = Convert.ToInt16(Console.ReadLine());

        for (int i = 1; i <= h; i++)
        {   
            int k = 0;
            for (int j = 1; j < h + i; j++)
            {   
                if(j > h-i)
                {
                    if(j > h)
                        Console.Write(--k);
                    else
                        Console.Write(++k);
                } else {
                    Console.Write(" ");
                }
            }
            Console.WriteLine();
        }
    }
}