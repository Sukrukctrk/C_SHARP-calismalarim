
String cumle = "merhab ben sukru kocaturk c# ogreniyorum";

Console.WriteLine("Cumle: " + cumle[0]);
Console.WriteLine("Cumle: " + cumle[1]);
Console.WriteLine("Cumle: " + cumle[2]);
Console.WriteLine("Cumle: " + cumle[3]);


Console.WriteLine("****************************************");

var cumle2 = "merhaba ben sukru kocaturk c# ogreniyorum.".Split();

Console.WriteLine("Cumle2: " + cumle2[0]);
Console.WriteLine("Cumle2: " + cumle2[1]);
Console.WriteLine("Cumle2: " + cumle2[2]);
Console.WriteLine("Cumle2: " + cumle2[3]);

// split ile kelimeleri ayırdık ve bir diziye atadık.

Console.WriteLine("****************************************");


String[] kelimeler = new string[50];
kelimeler[0] = " sukru kocaturk ";
kelimeler[1] = " c# ogreniyorum ";

Console.WriteLine("Kelime 0: " + kelimeler[0]);
Console.WriteLine("Kelime 1: " + kelimeler[1]);

// dizinin ilk elemanına sukru kocaturk atandı. dizi bu şekilde tanımlanır

Console.WriteLine("****************************************");


string[] cumle3 = { "merhaba ben sukru kocaturk c# ogreniyorum." };

Console.WriteLine("Cumle3: " + cumle3[0]);
// dizinin ilk elemanına merhaba ben sukru kocaturk c# ogreniyorum atandı. dizi bu şekilde tanımlanır

