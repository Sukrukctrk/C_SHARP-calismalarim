// çok gelişmiş gelişmiş tahmin bulma otomatı 

Console.WriteLine("tutunuz şeyi girin");
String tahmin = Console.ReadLine();

Console.WriteLine("tutunuz şeyin tahminini yapacağım");
var tahminHakkı = 20;

Console.WriteLine("tutuunuz şey canlı mı Evet/ Hayır");
string canlılık = Console.ReadLine();
tahminHakkı -= 1;

if (canlılık.ToLower() == "evet")
{
    Console.WriteLine("tutunuz şeyin canlı");

}
else if (canlılık.ToLower() == "hayır")
{
    Console.WriteLine("tutunuz şey cansız");

    Console.WriteLine("tutunuz şey bir araç mı E/H");
    tahminHakkı -= 1;


    string araç = Console.ReadLine();
    if (araç == "e" || araç == "E")


    {


        Console.WriteLine("bu bi araç");
        Console.WriteLine("tutunuz şey bir araba mı E/H");
        tahminHakkı -= 1;
        string araba = Console.ReadLine();

        if (araba == "e" || araba == "E")
        {
            Console.WriteLine("tutunuz şey bir araba");
            Console.WriteLine("oyun bitti");

        }
        else if (araba == "h" || araba == "H")
        {
            Console.WriteLine("tutunuz şey bir araç ama araba değil");
            Console.WriteLine("uçan bir araç mı E/H");
            tahminHakkı -= 1;

            string uçanAraç = Console.ReadLine();

            if (uçanAraç == "e" || uçanAraç == "E")
            {
                Console.WriteLine("tutunuz şey uçak mı E/H");
                tahminHakkı -= 1;
                string uçak = Console.ReadLine();

                if (uçak == "e" || uçak == "E")
                {
                    Console.WriteLine("tutunuz şey bir uçak");
                    Console.WriteLine("oyun bitti");
                }
                else if (uçak == "h" || uçak == "H")
                {
                    Console.WriteLine("helikopter mi E/H");
                    tahminHakkı -= 1;
                    string helikopter = Console.ReadLine();
                    if (helikopter == "e" || helikopter == "E")
                    {
                        Console.WriteLine("tutunuz şey bir helikopter");
                        Console.WriteLine("oyun bitti");
                    }
                    else if (helikopter == "h" || helikopter == "H")
                    {
                        Console.WriteLine("tutunuz şey birdron mu E/H");
                        tahminHakkı -= 1;
                        string dron = Console.ReadLine();

                        if (dron == "e" || dron == "E")
                        {
                            Console.WriteLine("tutunuz şey bir dron");
                            Console.WriteLine("oyun bitti");
                        }
                        else if (dron == "h" || dron == "H")
                        {
                            Console.WriteLine("tutunuz şey bir uçan araba mı E/H");
                            tahminHakkı -= 1;
                            string uçanAraba = Console.ReadLine();

                            if (uçanAraba == "e" || uçanAraba == "E")
                            {
                                Console.WriteLine("tutunuz şey bir uçan araba");
                                Console.WriteLine("oyun bitti");
                            }
                            else if (uçanAraba == "h" || uçanAraba == "H")
                            {
                                Console.WriteLine("tutunuz şey bir uzay aracı mı E/H");
                                tahminHakkı -= 1;
                                string uzayAracı = Console.ReadLine();

                                if (uzayAracı == "e" || uzayAracı == "E")
                                {
                                    Console.WriteLine("tutunuz şey bir uzay aracı");
                                    Console.WriteLine("oyun bitti");
                                }
                                else if (uzayAracı == "h" || uzayAracı == "H")
                                {
                                    Console.WriteLine("tutunuz şey bir balon mu E/H");
                                    tahminHakkı -= 1;
                                    string balon = Console.ReadLine();

                                    if (balon == "e" || balon == "E")
                                    {
                                        Console.WriteLine("tutunuz şey bir balon");
                                        Console.WriteLine("oyun bitti");
                                    }
                                    else if (balon == "h" || balon == "H")
                                    {
                                        Console.WriteLine("lütfen E veya H girin");
                                    }
                                    else
                                    {
                                        Console.WriteLine("lütfen E veya H girin");
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("lütfen E veya H girin");
                                }
                            }
                            else
                            {
                                Console.WriteLine("lütfen E veya H girin");
                            }
                        }
                        else
                        {
                            Console.WriteLine("lütfen E veya H girin");
                        }
                    }
                    else
                    {
                        Console.WriteLine("lütfen E veya H girin");
                    }

                }
                else
                {
                    Console.WriteLine("lütfen E veya H girin");
                }
            }



            else if (uçanAraç == "h" || uçanAraç == "H")
            {
                Console.WriteLine("tutunuz şey bir araç ama uçak değil");
                Console.WriteLine("oyun bitti");
            }
            else
            {
                Console.WriteLine("lütfen E veya H girin");
            }
        }

        else
        {
            Console.WriteLine("lütfen E veya H girin");
        }



    }

    else if (araç == "h" || araç == "H")
    {
        Console.WriteLine("tutunuz şey araç değil");
        Console.WriteLine("tutunuz teknolojik bir şey mi E/H");
        tahminHakkı -= 1;
        string teknolojik = Console.ReadLine();

        if (teknolojik == "e" || teknolojik == "E")
        {
            Console.WriteLine("tekolojik bir şey");
            Console.WriteLine("tutunuz şey bir telefon mu E/H");
            tahminHakkı -= 1;
            string telefon = Console.ReadLine();
            
            if (telefon == "e" || telefon == "E")
            {
                Console.WriteLine("tutunuz şey bir telefon");
                Console.WriteLine("oyun bitti");
            }
            else if (telefon == "h" || telefon == "H")
            {
                Console.WriteLine("tutunuz şey bir bilgisayar mı E/H");
                tahminHakkı -= 1;
                string bilgisayar = Console.ReadLine();

                if (bilgisayar == "e" || bilgisayar == "E")
                {
                    Console.WriteLine("tutunuz şey bir bilgisayar");
                    Console.WriteLine("oyun bitti");
                }
                else if (bilgisayar == "h" || bilgisayar == "H")
                {
                    Console.WriteLine("tutunuz şey bir tablet mi E/H");
                    tahminHakkı -= 1;
                    string tablet = Console.ReadLine();

                    if (tablet == "e" || tablet == "E")
                    {
                        Console.WriteLine("tutunuz şey bir tablet");
                        Console.WriteLine("oyun bitti");
                    }
                    else if (tablet == "h" || tablet == "H")
                    {
                        Console.WriteLine("tutunuz şey bir televizyon mu E/H");
                        tahminHakkı -= 1;
                        string televizyon = Console.ReadLine();

                        if (televizyon == "e" || televizyon == "E")
                        {
                            Console.WriteLine("tutunuz şey bir televizyon");
                            Console.WriteLine("oyun bitti");
                        }
                        else if (televizyon == "h" || televizyon == "H")
                        {
                            Console.WriteLine("tutunuz şey bir oyun konsolu mu E/H");
                            tahminHakkı -= 1;
                            string oyunKonsolu = Console.ReadLine();

                            if (oyunKonsolu == "e" || oyunKonsolu == "E")
                            {
                                Console.WriteLine("tutunuz şey bir oyun konsolu");
                                Console.WriteLine("oyun bitti");
                            }
                            else if (oyunKonsolu == "h" || oyunKonsolu == "H")
                            {
                                Console.WriteLine("tutunuz şey bir akıllı saat mi E/H");
                                tahminHakkı -= 1;
                                string akıllıSaat = Console.ReadLine();

                                if (akıllıSaat == "e" || akıllıSaat == "E")
                                {
                                    Console.WriteLine("tutunuz şey bir akıllı saat");
                                    Console.WriteLine("oyun bitti");
                                }
                                else if (akıllıSaat == "h" || akıllıSaat == "H")
                                {
                                    Console.WriteLine("lütfen E veya H girin");
                                }
                                else
                                {
                                    Console.WriteLine("lütfen E veya H girin");
                                }
                            }
                            else
                            {
                                Console.WriteLine("lütfen E veya H girin");
                            }
                        }
                        else
                        {
                            Console.WriteLine("lütfen E veya H girin");
                        }
                        else
                        {
                            Console.WriteLine("lütfen E veya H girin");
                        }
                    }
                    else
                    {
                        Console.WriteLine("lütfen E veya H girin");
                    }
                }
                else
                {
                    Console.WriteLine("lütfen E veya H girin");
                }
            }
            else
            {
                Console.WriteLine("lütfen E veya H girin");
            }
            
        }
        else if (teknolojik == "h" || teknolojik == "H")
        {
            Console.WriteLine("tutunuz şey bir motosiklet mi E/H");
            tahminHakkı -= 1;
            string motosiklet = Console.ReadLine();

            if (motosiklet == "e" || motosiklet == "E")
            {
                Console.WriteLine("tutunuz şey bir motosiklet");
                Console.WriteLine("oyun bitti");
            }
            else if (motosiklet == "h" || motosiklet == "H")
            {
                Console.WriteLine("tutunuz şey bir bisiklet değil");
                Console.WriteLine("oyun bitti");
            }
            else
            {
                Console.WriteLine("lütfen E veya H girin");
            }
        }
        else
        {
            Console.WriteLine("lütfen E veya H girin");
        }
    }

    else
    {
        Console.WriteLine("lütfen E veya H girin");
    }
    









































    
}
    
