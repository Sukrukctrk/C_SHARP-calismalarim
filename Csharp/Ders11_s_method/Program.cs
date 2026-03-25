
var isim = "ŞÜKRÜ kocatürk ";


int uzunluk = isim.Length;   // isim değişkeninin uzunluğunu alır
Console.WriteLine("İsmin uzunluğu: " + uzunluk);

var yeniIsim = isim.ToLower(); // isim değişkenini küçük harfe çevirir
Console.WriteLine("Küçük harfe çevrilmiş hali: " + yeniIsim);

yeniIsim = yeniIsim.ToUpper(); // isim değişkenini büyük harfe çevirir
Console.WriteLine("Büyük harfe çevrilmiş hali: " + yeniIsim);

yeniIsim = yeniIsim.Trim(); // isim değişkeninin başındaki ve sonundaki boşlukları siler
Console.WriteLine("Boşluklar silinmiş hali: " + yeniIsim);


yeniIsim = yeniIsim.Replace("K", "k"); // isim değişkenindeki K harfini k harfi ile değiştirir
Console.WriteLine("K harfi k harfi ile değiştirilmiş hali: " + yeniIsim);

yeniIsim = yeniIsim.Insert(0, "Merhaba "); // isim değişkeninin başına Merhaba kelimesini ekler
Console.WriteLine("Merhaba kelimesi eklenmiş hali: " + yeniIsim);

yeniIsim = yeniIsim.Remove(0, 8); // isim değişkeninin başındaki 8 karakteri siler
Console.WriteLine("Başındaki 8 karakter silinmiş hali: " + yeniIsim);

yeniIsim = yeniIsim.Substring(0, 5); // isim değişkeninin ilk 5 karakterini alır
Console.WriteLine("İlk 5 karakteri alınmış hali: " + yeniIsim);

yeniIsim = yeniIsim.Substring(5); // isim değişkeninin 5. karakterinden sonrasını alır
Console.WriteLine("5. karakterden sonrasının alınmış hali: " + yeniIsim);

yeniIsim = yeniIsim.PadLeft(10, '*'); // isim değişkeninin soluna 10 karakterlik boşluk ekler
Console.WriteLine("Soluna 10 karakterlik boşluk eklenmiş hali: " + yeniIsim);

yeniIsim = yeniIsim.PadRight(15, '*'); // isim değişkeninin sağına 15 karakterlik boşluk ekler
Console.WriteLine("Sağına 15 karakterlik boşluk eklenmiş hali: " + yeniIsim);

yeniIsim=yeniIsim.Split(' ')[0]; // isim değişkenini boşluk karakterine göre böler ve ilk parçayı alır
Console.WriteLine("Boşluk karakterine göre bölünmüş ve ilk parçası alınmış hali: " + yeniIsim);


yeniIsim = yeniIsim.TrimEnd('*'); // isim değişkeninin sonundaki * karakterlerini siler
Console.WriteLine("Sonundaki * karakterleri silinmiş hali: " + yeniIsim);

yeniIsim = yeniIsim.TrimStart('*'); // isim değişkeninin başındaki * karakterlerini siler
Console.WriteLine("Başındaki * karakterleri silinmiş hali: " + yeniIsim);




