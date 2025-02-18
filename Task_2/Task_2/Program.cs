
// Task 2
// Gün İsmi Belirleme (switch-case)

using System;
class HelloWorld
{
    static void Main()
    {
        Console.WriteLine("Haftanin kacinci gununuzde oldugunuza gore hangi gunde oldugunuzu soyleyen uygulama");
        Console.WriteLine("Haftanin kacinci gununuzde oldugunuzu giriniz: ");

        int gun = Convert.ToInt32(Console.ReadLine()); //icinde olunan gunu al

        switch (gun) //gune gore if else olmadan gunun ismini soyle
        {
            case 1:
                Console.WriteLine(gun + ". gun = pazartesi");
                break;
            case 2:
                Console.WriteLine(gun + ". gun = sali");
                break;
            case 3:
                Console.WriteLine(gun + ". gun = carsamba");
                break;
            case 4:
                Console.WriteLine(gun + ". gun = persembe");
                break;
            case 5:
                Console.WriteLine(gun + ". gun = cuma");
                break;
            case 6:
                Console.WriteLine(gun + ". gun = cumartesi");
                break;
            case 7:
                Console.WriteLine(gun + ". gun = pazar");
                break;
            default:
                Console.WriteLine("Gecerli bir gun girilmedi.");
                break;

        }
    }
}