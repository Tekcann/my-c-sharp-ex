using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Karar_yapıları
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Örnek kod
            //// if - else if - else
            //// switch - case - default
            //// Kullanıcıdan bir sayı alalım
            //Console.Write("Lütfen bir sayı giriniz: ");
            //int sayi = Convert.ToInt32(Console.ReadLine());
            //// Girilen sayının pozitif, negatif veya sıfır olduğunu kontrol edelim
            //if (sayi > 0)
            //{
            //    Console.WriteLine("Girilen sayı pozitiftir.");
            //}
            //else if (sayi < 0)
            //{
            //    Console.WriteLine("Girilen sayı negatiftir.");
            //}
            //else
            //{
            //    Console.WriteLine("Girilen sayı sıfırdır.");
            //}
            //// Kullanıcıdan bir gün numarası alalım (1-7)
            //Console.Write("Lütfen bir gün numarası giriniz (1-7): ");
            //int gunNumarasi = Convert.ToInt32(Console.ReadLine());
            //// Girilen gün numarasına göre gün adını yazdıralım
            //switch (gunNumarasi)
            //{
            //    case 1:
            //        Console.WriteLine("Pazartesi");
            //        break;
            //    case 2:
            //        Console.WriteLine("Salı");
            //        break;
            //    case 3:
            //        Console.WriteLine("Çarşamba");
            //        break;
            //    case 4:
            //        Console.WriteLine("Perşembe");
            //        break;
            //    case 5:
            //        Console.WriteLine("Cuma");
            //        break;
            //    case 6:
            //        Console.WriteLine("Cumartesi");
            //        break;
            //    case 7:
            //        Console.WriteLine("Pazar");
            //        break;
            //    default:
            //        Console.WriteLine("Geçersiz gün numarası!");
            //        break;
            //}
            //Console.ReadLine();
            #endregion

            #region if else
            //string password;
            //Console.WriteLine("***** Şifrenizi Giriniz: ****");
            //password = Console.ReadLine();

            //if (password == "123456")
            //{
            //    Console.WriteLine("Şifreniz Doğru");
            //}
            //else
            //{
            //   Console.WriteLine("Şifreniz Yanlış");
            //}

            // Console.ReadLine();

            #endregion

            #region mod işlemleri
            //int number;
            //number = 26;
            //int result = number % 5;
            //Console.WriteLine(result);

            //Console.WriteLine("bir sayı giriniz: ");
            //int number = int.Parse(Console.ReadLine());

            //if (number % 2 == 0)
            //{
            //    Console.WriteLine("girdiğiniz sayı çifttir");
            //}
            //else
            //{
            //    Console.WriteLine("girdiğiniz sayı tektir");
            //}

            #endregion

            #region char
            //char team;
            //Console.WriteLine("Lütfen bir takımınızın sembolünü giriniz");
            //team = char.Parse(Console.ReadLine());

            //if(team == 'F' || team == 'f')
            //{
            //    Console.WriteLine("Fenerbahçe");
            //}
            //else if (team == 'G' || team == 'g')
            //{
            //    Console.WriteLine("Galatasaray");
            //}
            //else if (team == 'B' || team == 'b')
            //{
            //    Console.WriteLine("Beşiktaş");
            //}
            //else if (team == 'T' || team == 't')
            //{
            //    Console.WriteLine("Trabzonspor");
            //}
            //else
            //{
            //    Console.WriteLine("Lütfen geçerli bir takım sembolü giriniz");
            //}

            #endregion

            #region switch case

            //Console.Write("bir ay numarası giriniz: ");
            //int month = int.Parse(Console.ReadLine());

            //switch(month)
            //{
            //    case 1:
            //        Console.WriteLine("Ocak");
            //        break;
            //    case 2:
            //        Console.WriteLine("Şubat");
            //        break;
            //    case 3:
            //        Console.WriteLine("Mart");
            //        break;
            //    case 4:
            //        Console.WriteLine("Nisan");
            //        break;
            //    case 5:
            //        Console.WriteLine("Mayıs");
            //        break;
            //    case 6:
            //        Console.WriteLine("Haziran");
            //        break;
            //    case 7:
            //        Console.WriteLine("Temmuz");
            //        break;
            //    case 8:
            //        Console.WriteLine("Ağustos");
            //        break;
            //    case 9:
            //        Console.WriteLine("Eylül");
            //        break;
            //    case 10:
            //        Console.WriteLine("Ekim");
            //        break;
            //    case 11:
            //        Console.WriteLine("Kasım");
            //        break;
            //    case 12:
            //        Console.WriteLine("Aralık");
            //        break;
            //    default:
            //        Console.WriteLine("Lütfen geçerli bir ay numarası giriniz");
            //        break;
            //}



            #endregion

            #region hesap makinesi

            //Console.Write("Birinci sayıyı giriniz: ");
            //double sayi1 = Convert.ToDouble(Console.ReadLine());

            //Console.Write("İkinci sayıyı giriniz: ");
            //double sayi2 = Convert.ToDouble(Console.ReadLine());

            //Console.Write("Yapmak istediğiniz işlemi giriniz (+, -, *, /): ");
            //char islem = Convert.ToChar(Console.ReadLine());

            //double sonuc;

            //switch (islem)
            //{
            //    case '+':
            //        sonuc = sayi1 + sayi2;
            //        Console.WriteLine("Sonuç: " + sonuc);
            //        break;
            //    case '-':
            //        sonuc = sayi1 - sayi2;
            //        Console.WriteLine("Sonuç: " + sonuc);
            //        break;
            //    case '*':
            //        sonuc = sayi1 * sayi2;
            //        Console.WriteLine("Sonuç: " + sonuc);
            //        break;
            //    case '/':
            //        if (sayi2 != 0)
            //        {
            //            sonuc = sayi1 / sayi2;
            //            Console.WriteLine("Sonuç: " + sonuc);
            //        }
            //        else
            //        {
            //            Console.WriteLine("Hata: Bir sayı sıfıra bölünemez.");
            //        }
            //        break;
            //    default:
            //        Console.WriteLine("Geçersiz işlem! Lütfen +, -, *, / işlemlerinden birini giriniz.");
            //        break;
            //}
            #endregion

            Console.Read();


            
        }
    }
}