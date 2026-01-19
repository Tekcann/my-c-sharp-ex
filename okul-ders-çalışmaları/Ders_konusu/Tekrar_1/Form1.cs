using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tekrar_1
{
    public partial class Form1 : Form
    {
        string yon = "Sol";
        int Top_X, Top_Y, speed = 5;

        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            yon = "Sol";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            yon = "Sağ";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Top_X = pictureBox1.Location.X;
            Top_Y = pictureBox1.Location.Y;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            label1.Text = trackBar1.Value.ToString();
            timer1.Interval = 265 - trackBar1.Value;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {



            if(Top_X < -3)
            {
                yon = "Sağ";
                radioButton2.Checked = true;
            }
            if(Top_X > 500)
            {
                yon = "Sol";
                radioButton1.Checked = true;
            }

            if(yon == "Sağ")
            {
                Top_X += 5;

            }else if(yon == "Sol")
            {
                Top_X -= 5;
            }

            pictureBox1.Location = new Point(Top_X, Top_Y);


        }
    }
}
