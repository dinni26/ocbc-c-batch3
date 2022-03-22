using System;

class Logika08
{
    public static  void Main (String[] args)
    {
        int i = 0;

        do{
            Console.WriteLine("i = {0}", i);
            i++;

            if (i > 5)
            break;
        }
        while (i < 10);
    }
}



