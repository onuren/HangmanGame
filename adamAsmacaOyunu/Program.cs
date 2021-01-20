
using System;
using System.Collections.Generic;

namespace adamAsmacaOyunu
{
    class Program
    {
        static void Main(string[] args)
        {

            islemler a = new islemler();
            a.baslangic();
            a.kelimeDizi = new List<char>();
            a.gecici = new List<char>();
            char harfTahmin;

            Console.Clear();
            Console.WriteLine("Zorluk seviyesi: " + a.zorlukSecimStr);
            Console.WriteLine("-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-");
            Console.WriteLine("Harf tahmini yaparak oyuna başlayınız:");

            //gecici diziye kelimenin harfleri yerine _ ve / eklenmesi
            for (int i = 0; i < a.girilenKelime.Length; i++)
            {
                a.kelimeDizi.Add(a.girilenKelime[i]);
                if (a.kelimeDizi[i] == ' ')
                    a.gecici.Add('/');
                else
                    a.gecici.Add('_');
            }

            for (int i = a.canHakki; i >= 0;)
            {
            here:
                try
                {
                    Console.WriteLine("Kalan canınız: " + i + " / " + a.canHakki);

                    //geciciyi yazdır
                    foreach (char item in a.gecici)
                    {
                        Console.Write(item + " ");
                    }
                    Console.WriteLine();

                    //harfi al
                    harfTahmin = Convert.ToChar(Console.ReadLine());
                    Console.Clear();

                    //harfi içeriyorsa geciciye ekle
                    for (int j = 0; j < a.kelimeDizi.Count; j++)
                    {
                        int ara = a.kelimeDizi.IndexOf(harfTahmin, j);
                        if (ara >= 0)
                        {
                            a.gecici[ara] = harfTahmin;
                        }
                        else
                        {
                            break;
                        }
                    }

                    //içermiyorsa 1 can düşür
                    if (!(a.kelimeDizi.Contains(harfTahmin)))
                    {
                        i--;
                        Console.WriteLine("Yanlış tahmin.");
                    }

                    //eğer _ yoksa oyunu kazandınız yaz
                    if (!(a.gecici.Contains('_')))
                    {
                        Console.WriteLine("Tebrikler kelimeyi buldunuz!");
                        Console.Beep(1000, 200);
                        Console.Beep(2000, 500);
                        break;
                    }
                }
                catch
                {
                    Console.WriteLine("Lütfen yalnızca harf girişi yapınız.");
                    goto here;
                }

            }

            //eğer _ varsa oyunu kaybettiniz yaz
            if (a.gecici.Contains('_'))
            {
                Console.WriteLine("Malesef tahmin hakkınız doldu. \nOyunu kaybettiniz.");
                Console.Beep(2000, 200);
                Console.Beep(1000, 500);
            }
        }
    }
}
