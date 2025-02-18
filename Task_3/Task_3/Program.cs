
// Task 3
// Basit Hesap Makinesi (switch-case)

using System;
class HelloWorld
{
    static void Main()
    {
        Console.WriteLine("Iki farkli sayi ile basit hesaplamalar yapan hesap makinesi.");

        //degerlerin alindigi yerler
        Console.WriteLine("Islem yapilmak istenen 1. sayiyi giriniz:");
        double sayi1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Islem yapilmak istenen 1. sayiyi giriniz:");
        double sayi2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("1 = Toplama \n2 = Cikarma \n3 = Carpma \n4 = Bolme \nYapilacak islemi seciniz:");
        int secim = Convert.ToInt32(Console.ReadLine());


        //secime gore islemi belirle
        switch (secim)
        {
            case 1:
                double toplam = sayi2 + sayi1;
                Console.WriteLine("Girilen sayilarin toplami: " + toplam);
                break;
            case 2:
                double cikarma = sayi1 - sayi2;
                Console.WriteLine("Girilen sayilarin cikarmasi: " + cikarma);
                break;
            case 3:
                double carpma = sayi2 * sayi1;
                Console.WriteLine("Girilen sayilarin carpimi: " + carpma);
                break;
            case 4:
                double bolme = sayi1 / sayi2;
                Console.WriteLine("Girilen sayilarin bolumu: " + bolme);
                break;
            default:
                Console.WriteLine("Degerler dogru girilmedi.");
                break;


        }


    }
}