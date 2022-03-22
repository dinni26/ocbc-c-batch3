using System;

public class Nomor3
{
	public static void Main(string [] args)
	{
        int d;
            Console.Write("Enter Any Number = ");
            int n = int.Parse(Console.In.ReadLine());
            d = 1;
            Console.Write(n + "! = ");

            for (int i = 1; i <= n; i++)
            {
                d = d * i;

                Console.Write(n - (i - 1));
                if (i != n)

                    Console.Write("*");
            }
            Console.WriteLine();
            Console.Write(n + "!");
            Console.Write(" Hasilnya Adalah = ");

            Console.WriteLine(d);
            Console.ReadLine();
	}
}