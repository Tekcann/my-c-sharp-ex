using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace şiir_seçemede
{
    public partial class Form1 : Form
    {

         string[] siirt = new string[6];



            
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int secim = comboBox1.SelectedIndex;
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                {
                        label1.Text = siirt[secim];

                }break;

                case 1:
                {
                        label1.Text = siirt[secim];

                }
                break;

                case 2:
                {
                       label1.Text = siirt[secim];

                }
                break;

                case 3:
                {
                        label1.Text = siirt[secim];

                }
                break;

                case 4:
                {
                        label1.Text = siirt[secim];

                }
                break;

                case 5:
                {
                        label1.Text = siirt[secim];

                }
                break;


            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            siirt[0] = "Ağır ağır çıkacaksın bu verdivenlerden \n Eteklerinde güneş rengi bir yığın yaprak \n Ve bir zaman... Bakacaksın semaya ağlayarak";
            siirt[1] = "Artık demir almak günü gelmişse zamandan \n Mechule giden bir gemi kalkar bu limandan";
            siirt[2] = "Seni anklatabilmek seni \n İyi çocuklara, kahramanlara \n Seni anlatabilmek seni \n Namussuza, halden bilmeze \n Kahpe yalana ";
            siirt[3] = "Şimdi sen kalkıp gidiyorsun. Git \n Gözlerin durur mu onlarda gidiyorlar. Gitsinler.";
            siirt[4] = "Ağlasam sesimi duyarmısınız, \n Mısralarımda; \n Dokunabilir misiniz, \n Gözyaşlarıma ellerinizle?";
            siirt[5] = "Biz ince bel, ela göz, sütün bacak için sevmedik \n Gümbür gümbür bir yürek diledik kavgamızda...";

        }
    }
}
