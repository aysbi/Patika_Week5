
List<string> kahveCesitleri = new List<string>(); //yeni bir liste tanimliyoruz

bool donguDevamEtsinMi = true;
int kahveSayisi = 0; //sayac icin tanimladim

while (donguDevamEtsinMi) // soruyu donguye aliyorum 
{
    kahveSayisi++; //kahve sayisi 1den baslayacak ve her dongu yenilendiginde bir artacak boylece 1 - kahve olarak yazacak
    Console.ForegroundColor = ConsoleColor.Red; //kirmizi renkte sormasi icin
    Console.Write($"{kahveSayisi} - Kahve: ");
    Console.ForegroundColor= ConsoleColor.White; //cevabin beyaz renkte yazmasini istiyoruz 
    kahveCesitleri.Add(Console.ReadLine()); //listeye ekliyoruz yazilani

    if (kahveSayisi == 5) //dongu 5.kahveden sorna durmasini istiyoruz
        donguDevamEtsinMi = false;
}

Console.WriteLine("Girdiginiz kahve isimleri: ");

foreach (string kahve in kahveCesitleri)
{
    Console.WriteLine(kahve); //kahve cesitlerini ekrana yazdiriyoruz
}

Console.ReadKey();
