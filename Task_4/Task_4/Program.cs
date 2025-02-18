
// Task_4
// Üç Sayının En Büyüğünü Bulma (if-else)

using System;

class HelloWorld
{
    static void Main()
    {
        Console.WriteLine("Bu program girilen Üç Sayının En Büyüğünü Bulur. ");
        Console.WriteLine("Lutfen 3 tane sayi giriniz: (sayilari space ile belirlemelisin!)");

        string[] sayilar = Console.ReadLine().Split(' ');
        double sayi1 = Convert.ToDouble(sayilar[0]);
        double sayi2 = Convert.ToDouble(sayilar[1]);
        double sayi3 = Convert.ToDouble(sayilar[2]);


        double buyuk = 0;

        // normalde bu kadar fazla if-else gerek olmayabilir <= isaretiyle esit olan durumlar anlasilabilir. Fakat buyuk projelerde sikinti olabilecek oldugunu dusundugumden bu sekilde parca parca yaptim.
        /*
         sadece asagidaki if-else ile de en buyuk olan bulunabilir.


        
        if(sayi1 => sayi2 && sayi1 => sayi3)
        {
            buyuk = sayi1;
        }else

        if (sayi2 => sayi1 && sayi2 => sayi3)
        {
            buyuk = sayi2;
        }else

        if (sayi3 => sayi2 && sayi3 => sayi2)
        {
            buyuk = sayi3;
        }else{
        Console.WriteLine("Gecersiz Giris.);
        }
         
         */


        // Hepsinin esit olma durumu
        if (sayi1 == sayi2 && sayi2 == sayi3)
        {
            Console.WriteLine("Girilen butun sayilar esittir.");
            buyuk = sayi1;
        }


         // Sadece ikisinin eşit olma durumu

        if(sayi1 == sayi2)
        {
            if(sayi2 > sayi3)
            {
                buyuk = sayi2;          
               
            }else
            {
                buyuk = sayi3;        
            
            }
        }
        if(sayi2 == sayi3)
        {
            if(sayi2 > sayi1)
            {
                buyuk = sayi2;    
             
            }
            else
            {
                buyuk = sayi1;
            }
        }


        if (sayi1 == sayi3)
        {
            if(sayi2 > sayi3)
            {
                buyuk = sayi2;     
            }
            else
            {
                buyuk = sayi3;  
            }
        }

        // Hepsinin farkli olma durumu

        if(sayi1 > sayi2 && sayi1 > sayi3)
        {
            buyuk = sayi1;
        }

        if (sayi2 > sayi1 && sayi2 > sayi3)
        {
            buyuk = sayi2;
        }

        if (sayi3 > sayi2 && sayi3 > sayi2)
        {
            buyuk = sayi3;
        }


        Console.WriteLine("En buyuk sayi: " + buyuk);
    }
}