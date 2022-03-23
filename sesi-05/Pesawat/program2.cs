using System;

class Program2
{
    public static void Main (string[] args)
    {
        class_pesawat pesawat = new class_pesawat();
        pesawat.nama = "GARUDAKU";
        pesawat.ketinggian = "2500 Kaki";

        pesawat.terbang();
        pesawat.sudahterbang();
        Console.Read();
    }
}