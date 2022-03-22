using System;

public class Nomor4
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a number : ");
        int val = int.Parse(Console.ReadLine());

        int remind, reverse = 0;
        while (val>0)
        {
            remind = val % 10;
            reverse = reverse * 10 + remind;
            val= val / 10;
        }
        Console.WriteLine($"Reverse Number : {reverse}");
    }
}