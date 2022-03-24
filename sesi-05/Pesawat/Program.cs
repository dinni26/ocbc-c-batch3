using System;

namespace Pesawat
{
    class Program
    {
        public static void Main (string[] args)
        {
            Pesawat pesawat = new Pesawat();
            pesawat.nama = "GARUDAKU";
            pesawat.Ketinggian = "2500 Kaki";

            pesawat.terbang();
            pesawat.sudahterbang();
            Console.Read();
        }
    }
}