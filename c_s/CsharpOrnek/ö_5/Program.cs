// Fibonacci Hesaplayıcı
// Girilen terim sayısına göre fibonacci dizisi üretir.


Console.Write("Fibonacci dizisi için terim sayısını giriniz: ");
int terimSayisi = Convert.ToInt32(Console.ReadLine());


int birinci = 0;
int ikinci = 1;
int toplam = 0;

for (int i =0;i<terimSayisi;i++)
{
    if (i == 0)
    {
        Console.WriteLine(birinci);
        continue;
    }
    if (i == 1)
    {
        Console.WriteLine(ikinci);
        continue;
    }
    
    toplam = birinci + ikinci; 
    birinci = ikinci; 
    ikinci = toplam; 
    
    Console.WriteLine(toplam); // Yeni terimi yazdır
}