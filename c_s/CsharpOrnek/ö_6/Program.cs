// factorial

Console.WriteLine("lutfen facturail hesaplamak isdeniz sayiyi girin");

int sayi = int.Parse(Console.ReadLine());
int faktoriyel = 1;

if (sayi < 0)
{
    Console.WriteLine("Negatif sayilarin faktoriyeli hesaplanamaz.");
}

else if (sayi == 0 || sayi == 1)
{

    Console.WriteLine(+sayi + "!=1");
}

else
{

    for (int i = 1; i <= sayi; i++)
    {
        faktoriyel *= i;
    }
    
    Console.WriteLine(sayi + "! = " + faktoriyel);
}