List<string> IMDB = new List<string>(); //film isimlerini tutan liste

List<double> IMDBPuani = new List<double>(); //puanlari tutan bir double listesi

do //ilk basta her turlu sormasini istiyorum o yuzden do while dongusu kullaniyoruz
{
    Console.Write("Girmek istediginiz filmin ismi: ");
    IMDB.Add(Console.ReadLine());  //yazilani filmlerin tutuldugu IMDB listesine kaydediyoruz
    
    Console.Write("Filmin IMDB puani: ");
    IMDBPuani.Add(Convert.ToDouble(Console.ReadLine())); //filmin puanini kaydediyoruz

    Console.Write("Yeni bir film girmek ister misiniz? (Evet/Hayir): ");
    string devamMi = Console.ReadLine().ToLower().Trim(); //evet hayir cevabini kucultup yanlarindaki bosluklari kesiyoruz

    if (devamMi != "evet") //cevap evet olmadigi surece dongu duracak
        break;

}while (true);

int sayi = 0; // for each kullanarak iki listeyi de yazdirabilmek icin birini sayac ile yazdirmak gerekiyor
foreach (string movie in IMDB)
{
    Console.WriteLine(movie + " - " + IMDBPuani[sayi]); 
    sayi++; 
}

Console.WriteLine("Puani 4 ile 9 araliginda olan filmler: ");

for (int i = 0; i < IMDB.Count; i++) //for dongusu kullanarak her girdiyi kontrol ediyoruz 
{

    if (IMDBPuani[i] >= 4 && IMDBPuani[i] <= 9) //eger sayi 9 ve 4un arasinda ise yazdirmak icin 
    {
        Console.WriteLine(IMDB[i] + " - " + IMDBPuani[i]);
    }
}

Console.WriteLine("Adi 'A' ile baslayan filmler: ");

for (int i = 0;i < IMDB.Count; i++)
{

    if (IMDB[i].StartsWith("A") || IMDB[i].StartsWith("a")) //eger kucuk a yada buyuk a ise film adinin baslangici bunla ekrana yazdiriliyor 
    {
        Console.WriteLine(IMDB[i] + " - " + IMDBPuani[i]);
    }
}
