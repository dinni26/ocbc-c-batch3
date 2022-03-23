using System;

class Program
{

    public static void Main(string[] args)
    {
        pesawat pesawat new pesawat();
        pesawat_tempur pswt tempur = new pesawat_tempur();//instantiasi objek

        pesawat.Nama = "Helly";
        pesawat.JumlahRoda = 3;
        pesawat. Ketinggian = "1000 kaki";
        pesawat.JumlahPenumpang = "3 penumpang";
        pswttempur.Nama = "AZ5OOTPU";
        pswttempur.JumlahRoda = 5;
        pswttempur.Ketinggian = "200 kaki";
        pswttempur.JumlahPenumpang = "2 Penumpang plus kopilot dan asistance";

        pesawat.terbang();
        pswttempur.terbangtinggi();
        Console.Read();
    }
}