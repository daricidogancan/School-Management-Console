using Okulyonetim.App.Database;
using Okulyonetim.App.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Okulyonetim.App
{
    public class Program
    {
        static void Main(string[] args)
        {
            bool  devam = true;
            while (true)
            {

            
            Console.WriteLine("Okul Yönetim Sayfası");
            Console.WriteLine("1:Öğrenci Sayfasına Geçmek için");
            Console.WriteLine("2:Öğretmen Sayfasına Geçmek için");
            Console.WriteLine("3:Personel Sayfasına Geçmek için");
            Console.WriteLine("4:Servis Sayfasına Geçmek için");
            char sayfaSec = Console.ReadKey(true).KeyChar;
            if (sayfaSec=='1')
            {
                Console.WriteLine("1.Öğrenci Ekle");
                Console.WriteLine("2.Öğrenci Listele");
                char ogrSec = Console.ReadKey(true).KeyChar;
                if (ogrSec=='1')
                {
                    Console.Clear();
                    OgrenciEkle();
                }
                else if (ogrSec=='2')
                {
                    Console.Clear();
                    OgrenciListele();
                }
            }
           else if (sayfaSec == '2')
            {
                Console.WriteLine("1.Öğretmen Ekle");
                Console.WriteLine("2.Öğretmen Listele");
                char ogrtSec = Console.ReadKey(true).KeyChar;
                if (ogrtSec == '1')
                {
                    Console.Clear();
                    OgretmenEkle();
                }
                else if (ogrtSec == '2')
                {
                    Console.Clear();
                    OgretmenListele();
                }
            }
            else if (sayfaSec == '3')
            {
                Console.WriteLine("1.Personel Ekle");
                Console.WriteLine("2.Personel Listele");
                char prsSec = Console.ReadKey(true).KeyChar;
                if (prsSec == '1')
                {
                    Console.Clear();
                    PersonelEkle();
                }
                else if (prsSec == '2')
                {
                    Console.Clear();
                    PersonelListele();
                }
            }
            else if (sayfaSec == '4')
            {
                Console.WriteLine("1.Servis Ekle");
                Console.WriteLine("2.Servis Listele");
                char srvSec = Console.ReadKey(true).KeyChar;
                if (srvSec == '1')
                {
                    Console.Clear();
                    ServisEkle();
                }
                else if (srvSec == '2')
                {
                    Console.Clear();
                    ServisListele();
                }
            }
            else
            {
                Console.WriteLine("Yanlış Seçim Yaptınız...");
            }
                Console.WriteLine("Devam Etmek İstiyorsanız: [E/H]");
                char sectir = Console.ReadKey(true).KeyChar;
                if (sectir=='E'||sectir=='e')
                {
                    devam = true;
                }
                else 
                {
                    devam = false;
                }

            }

        }
       static OkulContext ctx = new OkulContext();
        public static void OgretmenEkle()
        {
            Ogretmen tch = new Ogretmen();

            Console.Write("Öğretmen Adı Giriniz:");
            tch.Isim = Console.ReadLine();
            Console.Write("Öğretmen Soyadı Giriniz:");
            tch.Soyisim = Console.ReadLine();
            Console.Write("Tel No Giriniz:");
            tch.Telno = Console.ReadLine();

            ctx.Ogretmenler.Add(tch);
            ctx.SaveChanges();
            Console.Clear();
            Console.WriteLine("Öğretmen Kaydınız Başarıyla Eklendi");

        }
        public static void OgretmenListele()
        {
            List<Ogretmen> ogretmenler = ctx.Ogretmenler.ToList();
            foreach (var item in ogretmenler)
            {
                Console.WriteLine(item.Isim+" "+item.Soyisim);
            }
        
        }

        public static void ServisEkle()
        {
            Servis srv = new Servis();

            Console.Write("Ad Giriniz:");
            srv.Isim = Console.ReadLine();
            Console.Write("Soyad Giriniz:");
            srv.Soyisim = Console.ReadLine();
            Console.Write("Tel No Giriniz:");
            srv.Telno = Console.ReadLine();
            Console.Write("Güzergah Giriniz:");
            srv.Hat = Console.ReadLine();

            ctx.Servisler.Add(srv);
            ctx.SaveChanges();
            Console.Clear();
            Console.WriteLine("Servis Kaydınız Başarıyla Eklendi");

        }

        public static void ServisListele()
        {
            List<Servis> servisler = ctx.Servisler.ToList();
            foreach (var item in servisler)
            {
                Console.WriteLine(item.Isim + " " + item.Soyisim);
            }

        }

        public static void PersonelEkle()
        {
            Personel prs = new Personel();

            Console.Write("Ad Giriniz:");
            prs.Isim = Console.ReadLine();
            Console.Write("Soyad Giriniz:");
            prs.Soyisim = Console.ReadLine();
            Console.Write("Tel No Giriniz:");
            prs.Telno = Console.ReadLine();
            Console.Write("İş Alanı Giriniz:");
            prs.Isalani = Console.ReadLine();

            ctx.Personeller.Add(prs);
            ctx.SaveChanges();
            Console.Clear();
            Console.WriteLine("Personel Kaydınız Başarıyla Eklendi");

        }

        public static void PersonelListele()
        {
            List<Personel> personeller = ctx.Personeller.ToList();
            foreach (var item in personeller)
            {
                Console.WriteLine(item.Isim + " " + item.Soyisim);
            }

        }
        public static void OgrenciEkle()
        {
            Ogrenci ogr = new Ogrenci();

            Console.Write("Ad Giriniz:");
            ogr.Isim = Console.ReadLine();
            Console.Write("Soyad Giriniz:");
            ogr.Soyisim = Console.ReadLine();
            Console.Write("Okul No Giriniz:");
            ogr.Okulno = int.Parse(Console.ReadLine());
            Console.Write("Öğretmen Giriniz:");
            ogr.OgretmenId = int.Parse(Console.ReadLine());
            Console.Write("Servis Giriniz:");
            ogr.ServisId = int.Parse(Console.ReadLine());
            
            
            ctx.Ogrenciler.Add(ogr);
            ctx.SaveChanges();
            Console.Clear();
            Console.WriteLine("Ogrenci Kaydınız Başarıyla Eklendi");

        }

        public static void OgrenciListele()
        {
            List<Ogrenci> ogrenciler = ctx.Ogrenciler.ToList();
            foreach (var item in ogrenciler)
            {
                Console.WriteLine(item.Isim + " " + item.Soyisim);
            }

        }



    }
}
