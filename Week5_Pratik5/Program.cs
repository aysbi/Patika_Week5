Baslangic:
Console.Write("Bir sayı giriniz: ");

try
{
    int sayi = Convert.ToInt32(Console.ReadLine()); //burada hata yapilirsa catch parametresine duser 

    int karesi = sayi * sayi; //sayinin karesini tutan property
    Console.WriteLine("Girdiğiniz sayının karesi: " + karesi);
}
catch (FormatException) //format exception tamsayi yerine farkli bir sey girilirse calisacak ve hata yazdiracak
{
    Console.WriteLine("Geçersiz giriş! Lütfen bir sayı giriniz.");
    goto Baslangic; //tekrar bastan almasini istedim 
}
