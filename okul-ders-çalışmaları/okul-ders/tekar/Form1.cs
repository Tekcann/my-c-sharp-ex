using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tekar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int random_sayi;
        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            Random rnd = new Random();

           
            for(int i = 0; i < 10; i++)
            {
                random_sayi = rnd.Next(0, 101);
                listBox1.Items.Add(random_sayi);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            listBox3.Items.Clear();

            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                int listedeki_sayı = Convert.ToInt32(listBox1.Items[i]);

                if(listedeki_sayı % 2 == 0)
                {
                    listBox2.Items.Add(listedeki_sayı);
                }
                else
                {
                    listBox3.Items.Add(listedeki_sayı);
                }
            }
        }
    }
}
