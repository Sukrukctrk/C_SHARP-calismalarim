/*


// Dizi Uygulama

// ogrenciler ve notlar isminde 2 tane dizi oluşturunuz ve dizi elemanlarını kullanıcıdan aldığınız değerlerle doldurunuz. (3 öğrenci)

// ogrenciler dizisi kaç elemanlıdır, yazdırınız.

// ilk 2 öğrencinin ad ve not bilgisini yazdırınız.

// tüm öğrencilerin not ortalaması nedir?


*/

string[] ogrenciler = new string[3];

int[] notlar = new int[3];

for (int i = 1; i <= ogrenciler.Length; i++)
{

    Console.WriteLine(+i + "" + ". Öğrencinin adını giriniz:");
    ogrenciler[i - 1] = String.Concat(Console.ReadLine());

    Console.WriteLine(+i + "" + ". Öğrencinin notunu giriniz:");
    notlar[i - 1] = int.Parse(Console.ReadLine());


}


Console.WriteLine("1. Öğrencinin adı: " + ogrenciler[0] + " Notu: " + notlar[0]);
Console.WriteLine("2. Öğrencinin adı: " + ogrenciler[1] + " Notu: " + notlar[1]);

double ortalama = 0;

for (int i = 0; i < notlar.Length; i++)
{
    ortalama += notlar[i];
}
ortalama /= notlar.Length;
Console.WriteLine("Öğrencilerin not ortalaması: " + ortalama);