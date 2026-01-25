using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dizid_sorular
{
    public partial class Form1 : Form
    {
        int[] numbers = new int[10]; 
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rnd_number = new Random();
            

            for(int i = 0; i < 10; i++)
            {
                numbers[i] = rnd_number.Next(0, 101);
                

            }

            listBox1.Items.Clear();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < 10; i++)
            {
                listBox1.Items.Add(this.numbers[i]);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int enBüyükSayı = numbers[0];
            int enKüçükSayı = numbers[0];
            //for(int i=0; i< 10; i++)
            //{
            //    if(enBüyükSayı < numbers[i])
            //    {
            //        enBüyükSayı = numbers[i];
            //    }
            //}
            int sayac = 0;
            while(sayac < 10)
            {
                if (enBüyükSayı < numbers[sayac])
                {
                    enBüyükSayı = numbers[sayac];
                }

                sayac++;
            }

            


            MessageBox.Show($"EN BÜYÜK SAYI : {enBüyükSayı}");
        }
    }
}
