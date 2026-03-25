var rnd = new Random();
int skor_k = 0, skor_b = 0;
string cevap;
int sonuc = 1; // başlangıç değeri eklendi

Console.WriteLine("Taş-Kağıt-Makas oyununa hoş geldiniz!");

do
{
    Console.WriteLine("Lütfen seçiminizi yapın: 1 - Taş, 2 - Kağıt, 3 - Makas");
    int kullanıcıSeçimi = Convert.ToInt32(Console.ReadLine());

    if (kullanıcıSeçimi < 1 || kullanıcıSeçimi > 3)
    {
        Console.WriteLine("Geçersiz seçim! Lütfen 1, 2 veya 3 girin.");
        continue;
    }

    int sayı = rnd.Next(1, 4); // her turda yeni sayı üret

    if (kullanıcıSeçimi == sayı)
    {
        Console.WriteLine("Beraberlik! Bilgisayar da " + sayı + " seçti.");
    }
    else if ((kullanıcıSeçimi == 1 && sayı == 3) || (kullanıcıSeçimi == 2 && sayı == 1) || (kullanıcıSeçimi == 3 && sayı == 2))
    {
        skor_k++;
        Console.WriteLine("Tebrikler! Kazandınız. Bilgisayar " + sayı + " seçti.");
    }
    else
    {
        skor_b++;
        Console.WriteLine("Üzgünüz, kaybettiniz. Bilgisayar " + sayı + " seçti.");
    }

    Console.WriteLine("Skor -> Siz: " + skor_k + " | Bilgisayar: " + skor_b);
    Console.WriteLine("Devam etmek ister misiniz? (E/H)");
    cevap = Console.ReadLine();

    if (cevap == "E" || cevap == "e")
    {
        sonuc = 1;
    }
    else if (cevap == "H" || cevap == "h")
    {
        sonuc = 0;
    }
    else
    {
        Console.WriteLine("Geçersiz cevap! Devam ediliyor.");
        sonuc = 1;
    }

} while (sonuc == 1);
Console.WriteLine("Oyun bitti! Sonuçlar:");
Console.WriteLine("Sizin Skorunuz: " + skor_k);
Console.WriteLine("Bilgisayarın Skoru: " + skor_b);
Console.WriteLine("Teşekkürler! Oyuna katıldığınız için.");