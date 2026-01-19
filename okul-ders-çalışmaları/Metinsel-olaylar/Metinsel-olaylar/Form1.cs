using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Metinsel_olaylar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
                                     //Her HArfi büyük yazar
            label1.Text = textBox1.Text.ToUpper();//
        }

        private void button2_Click(object sender, EventArgs e)
        {                               //Her HArfi küçük yazar
            label1.Text = textBox1.Text.ToLower();
        }

        private void button3_Click(object sender, EventArgs e)
        {
                                                 //Boşlukları budar
            string isim = textBox1.Text.ToUpper().Trim(); ;
            if(isim == "AHMET")
            {
                MessageBox.Show("ismi dğoru girdiniz.");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string veri = textBox1.Text;
            int kharf = Convert.ToInt32(textBox2.Text);
            int kAdet = Convert.ToInt32(textBox3.Text);
            label1.Text = veri.Substring(kharf, kAdet);
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string kelime = textBox1.Text;     //kelimenin uzunluğunu bulur
            MessageBox.Show($"Girilen Kelime {kelime.Trim().Length}");
        }

        private void button6_Click(object sender, EventArgs e)
        {// Bu kod Kelimenin bütün harflerini listBox a ekler
            string kelime = textBox1.Text.Trim();

            for(int i =0;i < kelime.Length; i++)
            {
                listBox1.Items.Add(kelime.Substring(i,1));
            }
        }
    }
}
