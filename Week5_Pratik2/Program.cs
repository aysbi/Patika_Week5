
List<string> unluler = new List<string>(); //ilk once bir liste olusturuyoruz unluler adi altinda 

unluler.Add("Bulent Ersoy"); //listeye eklenecekler 'Add' methoduyla ekleniyor
unluler.Add("Ajda Pekkan");
unluler.Add("Ebru Gundes");
unluler.Add("Hadise");
unluler.Add("Hande Yener");
unluler.Add("Tarkan");
unluler.Add("Funda Arar");
unluler.Add("Demet Akalin");

for (int i = 0; i < unluler.Count; i++) //for dongusu kullandim cunku liste ileride genisletilirse basindaki numaranin da degismesini istedim
{
    Console.WriteLine((i+1) + " - " + unluler[i] ); //i 0dan basladigi icin i+1 den baslayacak basindaki sayilar
}

Console.ReadKey();
