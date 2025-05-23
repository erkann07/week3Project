int rastgeleSayiOyunu()
{
    Random rndSayi = new Random();
    int rastgeleSayi =rndSayi.Next(1, 101);// 1 ile 100 arasında rastgele sayı üretiyoruz
    int hak = 5;//Tahmin hakkımızı 5 veriyoruz
    Console.WriteLine("Rastgele Sayı Bulma Oyununu Seçtiniz\nHadi Başlayalım");
    Console.WriteLine("1 ile 100 arasında bir sayı ürettim bakalım bilebilicek misin");
    Console.WriteLine($"Tahmin hakkınız  {hak}\n");
    while (hak > 0)
    {
        Console.WriteLine("Tahminin --> ");
        string input = Console.ReadLine();
        int tahmin;
        if (!int.TryParse(input, out tahmin))// Kullanıcıdan alınan değeri int'e çeviriyoruz
        {
            Console.WriteLine("Lütfen geçerli bir sayı giriniz!\n");
            continue;
        }
        if (tahmin == rastgeleSayi)//Tahmin doğruysa tebrik mesajıyla programdan çıkıyoruz
        {
            Console.WriteLine("Tebrikler Sayıyı Bildiniz --> " + rastgeleSayi);
            break;
        }
        else
        {
            hak--;//Tahmin yanlış olduğunda tahmin hakkını bir azaltıyoruz
            if (tahmin < rastgeleSayi)
            {
                Console.WriteLine("Daha yüksek bir sayı giriniz.");
                Console.WriteLine($"Kalan tahmin hakkınız --> {hak}");
            }
            else
            {
                Console.WriteLine("Daha düşük bir sayı giriniz.");
                if (hak > 0)
                    Console.WriteLine($"Kalan tahmin hakkınız --> {hak}");
            }
           
        }

    }
    if (hak == 0)
    {
        Console.WriteLine("Maalesef tahmin haklarınız tükendi oyun sonlandı.");
        Console.WriteLine("Doğru cevap --> " + rastgeleSayi);
    }

    return 0;
}
int hesapMakinesi()
{
    Console.WriteLine("Hesap makinesine hoşgeldiniz\nİlk Sayınızı Giriniz");
    int sayi1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("İkinci Sayınızı Giriniz");
    int sayi2 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Yapmak istediğiniz işlemi seçiniz (+ , - , * , /");
    string islem = Console.ReadLine();
    switch(islem)
    {
        case "+":
            Console.WriteLine("İşlemin Sonucu --> " + (sayi1 + sayi2));
            break;
        case "-":
            Console.WriteLine("İşlemin Sonucu --> " + (sayi1 - sayi2));
            break;
            case "*":
            Console.WriteLine("İşlemin Sonucu --> " + (sayi1 * sayi2));
            break;
        case "/":
            if (sayi2 == 0)//Hiçbir sayı 0 ile bölenemeyeceğinden 0 yazılması halinde hata verip programı sonlandırıyoruz
            {
                Console.WriteLine("Hatalı İşlem");
            }
            else
            {
                Console.WriteLine("İşlemin Sonucu --> " + (sayi1 / sayi2));
            }
            break;
    }
    return 0;

}
double ortalamaHesapla()
{
    Console.WriteLine("Birinci notunuzu giriniz :");
    double not1 = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("İkinci notunuzu giriniz :");
    double not2 = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Üçüncü notunuzu giriniz :");
    double not3 = Convert.ToDouble(Console.ReadLine());
    if (not1 < 0 || not1 > 100 || not2 < 0 || not2 > 100 || not3 < 0 || not3 > 100)// Notların 0 ile 100 arasında olup olmadığını kontrol ediyoruz
    {
        Console.WriteLine("Notlar 0 ile 100 arasında olmalıdır.");
        return -1;
    }
    double ortalama = (not1 + not2 + not3) / 3;
    Console.WriteLine("Notlarınızın ortalaması --> " + ortalama);
    if (ortalama < 54)
    {
        Console.WriteLine("Harf notunuz --> FF");
    }
    else if (ortalama < 60)
    {
        Console.WriteLine("Harf notunuz --> FD");
    }
    else if (ortalama < 65)
    {
        Console.WriteLine("Harf notunuz --> DD");
    }
    else if (ortalama < 70)
    {
        Console.WriteLine("Harf notunuz --> DC");
    }
    else if (ortalama < 75)
    {
        Console.WriteLine("Harf notunuz --> CC");
    }
    else if (ortalama < 80)
    {
        Console.WriteLine("Harf notunuz --> CB");
    }
    else if (ortalama < 85)
    {
        Console.WriteLine("Harf notunuz --> BB");
    }
    else if (ortalama < 90)
    {
        Console.WriteLine("Harf notunuz --> BA");
    }
    else
    {
        Console.WriteLine("Harf notunuz --> AA");
    }
    return 0;
}

bool gecerliSecim = false;
while (!gecerliSecim)// Programın geçersiz giriş halinde tekrar çalışmasını while ile sağlıyoruz
{
    Console.WriteLine("Hangi Programı Çalıştırmak İstersiniz\n1- Rastgele Sayı Tahmin Etme\n2- Hesap Makinesi\n3- Not Ortalaması Hesaplama\n0- Çıkış");
    int secim = Convert.ToInt32(Console.ReadLine());
    switch (secim)
{
    case 1:
        rastgeleSayiOyunu();
        break;
    case 2:
        hesapMakinesi();
        break;
    case 3:
        ortalamaHesapla();
        break;
    case 0:
        Console.WriteLine("Çıkış Yapılıyor.İyi Günler Dileriz.");//Kullanıcı isteğine göre programı sonlandırıyoruz
            gecerliSecim = true;
        break;
    default:
        Console.WriteLine("Geçersiz Seçim");
            gecerliSecim = false;
            break;
}
}
