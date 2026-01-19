using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace okul_ders
{
    public partial class Form1 : Form
    {
        int Sayi;
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            Random rnd = new Random();
           
           

            for (int i = 0; i < 10; i++)
            {
                Sayi = rnd.Next(0, 20);
                listBox1.Items.Add(Sayi);
                

            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           
            
            


        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            listBox3.Items.Clear();


            for(int i = 0 ; i < listBox1.Items.Count; i++)
            {
                int list_sayi = Convert.ToInt32(listBox1.Items[i]);

                if (list_sayi % 2 == 1)
                {
                    listBox2.Items.Add(list_sayi);
                }

                else
                {
                    listBox3.Items.Add(list_sayi);
                }

            }
        }
    } 
}
