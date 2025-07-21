using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region DoubleDegisken
            //double number;
            //number = 4.85;
            //Console.WriteLine(number);

            //double applePrice, orangePrice, strawerryPrice, potatoPrice, tomatoPrice;
            //applePrice = 14.25;
            //orangePrice = 18.50;
            //strawerryPrice = 30.25;
            //potatoPrice = 9.75;
            //tomatoPrice = 15;
            //double appleGram, orangeGram,strawerryGram,potatoGram,tomatoGram;
            //appleGram = 1.245;
            //orangeGram = 2.650;
            //strawerryGram = 0.750;
            //potatoGram = 4.250;
            //tomatoGram = 3.150;
            //double appleTotalPrice = applePrice * appleGram ;
            //double orangeTotalPrice= orangePrice * orangeGram;
            //double strawberryToralPrice=strawerryPrice* strawerryGram;
            //double potatoTotalPrice = potatoGram * potatoPrice;
            //double tomatoTotalPrice = tomatoPrice* tomatoGram;
            //double totalPrice= appleTotalPrice+ orangeTotalPrice+ strawberryToralPrice+ potatoTotalPrice+ tomatoTotalPrice;



            //Console.WriteLine("*****FİYAT LİSTESİ*****");
            //Console.WriteLine();
            //Console.WriteLine("-----Elma KG Fiyatı: " + applePrice + "TL");
            //Console.WriteLine("-----Portakal KG Fiyatı: " + orangePrice + "TL");
            //Console.WriteLine("-----Çilek KG Fiyatı: " + strawerryPrice + "TL");
            //Console.WriteLine("-----Patates KG Fiyatı: " + potatoPrice + "TL");
            //Console.WriteLine("-----Domates KG Fiyatı: " + tomatoPrice + "TL");
            //Console.WriteLine("------------------------");
            //Console.WriteLine();
            //Console.WriteLine("Toplam Elma Ücretiniz: " + appleTotalPrice + "TL");
            //Console.WriteLine("Toplam Portakal Ücretiniz: " + orangeTotalPrice + "TL");
            //Console.WriteLine("Toplam Çilek Ücretiniz: "+strawberryToralPrice+"TL");
            //Console.WriteLine("Toplam Patates Ücretiniz: "+potatoTotalPrice+"TL");
            //Console.WriteLine("Toplam Domates Ücretiniz: "+tomatoTotalPrice+"TL");

            //Console.WriteLine("Ödenecek Tutar: " + totalPrice+"TL");






            #endregion

            #region CharDegisken

            //char symbol;
            //symbol= 'a';
            //Console.WriteLine(symbol);


            #endregion

            #region Klavyeden Veri Girisler String
            //Console.WriteLine("*****Akyol Hava Yolları Yolcu Bilgisi*****");
            //string passengerName, passengerSurname, passengerAge, passengerDistrict, passengerCity,passengerID;
            //Console.Write("Yolcu Adı: ");
            //passengerName = Console.ReadLine();
            //Console.Write("Yolcu Soyadı: ");
            //passengerSurname = Console.ReadLine();
            //Console.Write("Yolcu Yaşı: ");
            //passengerAge = Console.ReadLine();
            //Console.Write("Yolcunun İlçe: ");
            //passengerDistrict = Console.ReadLine();
            //Console.Write("Yolcunun Şehir: ");
            //passengerCity = Console.ReadLine();
            //Console.Write("Yolcunun TC ID'si: ");
            //passengerID = Console.ReadLine();

            //Console.WriteLine();
            //Console.WriteLine("------------------------------------------");
            //Console.WriteLine("*****Akyol Hava Yolları Yolcu Bilgisi*****");
            //Console.WriteLine();
            //Console.WriteLine("Yolcu Ad Soyad: "+passengerName +" "+ passengerSurname);
            //Console.WriteLine("Yolcu Yaşı: " + passengerAge);
            //Console.WriteLine("Yolcu İkamet Yeri: " + passengerDistrict + "/" + passengerCity);
            //Console.WriteLine("Yolcunun TC ID'si: " + passengerID);

            #endregion

            #region Klavyeden Tam Sayı Girişleri ve Dönüşümler

            //int shoePrice, computerPrice, chairPrice, tvPrice;
            //shoePrice = 1000;
            //computerPrice = 15000;
            //chairPrice = 1100;
            //tvPrice = 8500;
            //int shoeCount, computerCount, chairCount, tvCount;
            //Console.Write("Lütfen Aldığınız Ayakkabı sayısını giriniz: ");
            //shoeCount =int.Parse( Console.ReadLine());
            //Console.Write("Lütfen Aldığınız PC sayısını giriniz: ");
            //computerCount =int.Parse( Console.ReadLine());
            //Console.Write("Lütfen Aldığınız sandalye sayısını giriniz: ");
            //chairCount = int.Parse(Console.ReadLine());
            //Console.Write("Lütfen Aldığınız tv sayısını giriniz: ");
            //tvCount = int.Parse(Console.ReadLine());

            //int totalPrice = shoeCount * shoePrice + computerPrice * computerCount + chairPrice * chairCount + tvCount * tvPrice;
            //Console.WriteLine("Toplam ödemeniz gereken tutar: " + totalPrice + "TL");





            #endregion

            #region Klavyeden Ondalıklı sayı işlemleri

            //double exam1, exam2, exam3, result;
            //Console.Write("Lütfen 1.Sınav notunu giriniz: ");
            //exam1=double.Parse(Console.ReadLine());
            //Console.Write("Lütfen 2.sınav notunu giriniz: ");
            //exam2 = double.Parse(Console.ReadLine());
            //Console.Write("Lütfen 3.sınav notunu giriniz: ");
            //exam3=double.Parse(Console.ReadLine());
            //result = (exam1 + exam2 + exam3) / 3;
            //Console.WriteLine();
            //Console.WriteLine("Sınav Ortalamanız: " + result);



            #endregion

            #region Klavyeden Karakter Girişleri
            char gender;
            Console.Write("LütfeN Cinsiyet Seçiniz ");
            gender =char.Parse(Console.ReadLine());

            Console.WriteLine("Seçtiğiniz Cinsiyet: "+gender);
            
            
            #endregion
            Console.Read();
        }
    }
}
