using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_Dizileer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Temel Dizi Örnekleri
            //2,4,6,8
            //sarı,kırmızı,mavi,mor
            //ankara,izmir,istanbul,kars

            //DeğişkenTürü [] DiziAdı =new DeğişkenTürü[ElemanSayısı]
            //String[] colors = new string[4];

            //colors[0] = "kırmızı";
            //colors[1] = "sarı";
            //colors[2] = "beyaz";
            //colors[3] = "mavı";

            //Console.WriteLine(colors[2]);

            //NOT: Dizilerde ki index değeri verilmemişse
            //default olarak 0 değerini kabul eder


            //string[] cities = { "Prag", "Roma", "Atina", "Ankara", "Bursa" };

            //Console.WriteLine(cities[2]);

            #endregion

            #region Dizideki Tüm Elemanları Listeleme
            //string[] colors = { "Sarı", "Kırmızı", "Beyaz", "Mavi", "Yeşil", "Turuncu", "Pembe" };

            //for(int i = 0;i < colors.Length; i++)
            //{
            //    Console.WriteLine(colors[i]);
            //}

            //****************************************************************

            //int[] numbers = { 4, 55, 82, 120, 150, 785, 987, 1520, 2605 };

            //for(int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 3 == 0)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //}





            #endregion

            #region en büyük ve küçük sayıyı bulmak
            //int[] diziler = { 12, 34, 21, 23, 43, 567, 896, 453, 456, 555 };
            //int max_number = diziler[0];
            //int min_number = diziler[0];
            //for (int i = 0; i < diziler.Length; i++)
            //{
            //    En Büyük Sayı
            //    if (diziler[i] > max_number)
            //    {
            //        max_number = diziler[i];
            //    }
            //    En Küçük Sayı
            //    if (diziler[i] < min_number)
            //    {
            //        min_number = diziler[i];
            //    }
            //}
            //Console.WriteLine(max_number);
            //Console.WriteLine(min_number);
            #endregion



            Console.Read();
        }
    }
}
