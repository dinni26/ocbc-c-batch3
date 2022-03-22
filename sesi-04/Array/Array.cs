using System;

class Array
{
    public static void Main (String[] args)
    {
        string [] contoh = new string [4]
        {
            "Motherboard", "Processor", "Power Supply", "Video Card"
        };

        Console.WriteLine("Menampilkan Semua Data Dalam Array");
        Console.WriteLine("");

        foreach(string contoh1 in contoh)
        {
            Console.WriteLine(contoh1);
        }

        Console.Write("Press Any Key To Continue . . .");
    }
}