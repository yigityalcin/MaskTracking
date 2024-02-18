using Business.Concrete;
using Entities.Concrete;
using System;
namespace Workaround;

class Program
{
    static void Main(string[] args)
    {
        //Degiskenler();
        //Vatandas vatandas = new();
        //SelamVer(isim: "Engin");
        //SelamVer(isim: "Ahmet");
        //SelamVer(isim: "Ayşe");
        //SelamVer();
        //int sonuc = Topla(3, 5);

        //Arrays
        //string[] ogrenciler = new string[3];
        //ogrenciler[0] = "Engin";
        //ogrenciler[1] = "Yigit";
        //ogrenciler[2] = "Fatma";

        //ogrenciler = new string[4];
        //ogrenciler[3] = "Ayse";

        //for (int i = 0; i < ogrenciler.Length; i++)
        //{
        //    Console.WriteLine(ogrenciler[i]);
        //}

        //string[] sehirler1 = new string[] { "Ankara", "İzmir", "İstanbul" };
        //string[] sehirler2 = new string[] { "Mersin", "Diyarbakır", "Adana" };

        //sehirler2 = sehirler1;
        //sehirler1[0] = "Adana";
        //Console.WriteLine(sehirler2[0]);
        //foreach (string sehir in sehirler1)
        //{
        //    Console.WriteLine(sehir);
        //}

        //List<string> yeniSehirler1 = new List<string> { "Ankara", "İstanbul", "İzmir" };
        //yeniSehirler1.Add("Mersin");
        //foreach (var sehir in yeniSehirler1)
        //{
        //    Console.WriteLine(sehir);
        //}

        Person person1 = new Person();
        person1.FirstName = "Yiğit";
        person1.LastName = "Yalçın";
        person1.DateOfBirthYear = 2000;
        person1.NationalIdentity = 13901266918;

        Person person2 = new Person();
        person2.FirstName = "Mehmet";

        


        PttManager pttManager = new PttManager(new PersonManager());
        pttManager.GiveMask(person1);


    }
    //static void SelamVer(string isim = "noname")
    //{
    //    Console.WriteLine("Merhaba " + isim);
    //}

    //static int Topla(int sayi1 , int sayi2)
    //{
    //    int sonuc = sayi1 + sayi2;
    //    Console.WriteLine("Toplam : " + sonuc);
    //    return sonuc;
    //}

    //private static void Degiskenler()
    //{
    //    string mesaj = "Merhaba";
    //    double tutar = 100000; //dbden gelir bu bilgiler.
    //    int sayi = 100;
    //    bool girisYapmisMi = false;

    //    string ad = "Yigit";
    //    string soyad = "Yalcin";
    //    int dogumYili = 1985;
    //    long tcNo = 22111666999;

    //    Console.WriteLine(tutar * 1.18);
    //}

    //public class Vatandas
    //{
    //    public string Ad { get; set; }
    //    public string Soyad { get; set; }
    //    public int DogumYili { get; set; }
    //    public long TcNo { get; set; }
    //}
}