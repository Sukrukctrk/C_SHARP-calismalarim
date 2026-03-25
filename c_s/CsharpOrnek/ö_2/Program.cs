// Asal Sayı Bulucu
// Belirtilen aralıktaki asal sayıları listele

Console.WriteLine("lutfen bir üst sınır girin ");
int aralık_ü = int.Parse(Console.ReadLine());

Console.WriteLine("lutfen bir alt sınır girin ");
int aralık_a = int.Parse(Console.ReadLine());


int[] asal_list = new int[100];

while (aralık_a <= aralık_ü)
{
    if (aralık_ü <= 2)
    {
        asal_list[0] = 2;
    }

    else if (aralık_ü >= 2)
    {


        asal_list[0] = 2;
        for (int i = 3; i <= aralık_ü; i++)
        {
            bool asal = true;
            for (int j = 2; j < i; j++)
            {
                if (i % j == 0)
                {
                    asal = false;
                    break;
                }
            }
            if (asal && i >= aralık_a)
            {
                Console.WriteLine(i);
            }
        }   
    }


    
    
    

    aralık_a++;
}