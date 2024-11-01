

int[] sayilar = new int[10];  // yeni bir sayilar adinda array tanimliyoruz 10 elemanli

for (int i = 0; i < sayilar.Length; i++) //eleman sayisi kadar deger isticek bizden ve dolduracak array icini
{ 
    Console.Write("Diziye eklenecek sayıyı giriniz: ");
    int sayi = Convert.ToInt32(Console.ReadLine());
    sayilar[i] = sayi;
}

foreach (int sayi in sayilar) //her elemani ekrana yazdiracak foreach donguusuyle 
{
    Console.WriteLine(sayi);
}

Array.Resize<int>(ref sayilar, 11); //arrayi yeniden sekillendiriyoruz ve 11 elemanli yapiyoruz 

Console.Write("11. elemanı giriniz: "); //11. elemani istiyor 
sayilar[10] = Convert.ToInt32(Console.ReadLine());

Array.Sort(sayilar); //sayilari siraliyor 

foreach (int sayi in sayilar) //tekrardan sayilari sirasiyla yazdiriyor
{
    Console.WriteLine(sayi);
}






