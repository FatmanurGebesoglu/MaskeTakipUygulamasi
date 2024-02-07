using System;

namespace Workaround
{
    class Program
    {
        static void Main(string[] args)
        {
           // Degiskenler();
           Vatandas vatandas1 = new Vatandas();
           
        }

        private static void Degiskenler()
        {
            string mesaj = "merhaba";
            double tutar = 1000;
            int sayi = 100;
            bool girisYapmisMi = false;

            string ad = "Fatmanur";
            string soyad = "Gebeşoğlu";
            int dogumYili = 2000;
            long tcNo = 12345678910;

            Console.WriteLine("merhaba");
            Console.ReadLine();
        }
    }

    public class Vatandas
    {
        //public string ad = "Fatmanur";
        //public string soyad = "Gebeşoğlu";
        //public int dogumYili = 2000;
        //public long tcNo = 12345678910;

        public string Ad { get; set; }
        public string Soyad { get; set; }
        public int DogumYili { get; set; }
        public long TcNo { get; set; }


    }
}