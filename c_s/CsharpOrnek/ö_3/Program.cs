// EBOB - EKOK Hesaplayıcı
// 2 sayının en büyük ortak bölenini ve en küçük ortak katını bulur.

using System.ComponentModel;

Console.WriteLine("Lütfen birinci sayıyı girin: ");
int sayi1 = int.Parse(Console.ReadLine());
Console.WriteLine("Lütfen ikinci sayıyı girin: ");
int sayi2 = int.Parse(Console.ReadLine());

var gecici1 = 0;


var EBOB = 1;
var EKOK = 1;

if (sayi1 < sayi2) {

    gecici1 = sayi1;
    sayi1 = sayi2;
    sayi2 = gecici1;
}


for (int i = 1; i < sayi1; i++)
{
    if (sayi1 % i == 0 && sayi2 % i == 0)
    {
        EBOB = i;
    }


}

for (int i = 1; i <= sayi1 * sayi2; i++)
{
    if (i % sayi1 == 0 && i % sayi2 == 0)
    {
        EKOK = i;
        break;
    }
}

Console.WriteLine($"EBOB: {EBOB}");
Console.WriteLine($"EKOK: {EKOK}");