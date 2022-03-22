using System;

public class Nomor5
{
    public static void Main(string[] args)
    {
        string[] List = {"zero","one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten"};
        int c;
        string str;

        Console.Write("Enter the Number = ");
        c = Convert.ToInt16(Console.ReadLine());
        str = Convert.ToString(c);

        Console.Write("Numbers In Words = ");
        for (int i = 0; i < str.Length; i++)
        {   
            Console.Write($"{List[Int16.Parse(str[i].ToString())]} ");
            
        }
    }
}