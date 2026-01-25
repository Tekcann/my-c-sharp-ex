using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ddizilere
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string[] arabalar = { "Ahmet", "Mehmet", "Selami", "Enes", "Akif", "Cavit","Fatih","Nihat","İlyas","İnanç","Ali Eren","Yusuf","Bülent"};
        private void button1_Click(object sender, EventArgs e)
        {
            



            Random rnd_isim = new Random();

            int index = 0;
            for (int i = 0; i < 4; i++)
            {
                index = rnd_isim.Next(0, 13);
                listBox1.Items.Add(arabalar[index]);
            }
            for(int i = 0; i < 4; i++)
            {
                index = rnd_isim.Next(0, 13);
                listBox2.Items.Add(arabalar[index]);
            }
            for (int i = 0; i < 4; i++)
            {
                index = rnd_isim.Next(0, 13);
                listBox3.Items.Add(arabalar[index]);
            }


            //Array.Sort(arabalar);
            //foreach(string araba in arabalar)
            //{
            //    listBox1.Items.Add(araba);
            //}

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
