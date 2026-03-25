// Basit Zar Atma Oyunu
// 2 zar atan bir oyun, toplam 12 gelirse "Kazandın!" yazar.


var random = new Random();
int zar1 = random.Next(1, 7);
int zar2 = random.Next(1, 7);


int zar3 = random.Next(1, 7);
int zar4 = random.Next(1, 7);

int kişi1 = zar1 + zar2;
int kişi2 = zar3 + zar4;

Console.WriteLine($"Kişi 1'in zarları: {zar1} ve {zar2}, Toplam: {kişi1}");
Console.WriteLine($"Kişi 2'nin zarları: {zar3} ve {zar4}, Toplam: {kişi2}");

if (kişi1<kişi2){
    Console.WriteLine("Kişi 2 kazandı!");
}
else if (kişi1>kişi2){
    Console.WriteLine("Kişi 1 kazandı!");
}
else{
    Console.WriteLine("Beraberlik!");
}