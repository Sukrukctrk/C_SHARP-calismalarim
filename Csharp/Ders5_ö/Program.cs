Console.WriteLine("vize notun girin :");
int not1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("final notunu  girin :");
int not2 = Convert.ToInt32(Console.ReadLine());


var ortalama = ((not1 *0.3) + (not2*0.7)) ;


if (ortalama>90 && ortalama <= 100)
{
    Console.WriteLine(+ortalama+" : A");
}
else if (ortalama > 80 && ortalama <= 90)
{
    Console.WriteLine(+ortalama+" : B");
}
else if (ortalama > 70 && ortalama <= 80)
{
    Console.WriteLine(+ortalama+" : C");
}
else if (ortalama > 60 && ortalama <= 70)
{
    Console.WriteLine(+ortalama+" : D");
}
else if (ortalama >= 0 && ortalama <= 60)
{
    Console.WriteLine(+ortalama+" : F");
}
else
{
    Console.WriteLine("Geçersiz not.");
}