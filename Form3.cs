using System;
using System.Windows.Forms;

namespace ieskaites_uzdevums
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        private void Form3_Load(object sender, EventArgs e)
        {
            if (Form2.punkti == 20)
            {
                label2.Text = "Tu esi īsts Minecraft videospēles eksperts!\n" + Form2.punkti + " punkti"; ;
            }
            else if (Form2.punkti >=13 && Form2.punkti <= 19)
            {
                label2.Text = "Ļoti labi zini Minecraft videospēli!\n" + Form2.punkti + " punkti";
            }
            else if (Form2.punkti >= 6 && Form2.punkti <= 12)
            {
                label2.Text = "Zini, kaut ko par Minecraft videospēli, taču ir vēl fakti, ko uzzināt!\n" + Form2.punkti + " punkti";
            }
            else if (Form2.punkti >= 0 && Form2.punkti <= 5)
            {
                label2.Text = "Spriežot pēc atbildēm, vēl ir daudz kas jauns, ko iemācīties par Minecraft videospēli!\n" + Form2.punkti + " punkti";
            };

        }

        private void Form3_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
