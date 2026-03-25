// Yazı-Tura Oyunu
// Belirtilen sayıda yazı-tura atılır, sonuçlar ve istatistik gösterilir.

var rnd = new Random();



int yazı = 0;
int tura = 0;

Console.WriteLine("Lütfen yazı-tura oyunu için atılacak deneme sayısını girin:");
int denemeSayısı = Convert.ToInt32(Console.ReadLine());

for (int i = 0; i < denemeSayısı; i++)
{
    int atılan = rnd.Next(0, 2);
    if (atılan == 0)
    {
        yazı++;

    }
    else
    {
        tura++;

    }
}

Console.WriteLine(+denemeSayısı+" atışta " + yazı + " yazı ve " + tura + " tura geldi.");


