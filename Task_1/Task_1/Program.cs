
// Task 1
// Sayının Pozitif, Negatif veya Sıfır Olduğunu Belirleme (if-else) 

using System;
class HelloWorld
{
    static void Main()
    {

        Console.WriteLine("Bu program Sayının Pozitif, Negatif veya Sıfır Olduğunu Belirleyebilir.");
        Console.Write("Bunun için bir tam sayı giriniz: ");

        int kontrol = 1;
        double sayi;

        //Sayinin integer olmasini kontrol eden kisim
        do
        {

            sayi = Convert.ToDouble(Console.ReadLine());
            int variable = Convert.ToInt32(sayi);

            if (sayi == variable)
            {
                //ondaligin olmadigini gosterir.
                kontrol = 1;
            }
            else
            {
                //ondalikli oldugunu gosterir.
                Console.WriteLine("Lutfen tekrar giriniz: ");
                kontrol = 0;
            }


        } while (kontrol != 1);


        // sayinin ne oldugunu belirleyen kisim

        if (sayi == 0)
        {
            Console.WriteLine(sayi + ", 0' a esittir.");
        }
        else if (sayi < 0)
        {
            Console.WriteLine(sayi + ", 0' dan kucuktur. (negatif) ");
        }
        else if (sayi > 0)
        {
            Console.WriteLine(sayi + ", 0' dan buyuktur. (pozitif) ");
        }
        else
        {
            Console.WriteLine("Lutfen gecerli bir sayi giriniz.");

        }
    }
}