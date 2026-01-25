using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tekrar_üj
{
    

    public partial class Form1 : Form
    {
        string Yahya_Kemal = "Sağ";
        int araba_X, araba_Y, Ahmet_Haşim = 5;

        bool Ateş_etsin_mi = false;
        int mermi_X, mermi_Y;

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            Yahya_Kemal = "Sol";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            Yahya_Kemal = "Sağ";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           if(Ateş_etsin_mi == true)
            {
                if(mermi_Y < 5)
                {
                    mermi_Y = 350;
                }

            }






            label1.Text = trackBar1.Value.ToString();
            timer1.Interval = 265 - trackBar1.Value;
            


            if(araba_X < -2)
            {
                Yahya_Kemal = "Sağ";
                radioButton2.Checked = true;
                pictureBox1.Image = Properties.Resources.right;
            }else if(araba_X > 550)
            {
                Yahya_Kemal = "Sol";
                radioButton1.Checked = true;
                pictureBox1.Image = Properties.Resources.left;

            }

            if (Yahya_Kemal == "Sol") araba_X -= Ahmet_Haşim;
            if (Yahya_Kemal == "Sağ") araba_X += Ahmet_Haşim;

            pictureBox1.Location = new Point(araba_X, araba_Y);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            araba_X = pictureBox1.Location.X;
            araba_Y = pictureBox1.Location.Y;

            mermi_X = pictureBox2.Location.X;
            mermi_Y = pictureBox2.Location.Y;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Ateş_etsin_mi = true;

        }

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
