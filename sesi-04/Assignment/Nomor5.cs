using System;

public class Nomor5
{
    public static void Main(string[] args)
    {
        string[] List = {"zero","one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten"};
        int n;
        string str;

        Console.Write("Enter the Number = ");
        n = Convert.ToInt16(Console.ReadLine());
        str = Convert.ToString(n);


        for (int i = 0; i < str.Length; i++)
        {   
            Console.Write($"{List[Int16.Parse(str[i].ToString())]} ");
            
        }
    }
}