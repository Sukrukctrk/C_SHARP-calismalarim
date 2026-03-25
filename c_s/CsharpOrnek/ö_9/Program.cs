// Kelime Ters Çevirici
// Girilen kelimeyi tersten yazar (Örn: "masa" → "asam").


Console.WriteLine(" lutfen bir cümle giriniz");

String  cumle = Console.ReadLine();

string[] kelimeler = cumle.Split(' ');

Array.Reverse(kelimeler);

Console.WriteLine("Ters çevrilmiş cümle: "+kelimeler);