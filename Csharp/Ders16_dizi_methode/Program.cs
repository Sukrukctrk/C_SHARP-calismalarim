
String[] sehirler = {
    "Ankara",
    "İstanbul",
    "İzmir",
    "Bursa",
    "Adana",
    "Antalya",
    "Konya",
    "Gaziantep"
};



sehirler.SetValue("Mersin", 0);
Console.WriteLine("Dizinin ilk elemanı: " + sehirler[0]);


Console.WriteLine(sehirler.GetValue(0));

// set ile atama işlemi get ile ise 1çağirma işlemini gerçekleştiriyoruz.

Console.WriteLine(Array.IndexOf(sehirler, "İstanbul")); // İstanbul'un dizideki indeksini bulur. yoksa -1 döner

Array.Sort(sehirler); // Diziyi alfabetik olarak sıralar
Console.WriteLine("Sıralanmış şehirler:");

Array.Clear(sehirler, 0, sehirler.Length); // Dizinin tüm elemanlarını temizler
Console.WriteLine("Dizinin temizlenmiş hali:");

Array.Reverse(sehirler); // Diziyi ters çevirir
Console.WriteLine("Ters çevrilmiş şehirler:");

