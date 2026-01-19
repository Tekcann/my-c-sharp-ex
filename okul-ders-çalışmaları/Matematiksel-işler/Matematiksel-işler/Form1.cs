using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Matematiksel_işler
{
    public partial class Form1 : Form
    {
        double a,b,cevap = 1;
        public Form1()
        {
            InitializeComponent();
        }
        private void SayıAl()
        {
            //değişlenler textBox tan değer alır
            a = Convert.ToInt32(textBox1.Text);
            b = Convert.ToInt32(textBox2.Text);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SayıAl();
            //Mutlak değerini alır
            MessageBox.Show($"sayının mutlak değeri {Math.Abs(a)}");
        }
        

        private void button2_Click(object sender, EventArgs e)
        {
            SayıAl();
            //işaretini ekrana yazdırır
            MessageBox.Show($"sayının işareti {Math.Sign(a)}");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            SayıAl();
            MessageBox.Show($"KareKök :{Math.Sqrt(a)} \n");
                
        }

        private void button6_Click(object sender, EventArgs e)
        {
            SayıAl();
            MessageBox.Show($"Yuvarlama {Math.Round(a)}\n" +
                $"Ceillig = {Math.Ceiling(a)} \n" +
                $"Floor = {Math.Floor(a)}");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SayıAl();
            for(int i = 0; i < a; i++)//kaç kez tekrar edeceğini hesaplar
            {
               cevap *= b;//işlem yapılır
            }
            MessageBox.Show($"{b} üssü {a} = {cevap}");//ekrana sonucu yazdılır
            cevap = 1;//cevabı tekrar 1 e dönüştürür

        }

        private void button3_Click(object sender, EventArgs e)
        {
            SayıAl();
                                           //üssü işlemi yapan komut ilki taban ikicisi üs
            MessageBox.Show($"{a} üssü {b} = {Math.Pow(a,b)}");
        }
    }
}
