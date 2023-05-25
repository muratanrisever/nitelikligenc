using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //-------------------VERI/TIPLERI----------------

            //int x = 40, y = 10;
            //int toplam = x + y;
            //int fark = x - y;
            //int carpim = x * y;
            //int bolme = x / y;
            //int kalan = y % y;
            //int hepsiToplam = toplam + fark + carpim + bolme + kalan;
            //bool esitMi = !true;
            //if (esitMi==true && (x==40 || y==10))
            //{
            //    x= y;
            //    Console.WriteLine("x ve y birbirine e�ittir.");
            //}
            //else
            //{
            //    Console.WriteLine("x ve y birbirine e�it de�ildir.");
            //}
            //Console.WriteLine(toplam);
            //Console.WriteLine(fark);
            //Console.WriteLine(carpim);
            //Console.WriteLine(bolme);
            //Console.WriteLine(kalan);
            //Console.WriteLine(hepsiToplam);
            //Console.ReadLine();

            //-------IF/ELSE---------

            //Console.Write("Username : ");
            //var userName = Console.ReadLine();
            //Console.Write("Password : ");
            //var password = Console.ReadLine();
            //var dogruMu = true;
            //if (userName == "admin" && password == "123456" && dogruMu==true) {
            //    Console.WriteLine("Giri� Ba�ar�l�");
            //    Console.ReadLine();
            //}
            //else if (userName != "admin" || password != "123456" && dogruMu==false)
            //{
            //    Console.WriteLine("Hatal� kullan�c� ad� veya �ifre.");
            //    Console.ReadLine();
            //}
            //else if (userName != "admin" && password != "123456" && dogruMu == false)
            //{
            //    Console.WriteLine("L�tfen bilgileri do�ru girin!");
            //    Console.ReadLine();
            //}
            //else
            //{
            //    Console.WriteLine("404 Not Found");
            //    Console.ReadLine();
            //}

            //---------SWITCH/CASE/IF/ELSE------------------

            //switch (userName)
            //{
            //    case "admin" when password == "123456" && dogruMu == true:
            //        Console.WriteLine("Giri� Ba�ar�l�");
            //        Console.ReadLine();
            //        break;
            //    default:
            //        if (userName != "admin" || password != "123456" && dogruMu == false)
            //        {
            //            Console.WriteLine("Hatal� kullan�c� ad� veya �ifre.");
            //            Console.ReadLine();
            //        }
            //        else if (userName != "admin" && password != "123456" && dogruMu == false)
            //        {
            //            Console.WriteLine("L�tfen bilgileri do�ru girin!");
            //            Console.ReadLine();
            //        }
            //        else
            //        {
            //            Console.WriteLine("404 Not Found");
            //            Console.ReadLine();
            //        }

            //        break;
            //}

            //------------------FOR---------------

            //int minNumber = 10;
            //int maxNumber = 100;
            //for (int i = minNumber; i <= maxNumber; i++)
            //{
            //    Console.WriteLine(i);
            //}
            //Console.ReadLine();

            //--------------------WHILE-----------
            //int sayi = 1;
            //while (true)
            //{
            //    if (sayi == 11)
            //    {
            //        break;
            //    }
            //    Console.WriteLine(sayi);
            //    sayi++;
            //}
            //Console.ReadKey();

            //---------WHILE---------

            //int sayi = 0;
            //int tektoplam = 0;
            //int cifttoplam = 0;
            //while (sayi <= 3 )
            //{
            //    if (sayi % 2 == 1)
            //    {
            //        tektoplam += sayi;
            //        sayi++;
            //    }
            //    else
            //    {
            //        cifttoplam += sayi;
            //        sayi++;
            //    }
            //}
            //Console.WriteLine("Tek say�lar�n toplam� : "+tektoplam);
            //Console.WriteLine("�ift say�lar�n toplam� : "+cifttoplam);
            //Console.ReadKey();

            //----------ORNEK-1----------

            //2 farkl� de�i�kene 50 ve 25 de�erleri atay�p ekrana alt alta ve yan yana yazd�ran kodlar� yaz�n�z.

            //int x = 50;
            //int y = 25;
            //Console.WriteLine(x);
            //Console.WriteLine(x);
            //Console.WriteLine(y);
            //Console.WriteLine(y);
            //Console.Write(x);
            //Console.Write(x);
            //Console.Write(y);
            //Console.Write(y);
            //Console.ReadLine();

            //-------ORNEK-2-----------------------------------

            //Klavyeden girilen say�n�n tek mi �ift mi ooldu�unu bulan komutlar� yaz�n�z.

            //�fin yaz�l�� �ekilleri

            //Console.Write("Bir say� giriniz : ");
            //var sayi = Convert.ToInt32(Console.ReadLine());
            //var sonuc = sayi % 2 == 1 ? "Say� tektir" : "Say� �ifttir";

            //�fin yaz�l�� �ekilleri

            //if (sayi % 2 == 1) 
            //{
            //    Console.WriteLine("Say� tektir.");
            //}
            //else
            //{
            //    Console.WriteLine("Say� �ifttir.");
            //}
            //Console.ReadKey();

            //--ARRAY/LIST-----

            //----LIST--------

            //Random random = new Random();
            //List<int> _newlist = new List<int>();
            //for (int i = 0; i < 10; i++)
            //{
            //    _newlist.Add(random.Next(1, 10));
            //}

            //foreach (int d in _newlist) 
            //{
            //Console.WriteLine("eleman"+" "+d);
            //}
            //Console.ReadKey();

            //----ARRAY--------

            //----Bir dizinin i�indeki tek say�lar�n ka� tane oldu�unu yazd�ran consol uygulamas�-------
            //int sayac = 0;
            //int[] sayilar = { 10, 15, 20, 33, 22, 11, 9, 8, 48, 47, 12, 25, 12, 21 };
            //int toplam = 0;
            //foreach (int sayi in sayilar)
            //{

            //    if (sayi % 2 == 1)
            //    {
            //        sayac++;
            //        Console.WriteLine(sayi);
            //    }

            //}
            //Console.WriteLine("Tek say� adeti= " + sayac);

            //Console.ReadKey();

            //-------METHODLAR/FONKS�YONLAR---------------

            //CarpmaIslemi(2,4,6);
            //Bolme(20, 5);
            //Toplama(20, 5);
            //Carpma(20, 5);
            //Cikarma(20, 5);

            //----Kullan�c�dan iki de�er al�nacak b�y�k olan�n� ekrana yazd�r.



            //buyuk();
            //{
            //    Console.WriteLine("sonuc : ");
            //}



        }

        //public static void buyuk()
        //{
        //    Console.Write("Birinci say� giriniz : ");
        //    var sayi1 = Convert.ToInt32(Console.ReadLine());
        //    Console.Write("�kinci say� giriniz : ");
        //    var sayi2 = Convert.ToInt32(Console.ReadLine());
        //    if (sayi1 > sayi2)
        //    {
        //        Console.WriteLine("Birinci say� b�y�kt�r.");
        //        Console.ReadKey();
        //    }
        //    else if (sayi1 < sayi2)
        //    {
        //        Console.WriteLine("�kinci say� b�y�kt�r.");
        //        Console.ReadKey();
        //    }
        //    else { Console.WriteLine("Say�lar e�ittir.");
        //        Console.ReadKey();
        //    }
    }

    //public static void Bolme(int sayi1,int sayi2)
    //{
    //    int sonuc = sayi1 / sayi2;
    //    Console.WriteLine("B�lme i�leminin sonucu : " + sonuc);
    //    Console.ReadKey();
    //}
    //public static void Toplama(int sayi1, int sayi2) 
    //{
    //    int sonuc = sayi1 + sayi2;
    //    Console.WriteLine("Toplama i�leminin sonucu : "+sonuc);
    //    Console.ReadKey();
    //}
    //public static void Carpma(int sayi1, int sayi2) 
    //{
    //    int sonuc = sayi1 * sayi2;
    //    Console.WriteLine("�arpma i�leminin sonucu : " + sonuc);
    //    Console.ReadKey();
    //}
    //public static void Cikarma(int sayi1, int sayi2) 
    //{
    //    int sonuc = sayi1 - sayi2;
    //    Console.WriteLine("��karma i�leminin sonucu : " + sonuc);
    //    Console.ReadKey();
    //}

    //public static void CarpmaIslemi(int sayi3,int sayi4, int sayi5)
    //{
    //    int sonuc2 = sayi3 * sayi4 * sayi5;
    //    sonuc2 = sayi3 * sayi4 * sayi5;
    //    Console.WriteLine("��karma i�lemi sonucu : "+sonuc2);
    //    Console.ReadKey();
}
