

int[,] dizi = new int[4,5];


dizi[0,0] = 1;
dizi[0,1] = 2;
dizi[0,2] = 3;
dizi[0,3] = 4;
dizi[0,4] = 5;


dizi[1,0] = 6;
dizi[1,1] = 7;
dizi[1,2] = 8;
dizi[1,3] = 9;
dizi[1,4] = 10;

dizi[2,0] = 11;
dizi[2,1] = 12;
dizi[2,2] = 13;
dizi[2,3] = 14;

dizi[3,0] = 15;
dizi[3,1] = 16;
dizi[3,2] = 17;
dizi[3,3] = 18;
dizi[3,4] = 19;


for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 5; j++)
    {
        Console.Write(dizi[i,j] + " ");
    }
    Console.WriteLine();
}