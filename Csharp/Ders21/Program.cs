
static int toplama(int a, int b)
{
    return a + b;
}

Console.WriteLine("iki tane sayi girin");

int sayi1 = Convert.ToInt32(Console.ReadLine());
int sayi2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Toplam: " + toplama(sayi1, sayi2));
Console.ReadLine();




/*
 

using System;

namespace Ders21
{
    class Program
    {   
        static int toplam(int sayı1,int sayı2)
        {
            return sayı1 + sayı2;
        }

        static void Main(string[] args)

        {
            Console.WriteLine("lutfen iki tane sayi girin");

            int sayi1= int.Parse(Console.ReadLine());
            int sayi2 = int.Parse(Console.ReadLine());


            Console.WriteLine(toplam(sayi1, sayi2));
            Console.ReadLine();

        }
    }
}
 */