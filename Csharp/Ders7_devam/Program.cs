int hesap = 0;
bool devam = true;

while (devam)
{
    Console.WriteLine("\nLütfen menüden bir seçim yapınız:");
    Console.WriteLine("1- İçecekler");
    Console.WriteLine("2- Yiyecekler");
    Console.WriteLine("3- Tatlılar");
    Console.WriteLine("4- Çıkış");

    int secim = int.Parse(Console.ReadLine());

    switch (secim)
    {
        case 1:
            Console.WriteLine("1- Çay (15 TL)");
            Console.WriteLine("2- Kahve (50 TL)");
            Console.WriteLine("3- Su (10 TL)");
            int icecek = int.Parse(Console.ReadLine());
            if (icecek == 1) hesap += 15;
            else if (icecek == 2) hesap += 50;
            else if (icecek == 3) hesap += 10;
            else Console.WriteLine("Geçersiz içecek seçimi.");
            break;

        case 2:
            Console.WriteLine("1- Pizza (150 TL)");
            Console.WriteLine("2- Hamburger (200 TL)");
            Console.WriteLine("3- Salata (50 TL)");
            int yemek = int.Parse(Console.ReadLine());
            if (yemek == 1) hesap += 150;
            else if (yemek == 2) hesap += 200;
            else if (yemek == 3) hesap += 50;
            else Console.WriteLine("Geçersiz yiyecek seçimi.");
            break;

        case 3:
            Console.WriteLine("1- Pasta (100 TL)");
            Console.WriteLine("2- Dondurma (50 TL)");
            Console.WriteLine("3- Baklava (200 TL)");
            int tatli = int.Parse(Console.ReadLine());
            if (tatli == 1) hesap += 100;
            else if (tatli == 2) hesap += 50;
            else if (tatli == 3) hesap += 200;
            else Console.WriteLine("Geçersiz tatlı seçimi.");
            break;

        case 4:
            devam = false;
            break;

        default:
            Console.WriteLine("Geçersiz seçim, tekrar deneyin.");
            break;
    }
}

Console.WriteLine($"\nToplam hesabınız: {hesap} TL");