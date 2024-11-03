using System;
using System.Collections.Generic;

public class Araba
{
    public DateTime UretimTarihi { get; private set; }
    public string SeriNumarasi { get; set; }
    public string Marka { get; set; }
    public string Model { get; set; }
    public string Renk { get; set; }
    public int KapiSayisi { get; set; }

    public Araba(string seriNumarasi, string marka, string model, string renk, int kapiSayisi)
    {
        UretimTarihi = DateTime.Now; // Üretim Tarihi otomatik olarak atanıyor
        SeriNumarasi = seriNumarasi;
        Marka = marka;
        Model = model;
        Renk = renk;
        KapiSayisi = kapiSayisi;
    }

    public void BilgiYazdir()
    {
        Console.WriteLine($"Seri Numarası: {SeriNumarasi}, Marka: {Marka}");
    }
}

class Program
{
    static void Main()
    {
        List<Araba> arabalar = new List<Araba>();
        bool dongu = true;

        while (dongu)
        {
            Console.Write("Araba üretmek ister misiniz? (E/H): ");
            string cevap = Console.ReadLine().ToUpper().Trim();

            if (cevap == "E")
            {
                // Araba özelliklerini kullanıcıdan alıyoruz
                Console.Write("Araba Markası: ");
                string marka = Console.ReadLine();

                Console.Write("Araba Modeli: ");
                string model = Console.ReadLine();

                Console.Write("Araba Rengi: ");
                string renk = Console.ReadLine();

                Console.Write("Seri Numarası: ");
                string seriNumarasi = Console.ReadLine();

                int kapiSayisi = 0;

            KapiSayisiTekrar:
                try
                {
                    Console.Write("Kapı Sayısı: ");
                    kapiSayisi = Convert.ToInt32(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.WriteLine("Geçersiz giriş! Sayısal bir değer giriniz.");
                    goto KapiSayisiTekrar;
                }

                // Yeni araba nesnesi oluşturup listeye ekliyoruz
                Araba yeniAraba = new Araba(seriNumarasi, marka, model, renk, kapiSayisi);
                arabalar.Add(yeniAraba);

                // Başka araba üretmek isteyip istemediğini soruyoruz
                Console.Write("Başka araba üretmek ister misiniz? (E/H): ");
                string yeniCevap = Console.ReadLine().ToUpper().Trim();
                if (yeniCevap == "H")
                {
                    dongu = false;
                }
            }
            else if (cevap == "H")
            {
                Console.WriteLine("Programdan çıkılıyor...");
                dongu = false;
            }
            else
            {
                Console.WriteLine("Geçersiz giriş yaptınız, lütfen tekrar deneyin.");
            }
        }

        // Program sonunda tüm arabaların Seri Numarası ve Markası listelenir
        Console.WriteLine("\nÜretilen arabaların listesi:");
        foreach (var araba in arabalar)
        {
            araba.BilgiYazdir();
        }
    }
}
