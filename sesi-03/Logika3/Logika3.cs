using System;

class Logika03
{
    public static void Main (String[] args)
    {
        string Username;
        string Password;

        Console.Write("Username : ");
        Username = Console.ReadLine();
        Console.Write("Password : ");
        Password = Console.ReadLine();

        if (Username == "ocbc" && Password == "bootcamp")
        Console.WriteLine("Anda Berhasil Login");

        else 
        Console.WriteLine("Username atau Password Anda Salah");
    }
}
