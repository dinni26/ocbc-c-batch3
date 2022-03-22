using System;

public class Nomor6
{
    public static void Main(string[] args)
    {
        string[] List = {"zero","one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten"};
        string m;

        Console.Write("Enter the Number = ");
        m = Console.ReadLine();
        char[] charv = m.ToCharArray();
        Array.Reverse(charv);
        m = new string(charv);

        Console.Write("Reverse Numbers In Words = ");
        for (int i = 0; i < m.Length; i++)
        {   
            Console.Write($"{List[Int16.Parse(m[i].ToString())]} ");
            
        }
    }
}