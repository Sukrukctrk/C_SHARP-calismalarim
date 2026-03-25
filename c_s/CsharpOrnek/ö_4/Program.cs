// Sayının Basamaklarını Toplama
// Girilen sayının tüm basamaklarının toplamını verir. (Örn: 123 → 6)

Console.Write("Bir sayı giriniz: ");
int sayi = Convert.ToInt32(Console.ReadLine());


var uzunluk = sayi.ToString().Length;
int toplam = 0;

for (int i = 0; i < uzunluk; i++)
{
    int basamak = sayi % 10; // Son basamağı al
    toplam += basamak; // Basamağı toplama ekle
    sayi /= 10; // Son basamağı çıkar
}

Console.WriteLine($"Girilen sayının basamakları toplamı: {toplam}");