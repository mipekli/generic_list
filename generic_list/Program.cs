using System;
using System.Collections.Generic;

namespace generic_list
{

    class program
    {
        public static string Isim { get; private set; }
        public static object SoyIsim { get; private set; }
        public static int Yas { get; private set; }

        static void Main(string[] args)
        {
            //List<T> class
            //System.collections.Generic 
            //T-> object türündedir.

            List<int> sayiListesi = new List<int>();

            sayiListesi.Add(23);
            sayiListesi.Add(10);
            sayiListesi.Add(4);
            sayiListesi.Add(5);
            sayiListesi.Add(92);
            sayiListesi.Add(34);

            List<string> renkListesi = new List<string>();
            renkListesi.Add("Kırmızı");
            renkListesi.Add("Mavi");
            renkListesi.Add("Turuncu");
            renkListesi.Add("Sarı");
            renkListesi.Add("Yeşil");

            //Count
            Console.WriteLine(renkListesi.Count); // Liste içerisindeki eleman adedini gösterir.
            Console.WriteLine(sayiListesi.Count);

            foreach (var sayi in sayiListesi)
            {
                Console.WriteLine(sayi);
            }

            foreach (var renk in renkListesi)
            {
                Console.WriteLine(renk);
            }

            sayiListesi.ForEach(sayi => Console.WriteLine(sayi));
            renkListesi.ForEach(renk => Console.WriteLine(renk));

            //Listeden eleamn çıkarma   
            Console.WriteLine("**** Listeden eleamn çıkarma ****");
            sayiListesi.Remove(4);
            renkListesi.Remove("Yeşil");

            sayiListesi.RemoveAt(0);
            renkListesi.RemoveAt(1);


            sayiListesi.ForEach(sayi => Console.WriteLine(sayi));
            renkListesi.ForEach(renk => Console.WriteLine(renk));

            //Liste içerisinde arama
            if (sayiListesi.Contains(10))
            {
            
                Console.WriteLine("10 Liste içerisinde bulunamadı!");
            }
            // Eleman ile index'e erişme
            Console.WriteLine(renkListesi.BinarySearch("Sarı"));

            //Dizi'yi Liste çevirme
            string[] hayvanlar = { "Kedi", "Köpek", "Kuş" };

            List<string> hayvanListesi = new List<string>(hayvanlar);

            //Listeyi nasıl temizleriz?
            hayvanListesi.Clear();

            //List içerisinde nesne tutmak
            List<Kullanıclar> kullanıcıListesi = new List<Kullanıclar>();
            Kullanıclar kullanıcı1 = new Kullanıclar();
                kullanıcı1.Isim = "Ayşe";
                kullanıcı1.SoyIsim = "Aylin";
                kullanıcı1.Yas = 26;

                Kullanıclar kullanıcı2 = new Kullanıclar();
                kullanıcı2.Isim = " Özcan";
                kullanıcı2.SoyIsim = "Çalışkan";
                kullanıcı2.Yas = 26;

                kullanıcıListesi.Add(kullanıcı1);
                kullanıcıListesi.Add(kullanıcı2);

                List<Kullanıclar> yeniListe = new List<Kullanıclar>();
                yeniListe.Add(new Kullanıclar()
                {

                    Isim = "Deniz",
                    SoyIsim = "Arda",
                    Yas = 24
                });

                foreach (var kullanıcı in kullanıcıListesi)
                {
                    Console.WriteLine("Kullanıcı Adı:" + kullanıcı.Isim);
                    Console.WriteLine("Kullanıcı Soyadı:" + kullanıcı.SoyIsim);
                    Console.WriteLine("Kullanıcı Yaşı:" + kullanıcı.Yas);
                }

                yeniListe.Clear(); 
        }
    }
}

public class Kullanıclar
{ 

    public string Isim { get; set; }
    public string SoyIsim { get; set; }
    public int Yas { get; set; }
}

