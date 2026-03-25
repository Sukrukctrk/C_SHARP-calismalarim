static int asalmi(int sayi)
{
    if (sayi == 2)
    {
        return 1; // 2 asal
    }
    else if (sayi < 2)
    {
        return 0; // 0 ve 1 asal değil
    }
    else
    {
        for (int i = 2; i * i <= sayi; i++) // Math kullanmadan karekök sınırı
        {
            if (sayi % i == 0)
            {
                return 0; // Tam bölündüyse asal değil
            }
        }
        return 1; // Hiç böleni yoksa asal
    }
}

Console.WriteLine("Lütfen asal olup olmadığını anlamak istediğiniz sayıyı girin:");
int sayi = Convert.ToInt32(Console.ReadLine());

if (asalmi(sayi) == 1)
{ggg
    Console.WriteLine("Asal");
}
else
{
    Console.WriteLine("Asal değil");
}

Console.ReadLine();