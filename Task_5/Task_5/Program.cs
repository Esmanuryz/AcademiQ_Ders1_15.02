
// Task 5
// Şifre Güçlülüğünü Kontrol Etme (if-else)

using System;
using System.Diagnostics.Metrics;
class HelloWorld
{
    static void Main()
    {
        Console.WriteLine("Sifre Guclugu Kontrol Etme Programi");
        Console.WriteLine("Sifrenin guvenli olmasi icin BILGILER: \nŞifre en az 8 karakter uzunluğunda olmalı.\r\nŞifre içinde @, #, $, % gibi özel karakterler içermeli.\r\nŞifre en az 1 büyük harf içermeli.\r\n");

        Console.WriteLine("Sifrenizi giriniz: ");
        string sifre = Console.ReadLine();

        //char[] sifre_elemanlari = sifre.ToCharArray();

        // sifre uzunlugu kontrolu

        if (sifre.Length >= 8)
        {
            bool buyukHarf_check = false;
                foreach (char i in sifre)
            {

                if (char.IsUpper(i)) // buyuk harf kontrolu
                {
                    buyukHarf_check = true;
                    break; // buyuk harf buldugunda donguden cik
                }
            }

           


            if (buyukHarf_check)
            {
                bool ozel_karakter = false;
                foreach (char i in sifre)
                {

                    if (!char.IsLetterOrDigit(i)) // ozel karakter kontrolu
                    {
                        ozel_karakter = true;
                        break; // ozel karakter buldugunda donguden cik
                    }
                }

                // ozel karakter kontrolu

                if (ozel_karakter)
                {
                    Console.WriteLine("Sifreniz Sartlara gore yeterince guvenlidir. Kimseyle paylasmayiniz!");
                }
                else
                {
                    Console.WriteLine("Sifrede ozel karakter bulunmuyor, Guvenli degil!");
                }



            }
            else
            {
                Console.WriteLine("Sifrede en az bir harf buyuk olmali, Guvenli degil!");
            }



        }
        else
        {
            Console.WriteLine("Sifreniz Cok kisa en az 8 karakter olmali, Guvenli Degil!");
        }


    }
}