Console.WriteLine("lutfen bir sayi degeri giriniz ");

int sayi = int.Parse(Console.ReadLine());

if (sayi % 2 == 0)
{
    Console.WriteLine("Sayi cift sayidir");
}
else
{
    Console.WriteLine("Sayi tek sayidir");
}



Console.WriteLine("****************************************************************************");


int? sayi2 = null;

Console.WriteLine(+sayi2);

String ad = null;
Console.WriteLine(ad);

// int de null olamaz bunu belirtmemiz gerekir fakat string null olabil null olarak tanımlanabilir,,

// peki ufak bir proje yapalım

Console.WriteLine("lutfen ilk notunuzu girin  ");

int? not1 = int.Parse(Console.ReadLine());
if (not1 == null)
{
    Console.WriteLine("herhangi bir not değeri girilmedi tekrar deneyin");
}


Console.WriteLine("lutfen ikinci notunuzu girin  ");
int? not2 = int.Parse(Console.ReadLine());
if (not2 == null)
{
    Console.WriteLine("herhangi bir not değeri girilmedi tekrar deneyin");
}


 var ortalama = (not1 + not2) / 2;

 if (ortalama >= 50)
{
    Console.WriteLine("tebrikler ortalamanız : " + ortalama + "  başarıyla geçtiniz");
}
else
{
    Console.WriteLine("üzgünüz ortalamanız : " + ortalama + "  başarısız oldunuz");
}
