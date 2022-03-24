using System;

class Logika07
{
    public static void Main (String[] args)
    {
        // improve mengulang iterasi dari 10 - 20 lalu balik ke 19 - 10
        
        for (int i = 10; i < 20; i++)
        {
            Console.WriteLine($"Iterasi Ke - {i}");
            if (i == 19)
            for (int j = i+1; j > 14; --j){
                Console.WriteLine($"Iterasi Ke - {j}");
            }
        }
    }
}