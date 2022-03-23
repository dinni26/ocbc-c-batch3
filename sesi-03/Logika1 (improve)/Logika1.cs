using System;

class Logika01
{
    public static void Main (String[] args)
    {
        // improve memasukan nilai A dan A = 1
        int a , b = 53;
        bool hasil = false;

        Console.Write("Masukan Nilai A : ");
        a = int.Parse(Console.ReadLine());
        
            if (a > b) 
                Console.WriteLine("a lebih besar dari b");
            else 
                if (1 == a)
                hasil = true;

                if (hasil)
                    Console.WriteLine("Nilai a adalah 1");
                else
                    Console.WriteLine("Nilai a lebih besar dari 1");

    }
}