
string kursAdi = "C# Programlama Dili";



/*

- kursAdi değişkeni kaç karakterden oluşmaktadır?
- kursAdi'nın tüm harflerini küçük harfe çeviriniz.
- kursAdi değişkeni nokta (.) karakteri ile mi başlıyor?
- kursAdi içinde "C#" ifadesi hangi konumda yer almaktadır?
- kursAdi, "C#" ifadesini içeriyor mu?
- kursAdi içerisindeki "Dili" kelimesini "Dersleri" ile değiştiriniz.


*/

int sayac = 0;
foreach (var item in kursAdi)
{
    if (item == ' ')
    {
        sayac++;
    }
 }

Console.WriteLine("cumlenin karakter sayısı =" + sayac + 1);

string kucukHarfliKursAdi = kursAdi.ToLower();
Console.WriteLine("Küçük harfli kurs adı: " + kucukHarfliKursAdi);

Console.WriteLine("****************************************************************************");

for (var i = 0; i < kursAdi.Length; i++)

{
    if (kursAdi[i] == '.')
    {
        Console.WriteLine("Kurs adı nokta (.) karakteri ile başlıyor.");
        break;
    }
    else
    {
        Console.WriteLine("Kurs adı nokta (.) karakteri ile başlamıyor.");
        break;
    }
}

Console.WriteLine("****************************************************************************");


for (var j = 0; j < kursAdi.Length; j++)

{
    if (kursAdi[j] == 'C')
    {
        if (kursAdi[j + 1] == '#')
        {
            Console.WriteLine("Kurs adı içinde 'C#' ifadesi " + j + ". konumda yer almaktadır.");
            break;
        }
    }

}

Console.WriteLine("****************************************************************************");