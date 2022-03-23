using System;

class Logika02
{
    public static void Main (String[] args)
    {
        // improve masukan nama dan menambah keterangan giat belajar 
        int nilai = 30;
        string nama;

        Console.Write("Masukan Nama Anda : ");
        nama = Console.ReadLine();

        if (nilai < 40) {

            Console.WriteLine("Nilai Kamu D");
            for(int i = 0; i < 5; i++)
            {
                Console.WriteLine("Saya Akan Giat Belajar {0}", i);
            }
        }

        else if (nilai <= 60) {
            Console.WriteLine("Nilai Kamu C");
        }
        else if (nilai < 80) {
            Console.WriteLine("Nilai Kamu B");
        }
        else {
            Console.WriteLine("Nilai Kamu A");
        }
    }
}