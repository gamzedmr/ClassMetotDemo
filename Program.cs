using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 233455;
            musteri1.Name = "Gamze";
            musteri1.Surname = "DEMİR";
            musteri1.PhoneNumber ="52";
            musteri1.Adress = "istanbul";

            Musteri musteri2 = new Musteri();
            musteri2.Id = 122235;
            musteri2.Name = "Gizem";
            musteri2.Surname = "ÜNLÜ";
            musteri2.PhoneNumber = "14";
            musteri2.Adress = "Ankara";


            Musteri musteri3 = new Musteri();
            musteri3.Id = 122235;
            musteri3.Name = "Fatma";
            musteri3.Surname = "KAYA";
            musteri3.PhoneNumber = "13";
            musteri3.Adress = "Antalya";


            MusteriManager musteriManager = new MusteriManager();
            musteriManager.MusteriEkle(musteri1);
            musteriManager.MusteriSil(musteri2);
        }
    }
}
