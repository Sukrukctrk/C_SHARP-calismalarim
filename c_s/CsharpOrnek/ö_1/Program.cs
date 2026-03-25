// Not Ortalaması Hesaplama Sistemi
// Kullanıcının girdiği notlarla sınıf ortalaması, en yüksek ve en düşük notu hesapla.

Console.WriteLine("lutfen kac adet not gireceğinizi girin");

int not_sayisi = int.Parse(Console.ReadLine());
int[] list = new int[not_sayisi];
var ortalama = 0;
int i = 0;

Console.WriteLine("Lütfen notlarınızı giriniz:");
while (i < not_sayisi)
{

    list[i] = int.Parse(Console.ReadLine());
       ortalama+= list[i] ;

    i++;

    

}
 ortalama = ortalama / not_sayisi;


Array.Sort(list);

Console.WriteLine("Ortalama: " + ortalama);
Console.WriteLine("En yüksek not: " + list[not_sayisi-1]);
Console.WriteLine("En düşük not: " + list[0]);

