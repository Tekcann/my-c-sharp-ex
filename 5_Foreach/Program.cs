using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_Foreach
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Foreach Döngüsü
            //Foreach(1;2;3;4)

            //1: Değişken Türü
            //2: Değişken adı
            //3: In
            //4: Liste Koleksiyon,Dizi

            //string[] cities = { "Milano", "Roma", "Budapeşte", "Ankara", "İstanbul" };

            //foreach(string x in cities)
            //{
            //    Console.WriteLine(x);
            //}

            #endregion

            #region Örnek
            //int[] numbers = { 45, 21, 5, 83, 21, 84, 5, 132, 45, 21, 2, 154, 84, 6, 8, 4, 3, 4, 6, 4, 64, 65 };

            //foreach(int number in numbers)
            //{
            //    if(number % 2 ==0)
            //    {
            //        Console.WriteLine(number);
            //    }
            //}
            #endregion

            #region Örnek_2
            //int[] numbers = { 45, 21, 5, 83, 21, 84, 5, 132, 45, 21, 2, 154, 84, 6, 8, 4, 3, 4, 6, 4, 64, 65 };
            //int total = 0;

            //foreach (int number in numbers)
            //{
            //    total = total+ number;
            //}

            //Console.WriteLine(total);
            #endregion

            #region Örnek_3
            //List<int> numbers = new List<int>()
            //{
            //    1,2,3,4,5,6,7,8
            //};
            //foreach(int number in numbers)
            //{
            //    Console.WriteLine(number);
            //}
            #endregion

            #region Örnek_4 String Metnini Harflere Ayırmak
            //string word = "Merhaba";

            //foreach(char c in word)
            //{
            //    Console.WriteLine(c);
            //}

            #endregion

            #region Örnek_5 Sınav Sistemi Uygulaması
            Console.WriteLine("***** C# Eğitim Uygulaması*****");
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("------------------------------");
            Console.Write("Sınıfınızda Kaç Öğrenci var :");
            int student_count = int.Parse(Console.ReadLine());
            Console.WriteLine("------------------------------");

            string[] student_name = new string[student_count];
            double[] student_exam = new double[student_count];

            for(int i = 0; i < student_count; i++)
            {
                Console.WriteLine($"{i + 1} öğrencinin ismini giriniz");
                student_name[i] = Console.ReadLine();

                double total_exam = 0;



                //Her Öğrenci İçin 3 Sınav
                for(int j = 0; j < 3; j++)
                {
                    Console.WriteLine($"{student_name[i]} adlı öğrencinin {j + 1}. sinav nıtunu giriniz.");
                    double value = double.Parse(Console.ReadLine());

                    total_exam = +value;

                }

                student_exam[i] = total_exam / 3;


            }
            // öğrencilerin ortalaması
            for(int i= 0; i< student_count; i++)
            {
                Console.WriteLine($"{student_name[i]} adlı öğrencinin ortalaması :{student_exam[i]}");
            }


            #endregion

            Console.ReadKey();

        }
    }
}
