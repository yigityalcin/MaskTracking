using System;
namespace Workaround;

class Program
{
    static void Main(string[] args)
    {
        //Degiskenler();
        Vatandas vatandas = new();
        
        
    }

    private static void Degiskenler()
    {
        string mesaj = "Merhaba";
        double tutar = 100000; //dbden gelir bu bilgiler.
        int sayi = 100;
        bool girisYapmisMi = false;

        string ad = "Yigit";
        string soyad = "Yalcin";
        int dogumYili = 1985;
        long tcNo = 22111666999;

        Console.WriteLine(tutar * 1.18);
    }
}
   
public class Vatandas
{
    public string Ad { get; set; }
    public string Soyad { get; set; }
    public int DogumYili { get; set; }
    public long TcNo { get; set; }
}