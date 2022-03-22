using System;

public class Nomor3
{
	public static void Main(string [] args)
	{
        int d;
            Console.Write("Enter Any Number = ");
            int a= int.Parse(Console.In.ReadLine());
            d = 1;
            Console.Write(a+ "! = ");

            for (int i = 1; i <= a; i++)
            {
                d = d * i;

                Console.Write(a- (i - 1));
                if (i != a)

                    Console.Write("*");
            }
            Console.WriteLine();
            Console.Write(a+ "!");
            Console.Write(" Hasilnya Adalah = ");

            Console.WriteLine(d);
            Console.ReadLine();
	}
}