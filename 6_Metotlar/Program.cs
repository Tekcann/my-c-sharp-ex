using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_Metotlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Void Metotlar
            //belli işlemleri tekardan kullanmak gerektiği vakitlerde kullanılır.
            //()
            //Geriye değer dödürmeyen metotlar
            //Custumer ----->Listeles, ekle, sil, güncelle
            //void

            //void Custemer_List()
            //{
            //    Console.WriteLine("****Talat Paşa*");
            //    Console.WriteLine();
            //    Console.WriteLine("***Enver Paşa**");
            //    Console.WriteLine();
            //    Console.WriteLine("**Rafet Paşa***");
            //    Console.WriteLine();
            //    Console.WriteLine("*Kazım Paşa****");
            //    Console.WriteLine();
            //}


            //Custemer_List();
            //Custemer_List();
            //Custemer_List();
            //Custemer_List();



            //void Sum()
            //{
            //    int x = 3;
            //    int y = 5;
            //    int z = x + y;
            //    Console.WriteLine(z);
            //}

            //Sum();


            #endregion

            #region Geriye Değer Döndürmeyen Parametleri Metotlar (string)

            //void WriteMethod(string custumer_name)
            //{
            //    Console.WriteLine(custumer_name);
            //}
            //WriteMethod("Fahrettin Altay");


            //void CustumerCard(string name, string surName)
            //{
            //    Console.WriteLine($"müşteri :{name} {surName}");
            //}
            //CustumerCard("Felatun", "Bey");
            //CustumerCard("Rakıp", "Efendi");

            #endregion

            #region Geriye Değer Döndürmeyen Parametleri Metotlar (int)

            //void Sum(int number1,int number2 , int number3)
            //{
            //    int result = number1 + number2 + number3;
            //    Console.WriteLine(result);
            //}
            //Sum(4,5,6);
            #endregion

            #region Geriye Değer Döndüren Metotlar

            //string CustemerName()
            //{
            //    return "Nazım Hikmet";
            //}

            //CustemerName();


            //string StudentCard()
            //{
            //    String name = "Nazım";
            //    String surname = "Hikmet";

            //    return name + " " + surname;


            //}
            //Console.WriteLine(StudentCard());


            #endregion

            #region Geriye Değer Döndüren Parametleri Metotlar (string)

            //string CauntryCard(string cauntry_name, string capital, string flag_color)
            //{
            //    string card_info =$"Ülke {cauntry_name} Başkent {capital} Bayrak rengi {flag_color} ";
            //    return card_info;
            //}
            //string a, b, c;

            //Console.Write("Ülke Adını Giriniz :");
            //a=Console.ReadLine();

            //Console.Write("Başkenti Giriniz :");
            //b=Console.ReadLine();

            //Console.Write("BAyrak Rengini Giriniz :");
            //c=Console.ReadLine();


            //Console.WriteLine(CauntryCard(a, b, c));
            //Console.WriteLine(CauntryCard("Türkiye", "Ankara", "Kırmızı-Beyaz"));




            #endregion

            #region Geriye Değer Döndüren Parametleri Metotlar (int)

            //int Sum(int number1, int number2)
            //{
            //    int result = number1 + number2;

            //    return result;
                
            //}
            //Console.WriteLine(Sum(3,5));
            //Console.WriteLine(Sum(30,50));
            //Console.WriteLine(Sum(130,150));

            //********************örnek uygulama****************************
            string ExamResult(string name, int exam1, int exam2, int exam3)
            {
                int result = (exam1 + exam2 + exam3) / 3;
                if(result >= 50)
                {
                    return $"{name} Sınavı Geçti Ortalaması ise :{result}";
                }
                else
                {
                    return $"{name} Sınavdan Kaldı Ortalaması ise :{result}";
                }
            }
            Console.WriteLine(ExamResult("Ahmet", 33, 66, 99));
            Console.WriteLine(ExamResult("Mehmet", 88, 66, 20));
            #endregion


            Console.ReadKey();
        }
    }
}
