Console.WriteLine("Lütfen menüden bir seçim yapınız:");
Console.WriteLine("1- içecekler");
Console.WriteLine("2- yiyecekler");
Console.WriteLine("3- tatlılar");
Console.WriteLine("4- çıkış");
int hesap = 0;


int secim = int.Parse(Console.ReadLine());
switch (secim)
{
    case 1:
        Console.WriteLine("İçecekler menüsü:");
        Console.WriteLine("1- Çay 15 tl");
        Console.WriteLine("2- Kahve 50 tl");
        Console.WriteLine("3- Su 10 tl");

        int secim1 = int.Parse(Console.ReadLine());

        switch (secim1)
        {
            
            case 1:
                hesap += 15;
                Console.WriteLine("Çay seçildi. Hesap: " + hesap + " tl");
                break;

            case 2:
                hesap += 50;
                Console.WriteLine("Kahve seçildi. Hesap: " + hesap + " tl");
                break;

            case 3:
                hesap += 10;
                Console.WriteLine("Su seçildi. Hesap: " + hesap + " tl");
                break;

            default:
                Console.WriteLine("Geçersiz içecek seçimi.");
                break;
        }

    
        break;

    case 2:
        Console.WriteLine("Yiyecekler menüsü:");
        Console.WriteLine("1- Pizza 150 tl");
        Console.WriteLine("2- Hamburger 200 tl");
        Console.WriteLine("3-  Salata 50 tl");
        int secim2 = int.Parse(Console.ReadLine());

        switch (secim2)
        {
            case 1:
                hesap += 150;
                Console.WriteLine("Pizza seçildi. Hesap: " + hesap + " tl");
                break;

            case 2:
                hesap += 200;
                Console.WriteLine("Hamburger seçildi. Hesap: " + hesap + " tl");
                break;

            case 3:
                hesap += 50;
                Console.WriteLine("Salata seçildi. Hesap: " + hesap + " tl");
                break;

            default:
                Console.WriteLine("Geçersiz yiyecek seçimi.");
                break;
        }
        break;

    case 3:
        Console.WriteLine("Tatlılar menüsü:");
        Console.WriteLine("1- Pasta 100 tl");
        Console.WriteLine("2- Dondurma 50 tl");
        Console.WriteLine("3- Baklava   200 tl");
        int secim3 = int.Parse(Console.ReadLine());

        switch (secim3)
        {
            case 1:
                hesap += 100;
                Console.WriteLine("Pasta seçildi. Hesap: " + hesap + " tl");
                break;

            case 2:
                hesap += 50;
                Console.WriteLine("Dondurma seçildi. Hesap: " + hesap + " tl");
                break;

            case 3:
                hesap += 200;
                Console.WriteLine("Baklava seçildi. Hesap: " + hesap + " tl");
                break;

            default:
                Console.WriteLine("Geçersiz tatlı seçimi.");
                break;
        }
        break;

    case 4:
        Console.WriteLine("Çıkış yapılıyor...");
        break;

    default:
        Console.WriteLine("Geçersiz seçim. Lütfen tekrar deneyin.");
        break;
}