using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ders_konusu
{
    public partial class Form1 : Form
    {
        string yon = "Sol";
        int top_Y, top_X, hiz = 5;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            top_X = pictureBox1.Location.X;
            top_Y = pictureBox1.Location.Y;
        }

        private void Form1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            //if (e.KeyCode == Keys.Right)
            //{
            //    yon = "Sağ";
            //}
            //else if (e.KeyCode == Keys.Left)
            //{
            //    yon = "Sol";
            //}
            //else if (e.KeyCode == Keys.Up)
            //{
            //    yon = "Yukarı";
            //}
            //else if (e.KeyCode == Keys.Down)
            //{
            //    yon = "Aşağı";
            //}



        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            yon = "Sağ";
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            yon = "Sol";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = trackBar1.Value.ToString();
            timer1.Interval = 265 - trackBar1.Value;

            if (top_X < -2)
            {
                yon = "Sağ";
                radioButton2.Checked = true;
            }
            if (top_X > this.ClientSize.Width - 113)
            {
                yon = "Sol";
                radioButton1.Checked = true;
            }



            if (yon == "Sağ")
            {
                top_X += hiz;
            }
            if (yon == "Sol")
            {
                top_X -= hiz;
            }
            if (yon == "Yukarı")
            {
                top_Y -= hiz;
            }
            if (yon == "Aşağı")
            {
                top_Y += hiz;
            }

            pictureBox1.Location = new Point(top_X, top_Y);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
