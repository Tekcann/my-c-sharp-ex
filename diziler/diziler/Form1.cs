using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace diziler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int[] sayilar = new int[20];

        private void button1_Click(object sender, EventArgs e)
        {
            
            

            sayilar[0] = 10;
            sayilar[1] = 43;
            sayilar[2] = 9;

            sayilar[6] = 15;
            sayilar[7] = 456;
            sayilar[8] = 007;
            //for(int i = 0;i < 10; i++)
            //{
            //    listBox1.Items.Add(sayilar[i]);
            //}

            for(int i= 0; i < 40;i++)
            {
                listBox1.Items.Add(sayilar[i]);
            }
        }
        string[] meyveler = {"Elma", "Armut", "Şeftali", "Mihriban","","","","","",};
        private void button2_Click(object sender, EventArgs e)
        {
            foreach(string meyve in meyveler)
            {
                if (meyve == "") break;
                listBox1.Items.Add(meyve);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button1.Text = "Dizi artı";
             a = 40;


           
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
