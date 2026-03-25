

var rnd = new Random();  // Random sayılar üretmek için Random sınıfını kullanıyoruz

int sayı = rnd.Next(1, 100); // 1 ile 100 arasında rastgele bir sayı üretiyoruz


Console.WriteLine("lutfen 1 ile 100 arasında bir sayı tahmin edin: ");

int tahmin_h = 7;

do
{
    int tahmin = Convert.ToInt32(Console.ReadLine()); // Kullanıcıdan tahmin alıyoruz

    if (tahmin < sayı)
    {
        Console.WriteLine("Daha büyük bir sayı girin.");
        tahmin_h--;
    }
    else if (tahmin > sayı)
    {
        Console.WriteLine("Daha küçük bir sayı girin.");
        tahmin_h--;
    }
    else
    {
        Console.WriteLine("Tebrikler! Doğru tahmin ettiniz.");
        break;
    }
}while (tahmin_h != 0);
