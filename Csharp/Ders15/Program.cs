int[] sayılar = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

for (int i = 0; i < sayılar.Length; i++)
{
    Console.WriteLine("Sayılar: " + sayılar[i]);
}

Console.WriteLine("****************************************");


int[] sayılar2 = new int[100];

for (int i = 0; i < sayılar2.Length; i++)
{
    sayılar2[i] = i + 1; // 1 den 100 e kadar sayıları atıyoruz
}

for (int i = 0; i < sayılar2.Length; i++)
{
    Console.WriteLine("Sayılar2: " + sayılar2[i]);
}
Console.WriteLine("****************************************");