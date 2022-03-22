using System;

public class Nomor4
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a number : ");
        int n = int.Parse(Console.ReadLine());

        int remind, reverse = 0;
        while (n>0)
        {
            remind = n % 10;
            reverse = reverse * 10 + remind;
            n = n / 10;
        }
        Console.WriteLine($"Reverse Number : {reverse}");
    }
}