

var isim = "şükrü";

foreach (var karakte in isim)
{
    Console.WriteLine(karakte);
}


/*
aslında bu kod şunla aynı işi yapar

for (var i = 0; i < isim.Length; i++)
{
    Console.WriteLine(isim[i]);
}


*/

// kullanıcının girdiği sayıdan ve girdiği karekterden kaçtane olduğunu bulan program

Console.WriteLine("Lütfen bir cümle giriniz:");
var cumle = Console.ReadLine();
Console.WriteLine("Lütfen bir karakter giriniz:");
Char karakter = char.Parse(Console.ReadLine());
var sayac = 0;

foreach (var item in cumle)
{
    if (item == karakter)
    {
        sayac++;
    }
}
Console.WriteLine($"Cümledeki {karakter} karakteri {sayac} kez geçiyor.");