// döngü mantığı diğer dillerle neredeyse aynıdır 


var i = 0;

for (i = 0; i < 10; i++)
{
    Console.WriteLine(i);
}


// for döngüsü 3 kısımdan oluşur
// 1. kısım: i = 0; // başlangıç değeri 
// 2. kısım: i < 10; // döngü koşulu
// 3. kısım: i++ // her döngü sonunda i değerini
// artırır
// i++ ifadesi i = i + 1; ile aynıdır


Console.WriteLine("*******************************************************************************");

// while döngüsü
// while döngüsü, koşul doğru olduğu sürece çalışır

var j = 0;
while (j < 10)
{
    Console.WriteLine(j);
    j++;
}
// while döngüsü 2 kısımdan oluşur
// 1. kısım: j < 10; // döngü koşulu
// 2. kısım: j++; // her döngü sonunda j değerini
// artırır

Console.WriteLine("*******************************************************************************");

// do while döngüsü
// do while döngüsü, en az bir kez çalışır ve sonra koşulu kontrol eder 

var k = 0;
do
{
    Console.WriteLine(k);
    k++;
} while (k < 10);




