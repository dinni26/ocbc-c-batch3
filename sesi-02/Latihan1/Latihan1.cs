using System;

class Project3
{
    static void Main(String[]args)
    {

    string username, password, jk, status;
    int umur;
    bool status_jk, status_nikah;

    Console.WriteLine("== PROGRAM BIODATA ===");
    Console.Write("Masukan Username: ");
    username = Console.ReadLine();

    Console.Write("Masukan Password: ");
    password = Console.ReadLine();

    Console.Write("Masukan Umur: ");
    umur = int.Parse(Console.ReadLine());

    do{
        Console.Write("Masukan Jenis Kelamin [Laki-Laki / Perempuan]: ");
        jk = Console.ReadLine();
        status_jk = jk == "Laki-Laki" || jk == "Perempuan";
    } while (!status_jk);

    if (jk == "Laki-Laki" || jk == "Perempuan")
    {
        Console.WriteLine($"Jenis Kelamin : {jk}");

    }

    do{
        Console.Write("Masukan Status Nikah [Y / N]: ");
        status = Console.ReadLine();
        status_nikah = status == "Y" || status == "N";
    } while (!status_nikah);


    Console.WriteLine("=====================");
    Console.WriteLine();
    Console.WriteLine("Terimakasih!");
    Console.WriteLine("Data Berikut");
    Console.WriteLine($"Username: {username}");
    Console.WriteLine($"Password: {password}");
    Console.WriteLine($"Umur: {umur} tahun");
    Console.WriteLine($"Jenis Kelamin: {jk}");
    Console.WriteLine($"Status Nikah: {status_nikah}");
    Console.WriteLine("SUDAH DISIMPAN!");

    Console.WriteLine();
    Console.WriteLine("=======PERHITUNGAN ARITMATIKA=======");
    int nilaipertama, nilaikedua, nilaiketiga, total_nilai, rata2_nilai;

    Console.WriteLine("Masukan Nilai Pertama");
    nilaipertama = int.Parse(Console.ReadLine());
    Console.WriteLine("Masukan Nilai Kedua");
    nilaikedua = int.Parse(Console.ReadLine());
    Console.WriteLine("Masukan Nilai Ketiga");
    nilaiketiga = int.Parse(Console.ReadLine());

    total_nilai = nilaipertama + nilaikedua + nilaiketiga;
    rata2_nilai = total_nilai/3;


    Console.WriteLine($"Total Nilai: {total_nilai}");
    Console.WriteLine($"Rata-Rata Nilai: {rata2_nilai}");   

    }
}