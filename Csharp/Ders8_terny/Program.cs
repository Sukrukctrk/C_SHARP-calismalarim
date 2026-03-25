Console.WriteLine("lutfen bir sayi giriniz");
int sayi = int.Parse(Console.ReadLine());

var sonuc = (sayi % 2 == 0) ?
 sayi < 0 ? "Sayi pozitif ve  tek" : "Sayi pozitif ve cift" :
 sayi > 0 ? "Sayi negatif ve tek" : "Sayi negatif ve çift";

Console.WriteLine(sonuc);
