using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void MusteriEkle(Musteri musteri)
        {
            Console.WriteLine("Yeni müşteri eklendi: " + musteri.Id +" \n" + musteri.Name +" " + musteri.Surname +" \n" + musteri.PhoneNumber +"\n"+ musteri.Adress);
        }

        public void MusteriSil(Musteri musteri)
        {
            Console.WriteLine("Müşteri silindi: " + musteri.Id + " \n" + musteri.Name + " " + musteri.Surname + " \n" + musteri.PhoneNumber + "\n" + musteri.Adress);
        }
        

    }
}
