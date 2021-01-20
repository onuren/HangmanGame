using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adamAsmacaOyunu
{
    class islemler
    {
        public int zorlukSecim { get; set; }
        public string zorlukSecimStr { get; set; }
        public string girilenKelime { get; set; }
        public List<char> kelimeDizi { get; set; }
        public List<char> gecici { get; set; }
        public int canHakki { get; set; }

        public void baslangic()
        {
            here:
            Console.WriteLine("Lütfen Zorluk Seviyesini Seçiniz:");
            Console.WriteLine("-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-");
            Console.WriteLine("\t1. Kolay (20 can)");
            Console.WriteLine("\t2. Orta  (10 can)");
            Console.WriteLine("\t3. Zor   (5 can)");
            Console.WriteLine("\t4. Uzman (2 can)");
            Console.WriteLine("-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-");
            try
            {
                this.zorlukSecim = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                switch (zorlukSecim)
                {
                    case 1:
                        zorlukSecimStr = "Kolay";
                        canHakki = 20;
                        break;
                    case 2:
                        zorlukSecimStr = "Orta";
                        canHakki = 10;
                        break;
                    case 3:
                        zorlukSecimStr = "Zor";
                        canHakki = 5;
                        break;
                    case 4:
                        zorlukSecimStr = "Uzman";
                        canHakki = 2;
                        break;
                }

                Console.WriteLine("Zorluk seviyesi: "+zorlukSecimStr);
                Console.WriteLine("-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-");
                Console.WriteLine("Bir Kelime veya Cümle Giriniz:");
                girilenKelime = Console.ReadLine();

            }
            catch
            {
                Console.WriteLine("Lütfen 1-4 arasında zorluk derecesi seçiniz.");
                goto here;
            }
        }


    }
}
