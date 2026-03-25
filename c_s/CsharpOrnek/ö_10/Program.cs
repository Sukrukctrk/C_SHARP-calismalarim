// Palindrom Kontrolü
// Girilen kelimenin tersten de aynı olup olmadığını kontrol eder.


Console.WriteLine("Lütfen bir kelime giriniz:");
string kelime = Console.ReadLine();

char[] karakterler = kelime.ToCharArray();
Array.Reverse(karakterler);

string tersKelime = new string(karakterler);
if (kelime.Equals(tersKelime, StringComparison.OrdinalIgnoreCase))
{
    Console.WriteLine("Girilen kelime bir palindromdur.");
}
else
{
    Console.WriteLine("Girilen kelime bir palindrom değildir.");
}

