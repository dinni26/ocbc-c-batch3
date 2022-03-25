using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Assignment_1
{
    // Improve :
    // 1. Input Nama dan Kode Peserta atau Instruktur
    // 2. Setelah Memilih, Akan Muncul Keterangan Soal Ke-berapa Beserta Judul Soal
    // 3. Akan Kembali Ke Menu Pilihan Untuk Memilih Ulang Soal Setelah Soal Pilihan Pertama Selesai
    // 4. Jika Salah Input, Akan Muncul Warning Karena Memasukan Inputan Yang Salah
    // 5. Jika Salah Input, Akan Kembali Ke Menu Pilihan Untuk Memilih Ulang Soal

    static void Main(string[] args)
    {
        string nama,kode;
        Console.WriteLine();
        Console.WriteLine("------------------ ASSIGNMENT 1 ------------------");
        Console.Write("Masukan Nama : ");
        nama = Console.ReadLine();
        Console.Write("Masukan Kode Peserta atau Instruktur : ");
        kode = Console.ReadLine();
        Console.WriteLine();
        Console.WriteLine($"Nama : {nama}");
        Console.WriteLine($"Kode Peserta atau Instruktur : {kode}");
        Console.WriteLine("SELAMAT DATANG DI PROGRAM MENU ASSIGNMENT 1");
        int pilih;

        MenuPilihan :
        Console.WriteLine();
        Console.WriteLine(" --------- CHOOSE AN OPTION ---------- ");
        Console.WriteLine("1. Segitiga Alphabet");
        Console.WriteLine("2. Segitiga Angka");
        Console.WriteLine("3. Faktorial");
        Console.WriteLine("4. Balik Angka");
        Console.WriteLine("5. Convert Angka To String");
        Console.WriteLine("6. Balik Huruf");
        Console.WriteLine("7. Tentang Saya");
        Console.WriteLine("8. Exit");
        Console.WriteLine("-------------------------------------- ");
        Console.WriteLine();
        Console.Write (" SELECT AN OPTION (1 S/D 8) : ");

        pilih = Convert.ToInt16(Console.ReadLine());
        switch(pilih)
        {

            case 1 :
                int n;
                string abjad = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        
                Console.WriteLine("Soal Nomor 1 : Segitiga Alphabet");
                Console.WriteLine();
                Console.Write("Masukan Jumlah Tingkatan Segitiga (n) = ");
                n = Convert.ToInt16(Console.ReadLine());

                for (int i = 1; i <= n; i++)
                {   
                    int p = 0;
                    for (int j = 0; j < n + i; j++)
                    {   
                        if(j > n-i)
                        {
                            if(p < abjad.Length)
                            {
                                if(j >= n)
                                Console.Write(abjad[p--]);
                            else
                                Console.Write(abjad[p++]);
                            } else{
                                if(j >= n)
                                Console.Write(abjad[abjad.Length%p--]);
                            else
                                Console.Write(abjad[abjad.Length%p++]);
                            }
                                
                        } else {
                            Console.Write(" ");
                        }
                    }
                    Console.WriteLine();
                }
                goto MenuPilihan;
                break ;

            case 2 :
                int h;
                Console.WriteLine("Soal Nomor 2 : Segitiga Angka");
                Console.WriteLine();
                Console.Write("Enter the Range = ");
                h = Convert.ToInt16(Console.ReadLine());

                for (int i = 1; i <= h; i++)
                {   
                    int k = 0;
                    for (int j = 1; j < h + i; j++)
                    {   
                        if(j > h-i)
                        {
                            if(j > h)
                                Console.Write(--k);
                            else
                                Console.Write(++k);
                        } else {
                            Console.Write(" ");
                        }
                    }
                    Console.WriteLine();
                }
                goto MenuPilihan;
                break;
        
            case 3 :
                Console.WriteLine("Soal Nomor 3 : Faktorial");
                Console.WriteLine();
                int d;
                Console.Write("Enter Any Number = ");
                int a = int.Parse(Console.In.ReadLine());
                d = 1;
                Console.Write(a + "! = ");

                for (int i = 1; i <= a; i++)
                {
                    d = d * i;

                    Console.Write(a - (i - 1));
                    if (i != a)

                        Console.Write("*");
                }
                Console.WriteLine();
                Console.Write(a+ "!");
                Console.Write(" Hasilnya Adalah = ");

                Console.WriteLine(d);
                goto MenuPilihan;
                break;

            case 4 :
                Console.WriteLine("Soal Nomor 4 : Balik Angka");
                Console.WriteLine();
                Console.WriteLine("Enter a number : ");
                int val = int.Parse(Console.ReadLine());

                int remind, reverse = 0;
                while (val>0)
                {
                    remind = val % 10;
                    reverse = reverse * 10 + remind;
                    val= val / 10;
                }
                Console.WriteLine($"Reverse Number : {reverse}");
                goto MenuPilihan;
                break;

            case 5:
                Console.WriteLine("Soal Nomor 5 : Convert Angka To String");
                Console.WriteLine();
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
                Console.WriteLine();
                goto MenuPilihan;
                break;

            case 6 :
                Console.WriteLine("Soal Nomor 6 : Balik Huruf");
                Console.WriteLine();
                string[] ListNumber = {"zero","one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten"};
                string m;

                Console.Write("Enter the Number = ");
                m = Console.ReadLine();
                char[] charv = m.ToCharArray();
                Array.Reverse(charv);
                m = new string(charv);

                Console.Write("Reverse Numbers In Words = ");
                for (int i = 0; i < m.Length; i++)
                {   
                    Console.Write($"{ListNumber[Int16.Parse(m[i].ToString())]} ");
                    
                }
                Console.WriteLine();
                goto MenuPilihan;
                break;

            case 7 :
                Console.WriteLine();
                Console.WriteLine("-------------- TENTANG SAYA ---------------");
                Console.WriteLine("Nama Peserta : Dini Tri Widianingsih");
                Console.WriteLine("Kode Peserta : FSDO003ONL007");
                Console.WriteLine("Jenis Kelamin : Perempuan");
                Console.WriteLine("Alamat : Jl. Tanah Merdeka, Ciracas");
                Console.WriteLine("No. Telephone : 085691362814");
                Console.WriteLine("Hobi : Travelling");
                Console.WriteLine("Umur : 22");
                Console.WriteLine("Pekerjaan : Fullstack Engineer at OCBC NISP - aamiin...");
                Console.WriteLine("Jurusan : Teknik Informatika");
                Console.WriteLine("Nama Kampus : Universitas Indraprasta PGRI");
                Console.WriteLine("SIAP MENGIKUTI PROGRAM BOOTCAMP OCBC NISP");
                Console.WriteLine("-------------------------------------------");
                goto MenuPilihan;
                break;
        
            case 8 :
                Console.WriteLine("----------------------------");
                Console.WriteLine("Selesai & Terima Kasih!");
                Console.WriteLine("----------------------------");
                Console.ReadKey();
                break;
        
            default:
            Console.WriteLine("Input Yang Anda Masukan Salah, Silahkan Pilih Kembali!");
            goto MenuPilihan;
            break;
        }
    }
}